namespace IznajmljivanjeVozila.Forme
{
    partial class FormZaDodavanjeNacinaPlacanja
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxTipPlacanja = new TextBox();
            textBoxStatus = new TextBox();
            buttonDodajNP = new Button();
            label4 = new Label();
            textBoxId = new TextBox();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            labelKorisnik = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(22, 145);
            label1.Name = "label1";
            label1.Size = new Size(135, 23);
            label1.TabIndex = 5;
            label1.Text = "Tip plaćanja:";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(22, 210);
            label2.Name = "label2";
            label2.Size = new Size(72, 23);
            label2.TabIndex = 6;
            label2.Text = "Status:";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(22, 267);
            label3.Name = "label3";
            label3.Size = new Size(204, 23);
            label3.TabIndex = 7;
            label3.Text = "Datum ograničenja:";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // textBoxTipPlacanja
            // 
            textBoxTipPlacanja.BackColor = Color.PaleGoldenrod;
            textBoxTipPlacanja.Location = new Point(165, 142);
            textBoxTipPlacanja.Name = "textBoxTipPlacanja";
            textBoxTipPlacanja.Size = new Size(197, 32);
            textBoxTipPlacanja.TabIndex = 8;
            // 
            // textBoxStatus
            // 
            textBoxStatus.BackColor = Color.PaleGoldenrod;
            textBoxStatus.Location = new Point(100, 207);
            textBoxStatus.Name = "textBoxStatus";
            textBoxStatus.Size = new Size(197, 32);
            textBoxStatus.TabIndex = 9;
            // 
            // buttonDodajNP
            // 
            buttonDodajNP.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            buttonDodajNP.FlatAppearance.BorderSize = 3;
            buttonDodajNP.FlatStyle = FlatStyle.Flat;
            buttonDodajNP.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDodajNP.ForeColor = SystemColors.ControlDarkDark;
            buttonDodajNP.Location = new Point(20, 307);
            buttonDodajNP.Name = "buttonDodajNP";
            buttonDodajNP.Size = new Size(192, 62);
            buttonDodajNP.TabIndex = 11;
            buttonDodajNP.Text = "Potvrdi ";
            buttonDodajNP.UseVisualStyleBackColor = true;
            buttonDodajNP.Click += buttonDodajNP_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(22, 96);
            label4.Name = "label4";
            label4.Size = new Size(36, 23);
            label4.TabIndex = 12;
            label4.Text = "ID:";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // textBoxId
            // 
            textBoxId.BackColor = Color.PaleGoldenrod;
            textBoxId.Location = new Point(64, 93);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(197, 32);
            textBoxId.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(22, 24);
            label5.Name = "label5";
            label5.Size = new Size(579, 23);
            label5.TabIndex = 14;
            label5.Text = "Popunite sve kontrole da biste dodali novi način plaćanja.";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.PaleGoldenrod;
            dateTimePicker1.CalendarMonthBackground = Color.PaleGoldenrod;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(232, 264);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(183, 32);
            dateTimePicker1.TabIndex = 15;
            // 
            // labelKorisnik
            // 
            labelKorisnik.AutoSize = true;
            labelKorisnik.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelKorisnik.ForeColor = SystemColors.ControlDarkDark;
            labelKorisnik.Location = new Point(20, 53);
            labelKorisnik.Name = "labelKorisnik";
            labelKorisnik.Size = new Size(0, 23);
            labelKorisnik.TabIndex = 16;
            labelKorisnik.TextAlign = ContentAlignment.TopRight;
            // 
            // FormZaDodavanjeNacinaPlacanja
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(632, 395);
            Controls.Add(labelKorisnik);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(textBoxId);
            Controls.Add(label4);
            Controls.Add(buttonDodajNP);
            Controls.Add(textBoxStatus);
            Controls.Add(textBoxTipPlacanja);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormZaDodavanjeNacinaPlacanja";
            ShowIcon = false;
            Text = "Dodavanje načina plaćanja";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxTipPlacanja;
        private TextBox textBoxStatus;
        private Button buttonDodajNP;
        private Label label4;
        private TextBox textBoxId;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Label labelKorisnik;
    }
}