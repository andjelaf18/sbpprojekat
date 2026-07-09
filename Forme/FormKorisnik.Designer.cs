namespace IznajmljivanjeVozila.Forme
{
    partial class FormKorisnik
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
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            menuStrip1 = new MenuStrip();
            nacinPlacanjaToolStripMenuItem = new ToolStripMenuItem();
            pravnaLicaToolStripMenuItem = new ToolStripMenuItem();
            buttonDodajKorisnika = new Button();
            buttonIzmeniKorisnika = new Button();
            buttonObrisiKorisnika = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.BackColor = Color.PaleGoldenrod;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            listView1.ForeColor = SystemColors.ControlDarkDark;
            listView1.FullRowSelect = true;
            listView1.Location = new Point(13, 116);
            listView1.Margin = new Padding(4, 3, 4, 3);
            listView1.Name = "listView1";
            listView1.Size = new Size(919, 518);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Adresa";
            columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Broj telefona";
            columnHeader3.Width = 140;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Email";
            columnHeader4.Width = 210;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Status";
            columnHeader5.Width = 110;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Način verifikacije";
            columnHeader6.Width = 200;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Datum registracije";
            columnHeader7.Width = 200;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.PaleGoldenrod;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Font = new Font("Century Gothic", 12F);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { nacinPlacanjaToolStripMenuItem, pravnaLicaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 2, 0, 2);
            menuStrip1.Size = new Size(323, 31);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // nacinPlacanjaToolStripMenuItem
            // 
            nacinPlacanjaToolStripMenuItem.Name = "nacinPlacanjaToolStripMenuItem";
            nacinPlacanjaToolStripMenuItem.Size = new Size(176, 27);
            nacinPlacanjaToolStripMenuItem.Text = "Način plaćanja";
            nacinPlacanjaToolStripMenuItem.Click += nacinPlacanjaToolStripMenuItem_Click;
            // 
            // pravnaLicaToolStripMenuItem
            // 
            pravnaLicaToolStripMenuItem.Name = "pravnaLicaToolStripMenuItem";
            pravnaLicaToolStripMenuItem.Size = new Size(136, 27);
            pravnaLicaToolStripMenuItem.Text = "Pravna lica";
            pravnaLicaToolStripMenuItem.Click += pravnaLicaToolStripMenuItem_Click;
            // 
            // buttonDodajKorisnika
            // 
            buttonDodajKorisnika.Anchor = AnchorStyles.Right;
            buttonDodajKorisnika.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            buttonDodajKorisnika.FlatAppearance.BorderSize = 3;
            buttonDodajKorisnika.FlatStyle = FlatStyle.Flat;
            buttonDodajKorisnika.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDodajKorisnika.ForeColor = SystemColors.ControlDarkDark;
            buttonDodajKorisnika.Location = new Point(957, 156);
            buttonDodajKorisnika.Margin = new Padding(4, 3, 4, 3);
            buttonDodajKorisnika.Name = "buttonDodajKorisnika";
            buttonDodajKorisnika.Size = new Size(202, 58);
            buttonDodajKorisnika.TabIndex = 4;
            buttonDodajKorisnika.Text = "Dodaj";
            buttonDodajKorisnika.UseVisualStyleBackColor = true;
            buttonDodajKorisnika.Click += buttonDodajKorisnika_Click;
            // 
            // buttonIzmeniKorisnika
            // 
            buttonIzmeniKorisnika.Anchor = AnchorStyles.Right;
            buttonIzmeniKorisnika.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            buttonIzmeniKorisnika.FlatAppearance.BorderSize = 3;
            buttonIzmeniKorisnika.FlatStyle = FlatStyle.Flat;
            buttonIzmeniKorisnika.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonIzmeniKorisnika.ForeColor = SystemColors.ControlDarkDark;
            buttonIzmeniKorisnika.Location = new Point(957, 303);
            buttonIzmeniKorisnika.Margin = new Padding(4, 3, 4, 3);
            buttonIzmeniKorisnika.Name = "buttonIzmeniKorisnika";
            buttonIzmeniKorisnika.Size = new Size(202, 58);
            buttonIzmeniKorisnika.TabIndex = 7;
            buttonIzmeniKorisnika.Text = "Izmeni";
            buttonIzmeniKorisnika.UseVisualStyleBackColor = true;
            buttonIzmeniKorisnika.Click += buttonIzmeniKorisnika_Click;
            // 
            // buttonObrisiKorisnika
            // 
            buttonObrisiKorisnika.Anchor = AnchorStyles.Right;
            buttonObrisiKorisnika.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            buttonObrisiKorisnika.FlatAppearance.BorderSize = 3;
            buttonObrisiKorisnika.FlatStyle = FlatStyle.Flat;
            buttonObrisiKorisnika.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonObrisiKorisnika.ForeColor = SystemColors.ControlDarkDark;
            buttonObrisiKorisnika.Location = new Point(957, 438);
            buttonObrisiKorisnika.Margin = new Padding(4, 3, 4, 3);
            buttonObrisiKorisnika.Name = "buttonObrisiKorisnika";
            buttonObrisiKorisnika.Size = new Size(202, 58);
            buttonObrisiKorisnika.TabIndex = 8;
            buttonObrisiKorisnika.Text = "Obriši";
            buttonObrisiKorisnika.UseVisualStyleBackColor = true;
            buttonObrisiKorisnika.Click += buttonObrisiKorisnika_Click;
            // 
            // FormKorisnik
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(1172, 665);
            Controls.Add(buttonObrisiKorisnika);
            Controls.Add(buttonIzmeniKorisnika);
            Controls.Add(buttonDodajKorisnika);
            Controls.Add(listView1);
            Controls.Add(menuStrip1);
            Font = new Font("Century Gothic", 12F);
            ForeColor = SystemColors.ControlDarkDark;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormKorisnik";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Korisnik";
            Load += FormKorisnik_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem nacinPlacanjaToolStripMenuItem;
        private ToolStripMenuItem pravnaLicaToolStripMenuItem;
        private Button buttonDodajKorisnika;
        private Button buttonIzmeniKorisnika;
        private Button buttonObrisiKorisnika;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
    }
}