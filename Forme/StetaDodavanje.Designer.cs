namespace IznajmljivanjeVozila.Forme
{
    partial class StetaDodavanje
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
            textBoxOdgovornosti = new TextBox();
            textBoxProcenaStete = new TextBox();
            textBoxOsiguravajuceKuce = new TextBox();
            textBoxZapisnici = new TextBox();
            textBoxID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label7 = new Label();
            label8 = new Label();
            openFileDialog1 = new OpenFileDialog();
            buttonIzaberiFoto = new Button();
            labelFotografija = new Label();
            label1 = new Label();
            comboBoxVoznja = new ComboBox();
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
            buttonDodaj.Location = new Point(13, 517);
            buttonDodaj.Margin = new Padding(4, 3, 4, 3);
            buttonDodaj.Name = "buttonDodaj";
            buttonDodaj.Size = new Size(181, 58);
            buttonDodaj.TabIndex = 43;
            buttonDodaj.Text = "Dodaj";
            buttonDodaj.UseVisualStyleBackColor = true;
            buttonDodaj.Click += buttonDodaj_Click;
            // 
            // textBoxOdgovornosti
            // 
            textBoxOdgovornosti.BackColor = Color.PaleGoldenrod;
            textBoxOdgovornosti.Location = new Point(171, 373);
            textBoxOdgovornosti.Name = "textBoxOdgovornosti";
            textBoxOdgovornosti.Size = new Size(173, 32);
            textBoxOdgovornosti.TabIndex = 42;
            // 
            // textBoxProcenaStete
            // 
            textBoxProcenaStete.BackColor = Color.PaleGoldenrod;
            textBoxProcenaStete.Location = new Point(174, 314);
            textBoxProcenaStete.Name = "textBoxProcenaStete";
            textBoxProcenaStete.Size = new Size(173, 32);
            textBoxProcenaStete.TabIndex = 41;
            // 
            // textBoxOsiguravajuceKuce
            // 
            textBoxOsiguravajuceKuce.BackColor = Color.PaleGoldenrod;
            textBoxOsiguravajuceKuce.Location = new Point(238, 248);
            textBoxOsiguravajuceKuce.Name = "textBoxOsiguravajuceKuce";
            textBoxOsiguravajuceKuce.Size = new Size(173, 32);
            textBoxOsiguravajuceKuce.TabIndex = 40;
            // 
            // textBoxZapisnici
            // 
            textBoxZapisnici.BackColor = Color.PaleGoldenrod;
            textBoxZapisnici.Location = new Point(134, 191);
            textBoxZapisnici.Name = "textBoxZapisnici";
            textBoxZapisnici.Size = new Size(173, 32);
            textBoxZapisnici.TabIndex = 39;
            // 
            // textBoxID
            // 
            textBoxID.BackColor = Color.PaleGoldenrod;
            textBoxID.Location = new Point(59, 77);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(173, 32);
            textBoxID.TabIndex = 37;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(18, 376);
            label6.Name = "label6";
            label6.Size = new Size(147, 23);
            label6.TabIndex = 36;
            label6.Text = "Odgovornosti:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(18, 317);
            label5.Name = "label5";
            label5.Size = new Size(150, 23);
            label5.TabIndex = 35;
            label5.Text = "Procena štete:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(18, 257);
            label4.Name = "label4";
            label4.Size = new Size(214, 23);
            label4.TabIndex = 34;
            label4.Text = "Osiguravajuće kuće:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(18, 194);
            label3.Name = "label3";
            label3.Size = new Size(101, 23);
            label3.TabIndex = 33;
            label3.Text = "Zapisnici:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(18, 131);
            label2.Name = "label2";
            label2.Size = new Size(119, 23);
            label2.TabIndex = 32;
            label2.Text = "Fotografije:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(18, 80);
            label7.Name = "label7";
            label7.Size = new Size(35, 23);
            label7.TabIndex = 31;
            label7.Text = "Id:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(18, 11);
            label8.Name = "label8";
            label8.Size = new Size(429, 46);
            label8.TabIndex = 30;
            label8.Text = "Popunite sve kontrole da biste dodali\r\nnovu štetu u sistem za iznajmljivanje vozila.";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonIzaberiFoto
            // 
            buttonIzaberiFoto.Anchor = AnchorStyles.Right;
            buttonIzaberiFoto.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            buttonIzaberiFoto.FlatAppearance.BorderSize = 3;
            buttonIzaberiFoto.FlatStyle = FlatStyle.Flat;
            buttonIzaberiFoto.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonIzaberiFoto.ForeColor = SystemColors.ControlDarkDark;
            buttonIzaberiFoto.Location = new Point(144, 116);
            buttonIzaberiFoto.Margin = new Padding(4, 3, 4, 3);
            buttonIzaberiFoto.Name = "buttonIzaberiFoto";
            buttonIzaberiFoto.Size = new Size(213, 52);
            buttonIzaberiFoto.TabIndex = 59;
            buttonIzaberiFoto.Text = "Izaberi fotografiju";
            buttonIzaberiFoto.UseVisualStyleBackColor = true;
            buttonIzaberiFoto.Click += buttonIzaberiFoto_Click;
            // 
            // labelFotografija
            // 
            labelFotografija.AutoSize = true;
            labelFotografija.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFotografija.ForeColor = SystemColors.ControlDarkDark;
            labelFotografija.Location = new Point(391, 119);
            labelFotografija.Name = "labelFotografija";
            labelFotografija.Size = new Size(189, 46);
            labelFotografija.TabIndex = 60;
            labelFotografija.Text = "Uspešno ste\r\nizabrali fotografiju.";
            labelFotografija.TextAlign = ContentAlignment.MiddleLeft;
            labelFotografija.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(18, 439);
            label1.Name = "label1";
            label1.Size = new Size(82, 23);
            label1.TabIndex = 61;
            label1.Text = "Vožnja:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxVoznja
            // 
            comboBoxVoznja.BackColor = Color.PaleGoldenrod;
            comboBoxVoznja.FormattingEnabled = true;
            comboBoxVoznja.Location = new Point(106, 436);
            comboBoxVoznja.Name = "comboBoxVoznja";
            comboBoxVoznja.Size = new Size(474, 31);
            comboBoxVoznja.TabIndex = 62;
            // 
            // StetaDodavanje
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(603, 587);
            Controls.Add(comboBoxVoznja);
            Controls.Add(label1);
            Controls.Add(labelFotografija);
            Controls.Add(buttonIzaberiFoto);
            Controls.Add(buttonDodaj);
            Controls.Add(textBoxOdgovornosti);
            Controls.Add(textBoxProcenaStete);
            Controls.Add(textBoxOsiguravajuceKuce);
            Controls.Add(textBoxZapisnici);
            Controls.Add(textBoxID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label8);
            Font = new Font("Century Gothic", 12F);
            Margin = new Padding(4, 3, 4, 3);
            Name = "StetaDodavanje";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dodavanje štete";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonDodaj;
        private TextBox textBoxOdgovornosti;
        private TextBox textBoxProcenaStete;
        private TextBox textBoxOsiguravajuceKuce;
        private TextBox textBoxZapisnici;
        private TextBox textBoxID;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private Label label8;
        private OpenFileDialog openFileDialog1;
        private Button buttonIzaberiFoto;
        private Label labelFotografija;
        private Label label1;
        private ComboBox comboBoxVoznja;
    }
}