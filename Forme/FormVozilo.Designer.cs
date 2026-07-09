namespace IznajmljivanjeVozila.Forme
{
    partial class FormVozilo
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
            menuStrip1 = new MenuStrip();
            pretragaVozilaToolStripMenuItem = new ToolStripMenuItem();
            buttonObrisiVozilo = new Button();
            buttonIzmeniVozilo = new Button();
            buttonDodajVozilo = new Button();
            listView1 = new ListView();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            label1 = new Label();
            buttonServisiKvarovi = new Button();
            buttonDostupnostVozila = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.PaleGoldenrod;
            menuStrip1.Font = new Font("Century Gothic", 12F);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { pretragaVozilaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1198, 31);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // pretragaVozilaToolStripMenuItem
            // 
            pretragaVozilaToolStripMenuItem.Name = "pretragaVozilaToolStripMenuItem";
            pretragaVozilaToolStripMenuItem.Size = new Size(172, 27);
            pretragaVozilaToolStripMenuItem.Text = "Pretraga vozila";
            pretragaVozilaToolStripMenuItem.Click += pretragaVozilaToolStripMenuItem_Click;
            // 
            // buttonObrisiVozilo
            // 
            buttonObrisiVozilo.Anchor = AnchorStyles.Right;
            buttonObrisiVozilo.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            buttonObrisiVozilo.FlatAppearance.BorderSize = 3;
            buttonObrisiVozilo.FlatStyle = FlatStyle.Flat;
            buttonObrisiVozilo.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonObrisiVozilo.ForeColor = SystemColors.ControlDarkDark;
            buttonObrisiVozilo.Location = new Point(970, 276);
            buttonObrisiVozilo.Margin = new Padding(4, 3, 4, 3);
            buttonObrisiVozilo.Name = "buttonObrisiVozilo";
            buttonObrisiVozilo.Size = new Size(202, 58);
            buttonObrisiVozilo.TabIndex = 11;
            buttonObrisiVozilo.Text = "Obriši";
            buttonObrisiVozilo.UseVisualStyleBackColor = true;
            buttonObrisiVozilo.Click += buttonObrisiVozilo_Click;
            // 
            // buttonIzmeniVozilo
            // 
            buttonIzmeniVozilo.Anchor = AnchorStyles.Right;
            buttonIzmeniVozilo.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            buttonIzmeniVozilo.FlatAppearance.BorderSize = 3;
            buttonIzmeniVozilo.FlatStyle = FlatStyle.Flat;
            buttonIzmeniVozilo.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonIzmeniVozilo.ForeColor = SystemColors.ControlDarkDark;
            buttonIzmeniVozilo.Location = new Point(970, 176);
            buttonIzmeniVozilo.Margin = new Padding(4, 3, 4, 3);
            buttonIzmeniVozilo.Name = "buttonIzmeniVozilo";
            buttonIzmeniVozilo.Size = new Size(202, 58);
            buttonIzmeniVozilo.TabIndex = 10;
            buttonIzmeniVozilo.Text = "Izmeni";
            buttonIzmeniVozilo.UseVisualStyleBackColor = true;
            buttonIzmeniVozilo.Click += buttonIzmeniVozilo_Click;
            // 
            // buttonDodajVozilo
            // 
            buttonDodajVozilo.Anchor = AnchorStyles.Right;
            buttonDodajVozilo.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            buttonDodajVozilo.FlatAppearance.BorderSize = 3;
            buttonDodajVozilo.FlatStyle = FlatStyle.Flat;
            buttonDodajVozilo.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDodajVozilo.ForeColor = SystemColors.ControlDarkDark;
            buttonDodajVozilo.Location = new Point(970, 77);
            buttonDodajVozilo.Margin = new Padding(4, 3, 4, 3);
            buttonDodajVozilo.Name = "buttonDodajVozilo";
            buttonDodajVozilo.Size = new Size(202, 58);
            buttonDodajVozilo.TabIndex = 9;
            buttonDodajVozilo.Text = "Dodaj";
            buttonDodajVozilo.UseVisualStyleBackColor = true;
            buttonDodajVozilo.Click += buttonDodajVozilo_Click;
            // 
            // listView1
            // 
            listView1.BackColor = Color.PaleGoldenrod;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader12, columnHeader13, columnHeader14 });
            listView1.ForeColor = SystemColors.ControlDarkDark;
            listView1.FullRowSelect = true;
            listView1.Location = new Point(20, 67);
            listView1.Margin = new Padding(4, 3, 4, 3);
            listView1.Name = "listView1";
            listView1.Size = new Size(925, 562);
            listView1.TabIndex = 12;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "ID";
            columnHeader8.Width = 50;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Registracija";
            columnHeader9.Width = 160;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Vin broj";
            columnHeader10.Width = 140;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Marka";
            columnHeader11.Width = 140;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Model";
            columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Godina proizvodnje";
            columnHeader2.Width = 220;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Datum nabavke";
            columnHeader3.Width = 220;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Status";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Tip korišćenja";
            columnHeader5.Width = 140;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Broj sedišta";
            columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Stanje enterijera";
            columnHeader7.Width = 200;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Stanje eksterijera";
            columnHeader12.Width = 200;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Dodatna oprema";
            columnHeader13.Width = 200;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Tip pogona";
            columnHeader14.Width = 140;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(967, 374);
            label1.Name = "label1";
            label1.Size = new Size(220, 161);
            label1.TabIndex = 13;
            label1.Text = "Izaberite vozilo iz liste\r\nsvih vozila i klikom\r\nna dugme\r\n\"Servisi i kvarovi\"\r\npregledajte liste svih\r\nservisa i kvarova\r\nkoje je vozilo imalo.";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonServisiKvarovi
            // 
            buttonServisiKvarovi.Anchor = AnchorStyles.Right;
            buttonServisiKvarovi.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            buttonServisiKvarovi.FlatAppearance.BorderSize = 3;
            buttonServisiKvarovi.FlatStyle = FlatStyle.Flat;
            buttonServisiKvarovi.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonServisiKvarovi.ForeColor = SystemColors.ControlDarkDark;
            buttonServisiKvarovi.Location = new Point(970, 547);
            buttonServisiKvarovi.Margin = new Padding(4, 3, 4, 3);
            buttonServisiKvarovi.Name = "buttonServisiKvarovi";
            buttonServisiKvarovi.Size = new Size(202, 58);
            buttonServisiKvarovi.TabIndex = 14;
            buttonServisiKvarovi.Text = "Servisi i kvarovi";
            buttonServisiKvarovi.UseVisualStyleBackColor = true;
            buttonServisiKvarovi.Click += buttonServisiKvarovi_Click;
            // 
            // buttonDostupnostVozila
            // 
            buttonDostupnostVozila.Anchor = AnchorStyles.Right;
            buttonDostupnostVozila.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            buttonDostupnostVozila.FlatAppearance.BorderSize = 3;
            buttonDostupnostVozila.FlatStyle = FlatStyle.Flat;
            buttonDostupnostVozila.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDostupnostVozila.ForeColor = SystemColors.ControlDarkDark;
            buttonDostupnostVozila.Location = new Point(970, 627);
            buttonDostupnostVozila.Margin = new Padding(4, 3, 4, 3);
            buttonDostupnostVozila.Name = "buttonDostupnostVozila";
            buttonDostupnostVozila.Size = new Size(202, 75);
            buttonDostupnostVozila.TabIndex = 15;
            buttonDostupnostVozila.Text = "Proveri dostupnost vozila";
            buttonDostupnostVozila.UseVisualStyleBackColor = true;
            buttonDostupnostVozila.Click += buttonDostupnostVozila_Click;
            // 
            // FormVozilo
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(1198, 714);
            Controls.Add(buttonDostupnostVozila);
            Controls.Add(buttonServisiKvarovi);
            Controls.Add(label1);
            Controls.Add(listView1);
            Controls.Add(buttonObrisiVozilo);
            Controls.Add(buttonIzmeniVozilo);
            Controls.Add(buttonDodajVozilo);
            Controls.Add(menuStrip1);
            Font = new Font("Century Gothic", 12F);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormVozilo";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Vozilo";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem pretragaVozilaToolStripMenuItem;
        private Button buttonObrisiVozilo;
        private Button buttonIzmeniVozilo;
        private Button buttonDodajVozilo;
        private ListView listView1;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private Label label1;
        private Button buttonServisiKvarovi;
        private ColumnHeader columnHeader14;
        private Button buttonDostupnostVozila;
    }
}