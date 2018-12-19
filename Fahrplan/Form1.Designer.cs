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
            this.dtpZeit = new System.Windows.Forms.DateTimePicker();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbfahrtstafel)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpZeit);
            this.panel1.Controls.Add(this.dataGridView2);
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
            this.panel1.Location = new System.Drawing.Point(13, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 699);
            this.panel1.TabIndex = 0;
            // 
            // dtpZeit
            // 
            this.dtpZeit.CustomFormat = "HH.mm";
            this.dtpZeit.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpZeit.Location = new System.Drawing.Point(152, 109);
            this.dtpZeit.Name = "dtpZeit";
            this.dtpZeit.ShowUpDown = true;
            this.dtpZeit.Size = new System.Drawing.Size(239, 24);
            this.dtpZeit.TabIndex = 12;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(435, 22);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(362, 232);
            this.dataGridView2.TabIndex = 11;
            // 
            // dgvAbfahrtstafel
            // 
            this.dgvAbfahrtstafel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbfahrtstafel.Location = new System.Drawing.Point(152, 358);
            this.dgvAbfahrtstafel.Name = "dgvAbfahrtstafel";
            this.dgvAbfahrtstafel.Size = new System.Drawing.Size(645, 272);
            this.dgvAbfahrtstafel.TabIndex = 10;
            this.dgvAbfahrtstafel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAbfahrtstafel_CellContentClick);
            // 
            // btnTafel
            // 
            this.btnTafel.Location = new System.Drawing.Point(152, 273);
            this.btnTafel.Name = "btnTafel";
            this.btnTafel.Size = new System.Drawing.Size(239, 52);
            this.btnTafel.TabIndex = 9;
            this.btnTafel.Text = "Abfahrtstafel";
            this.btnTafel.UseVisualStyleBackColor = true;
            this.btnTafel.Click += new System.EventHandler(this.btnTafel_Click);
            // 
            // btnSuchen
            // 
            this.btnSuchen.Location = new System.Drawing.Point(152, 202);
            this.btnSuchen.Name = "btnSuchen";
            this.btnSuchen.Size = new System.Drawing.Size(239, 52);
            this.btnSuchen.TabIndex = 8;
            this.btnSuchen.Text = "Verbindung Suchen";
            this.btnSuchen.UseVisualStyleBackColor = true;
            this.btnSuchen.Click += new System.EventHandler(this.btnSuchen_Click);
            // 
            // txtZielort
            // 
            this.txtZielort.Location = new System.Drawing.Point(152, 67);
            this.txtZielort.Name = "txtZielort";
            this.txtZielort.Size = new System.Drawing.Size(239, 24);
            this.txtZielort.TabIndex = 6;
            this.txtZielort.TextChanged += new System.EventHandler(this.txtZielort_TextChanged);
            // 
            // txtAbfahrtsort
            // 
            this.txtAbfahrtsort.Location = new System.Drawing.Point(152, 22);
            this.txtAbfahrtsort.Name = "txtAbfahrtsort";
            this.txtAbfahrtsort.Size = new System.Drawing.Size(239, 24);
            this.txtAbfahrtsort.TabIndex = 5;
            this.txtAbfahrtsort.TextChanged += new System.EventHandler(this.txtAbfahrtsort_TextChanged);
            // 
            // dtpDatum
            // 
            this.dtpDatum.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtpDatum.Location = new System.Drawing.Point(152, 151);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(239, 24);
            this.dtpDatum.TabIndex = 4;
            this.dtpDatum.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lbl_Datum
            // 
            this.lbl_Datum.AutoSize = true;
            this.lbl_Datum.Location = new System.Drawing.Point(47, 151);
            this.lbl_Datum.Name = "lbl_Datum";
            this.lbl_Datum.Size = new System.Drawing.Size(52, 18);
            this.lbl_Datum.TabIndex = 3;
            this.lbl_Datum.Text = "Datum";
            // 
            // lbl_Uhrzeit
            // 
            this.lbl_Uhrzeit.AutoSize = true;
            this.lbl_Uhrzeit.Location = new System.Drawing.Point(44, 109);
            this.lbl_Uhrzeit.Name = "lbl_Uhrzeit";
            this.lbl_Uhrzeit.Size = new System.Drawing.Size(55, 18);
            this.lbl_Uhrzeit.TabIndex = 2;
            this.lbl_Uhrzeit.Text = "Uhrzeit";
            // 
            // lbl_Zielort
            // 
            this.lbl_Zielort.AutoSize = true;
            this.lbl_Zielort.Location = new System.Drawing.Point(44, 67);
            this.lbl_Zielort.Name = "lbl_Zielort";
            this.lbl_Zielort.Size = new System.Drawing.Size(53, 18);
            this.lbl_Zielort.TabIndex = 1;
            this.lbl_Zielort.Text = "Zielort:";
            // 
            // lbl_Abfahrtsort
            // 
            this.lbl_Abfahrtsort.AutoSize = true;
            this.lbl_Abfahrtsort.Location = new System.Drawing.Point(44, 25);
            this.lbl_Abfahrtsort.Name = "lbl_Abfahrtsort";
            this.lbl_Abfahrtsort.Size = new System.Drawing.Size(84, 18);
            this.lbl_Abfahrtsort.TabIndex = 0;
            this.lbl_Abfahrtsort.Text = "Abfahrtsort:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 669);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DateTimePicker dtpZeit;
    }
}

