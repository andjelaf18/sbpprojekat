namespace IznajmljivanjeVozila.Forme
{
    partial class FormZaDodavanjeKorisnika
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
            buttonPotvrdiDodavanje = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            textBoxId = new TextBox();
            textBoxAdresa = new TextBox();
            textBoxBrTelefona = new TextBox();
            textBoxEmail = new TextBox();
            textBoxNacinVerifikacije = new TextBox();
            dateTimePickerRegistracija = new DateTimePicker();
            SuspendLayout();
            // 
            // buttonPotvrdiDodavanje
            // 
            buttonPotvrdiDodavanje.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            buttonPotvrdiDodavanje.FlatAppearance.BorderSize = 3;
            buttonPotvrdiDodavanje.FlatStyle = FlatStyle.Flat;
            buttonPotvrdiDodavanje.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPotvrdiDodavanje.ForeColor = SystemColors.ControlDarkDark;
            buttonPotvrdiDodavanje.Location = new Point(43, 292);
            buttonPotvrdiDodavanje.Name = "buttonPotvrdiDodavanje";
            buttonPotvrdiDodavanje.Size = new Size(176, 52);
            buttonPotvrdiDodavanje.TabIndex = 0;
            buttonPotvrdiDodavanje.Text = "Potvrdi";
            buttonPotvrdiDodavanje.UseVisualStyleBackColor = true;
            buttonPotvrdiDodavanje.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(31, 26);
            label1.Name = "label1";
            label1.Size = new Size(484, 46);
            label1.TabIndex = 2;
            label1.Text = "Popunite sve kontrole da biste dodali\r\nnovog korisnika u sistem za iznajmljivanje vozila.";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(43, 97);
            label2.Name = "label2";
            label2.Size = new Size(36, 23);
            label2.TabIndex = 3;
            label2.Text = "ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(43, 164);
            label3.Name = "label3";
            label3.Size = new Size(85, 23);
            label3.TabIndex = 4;
            label3.Text = "Adresa:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(43, 232);
            label4.Name = "label4";
            label4.Size = new Size(139, 23);
            label4.TabIndex = 5;
            label4.Text = "Broj telefona:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(447, 164);
            label5.Name = "label5";
            label5.Size = new Size(68, 23);
            label5.TabIndex = 6;
            label5.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(445, 97);
            label6.Name = "label6";
            label6.Size = new Size(193, 23);
            label6.TabIndex = 7;
            label6.Text = "Datum registracije:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(445, 232);
            label8.Name = "label8";
            label8.Size = new Size(187, 23);
            label8.TabIndex = 9;
            label8.Text = "Način verifikacije:";
            // 
            // textBoxId
            // 
            textBoxId.BackColor = Color.PaleGoldenrod;
            textBoxId.Location = new Point(203, 97);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(188, 32);
            textBoxId.TabIndex = 10;
            // 
            // textBoxAdresa
            // 
            textBoxAdresa.BackColor = Color.PaleGoldenrod;
            textBoxAdresa.Location = new Point(203, 161);
            textBoxAdresa.Name = "textBoxAdresa";
            textBoxAdresa.Size = new Size(188, 32);
            textBoxAdresa.TabIndex = 11;
            // 
            // textBoxBrTelefona
            // 
            textBoxBrTelefona.BackColor = Color.PaleGoldenrod;
            textBoxBrTelefona.Location = new Point(203, 229);
            textBoxBrTelefona.Name = "textBoxBrTelefona";
            textBoxBrTelefona.Size = new Size(188, 32);
            textBoxBrTelefona.TabIndex = 12;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.PaleGoldenrod;
            textBoxEmail.Location = new Point(669, 161);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(188, 32);
            textBoxEmail.TabIndex = 13;
            // 
            // textBoxNacinVerifikacije
            // 
            textBoxNacinVerifikacije.BackColor = Color.PaleGoldenrod;
            textBoxNacinVerifikacije.Location = new Point(669, 229);
            textBoxNacinVerifikacije.Name = "textBoxNacinVerifikacije";
            textBoxNacinVerifikacije.Size = new Size(188, 32);
            textBoxNacinVerifikacije.TabIndex = 16;
            // 
            // dateTimePickerRegistracija
            // 
            dateTimePickerRegistracija.CalendarForeColor = SystemColors.ControlDarkDark;
            dateTimePickerRegistracija.CalendarMonthBackground = Color.PaleGoldenrod;
            dateTimePickerRegistracija.CalendarTitleBackColor = Color.Tan;
            dateTimePickerRegistracija.CalendarTitleForeColor = SystemColors.ControlDarkDark;
            dateTimePickerRegistracija.CustomFormat = "";
            dateTimePickerRegistracija.Format = DateTimePickerFormat.Short;
            dateTimePickerRegistracija.Location = new Point(669, 90);
            dateTimePickerRegistracija.Name = "dateTimePickerRegistracija";
            dateTimePickerRegistracija.Size = new Size(188, 32);
            dateTimePickerRegistracija.TabIndex = 17;
            // 
            // FormZaDodavanjeKorisnika
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(880, 367);
            Controls.Add(dateTimePickerRegistracija);
            Controls.Add(textBoxNacinVerifikacije);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxBrTelefona);
            Controls.Add(textBoxAdresa);
            Controls.Add(textBoxId);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonPotvrdiDodavanje);
            Font = new Font("Century Gothic", 12F);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormZaDodavanjeKorisnika";
            ShowIcon = false;
            Text = "Dodavanje korisnika";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonPotvrdiDodavanje;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private TextBox textBoxId;
        private TextBox textBoxAdresa;
        private TextBox textBoxBrTelefona;
        private TextBox textBoxEmail;
        private TextBox textBoxNacinVerifikacije;
        private DateTimePicker dateTimePickerRegistracija;
    }
}