namespace Fahrplan
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.btnSenden = new System.Windows.Forms.Button();
            this.btnSchliessen = new System.Windows.Forms.Button();
            this.WebGmaps = new System.Windows.Forms.WebBrowser();
            this.btnMaps = new System.Windows.Forms.Button();
            this.lsbZiel = new System.Windows.Forms.ListBox();
            this.lsbAbfahrt = new System.Windows.Forms.ListBox();
            this.dtpZeit = new System.Windows.Forms.DateTimePicker();
            this.dgvAbfahrtstafel = new System.Windows.Forms.DataGridView();
            this.btnTafel = new System.Windows.Forms.Button();
            this.btnSuchen = new System.Windows.Forms.Button();
            this.txtZielort = new System.Windows.Forms.TextBox();
            this.txtAbfahrtsort = new System.Windows.Forms.TextBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.lbl_Datum = new System.Windows.Forms.Label();
            this.lbl_Uhrzeit = new System.Windows.Forms.Label();
            this.lbl_Zielort = new System.Windows.Forms.Label();
            this.lbl_Abfahrtsort = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbfahrtstafel)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.txtMail);
            this.panel1.Controls.Add(this.btnSenden);
            this.panel1.Controls.Add(this.btnSchliessen);
            this.panel1.Controls.Add(this.WebGmaps);
            this.panel1.Controls.Add(this.btnMaps);
            this.panel1.Controls.Add(this.lsbZiel);
            this.panel1.Controls.Add(this.lsbAbfahrt);
            this.panel1.Controls.Add(this.dtpZeit);
            this.panel1.Controls.Add(this.dgvAbfahrtstafel);
            this.panel1.Controls.Add(this.btnTafel);
            this.panel1.Controls.Add(this.btnSuchen);
            this.panel1.Controls.Add(this.txtZielort);
            this.panel1.Controls.Add(this.txtAbfahrtsort);
            this.panel1.Controls.Add(this.dtpDatum);
            this.panel1.Controls.Add(this.lbl_Datum);
            this.panel1.Controls.Add(this.lbl_Uhrzeit);
            this.panel1.Controls.Add(this.lbl_Zielort);
            this.panel1.Controls.Add(this.lbl_Abfahrtsort);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 653);
            this.panel1.TabIndex = 0;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(429, 175);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(112, 18);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "E-Mail Adresse:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(547, 172);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(239, 24);
            this.txtMail.TabIndex = 9;
            // 
            // btnSenden
            // 
            this.btnSenden.Location = new System.Drawing.Point(547, 202);
            this.btnSenden.Name = "btnSenden";
            this.btnSenden.Size = new System.Drawing.Size(239, 38);
            this.btnSenden.TabIndex = 10;
            this.btnSenden.Text = "E-Mail versenden";
            this.btnSenden.UseVisualStyleBackColor = true;
            this.btnSenden.Click += new System.EventHandler(this.btnSenden_Click);
            // 
            // btnSchliessen
            // 
            this.btnSchliessen.Location = new System.Drawing.Point(482, 288);
            this.btnSchliessen.Name = "btnSchliessen";
            this.btnSchliessen.Size = new System.Drawing.Size(59, 52);
            this.btnSchliessen.TabIndex = 12;
            this.btnSchliessen.Text = "X";
            this.btnSchliessen.UseVisualStyleBackColor = true;
            this.btnSchliessen.Visible = false;
            this.btnSchliessen.Click += new System.EventHandler(this.btnSchliessen_Click);
            // 
            // WebGmaps
            // 
            this.WebGmaps.Location = new System.Drawing.Point(152, 358);
            this.WebGmaps.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebGmaps.Name = "WebGmaps";
            this.WebGmaps.Size = new System.Drawing.Size(645, 272);
            this.WebGmaps.TabIndex = 12;
            this.WebGmaps.Visible = false;
            // 
            // btnMaps
            // 
            this.btnMaps.BackColor = System.Drawing.Color.Gainsboro;
            this.btnMaps.Location = new System.Drawing.Point(547, 288);
            this.btnMaps.Name = "btnMaps";
            this.btnMaps.Size = new System.Drawing.Size(250, 52);
            this.btnMaps.TabIndex = 11;
            this.btnMaps.Text = "Google Maps";
            this.btnMaps.UseVisualStyleBackColor = false;
            this.btnMaps.Click += new System.EventHandler(this.btnMaps_Click);
            // 
            // lsbZiel
            // 
            this.lsbZiel.FormattingEnabled = true;
            this.lsbZiel.ItemHeight = 18;
            this.lsbZiel.Location = new System.Drawing.Point(547, 52);
            this.lsbZiel.Name = "lsbZiel";
            this.lsbZiel.Size = new System.Drawing.Size(239, 58);
            this.lsbZiel.TabIndex = 4;
            this.lsbZiel.SelectedIndexChanged += new System.EventHandler(this.lsbZiel_SelectedIndexChanged);
            this.lsbZiel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lsbZiel_KeyDown);
            // 
            // lsbAbfahrt
            // 
            this.lsbAbfahrt.FormattingEnabled = true;
            this.lsbAbfahrt.ItemHeight = 18;
            this.lsbAbfahrt.Location = new System.Drawing.Point(152, 52);
            this.lsbAbfahrt.Name = "lsbAbfahrt";
            this.lsbAbfahrt.Size = new System.Drawing.Size(239, 58);
            this.lsbAbfahrt.TabIndex = 2;
            this.lsbAbfahrt.SelectedIndexChanged += new System.EventHandler(this.lsbAbfahrt_SelectedIndexChanged);
            // 
            // dtpZeit
            // 
            this.dtpZeit.CustomFormat = "HH.mm";
            this.dtpZeit.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpZeit.Location = new System.Drawing.Point(152, 126);
            this.dtpZeit.Name = "dtpZeit";
            this.dtpZeit.ShowUpDown = true;
            this.dtpZeit.Size = new System.Drawing.Size(239, 24);
            this.dtpZeit.TabIndex = 5;
            // 
            // dgvAbfahrtstafel
            // 
            this.dgvAbfahrtstafel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAbfahrtstafel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbfahrtstafel.Location = new System.Drawing.Point(152, 358);
            this.dgvAbfahrtstafel.Name = "dgvAbfahrtstafel";
            this.dgvAbfahrtstafel.Size = new System.Drawing.Size(645, 272);
            this.dgvAbfahrtstafel.TabIndex = 10;
            this.dgvAbfahrtstafel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAbfahrtstafel_CellContentClick);
            // 
            // btnTafel
            // 
            this.btnTafel.Location = new System.Drawing.Point(152, 288);
            this.btnTafel.Name = "btnTafel";
            this.btnTafel.Size = new System.Drawing.Size(239, 52);
            this.btnTafel.TabIndex = 8;
            this.btnTafel.Text = "Abfahrtstafel";
            this.btnTafel.UseVisualStyleBackColor = true;
            this.btnTafel.Click += new System.EventHandler(this.btnTafel_Click);
            // 
            // btnSuchen
            // 
            this.btnSuchen.Location = new System.Drawing.Point(152, 230);
            this.btnSuchen.Name = "btnSuchen";
            this.btnSuchen.Size = new System.Drawing.Size(239, 52);
            this.btnSuchen.TabIndex = 7;
            this.btnSuchen.Text = "Verbindung Suchen";
            this.btnSuchen.UseVisualStyleBackColor = true;
            this.btnSuchen.Click += new System.EventHandler(this.btnSuchen_Click);
            // 
            // txtZielort
            // 
            this.txtZielort.Location = new System.Drawing.Point(547, 22);
            this.txtZielort.Name = "txtZielort";
            this.txtZielort.Size = new System.Drawing.Size(239, 24);
            this.txtZielort.TabIndex = 3;
            this.txtZielort.TextChanged += new System.EventHandler(this.txtZielort_TextChanged);
            this.txtZielort.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtZielort_KeyDown);
            // 
            // txtAbfahrtsort
            // 
            this.txtAbfahrtsort.Location = new System.Drawing.Point(152, 22);
            this.txtAbfahrtsort.Name = "txtAbfahrtsort";
            this.txtAbfahrtsort.Size = new System.Drawing.Size(239, 24);
            this.txtAbfahrtsort.TabIndex = 1;
            this.txtAbfahrtsort.TextChanged += new System.EventHandler(this.txtAbfahrtsort_TextChanged);
            // 
            // dtpDatum
            // 
            this.dtpDatum.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtpDatum.Location = new System.Drawing.Point(152, 172);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(239, 24);
            this.dtpDatum.TabIndex = 6;
            this.dtpDatum.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lbl_Datum
            // 
            this.lbl_Datum.AutoSize = true;
            this.lbl_Datum.Location = new System.Drawing.Point(90, 172);
            this.lbl_Datum.Name = "lbl_Datum";
            this.lbl_Datum.Size = new System.Drawing.Size(56, 18);
            this.lbl_Datum.TabIndex = 3;
            this.lbl_Datum.Text = "Datum:";
            // 
            // lbl_Uhrzeit
            // 
            this.lbl_Uhrzeit.AutoSize = true;
            this.lbl_Uhrzeit.Location = new System.Drawing.Point(87, 126);
            this.lbl_Uhrzeit.Name = "lbl_Uhrzeit";
            this.lbl_Uhrzeit.Size = new System.Drawing.Size(59, 18);
            this.lbl_Uhrzeit.TabIndex = 2;
            this.lbl_Uhrzeit.Text = "Uhrzeit:";
            // 
            // lbl_Zielort
            // 
            this.lbl_Zielort.AutoSize = true;
            this.lbl_Zielort.Location = new System.Drawing.Point(479, 22);
            this.lbl_Zielort.Name = "lbl_Zielort";
            this.lbl_Zielort.Size = new System.Drawing.Size(53, 18);
            this.lbl_Zielort.TabIndex = 1;
            this.lbl_Zielort.Text = "Zielort:";
            // 
            // lbl_Abfahrtsort
            // 
            this.lbl_Abfahrtsort.AutoSize = true;
            this.lbl_Abfahrtsort.Location = new System.Drawing.Point(62, 25);
            this.lbl_Abfahrtsort.Name = "lbl_Abfahrtsort";
            this.lbl_Abfahrtsort.Size = new System.Drawing.Size(84, 18);
            this.lbl_Abfahrtsort.TabIndex = 0;
            this.lbl_Abfahrtsort.Text = "Abfahrtsort:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 666);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbfahrtstafel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label lbl_Datum;
        private System.Windows.Forms.Label lbl_Uhrzeit;
        private System.Windows.Forms.Label lbl_Zielort;
        private System.Windows.Forms.Label lbl_Abfahrtsort;
        private System.Windows.Forms.TextBox txtZielort;
        private System.Windows.Forms.TextBox txtAbfahrtsort;
        private System.Windows.Forms.DataGridView dgvAbfahrtstafel;
        private System.Windows.Forms.Button btnTafel;
        private System.Windows.Forms.Button btnSuchen;
        private System.Windows.Forms.DateTimePicker dtpZeit;
        private System.Windows.Forms.ListBox lsbZiel;
        private System.Windows.Forms.ListBox lsbAbfahrt;
        private System.Windows.Forms.Button btnMaps;
        private System.Windows.Forms.WebBrowser WebGmaps;
        private System.Windows.Forms.Button btnSchliessen;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Button btnSenden;
        private System.Windows.Forms.Label lblEmail;
    }
}

