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
            label8 = new Label();
            comboBoxDopuna = new ComboBox();
            label9 = new Label();
            comboBoxTipGoriva = new ComboBox();
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
            comboBoxTipPogona.Location = new Point(177, 191);
            comboBoxTipPogona.Name = "comboBoxTipPogona";
            comboBoxTipPogona.Size = new Size(151, 31);
            comboBoxTipPogona.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(12, 191);
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
            label2.Location = new Point(12, 299);
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
            textBoxMarka.Location = new Point(106, 296);
            textBoxMarka.Name = "textBoxMarka";
            textBoxMarka.Size = new Size(222, 32);
            textBoxMarka.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(363, 299);
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
            label5.Location = new Point(366, 191);
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
            comboBoxStatus.Location = new Point(462, 188);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(151, 31);
            comboBoxStatus.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(649, 191);
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
            comboBoxNamena.Location = new Point(771, 188);
            comboBoxNamena.Name = "comboBoxNamena";
            comboBoxNamena.Size = new Size(151, 31);
            comboBoxNamena.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(12, 245);
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
            comboBoxTipKoriscenja.Location = new Point(177, 242);
            comboBoxTipKoriscenja.Name = "comboBoxTipKoriscenja";
            comboBoxTipKoriscenja.Size = new Size(151, 31);
            comboBoxTipKoriscenja.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(363, 245);
            label8.Name = "label8";
            label8.Size = new Size(93, 23);
            label8.TabIndex = 17;
            label8.Text = "Dopuna:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxDopuna
            // 
            comboBoxDopuna.BackColor = Color.PaleGoldenrod;
            comboBoxDopuna.FormattingEnabled = true;
            comboBoxDopuna.Items.AddRange(new object[] { "Sve", "Točenje goriva", "Punjenje baterije" });
            comboBoxDopuna.Location = new Point(462, 242);
            comboBoxDopuna.Name = "comboBoxDopuna";
            comboBoxDopuna.Size = new Size(181, 31);
            comboBoxDopuna.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlDarkDark;
            label9.Location = new Point(649, 245);
            label9.Name = "label9";
            label9.Size = new Size(109, 23);
            label9.TabIndex = 19;
            label9.Text = "Tip goriva:";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxTipGoriva
            // 
            comboBoxTipGoriva.BackColor = Color.PaleGoldenrod;
            comboBoxTipGoriva.FormattingEnabled = true;
            comboBoxTipGoriva.Items.AddRange(new object[] { "Svi", "Dizel", "Benzin" });
            comboBoxTipGoriva.Location = new Point(771, 242);
            comboBoxTipGoriva.Name = "comboBoxTipGoriva";
            comboBoxTipGoriva.Size = new Size(151, 31);
            comboBoxTipGoriva.TabIndex = 18;
            // 
            // textBoxModel
            // 
            textBoxModel.BackColor = Color.PaleGoldenrod;
            textBoxModel.Location = new Point(462, 296);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(151, 32);
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
            buttonPretrazi.Location = new Point(733, 289);
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
            listView1.Location = new Point(12, 378);
            listView1.Name = "listView1";
            listView1.Size = new Size(910, 287);
            listView1.TabIndex = 22;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Marka";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Model";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Status";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Tip korišćenja";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Broj sedišta";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Namena";
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Ostale informacije";
            // 
            // VoziloPretragaForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(943, 706);
            Controls.Add(listView1);
            Controls.Add(buttonPretrazi);
            Controls.Add(textBoxModel);
            Controls.Add(label9);
            Controls.Add(comboBoxTipGoriva);
            Controls.Add(label8);
            Controls.Add(comboBoxDopuna);
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
        private Label label8;
        private ComboBox comboBoxDopuna;
        private Label label9;
        private ComboBox comboBoxTipGoriva;
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