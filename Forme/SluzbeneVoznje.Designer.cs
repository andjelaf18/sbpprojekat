namespace IznajmljivanjeVozila.Forme
{
    partial class SluzbeneVoznje
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
            comboBoxOvlascenoLice = new ComboBox();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(444, 46);
            label1.TabIndex = 5;
            label1.Text = "Izaberite ovlašćeno lice za koje želite\r\nda proverite koje službene vožnje je odobrio";
            // 
            // comboBoxOvlascenoLice
            // 
            comboBoxOvlascenoLice.BackColor = Color.PaleGoldenrod;
            comboBoxOvlascenoLice.ForeColor = SystemColors.ControlDarkDark;
            comboBoxOvlascenoLice.FormattingEnabled = true;
            comboBoxOvlascenoLice.Location = new Point(469, 36);
            comboBoxOvlascenoLice.Name = "comboBoxOvlascenoLice";
            comboBoxOvlascenoLice.Size = new Size(241, 31);
            comboBoxOvlascenoLice.TabIndex = 6;
            comboBoxOvlascenoLice.SelectedIndexChanged += comboBoxOvlascenoLice_SelectedIndexChanged;
            // 
            // listView1
            // 
            listView1.BackColor = Color.PaleGoldenrod;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(12, 100);
            listView1.Name = "listView1";
            listView1.Size = new Size(698, 268);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Razlog";
            // 
            // SluzbeneVoznje
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(733, 403);
            Controls.Add(listView1);
            Controls.Add(comboBoxOvlascenoLice);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F);
            Margin = new Padding(4, 3, 4, 3);
            Name = "SluzbeneVoznje";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Službene vožnje";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxOvlascenoLice;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}