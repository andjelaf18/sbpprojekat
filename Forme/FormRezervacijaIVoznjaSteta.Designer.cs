namespace IznajmljivanjeVozila.Forme
{
    partial class FormRezervacijaIVoznjaSteta
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
            buttonIzmeniStetu = new Button();
            buttonDodajStetu = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            label1 = new Label();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            SuspendLayout();
            // 
            // buttonIzmeniStetu
            // 
            buttonIzmeniStetu.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            buttonIzmeniStetu.FlatAppearance.BorderSize = 3;
            buttonIzmeniStetu.FlatStyle = FlatStyle.Flat;
            buttonIzmeniStetu.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonIzmeniStetu.ForeColor = SystemColors.ControlDarkDark;
            buttonIzmeniStetu.Location = new Point(309, 321);
            buttonIzmeniStetu.Name = "buttonIzmeniStetu";
            buttonIzmeniStetu.Size = new Size(205, 103);
            buttonIzmeniStetu.TabIndex = 13;
            buttonIzmeniStetu.Text = "Izmeni postojeću štetu";
            buttonIzmeniStetu.UseVisualStyleBackColor = true;
            buttonIzmeniStetu.Click += buttonIzmeniStetu_Click;
            // 
            // buttonDodajStetu
            // 
            buttonDodajStetu.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            buttonDodajStetu.FlatAppearance.BorderSize = 3;
            buttonDodajStetu.FlatStyle = FlatStyle.Flat;
            buttonDodajStetu.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDodajStetu.ForeColor = SystemColors.ControlDarkDark;
            buttonDodajStetu.Location = new Point(68, 321);
            buttonDodajStetu.Name = "buttonDodajStetu";
            buttonDodajStetu.Size = new Size(205, 103);
            buttonDodajStetu.TabIndex = 12;
            buttonDodajStetu.Text = "Dodaj novu štetu";
            buttonDodajStetu.UseVisualStyleBackColor = true;
            buttonDodajStetu.Click += buttonDodajDogadjaj_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader2 });
            listView1.Location = new Point(12, 65);
            listView1.Name = "listView1";
            listView1.Size = new Size(601, 212);
            listView1.TabIndex = 11;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(520, 23);
            label1.TabIndex = 10;
            label1.Text = "U listi možete pregledati informacije o svim štetama.";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Fotografije";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Zapisnici";
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Osiguravajuće kuće";
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Procena štete";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Odgovornost";
            // 
            // FormRezervacijaIVoznjaSteta
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(637, 463);
            Controls.Add(buttonIzmeniStetu);
            Controls.Add(buttonDodajStetu);
            Controls.Add(listView1);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormRezervacijaIVoznjaSteta";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Šteta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonIzmeniStetu;
        private Button buttonDodajStetu;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private Label label1;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader2;
    }
}