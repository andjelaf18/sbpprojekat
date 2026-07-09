namespace IznajmljivanjeVozila.Forme
{
    partial class FormRezervacijaIVoznjaDogadjaji
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
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            buttonDodajDogadjaj = new Button();
            buttonIzmeniDogadjaj = new Button();
            columnHeader7 = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(429, 46);
            label1.TabIndex = 5;
            label1.Text = "U listi možete pregledati informacije o svim\r\ndogađajima koji su se desili u toku vožnje.";
            // 
            // listView1
            // 
            listView1.BackColor = Color.PaleGoldenrod;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(12, 86);
            listView1.Name = "listView1";
            listView1.Size = new Size(899, 212);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Naglo kočenje";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Prekoračenje brzine";
            columnHeader3.Width = 250;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Duže zadržavanje";
            columnHeader4.Width = 250;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Neovlašćeni izlazak";
            columnHeader5.Width = 250;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Sudar";
            columnHeader6.Width = 200;
            // 
            // buttonDodajDogadjaj
            // 
            buttonDodajDogadjaj.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            buttonDodajDogadjaj.FlatAppearance.BorderSize = 3;
            buttonDodajDogadjaj.FlatStyle = FlatStyle.Flat;
            buttonDodajDogadjaj.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDodajDogadjaj.ForeColor = SystemColors.ControlDarkDark;
            buttonDodajDogadjaj.Location = new Point(236, 322);
            buttonDodajDogadjaj.Name = "buttonDodajDogadjaj";
            buttonDodajDogadjaj.Size = new Size(205, 103);
            buttonDodajDogadjaj.TabIndex = 8;
            buttonDodajDogadjaj.Text = "Dodaj novi događaj";
            buttonDodajDogadjaj.UseVisualStyleBackColor = true;
            buttonDodajDogadjaj.Click += buttonDodajDogadjaj_Click;
            // 
            // buttonIzmeniDogadjaj
            // 
            buttonIzmeniDogadjaj.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            buttonIzmeniDogadjaj.FlatAppearance.BorderSize = 3;
            buttonIzmeniDogadjaj.FlatStyle = FlatStyle.Flat;
            buttonIzmeniDogadjaj.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonIzmeniDogadjaj.ForeColor = SystemColors.ControlDarkDark;
            buttonIzmeniDogadjaj.Location = new Point(521, 322);
            buttonIzmeniDogadjaj.Name = "buttonIzmeniDogadjaj";
            buttonIzmeniDogadjaj.Size = new Size(205, 103);
            buttonIzmeniDogadjaj.TabIndex = 9;
            buttonIzmeniDogadjaj.Text = "Izmeni postojeći događaj";
            buttonIzmeniDogadjaj.UseVisualStyleBackColor = true;
            buttonIzmeniDogadjaj.Click += buttonIzmeniDogadjaj_Click;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Id vožnje";
            columnHeader7.Width = 100;
            // 
            // FormRezervacijaIVoznjaDogadjaji
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(923, 437);
            Controls.Add(buttonIzmeniDogadjaj);
            Controls.Add(buttonDodajDogadjaj);
            Controls.Add(listView1);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormRezervacijaIVoznjaDogadjaji";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Događaji";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button buttonDodajDogadjaj;
        private Button buttonIzmeniDogadjaj;
        private ColumnHeader columnHeader7;
    }
}