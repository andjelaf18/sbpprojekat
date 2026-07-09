namespace IznajmljivanjeVozila.Forme
{
    partial class VoziloPretragaForm
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
            comboBoxTipPogona = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxMarka = new TextBox();
            label4 = new Label();
            label5 = new Label();
            comboBoxStatus = new ComboBox();
            label6 = new Label();
            comboBoxNamena = new ComboBox();
            label7 = new Label();
            comboBoxTipKoriscenja = new ComboBox();
            textBoxModel = new TextBox();
            buttonPretrazi = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            SuspendLayout();
            // 
            // comboBoxTipPogona
            // 
            comboBoxTipPogona.BackColor = Color.PaleGoldenrod;
            comboBoxTipPogona.FormattingEnabled = true;
            comboBoxTipPogona.Items.AddRange(new object[] { "Svi", "Elektricno", "Hibridno", "Klasicno" });
            comboBoxTipPogona.Location = new Point(537, 18);
            comboBoxTipPogona.Name = "comboBoxTipPogona";
            comboBoxTipPogona.Size = new Size(151, 31);
            comboBoxTipPogona.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(396, 18);
            label1.Name = "label1";
            label1.Size = new Size(125, 23);
            label1.TabIndex = 4;
            label1.Text = "Tip pogona:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(752, 76);
            label2.Name = "label2";
            label2.Size = new Size(78, 23);
            label2.TabIndex = 5;
            label2.Text = "Marka:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(12, 18);
            label3.Name = "label3";
            label3.Size = new Size(343, 138);
            label3.TabIndex = 6;
            label3.Text = "Pretragu vozila možete izvršiti tako\r\nšto će te uneti željene vrednosti u\r\nkontrole ili izabrati neku od\r\nponuđenih vrednosti iz kontrola.\r\nNa kraju je potrebno kliknuti\r\nna dugme \"Pretraži\".";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxMarka
            // 
            textBoxMarka.BackColor = Color.PaleGoldenrod;
            textBoxMarka.Location = new Point(846, 73);
            textBoxMarka.Name = "textBoxMarka";
            textBoxMarka.Size = new Size(222, 32);
            textBoxMarka.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(752, 133);
            label4.Name = "label4";
            label4.Size = new Size(78, 23);
            label4.TabIndex = 8;
            label4.Text = "Model:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(396, 76);
            label5.Name = "label5";
            label5.Size = new Size(72, 23);
            label5.TabIndex = 11;
            label5.Text = "Status:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.BackColor = Color.PaleGoldenrod;
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "Svi", "Aktivno", "Neaktivno", "Na servisu" });
            comboBoxStatus.Location = new Point(485, 73);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(203, 31);
            comboBoxStatus.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(396, 133);
            label6.Name = "label6";
            label6.Size = new Size(101, 23);
            label6.TabIndex = 13;
            label6.Text = "Namena:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxNamena
            // 
            comboBoxNamena.BackColor = Color.PaleGoldenrod;
            comboBoxNamena.FormattingEnabled = true;
            comboBoxNamena.Items.AddRange(new object[] { "Sve", "Putnicko", "Dostavno", "Specijalno" });
            comboBoxNamena.Location = new Point(503, 130);
            comboBoxNamena.Name = "comboBoxNamena";
            comboBoxNamena.Size = new Size(185, 31);
            comboBoxNamena.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(752, 18);
            label7.Name = "label7";
            label7.Size = new Size(149, 23);
            label7.TabIndex = 15;
            label7.Text = "Tip korišćenja:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxTipKoriscenja
            // 
            comboBoxTipKoriscenja.BackColor = Color.PaleGoldenrod;
            comboBoxTipKoriscenja.FormattingEnabled = true;
            comboBoxTipKoriscenja.Items.AddRange(new object[] { "Svi", "Privatno", "Sluzbeno" });
            comboBoxTipKoriscenja.Location = new Point(917, 15);
            comboBoxTipKoriscenja.Name = "comboBoxTipKoriscenja";
            comboBoxTipKoriscenja.Size = new Size(151, 31);
            comboBoxTipKoriscenja.TabIndex = 14;
            // 
            // textBoxModel
            // 
            textBoxModel.BackColor = Color.PaleGoldenrod;
            textBoxModel.Location = new Point(846, 130);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(217, 32);
            textBoxModel.TabIndex = 20;
            // 
            // buttonPretrazi
            // 
            buttonPretrazi.Anchor = AnchorStyles.Right;
            buttonPretrazi.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            buttonPretrazi.FlatAppearance.BorderSize = 3;
            buttonPretrazi.FlatStyle = FlatStyle.Flat;
            buttonPretrazi.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPretrazi.ForeColor = SystemColors.ControlDarkDark;
            buttonPretrazi.Location = new Point(874, 187);
            buttonPretrazi.Margin = new Padding(4, 3, 4, 3);
            buttonPretrazi.Name = "buttonPretrazi";
            buttonPretrazi.Size = new Size(189, 43);
            buttonPretrazi.TabIndex = 21;
            buttonPretrazi.Text = "Pretraži";
            buttonPretrazi.UseVisualStyleBackColor = true;
            buttonPretrazi.Click += buttonPretrazi_Click;
            // 
            // listView1
            // 
            listView1.BackColor = Color.PaleGoldenrod;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9 });
            listView1.ForeColor = SystemColors.ControlDarkDark;
            listView1.Location = new Point(12, 248);
            listView1.Name = "listView1";
            listView1.Size = new Size(1096, 323);
            listView1.TabIndex = 22;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            columnHeader1.Width = 50;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Marka";
            columnHeader3.Width = 140;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Model";
            columnHeader4.Width = 140;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Status";
            columnHeader5.Width = 140;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Tip korišćenja";
            columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Broj sedišta";
            columnHeader7.Width = 140;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Namena";
            columnHeader8.Width = 120;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Ostale informacije";
            columnHeader9.Width = 190;
            // 
            // VoziloPretragaForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(1134, 595);
            Controls.Add(listView1);
            Controls.Add(buttonPretrazi);
            Controls.Add(textBoxModel);
            Controls.Add(label7);
            Controls.Add(comboBoxTipKoriscenja);
            Controls.Add(label6);
            Controls.Add(comboBoxNamena);
            Controls.Add(label5);
            Controls.Add(comboBoxStatus);
            Controls.Add(label4);
            Controls.Add(textBoxMarka);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxTipPogona);
            Font = new Font("Century Gothic", 12F);
            Margin = new Padding(4, 3, 4, 3);
            Name = "VoziloPretragaForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Tip korišćenja:";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxTipPogona;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxMarka;
        private Label label4;
        private Label label5;
        private ComboBox comboBoxStatus;
        private Label label6;
        private ComboBox comboBoxNamena;
        private Label label7;
        private ComboBox comboBoxTipKoriscenja;
        private TextBox textBoxModel;
        private Button buttonPretrazi;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
    }
}