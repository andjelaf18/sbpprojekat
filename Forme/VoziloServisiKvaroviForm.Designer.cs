namespace IznajmljivanjeVozila.Forme
{
    partial class VoziloServisiKvaroviForm
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
            listViewServisi = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            label2 = new Label();
            listViewKvar = new ListView();
            columnHeader19 = new ColumnHeader();
            columnHeader20 = new ColumnHeader();
            columnHeader21 = new ColumnHeader();
            columnHeader22 = new ColumnHeader();
            columnHeader23 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(414, 23);
            label1.TabIndex = 20;
            label1.Text = "Podaci o svim servisima izabranog vozila:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // listViewServisi
            // 
            listViewServisi.BackColor = Color.PaleGoldenrod;
            listViewServisi.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9 });
            listViewServisi.ForeColor = SystemColors.ControlDarkDark;
            listViewServisi.FullRowSelect = true;
            listViewServisi.Location = new Point(12, 50);
            listViewServisi.Name = "listViewServisi";
            listViewServisi.Size = new Size(639, 236);
            listViewServisi.TabIndex = 21;
            listViewServisi.UseCompatibleStateImageBehavior = false;
            listViewServisi.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id servisa";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Servisni centar";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Datum prijema";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Datum završetka";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Opis radova";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Zamenjeni delovi";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Status";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Tip";
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Troškovi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(12, 316);
            label2.Name = "label2";
            label2.Size = new Size(427, 23);
            label2.TabIndex = 22;
            label2.Text = "Podaci o svim kvarovima izabranog vozila:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // listViewKvar
            // 
            listViewKvar.BackColor = Color.PaleGoldenrod;
            listViewKvar.Columns.AddRange(new ColumnHeader[] { columnHeader19, columnHeader20, columnHeader21, columnHeader22, columnHeader23, columnHeader10, columnHeader11 });
            listViewKvar.ForeColor = SystemColors.ControlDarkDark;
            listViewKvar.FullRowSelect = true;
            listViewKvar.Location = new Point(12, 346);
            listViewKvar.Name = "listViewKvar";
            listViewKvar.Size = new Size(639, 236);
            listViewKvar.TabIndex = 23;
            listViewKvar.UseCompatibleStateImageBehavior = false;
            listViewKvar.View = View.Details;
            // 
            // columnHeader19
            // 
            columnHeader19.Text = "Id kvara";
            // 
            // columnHeader20
            // 
            columnHeader20.Text = "Prijavio problem";
            // 
            // columnHeader21
            // 
            columnHeader21.Text = "Opis problema";
            // 
            // columnHeader22
            // 
            columnHeader22.Text = "Procena ozbiljnosti";
            // 
            // columnHeader23
            // 
            columnHeader23.Text = "Status";
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Datum prijave";
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Datum otklanjanja";
            // 
            // VoziloServisiKvaroviForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(684, 615);
            Controls.Add(listViewKvar);
            Controls.Add(label2);
            Controls.Add(listViewServisi);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F);
            Margin = new Padding(4, 3, 4, 3);
            Name = "VoziloServisiKvaroviForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Servisi i kvarovi vozila";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listViewServisi;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private Label label2;
        private ListView listViewKvar;
        private ColumnHeader columnHeader19;
        private ColumnHeader columnHeader20;
        private ColumnHeader columnHeader21;
        private ColumnHeader columnHeader22;
        private ColumnHeader columnHeader23;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
    }
}