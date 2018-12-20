using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;
using System.Net.Mail;

namespace Fahrplan
{
    public partial class Form1 : Form
    {
        Transport transport = new Transport();
        Coordinate coordinate = new Coordinate();
        public Form1()

        {
            InitializeComponent();
        }
        private void Get_Stations(string text, ListBox listBox)
        {
            if (text.Length >= 3)
            {
                listBox.Items.Clear();
                Stations stations = transport.GetStations(text);
                foreach (Station station in stations.StationList)
                {
                    listBox.Items.Add(station.Name);
                    listBox.Visible = true;
                    listBox.BringToFront();
                }
            }
        }

        public string Get_TableFromDataGrid()
        {
            StringBuilder strTable = new StringBuilder();
            try
            {
                strTable.Append("<table border='1' cellpadding='0' cellspacing='0'>");
                strTable.Append("<tr>");
                foreach (DataGridViewColumn col in dgvAbfahrtstafel.Columns)
                {
                    strTable.AppendFormat("<th>{0}</th>", col.HeaderText);
                }
                strTable.Append("</tr>");
                for (int i = 0; i < dgvAbfahrtstafel.Rows.Count; i++)
                {
                    strTable.Append("<tr>");
                    foreach (DataGridViewCell cell in dgvAbfahrtstafel.Rows[i].Cells)
                    {
                        if (cell.Value != null)
                        {
                            strTable.AppendFormat("<td>{0}</td>", cell.Value.ToString());
                        }
                    }
                    strTable.Append("</tr>");
                }
                strTable.Append("</table>");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return strTable.ToString();
        }

        private void Get_Grid()
        {
            Cursor.Current = Cursors.WaitCursor;

            DataTable dtt_connections = new DataTable();
            dtt_connections.Columns.Add("Datum");
            dtt_connections.Columns.Add("Abfahrtsort");
            dtt_connections.Columns.Add("Abfahrt");
            dtt_connections.Columns.Add("Zielort");
            dtt_connections.Columns.Add("Ankunft");
            dtt_connections.Columns.Add("Gleis");

            //Abfrage
            Connections connections = transport.GetConnections(txtAbfahrtsort.Text, txtZielort.Text, dtpDatum.Value.ToString("yyyy-MM-dd"), dtpZeit.Text);

            //Jedes Resulatat zur Liste hinzufügen
            foreach (Connection connection in connections.ConnectionList)
            {
                dtt_connections.Rows.Add(Get_Date(connection.From.Departure), connection.From.Station.Name, Get_Time(connection.From.Departure), connection.To.Station.Name, Get_Time(connection.To.Arrival), connection.To.Platform);
            }

            dgvAbfahrtstafel.DataSource = dtt_connections;

            UseWaitCursor = false;
        }

        private void Get_2_Grid()
        {
            DataTable dtt_routes = new DataTable();
            dtt_routes.Columns.Add("Zeit");
            dtt_routes.Columns.Add("Nach");
            dtt_routes.Columns.Add("Linie");

            //Zeigt die Station für die Abfahrtstafel an, der Inhalt wird an die Textbox txtAbfahrtsort weitergegeben
            Station station = transport.GetStations(txtAbfahrtsort.Text).StationList.First();
            StationBoardRoot departures = transport.GetStationBoard(station.Name, station.Id); //Beispiel für die Station ist Zürich

            foreach (StationBoard station_b in departures.Entries)
            {
                dtt_routes.Rows.Add(Get_Time(station_b.Stop.Departure.ToString()), station_b.To, (station_b.Category + " " + station_b.Number));
            }

            dgvAbfahrtstafel.DataSource = dtt_routes;
        }


        private string Get_Date(string date1)
        {
            string date2 = date1.Remove(10);
            DateTime date3 = Convert.ToDateTime(date2);
            return date3.ToString("dd.MM.yyyy");
        }

        private string Get_Time(string time1) //Zeit ist 18:05:00 die zwei letzten Stellen werden gelöst
        {
            string time2 = time1.Remove(0, 11);
            time2 = time2.Remove(5);
            return time2;
        }

        private void Create_GmapStation(string x, string y)
        {
            string url = "https://www.google.ch/maps/place/" + x + "," + y;
            WebGmaps.Navigate(url);
        }


        private void txtAbfahrtsort_TextChanged(object sender, EventArgs e)
        {
            Get_Stations(txtAbfahrtsort.Text, lsbAbfahrt);
        }

        private void txtZielort_TextChanged(object sender, EventArgs e)
        {
            Get_Stations(txtZielort.Text, lsbZiel);
        }




        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSuchen_Click(object sender, EventArgs e)
        {
            if (txtAbfahrtsort.Text != string.Empty)
            {
                Get_Grid();
            }
            else
            {
                MessageBox.Show("Bitte geben Sie zwei Orte ein!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTafel_Click(object sender, EventArgs e)
        {
            {
                if (btnTafel.Text != string.Empty)
                {
                    Get_2_Grid();
                }
                else
                {
                    MessageBox.Show("Bitte geben Sie einen Ort ein!");
                }
            }
        }

        private void dgvAbfahrtstafel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lsbAbfahrt_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAbfahrtsort.Text = lsbAbfahrt.SelectedItem.ToString();
            btnSuchen.Focus();
            lsbAbfahrt.Visible = false;
        }

        private void lsbZiel_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtZielort.Text = lsbZiel.SelectedItem.ToString();
            btnSuchen.Focus();
            lsbZiel.Visible = false;
        }

        private void btnMaps_Click(object sender, EventArgs e)
        {

            if (txtAbfahrtsort.Text != string.Empty)
            {
                Stations stations = transport.GetStations(txtAbfahrtsort.Text);
                Station station = stations.StationList[0];
                Create_GmapStation(Convert.ToString(station.Coordinate.XCoordinate).Replace(',', '.'), Convert.ToString(station.Coordinate.YCoordinate).Replace(',', '.'));
                WebGmaps.Visible = true;
                btnSchliessen.Visible = true;

            }
            else
            {
                MessageBox.Show("Bitte geben Sie einen Ort ein!");
            }
        }

        private void btnSchliessen_Click(object sender, EventArgs e)
        {
            WebGmaps.Visible = false;
            btnSchliessen.Visible = false;
        }

        private void btnSenden_Click(object sender, EventArgs e)
        {
            if (txtMail.Text == "")
                MessageBox.Show("Bitte ihre E-Mail Adresse eingeben");
            else
            {
                try
                {
                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress("m318.dominikbielser@gmail.com");
                    mail.To.Add(new MailAddress(Convert.ToString(this.txtMail)));
                    mail.Subject = "Fahrplan";
                    mail.Body = "Hier erhalten Sie ihre Abfahrtstafel von Ihrem gewälhtem Standort";
                    mail.Body += "<b>" + Get_TableFromDataGrid() + "</b>";
                    mail.IsBodyHtml = true;
                    SmtpClient SmtpServer = new SmtpClient();
                    SmtpServer.Host = "smtp.gmail.com";
                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("m318.dominikbielser@gmail.com", "Kennwort$11");
                    SmtpServer.EnableSsl = true;
                    SmtpServer.Send(mail);
                    MessageBox.Show("Senden der E-Mail war erfolgreich!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void lsbZiel_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtZielort_KeyDown(object sender, KeyEventArgs e)
        {

        } 
        
    }
}
