namespace IznajmljivanjeVozila.Forme
{
    partial class FormVoznje
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
            buttonDodajVoznju = new Button();
            buttonIzmeniVoznju = new Button();
            buttonObrisiVoznju = new Button();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(156, 23);
            label1.TabIndex = 5;
            label1.Text = "Lista svih vožnji";
            // 
            // listView1
            // 
            listView1.BackColor = Color.PaleGoldenrod;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader3, columnHeader4, columnHeader5, columnHeader11, columnHeader12, columnHeader2, columnHeader6, columnHeader7, columnHeader8 });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(12, 61);
            listView1.Name = "listView1";
            listView1.Size = new Size(768, 214);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            // 
            // buttonDodajVoznju
            // 
            buttonDodajVoznju.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            buttonDodajVoznju.FlatAppearance.BorderSize = 3;
            buttonDodajVoznju.FlatStyle = FlatStyle.Flat;
            buttonDodajVoznju.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDodajVoznju.ForeColor = SystemColors.ControlDarkDark;
            buttonDodajVoznju.Location = new Point(49, 333);
            buttonDodajVoznju.Name = "buttonDodajVoznju";
            buttonDodajVoznju.Size = new Size(205, 74);
            buttonDodajVoznju.TabIndex = 8;
            buttonDodajVoznju.Text = "Dodaj novu vožnju";
            buttonDodajVoznju.UseVisualStyleBackColor = true;
            buttonDodajVoznju.Click += buttonDodajVoznju_Click;
            // 
            // buttonIzmeniVoznju
            // 
            buttonIzmeniVoznju.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            buttonIzmeniVoznju.FlatAppearance.BorderSize = 3;
            buttonIzmeniVoznju.FlatStyle = FlatStyle.Flat;
            buttonIzmeniVoznju.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonIzmeniVoznju.ForeColor = SystemColors.ControlDarkDark;
            buttonIzmeniVoznju.Location = new Point(272, 333);
            buttonIzmeniVoznju.Name = "buttonIzmeniVoznju";
            buttonIzmeniVoznju.Size = new Size(205, 74);
            buttonIzmeniVoznju.TabIndex = 9;
            buttonIzmeniVoznju.Text = "Izmeni postojeću vožnju";
            buttonIzmeniVoznju.UseVisualStyleBackColor = true;
            buttonIzmeniVoznju.Click += buttonIzmeniVoznju_Click;
            // 
            // buttonObrisiVoznju
            // 
            buttonObrisiVoznju.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            buttonObrisiVoznju.FlatAppearance.BorderSize = 3;
            buttonObrisiVoznju.FlatStyle = FlatStyle.Flat;
            buttonObrisiVoznju.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonObrisiVoznju.ForeColor = SystemColors.ControlDarkDark;
            buttonObrisiVoznju.Location = new Point(498, 333);
            buttonObrisiVoznju.Name = "buttonObrisiVoznju";
            buttonObrisiVoznju.Size = new Size(205, 74);
            buttonObrisiVoznju.TabIndex = 10;
            buttonObrisiVoznju.Text = "Obriši vožnju";
            buttonObrisiVoznju.UseVisualStyleBackColor = true;
            buttonObrisiVoznju.Click += buttonObrisiVoznju_Click;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Vreme početka";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Vreme završetka";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Kilometraža";
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Trajanje";
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Početni nivo goriva/baterije";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Početna lokacija";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Završna lokacija";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Obračunata cena";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Dodatne naknade";
            // 
            // FormVoznje
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(792, 447);
            Controls.Add(buttonObrisiVoznju);
            Controls.Add(buttonIzmeniVoznju);
            Controls.Add(buttonDodajVoznju);
            Controls.Add(listView1);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormVoznje";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Vožnje";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private Button buttonDodajVoznju;
        private Button buttonIzmeniVoznju;
        private Button buttonObrisiVoznju;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
    }
}