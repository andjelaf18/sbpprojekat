namespace IznajmljivanjeVozila.Forme
{
    partial class DostupnostVozila
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
            labelPodaciVozilo = new Label();
            label2 = new Label();
            label3 = new Label();
            dateTimePickerPocetak = new DateTimePicker();
            dateTimePickerKraj = new DateTimePicker();
            buttonProvera = new Button();
            labelRezultat = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(182, 23);
            label1.TabIndex = 4;
            label1.Text = "Izabrali ste vozilo:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelPodaciVozilo
            // 
            labelPodaciVozilo.AutoSize = true;
            labelPodaciVozilo.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPodaciVozilo.ForeColor = SystemColors.ControlDarkDark;
            labelPodaciVozilo.Location = new Point(198, 39);
            labelPodaciVozilo.Name = "labelPodaciVozilo";
            labelPodaciVozilo.Size = new Size(0, 23);
            labelPodaciVozilo.TabIndex = 5;
            labelPodaciVozilo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(12, 121);
            label2.Name = "label2";
            label2.Size = new Size(179, 23);
            label2.TabIndex = 6;
            label2.Text = "Početak perioda:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(12, 187);
            label3.Name = "label3";
            label3.Size = new Size(134, 23);
            label3.TabIndex = 7;
            label3.Text = "Kraj perioda:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dateTimePickerPocetak
            // 
            dateTimePickerPocetak.CalendarForeColor = Color.PaleGoldenrod;
            dateTimePickerPocetak.CustomFormat = "dd.MM.yyyy HH:mm";
            dateTimePickerPocetak.Format = DateTimePickerFormat.Custom;
            dateTimePickerPocetak.Location = new Point(198, 114);
            dateTimePickerPocetak.Name = "dateTimePickerPocetak";
            dateTimePickerPocetak.Size = new Size(236, 32);
            dateTimePickerPocetak.TabIndex = 8;
            // 
            // dateTimePickerKraj
            // 
            dateTimePickerKraj.CalendarForeColor = Color.PaleGoldenrod;
            dateTimePickerKraj.CustomFormat = "dd.MM.yyyy HH:mm";
            dateTimePickerKraj.Format = DateTimePickerFormat.Custom;
            dateTimePickerKraj.Location = new Point(198, 180);
            dateTimePickerKraj.Name = "dateTimePickerKraj";
            dateTimePickerKraj.Size = new Size(236, 32);
            dateTimePickerKraj.TabIndex = 9;
            // 
            // buttonProvera
            // 
            buttonProvera.Anchor = AnchorStyles.Right;
            buttonProvera.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            buttonProvera.FlatAppearance.BorderSize = 3;
            buttonProvera.FlatStyle = FlatStyle.Flat;
            buttonProvera.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonProvera.ForeColor = SystemColors.ControlDarkDark;
            buttonProvera.Location = new Point(13, 236);
            buttonProvera.Margin = new Padding(4, 3, 4, 3);
            buttonProvera.Name = "buttonProvera";
            buttonProvera.Size = new Size(202, 47);
            buttonProvera.TabIndex = 10;
            buttonProvera.Text = "Proveri dostupnost";
            buttonProvera.UseVisualStyleBackColor = true;
            buttonProvera.Click += buttonProvera_Click;
            // 
            // labelRezultat
            // 
            labelRezultat.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRezultat.ForeColor = SystemColors.ControlDarkDark;
            labelRezultat.Location = new Point(46, 318);
            labelRezultat.Name = "labelRezultat";
            labelRezultat.Size = new Size(422, 67);
            labelRezultat.TabIndex = 11;
            labelRezultat.TextAlign = ContentAlignment.MiddleCenter;
            labelRezultat.Visible = false;
            // 
            // DostupnostVozila
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(546, 415);
            Controls.Add(labelRezultat);
            Controls.Add(buttonProvera);
            Controls.Add(dateTimePickerKraj);
            Controls.Add(dateTimePickerPocetak);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(labelPodaciVozilo);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F);
            Margin = new Padding(4, 3, 4, 3);
            Name = "DostupnostVozila";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dostupnost vozila";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelPodaciVozilo;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePickerPocetak;
        private DateTimePicker dateTimePickerKraj;
        private Button buttonProvera;
        private Label labelRezultat;
    }
}