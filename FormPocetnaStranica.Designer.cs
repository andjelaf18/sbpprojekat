namespace IznajmljivanjeVozila
{
    partial class FormPocetnaStranica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPocetnaStranica));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            buttonKorisnik = new Button();
            buttonVozilo = new Button();
            buttonRezIVoznje = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(157, 320);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(420, 40);
            label1.TabIndex = 0;
            label1.Text = "IZNAJMLJIVANJE VOZILA";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(113, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(563, 280);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // buttonKorisnik
            // 
            buttonKorisnik.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            buttonKorisnik.FlatAppearance.BorderSize = 3;
            buttonKorisnik.FlatStyle = FlatStyle.Flat;
            buttonKorisnik.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonKorisnik.ForeColor = SystemColors.ControlDarkDark;
            buttonKorisnik.Location = new Point(26, 376);
            buttonKorisnik.Name = "buttonKorisnik";
            buttonKorisnik.Size = new Size(221, 118);
            buttonKorisnik.TabIndex = 2;
            buttonKorisnik.Text = "KORISNIK";
            buttonKorisnik.UseVisualStyleBackColor = true;
            buttonKorisnik.Click += buttonKorisnik_Click;
            // 
            // buttonVozilo
            // 
            buttonVozilo.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            buttonVozilo.FlatAppearance.BorderSize = 3;
            buttonVozilo.FlatStyle = FlatStyle.Flat;
            buttonVozilo.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonVozilo.ForeColor = SystemColors.ControlDarkDark;
            buttonVozilo.Location = new Point(268, 376);
            buttonVozilo.Name = "buttonVozilo";
            buttonVozilo.Size = new Size(221, 118);
            buttonVozilo.TabIndex = 3;
            buttonVozilo.Text = "VOZILO";
            buttonVozilo.UseVisualStyleBackColor = true;
            buttonVozilo.Click += buttonVozilo_Click;
            // 
            // buttonRezIVoznje
            // 
            buttonRezIVoznje.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            buttonRezIVoznje.FlatAppearance.BorderSize = 3;
            buttonRezIVoznje.FlatStyle = FlatStyle.Flat;
            buttonRezIVoznje.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRezIVoznje.ForeColor = SystemColors.ControlDarkDark;
            buttonRezIVoznje.Location = new Point(512, 376);
            buttonRezIVoznje.Name = "buttonRezIVoznje";
            buttonRezIVoznje.Size = new Size(221, 118);
            buttonRezIVoznje.TabIndex = 4;
            buttonRezIVoznje.Text = "REZERVACIJE I VOŽNJE";
            buttonRezIVoznje.UseVisualStyleBackColor = true;
            buttonRezIVoznje.Click += buttonRegIVoznje_Click;
            // 
            // FormPocetnaStranica
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(756, 541);
            Controls.Add(buttonRezIVoznje);
            Controls.Add(buttonVozilo);
            Controls.Add(buttonKorisnik);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormPocetnaStranica";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dobrodošli na početnu stranicu aplikacije za iznajmljivanje vozila!";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button buttonKorisnik;
        private Button buttonVozilo;
        private Button buttonRezIVoznje;
    }
}