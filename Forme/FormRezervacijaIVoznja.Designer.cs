namespace IznajmljivanjeVozila.Forme
{
    partial class FormRezervacijaIVoznja
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
            buttonIzmeni = new Button();
            buttonObrisi = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            menuStrip1 = new MenuStrip();
            vožnjeToolStripMenuItem = new ToolStripMenuItem();
            događajiToolStripMenuItem = new ToolStripMenuItem();
            šteteToolStripMenuItem = new ToolStripMenuItem();
            službenaVoznjaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
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
            buttonDodaj.Location = new Point(837, 149);
            buttonDodaj.Margin = new Padding(4, 3, 4, 3);
            buttonDodaj.Name = "buttonDodaj";
            buttonDodaj.Size = new Size(202, 58);
            buttonDodaj.TabIndex = 5;
            buttonDodaj.Text = "Dodaj";
            buttonDodaj.UseVisualStyleBackColor = true;
            buttonDodaj.Click += buttonDodaj_Click;
            // 
            // buttonIzmeni
            // 
            buttonIzmeni.Anchor = AnchorStyles.Right;
            buttonIzmeni.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            buttonIzmeni.FlatAppearance.BorderSize = 3;
            buttonIzmeni.FlatStyle = FlatStyle.Flat;
            buttonIzmeni.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonIzmeni.ForeColor = SystemColors.ControlDarkDark;
            buttonIzmeni.Location = new Point(837, 262);
            buttonIzmeni.Margin = new Padding(4, 3, 4, 3);
            buttonIzmeni.Name = "buttonIzmeni";
            buttonIzmeni.Size = new Size(202, 58);
            buttonIzmeni.TabIndex = 6;
            buttonIzmeni.Text = "Izmeni";
            buttonIzmeni.UseVisualStyleBackColor = true;
            buttonIzmeni.Click += buttonIzmeni_Click;
            // 
            // buttonObrisi
            // 
            buttonObrisi.Anchor = AnchorStyles.Right;
            buttonObrisi.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            buttonObrisi.FlatAppearance.BorderSize = 3;
            buttonObrisi.FlatStyle = FlatStyle.Flat;
            buttonObrisi.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonObrisi.ForeColor = SystemColors.ControlDarkDark;
            buttonObrisi.Location = new Point(837, 372);
            buttonObrisi.Margin = new Padding(4, 3, 4, 3);
            buttonObrisi.Name = "buttonObrisi";
            buttonObrisi.Size = new Size(202, 58);
            buttonObrisi.TabIndex = 7;
            buttonObrisi.Text = "Obriši";
            buttonObrisi.UseVisualStyleBackColor = true;
            buttonObrisi.Click += buttonObrisi_Click;
            // 
            // listView1
            // 
            listView1.BackColor = Color.PaleGoldenrod;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(12, 92);
            listView1.Name = "listView1";
            listView1.Size = new Size(800, 378);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            columnHeader1.Width = 50;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Id korisnika";
            columnHeader8.Width = 120;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Id vozača";
            columnHeader9.Width = 120;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Id vozila";
            columnHeader10.Width = 120;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Planirana lokacija preuzimanja";
            columnHeader11.Width = 200;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Planirana lokacija vraćanja";
            columnHeader12.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tip";
            columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Status";
            columnHeader3.Width = 140;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Planirano vreme početka";
            columnHeader4.Width = 300;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Planirano vreme završetka";
            columnHeader5.Width = 300;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.PaleGoldenrod;
            menuStrip1.Font = new Font("Century Gothic", 12F);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { vožnjeToolStripMenuItem, događajiToolStripMenuItem, šteteToolStripMenuItem, službenaVoznjaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1052, 31);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // vožnjeToolStripMenuItem
            // 
            vožnjeToolStripMenuItem.Name = "vožnjeToolStripMenuItem";
            vožnjeToolStripMenuItem.Size = new Size(89, 27);
            vožnjeToolStripMenuItem.Text = "Vožnje";
            vožnjeToolStripMenuItem.Click += vožnjeToolStripMenuItem_Click;
            // 
            // događajiToolStripMenuItem
            // 
            događajiToolStripMenuItem.Name = "događajiToolStripMenuItem";
            događajiToolStripMenuItem.Size = new Size(113, 27);
            događajiToolStripMenuItem.Text = "Događaji";
            događajiToolStripMenuItem.Click += događajiToolStripMenuItem_Click;
            // 
            // šteteToolStripMenuItem
            // 
            šteteToolStripMenuItem.Name = "šteteToolStripMenuItem";
            šteteToolStripMenuItem.Size = new Size(74, 27);
            šteteToolStripMenuItem.Text = "Štete";
            šteteToolStripMenuItem.Click += šteteToolStripMenuItem_Click;
            // 
            // službenaVoznjaToolStripMenuItem
            // 
            službenaVoznjaToolStripMenuItem.Name = "službenaVoznjaToolStripMenuItem";
            službenaVoznjaToolStripMenuItem.Size = new Size(183, 27);
            službenaVoznjaToolStripMenuItem.Text = "Službena vožnja";
            službenaVoznjaToolStripMenuItem.Click += službenaŠtetaToolStripMenuItem_Click;
            // 
            // FormRezervacijaIVoznja
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(1052, 482);
            Controls.Add(listView1);
            Controls.Add(buttonObrisi);
            Controls.Add(buttonIzmeni);
            Controls.Add(buttonDodaj);
            Controls.Add(menuStrip1);
            Font = new Font("Century Gothic", 12F);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormRezervacijaIVoznja";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Registracija i vožnja";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDodaj;
        private Button buttonIzmeni;
        private Button buttonObrisi;
        private ListView listView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem vožnjeToolStripMenuItem;
        private ToolStripMenuItem događajiToolStripMenuItem;
        private ToolStripMenuItem šteteToolStripMenuItem;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ToolStripMenuItem službenaVoznjaToolStripMenuItem;
    }
}