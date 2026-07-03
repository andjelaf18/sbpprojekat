namespace IznajmljivanjeVozila.Forme
{
    partial class FormRezervacijaDodavanje
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonDodaj = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBoxId = new TextBox();
            textBoxLokPreuzimanja = new TextBox();
            textBoxLokVracanja = new TextBox();
            comboBoxTip = new ComboBox();
            comboBoxStatus = new ComboBox();
            dateTimePickerPocetak = new DateTimePicker();
            dateTimePickerKraj = new DateTimePicker();
            comboBoxVozilo = new ComboBox();
            comboBoxVozac = new ComboBox();
            comboBoxKorisnik = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // buttonDodaj
            // 
            buttonDodaj.Anchor = AnchorStyles.Right;
            buttonDodaj.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            buttonDodaj.FlatAppearance.BorderSize = 3;
            buttonDodaj.FlatStyle = FlatStyle.Flat;
            buttonDodaj.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDodaj.ForeColor = SystemColors.ControlDarkDark;
            buttonDodaj.Location = new Point(21, 585);
            buttonDodaj.Margin = new Padding(4, 3, 4, 3);
            buttonDodaj.Name = "buttonDodaj";
            buttonDodaj.Size = new Size(202, 58);
            buttonDodaj.TabIndex = 6;
            buttonDodaj.Text = "Dodaj";
            buttonDodaj.UseVisualStyleBackColor = true;
            buttonDodaj.Click += buttonDodaj_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(24, 85);
            label1.Name = "label1";
            label1.Size = new Size(35, 23);
            label1.TabIndex = 7;
            label1.Text = "Id:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(21, 271);
            label2.Name = "label2";
            label2.Size = new Size(317, 23);
            label2.TabIndex = 8;
            label2.Text = "Planirana lokacija preuzimanja:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(21, 318);
            label3.Name = "label3";
            label3.Size = new Size(283, 23);
            label3.TabIndex = 9;
            label3.Text = "Planirana lokacija vraćanja:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(21, 369);
            label4.Name = "label4";
            label4.Size = new Size(42, 23);
            label4.TabIndex = 10;
            label4.Text = "Tip:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(21, 419);
            label5.Name = "label5";
            label5.Size = new Size(72, 23);
            label5.TabIndex = 11;
            label5.Text = "Status:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(21, 472);
            label6.Name = "label6";
            label6.Size = new Size(263, 23);
            label6.TabIndex = 12;
            label6.Text = "Planirano vreme početka:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(21, 523);
            label7.Name = "label7";
            label7.Size = new Size(272, 23);
            label7.TabIndex = 13;
            label7.Text = "Planirano vreme završetka:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(21, 19);
            label8.Name = "label8";
            label8.Size = new Size(489, 46);
            label8.TabIndex = 14;
            label8.Text = "Popunite sve kontrole da biste dodali\r\nnovu rezervaciju u sistem za iznajmljivanje vozila.";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxId
            // 
            textBoxId.BackColor = Color.PaleGoldenrod;
            textBoxId.Location = new Point(66, 82);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(160, 32);
            textBoxId.TabIndex = 15;
            // 
            // textBoxLokPreuzimanja
            // 
            textBoxLokPreuzimanja.BackColor = Color.PaleGoldenrod;
            textBoxLokPreuzimanja.Location = new Point(344, 268);
            textBoxLokPreuzimanja.Name = "textBoxLokPreuzimanja";
            textBoxLokPreuzimanja.Size = new Size(160, 32);
            textBoxLokPreuzimanja.TabIndex = 16;
            // 
            // textBoxLokVracanja
            // 
            textBoxLokVracanja.BackColor = Color.PaleGoldenrod;
            textBoxLokVracanja.Location = new Point(344, 315);
            textBoxLokVracanja.Name = "textBoxLokVracanja";
            textBoxLokVracanja.Size = new Size(160, 32);
            textBoxLokVracanja.TabIndex = 17;
            // 
            // comboBoxTip
            // 
            comboBoxTip.BackColor = Color.PaleGoldenrod;
            comboBoxTip.FormattingEnabled = true;
            comboBoxTip.Items.AddRange(new object[] { "Privatna", "Službena" });
            comboBoxTip.Location = new Point(69, 366);
            comboBoxTip.Name = "comboBoxTip";
            comboBoxTip.Size = new Size(160, 31);
            comboBoxTip.TabIndex = 18;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.BackColor = Color.PaleGoldenrod;
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "Aktivna", "Završena", "Otkazana" });
            comboBoxStatus.Location = new Point(99, 416);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(160, 31);
            comboBoxStatus.TabIndex = 19;
            // 
            // dateTimePickerPocetak
            // 
            dateTimePickerPocetak.CalendarForeColor = SystemColors.ControlDarkDark;
            dateTimePickerPocetak.CalendarMonthBackground = Color.PaleGoldenrod;
            dateTimePickerPocetak.CustomFormat = "HH:mm";
            dateTimePickerPocetak.Format = DateTimePickerFormat.Custom;
            dateTimePickerPocetak.Location = new Point(309, 465);
            dateTimePickerPocetak.Name = "dateTimePickerPocetak";
            dateTimePickerPocetak.ShowUpDown = true;
            dateTimePickerPocetak.Size = new Size(195, 32);
            dateTimePickerPocetak.TabIndex = 59;
            // 
            // dateTimePickerKraj
            // 
            dateTimePickerKraj.CalendarForeColor = SystemColors.ControlDarkDark;
            dateTimePickerKraj.CalendarMonthBackground = Color.PaleGoldenrod;
            dateTimePickerKraj.CustomFormat = "HH:mm";
            dateTimePickerKraj.Format = DateTimePickerFormat.Custom;
            dateTimePickerKraj.Location = new Point(309, 516);
            dateTimePickerKraj.Name = "dateTimePickerKraj";
            dateTimePickerKraj.ShowUpDown = true;
            dateTimePickerKraj.Size = new Size(195, 32);
            dateTimePickerKraj.TabIndex = 60;
            // 
            // comboBoxVozilo
            // 
            comboBoxVozilo.BackColor = Color.PaleGoldenrod;
            comboBoxVozilo.FormattingEnabled = true;
            comboBoxVozilo.Location = new Point(110, 227);
            comboBoxVozilo.Name = "comboBoxVozilo";
            comboBoxVozilo.Size = new Size(394, 31);
            comboBoxVozilo.TabIndex = 66;
            // 
            // comboBoxVozac
            // 
            comboBoxVozac.BackColor = Color.PaleGoldenrod;
            comboBoxVozac.FormattingEnabled = true;
            comboBoxVozac.Location = new Point(110, 176);
            comboBoxVozac.Name = "comboBoxVozac";
            comboBoxVozac.Size = new Size(394, 31);
            comboBoxVozac.TabIndex = 65;
            // 
            // comboBoxKorisnik
            // 
            comboBoxKorisnik.BackColor = Color.PaleGoldenrod;
            comboBoxKorisnik.FormattingEnabled = true;
            comboBoxKorisnik.Location = new Point(119, 127);
            comboBoxKorisnik.Name = "comboBoxKorisnik";
            comboBoxKorisnik.Size = new Size(246, 31);
            comboBoxKorisnik.TabIndex = 64;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ControlDarkDark;
            label11.Location = new Point(23, 227);
            label11.Name = "label11";
            label11.Size = new Size(75, 23);
            label11.TabIndex = 63;
            label11.Text = "Vozilo:";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ControlDarkDark;
            label10.Location = new Point(23, 179);
            label10.Name = "label10";
            label10.Size = new Size(78, 23);
            label10.TabIndex = 62;
            label10.Text = "Vozač:";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlDarkDark;
            label9.Location = new Point(23, 130);
            label9.Name = "label9";
            label9.Size = new Size(90, 23);
            label9.TabIndex = 61;
            label9.Text = "Korisnik:";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FormRezervacijaDodavanje
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(575, 655);
            Controls.Add(comboBoxVozilo);
            Controls.Add(comboBoxVozac);
            Controls.Add(comboBoxKorisnik);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(dateTimePickerKraj);
            Controls.Add(dateTimePickerPocetak);
            Controls.Add(comboBoxStatus);
            Controls.Add(comboBoxTip);
            Controls.Add(textBoxLokVracanja);
            Controls.Add(textBoxLokPreuzimanja);
            Controls.Add(textBoxId);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonDodaj);
            Font = new Font("Century Gothic", 12F);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormRezervacijaDodavanje";
            ShowIcon = false;
            Text = "Dodavanje rezervacije";
            Load += FormRezervacijaIVoznjaDodavanje_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDodaj;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBoxId;
        private TextBox textBoxLokPreuzimanja;
        private TextBox textBoxLokVracanja;
        private ComboBox comboBoxTip;
        private ComboBox comboBoxStatus;
        private TextBox textBoxVremeP;
        private TextBox textBoxVremeZ;
        private DateTimePicker dateTimePickerPocetak;
        private DateTimePicker dateTimePickerKraj;
        private ComboBox comboBoxVozilo;
        private ComboBox comboBoxVozac;
        private ComboBox comboBoxKorisnik;
        private Label label11;
        private Label label10;
        private Label label9;
    }
}