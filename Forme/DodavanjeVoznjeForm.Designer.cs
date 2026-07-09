namespace IznajmljivanjeVozila.Forme
{
    partial class DodavanjeVoznjeForm
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
            label8 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            textBoxId = new TextBox();
            textBoxKm = new TextBox();
            textBoxTrajanje = new TextBox();
            textBoxDodatneNaknade = new TextBox();
            numericUpDown1 = new NumericUpDown();
            textBoxPLokacija = new TextBox();
            textBoxZLokacija = new TextBox();
            textBoxObracunaCena = new TextBox();
            dateTimePickerP = new DateTimePicker();
            dateTimePickerZ = new DateTimePicker();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // buttonDodaj
            // 
            buttonDodaj.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            buttonDodaj.FlatAppearance.BorderSize = 3;
            buttonDodaj.FlatStyle = FlatStyle.Flat;
            buttonDodaj.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDodaj.ForeColor = SystemColors.ControlDarkDark;
            buttonDodaj.Location = new Point(24, 378);
            buttonDodaj.Name = "buttonDodaj";
            buttonDodaj.Size = new Size(170, 45);
            buttonDodaj.TabIndex = 9;
            buttonDodaj.Text = "Dodaj";
            buttonDodaj.UseVisualStyleBackColor = true;
            buttonDodaj.Click += buttonDodaj_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(24, 19);
            label8.Name = "label8";
            label8.Size = new Size(445, 46);
            label8.TabIndex = 15;
            label8.Text = "Popunite sve kontrole da biste dodali\r\nnovu vožnju u sistem za iznajmljivanje vozila.";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(24, 100);
            label1.Name = "label1";
            label1.Size = new Size(35, 23);
            label1.TabIndex = 16;
            label1.Text = "Id:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(24, 150);
            label2.Name = "label2";
            label2.Size = new Size(170, 23);
            label2.TabIndex = 17;
            label2.Text = "Vreme početka:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(24, 208);
            label3.Name = "label3";
            label3.Size = new Size(179, 23);
            label3.TabIndex = 18;
            label3.Text = "Vreme završetka:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(24, 265);
            label4.Name = "label4";
            label4.Size = new Size(130, 23);
            label4.TabIndex = 19;
            label4.Text = "Kilometraža:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(24, 316);
            label5.Name = "label5";
            label5.Size = new Size(91, 23);
            label5.TabIndex = 20;
            label5.Text = "Trajanje:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(433, 150);
            label6.Name = "label6";
            label6.Size = new Size(286, 23);
            label6.TabIndex = 21;
            label6.Text = "Početni nivo baterije/goriva:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(433, 210);
            label7.Name = "label7";
            label7.Size = new Size(182, 23);
            label7.TabIndex = 22;
            label7.Text = "Početna lokacija:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlDarkDark;
            label9.Location = new Point(433, 265);
            label9.Name = "label9";
            label9.Size = new Size(175, 23);
            label9.TabIndex = 23;
            label9.Text = "Završna lokacija:";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ControlDarkDark;
            label10.Location = new Point(433, 316);
            label10.Name = "label10";
            label10.Size = new Size(191, 23);
            label10.TabIndex = 24;
            label10.Text = "Obračunata cena:";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ControlDarkDark;
            label11.Location = new Point(433, 100);
            label11.Name = "label11";
            label11.Size = new Size(194, 23);
            label11.TabIndex = 25;
            label11.Text = "Dodatne naknade:";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxId
            // 
            textBoxId.BackColor = Color.PaleGoldenrod;
            textBoxId.Location = new Point(65, 97);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(171, 32);
            textBoxId.TabIndex = 26;
            // 
            // textBoxKm
            // 
            textBoxKm.BackColor = Color.PaleGoldenrod;
            textBoxKm.Location = new Point(160, 262);
            textBoxKm.Name = "textBoxKm";
            textBoxKm.Size = new Size(171, 32);
            textBoxKm.TabIndex = 29;
            // 
            // textBoxTrajanje
            // 
            textBoxTrajanje.BackColor = Color.PaleGoldenrod;
            textBoxTrajanje.Location = new Point(121, 313);
            textBoxTrajanje.Name = "textBoxTrajanje";
            textBoxTrajanje.Size = new Size(171, 32);
            textBoxTrajanje.TabIndex = 30;
            // 
            // textBoxDodatneNaknade
            // 
            textBoxDodatneNaknade.BackColor = Color.PaleGoldenrod;
            textBoxDodatneNaknade.Location = new Point(643, 97);
            textBoxDodatneNaknade.Name = "textBoxDodatneNaknade";
            textBoxDodatneNaknade.Size = new Size(171, 32);
            textBoxDodatneNaknade.TabIndex = 31;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.PaleGoldenrod;
            numericUpDown1.DecimalPlaces = 1;
            numericUpDown1.Location = new Point(728, 141);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(134, 32);
            numericUpDown1.TabIndex = 32;
            // 
            // textBoxPLokacija
            // 
            textBoxPLokacija.BackColor = Color.PaleGoldenrod;
            textBoxPLokacija.Location = new Point(630, 205);
            textBoxPLokacija.Name = "textBoxPLokacija";
            textBoxPLokacija.Size = new Size(171, 32);
            textBoxPLokacija.TabIndex = 33;
            // 
            // textBoxZLokacija
            // 
            textBoxZLokacija.BackColor = Color.PaleGoldenrod;
            textBoxZLokacija.Location = new Point(621, 262);
            textBoxZLokacija.Name = "textBoxZLokacija";
            textBoxZLokacija.Size = new Size(171, 32);
            textBoxZLokacija.TabIndex = 34;
            // 
            // textBoxObracunaCena
            // 
            textBoxObracunaCena.BackColor = Color.PaleGoldenrod;
            textBoxObracunaCena.Location = new Point(633, 313);
            textBoxObracunaCena.Name = "textBoxObracunaCena";
            textBoxObracunaCena.Size = new Size(171, 32);
            textBoxObracunaCena.TabIndex = 35;
            // 
            // dateTimePickerP
            // 
            dateTimePickerP.CalendarForeColor = SystemColors.ControlDarkDark;
            dateTimePickerP.CalendarMonthBackground = Color.PaleGoldenrod;
            dateTimePickerP.CustomFormat = "HH:mm";
            dateTimePickerP.Format = DateTimePickerFormat.Custom;
            dateTimePickerP.Location = new Point(211, 143);
            dateTimePickerP.Name = "dateTimePickerP";
            dateTimePickerP.ShowUpDown = true;
            dateTimePickerP.Size = new Size(195, 32);
            dateTimePickerP.TabIndex = 39;
            // 
            // dateTimePickerZ
            // 
            dateTimePickerZ.CalendarForeColor = SystemColors.ControlDarkDark;
            dateTimePickerZ.CalendarMonthBackground = Color.PaleGoldenrod;
            dateTimePickerZ.CustomFormat = "HH:mm";
            dateTimePickerZ.Format = DateTimePickerFormat.Custom;
            dateTimePickerZ.Location = new Point(211, 201);
            dateTimePickerZ.Name = "dateTimePickerZ";
            dateTimePickerZ.ShowUpDown = true;
            dateTimePickerZ.Size = new Size(195, 32);
            dateTimePickerZ.TabIndex = 40;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ControlDarkDark;
            label12.Location = new Point(298, 322);
            label12.Name = "label12";
            label12.Size = new Size(22, 23);
            label12.TabIndex = 41;
            label12.Text = "h";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DodavanjeVoznjeForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(874, 446);
            Controls.Add(label12);
            Controls.Add(dateTimePickerZ);
            Controls.Add(dateTimePickerP);
            Controls.Add(textBoxObracunaCena);
            Controls.Add(textBoxZLokacija);
            Controls.Add(textBoxPLokacija);
            Controls.Add(numericUpDown1);
            Controls.Add(textBoxDodatneNaknade);
            Controls.Add(textBoxTrajanje);
            Controls.Add(textBoxKm);
            Controls.Add(textBoxId);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(buttonDodaj);
            Font = new Font("Century Gothic", 12F);
            Margin = new Padding(4, 3, 4, 3);
            Name = "DodavanjeVoznjeForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dodavanje vožnje";
            Load += DodavanjeVoznjeForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDodaj;
        private Label label8;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox textBoxId;
        private TextBox textBoxKm;
        private TextBox textBoxTrajanje;
        private TextBox textBoxDodatneNaknade;
        private NumericUpDown numericUpDown1;
        private TextBox textBoxPLokacija;
        private TextBox textBoxZLokacija;
        private TextBox textBoxObracunaCena;
        private DateTimePicker dateTimePickerP;
        private DateTimePicker dateTimePickerZ;
        private Label label12;
    }
}