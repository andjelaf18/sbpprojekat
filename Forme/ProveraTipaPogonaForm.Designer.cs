namespace IznajmljivanjeVozila.Forme
{
    partial class ProveraTipaPogonaForm
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
            buttonHVozilo = new Button();
            buttonKVozilo = new Button();
            buttonEVozilo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(76, 22);
            label1.Name = "label1";
            label1.Size = new Size(714, 46);
            label1.TabIndex = 14;
            label1.Text = "Da biste nastavili sa dodavanjem vozila u sistem za iznajmljivanje vozila,\r\nneophodno je da odaberete jedan od ponuđenih tipova pogona.";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonHVozilo
            // 
            buttonHVozilo.Anchor = AnchorStyles.Right;
            buttonHVozilo.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            buttonHVozilo.FlatAppearance.BorderSize = 3;
            buttonHVozilo.FlatStyle = FlatStyle.Flat;
            buttonHVozilo.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonHVozilo.ForeColor = SystemColors.ControlDarkDark;
            buttonHVozilo.Location = new Point(30, 105);
            buttonHVozilo.Margin = new Padding(4, 3, 4, 3);
            buttonHVozilo.Name = "buttonHVozilo";
            buttonHVozilo.Size = new Size(202, 58);
            buttonHVozilo.TabIndex = 15;
            buttonHVozilo.Text = "Hibridno vozilo";
            buttonHVozilo.UseVisualStyleBackColor = true;
            buttonHVozilo.Click += buttonHVozilo_Click;
            // 
            // buttonKVozilo
            // 
            buttonKVozilo.Anchor = AnchorStyles.Right;
            buttonKVozilo.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            buttonKVozilo.FlatAppearance.BorderSize = 3;
            buttonKVozilo.FlatStyle = FlatStyle.Flat;
            buttonKVozilo.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonKVozilo.ForeColor = SystemColors.ControlDarkDark;
            buttonKVozilo.Location = new Point(358, 105);
            buttonKVozilo.Margin = new Padding(4, 3, 4, 3);
            buttonKVozilo.Name = "buttonKVozilo";
            buttonKVozilo.Size = new Size(202, 58);
            buttonKVozilo.TabIndex = 16;
            buttonKVozilo.Text = "Klasično vozilo";
            buttonKVozilo.UseVisualStyleBackColor = true;
            buttonKVozilo.Click += buttonKVozilo_Click;
            // 
            // buttonEVozilo
            // 
            buttonEVozilo.Anchor = AnchorStyles.Right;
            buttonEVozilo.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            buttonEVozilo.FlatAppearance.BorderSize = 3;
            buttonEVozilo.FlatStyle = FlatStyle.Flat;
            buttonEVozilo.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEVozilo.ForeColor = SystemColors.ControlDarkDark;
            buttonEVozilo.Location = new Point(647, 105);
            buttonEVozilo.Margin = new Padding(4, 3, 4, 3);
            buttonEVozilo.Name = "buttonEVozilo";
            buttonEVozilo.Size = new Size(202, 58);
            buttonEVozilo.TabIndex = 17;
            buttonEVozilo.Text = "Električno vozilo";
            buttonEVozilo.UseVisualStyleBackColor = true;
            buttonEVozilo.Click += buttonEVozilo_Click;
            // 
            // ProveraTipaPogonaForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(931, 227);
            Controls.Add(buttonEVozilo);
            Controls.Add(buttonKVozilo);
            Controls.Add(buttonHVozilo);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ProveraTipaPogonaForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Odaberite tipa pogona vozila";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonHVozilo;
        private Button buttonKVozilo;
        private Button buttonEVozilo;
    }
}