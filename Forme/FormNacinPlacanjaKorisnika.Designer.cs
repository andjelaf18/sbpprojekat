namespace IznajmljivanjeVozila.Forme
{
    partial class FormNacinPlacanjaKorisnika
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
            comboBoxKorisnik = new ComboBox();
            listViewNP = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            buttonDodajNP = new Button();
            buttonIzmeniNP = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(414, 92);
            label1.TabIndex = 4;
            label1.Text = "Izaberite korisnika za koga želite\r\nda proverite podatke o načinu plaćanja, \r\nda mu dodate novi ili\r\nizmenite postojeći način plaćanja.";
            // 
            // comboBoxKorisnik
            // 
            comboBoxKorisnik.BackColor = Color.PaleGoldenrod;
            comboBoxKorisnik.FormattingEnabled = true;
            comboBoxKorisnik.Location = new Point(441, 34);
            comboBoxKorisnik.Name = "comboBoxKorisnik";
            comboBoxKorisnik.Size = new Size(346, 31);
            comboBoxKorisnik.TabIndex = 5;
            comboBoxKorisnik.SelectedIndexChanged += comboBoxKorisnik_SelectedIndexChanged;
            // 
            // listViewNP
            // 
            listViewNP.BackColor = Color.PaleGoldenrod;
            listViewNP.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listViewNP.FullRowSelect = true;
            listViewNP.Location = new Point(12, 133);
            listViewNP.Name = "listViewNP";
            listViewNP.Size = new Size(775, 268);
            listViewNP.TabIndex = 6;
            listViewNP.UseCompatibleStateImageBehavior = false;
            listViewNP.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tip plaćanja";
            columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Status";
            columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Datum dodavanje ograničenja";
            columnHeader4.Width = 320;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Id korisnika";
            columnHeader5.Width = 140;
            // 
            // buttonDodajNP
            // 
            buttonDodajNP.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            buttonDodajNP.FlatAppearance.BorderSize = 3;
            buttonDodajNP.FlatStyle = FlatStyle.Flat;
            buttonDodajNP.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDodajNP.ForeColor = SystemColors.ControlDarkDark;
            buttonDodajNP.Location = new Point(161, 419);
            buttonDodajNP.Name = "buttonDodajNP";
            buttonDodajNP.Size = new Size(205, 106);
            buttonDodajNP.TabIndex = 7;
            buttonDodajNP.Text = "Dodaj novi način plaćanja";
            buttonDodajNP.UseVisualStyleBackColor = true;
            buttonDodajNP.Click += buttonDodajNP_Click;
            // 
            // buttonIzmeniNP
            // 
            buttonIzmeniNP.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            buttonIzmeniNP.FlatAppearance.BorderSize = 3;
            buttonIzmeniNP.FlatStyle = FlatStyle.Flat;
            buttonIzmeniNP.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonIzmeniNP.ForeColor = SystemColors.ControlDarkDark;
            buttonIzmeniNP.Location = new Point(413, 419);
            buttonIzmeniNP.Name = "buttonIzmeniNP";
            buttonIzmeniNP.Size = new Size(205, 106);
            buttonIzmeniNP.TabIndex = 8;
            buttonIzmeniNP.Text = "Izmeni postojeći način plaćanja";
            buttonIzmeniNP.UseVisualStyleBackColor = true;
            buttonIzmeniNP.Click += buttonIzmeniNP_Click;
            // 
            // FormNacinPlacanjaKorisnika
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(823, 552);
            Controls.Add(buttonIzmeniNP);
            Controls.Add(buttonDodajNP);
            Controls.Add(listViewNP);
            Controls.Add(comboBoxKorisnik);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormNacinPlacanjaKorisnika";
            ShowIcon = false;
            Text = "Način plaćanja";
            Load += FormNacinPlacanjaKorisnika_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxKorisnik;
        private ListView listViewNP;
        private Button buttonDodajNP;
        private Button buttonIzmeniNP;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}