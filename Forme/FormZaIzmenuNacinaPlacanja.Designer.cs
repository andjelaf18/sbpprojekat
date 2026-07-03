namespace IznajmljivanjeVozila.Forme
{
    partial class FormZaIzmenuNacinaPlacanja
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
            textBoxId = new TextBox();
            label4 = new Label();
            buttonIzmeniNP = new Button();
            textBoxStatus = new TextBox();
            textBoxTipPlacanja = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // textBoxId
            // 
            textBoxId.BackColor = Color.PaleGoldenrod;
            textBoxId.Location = new Point(71, 67);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(197, 32);
            textBoxId.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(39, 70);
            label4.Name = "label4";
            label4.Size = new Size(36, 23);
            label4.TabIndex = 21;
            label4.Text = "ID:";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // buttonIzmeniNP
            // 
            buttonIzmeniNP.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            buttonIzmeniNP.FlatAppearance.BorderSize = 3;
            buttonIzmeniNP.FlatStyle = FlatStyle.Flat;
            buttonIzmeniNP.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonIzmeniNP.ForeColor = SystemColors.ControlDarkDark;
            buttonIzmeniNP.Location = new Point(433, 116);
            buttonIzmeniNP.Name = "buttonIzmeniNP";
            buttonIzmeniNP.Size = new Size(192, 54);
            buttonIzmeniNP.TabIndex = 20;
            buttonIzmeniNP.Text = "Izmeni";
            buttonIzmeniNP.UseVisualStyleBackColor = true;
            buttonIzmeniNP.Click += buttonIzmeniNP_Click;
            // 
            // textBoxStatus
            // 
            textBoxStatus.BackColor = Color.PaleGoldenrod;
            textBoxStatus.Location = new Point(107, 181);
            textBoxStatus.Name = "textBoxStatus";
            textBoxStatus.Size = new Size(197, 32);
            textBoxStatus.TabIndex = 18;
            // 
            // textBoxTipPlacanja
            // 
            textBoxTipPlacanja.BackColor = Color.PaleGoldenrod;
            textBoxTipPlacanja.Location = new Point(172, 116);
            textBoxTipPlacanja.Name = "textBoxTipPlacanja";
            textBoxTipPlacanja.Size = new Size(197, 32);
            textBoxTipPlacanja.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(29, 241);
            label3.Name = "label3";
            label3.Size = new Size(204, 23);
            label3.TabIndex = 16;
            label3.Text = "Datum ograničenja:";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(29, 184);
            label2.Name = "label2";
            label2.Size = new Size(72, 23);
            label2.TabIndex = 15;
            label2.Text = "Status:";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(29, 119);
            label1.Name = "label1";
            label1.Size = new Size(135, 23);
            label1.TabIndex = 14;
            label1.Text = "Tip plaćanja:";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(29, 7);
            label5.Name = "label5";
            label5.Size = new Size(383, 69);
            label5.TabIndex = 23;
            label5.Text = "Izmenite podatke o izabranom načinu\r\nplaćanja tako što ćete upisati nove vrednosti u kontrole.";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(257, 234);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(184, 32);
            dateTimePicker1.TabIndex = 24;
            // 
            // FormZaIzmenuNacinaPlacanja
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(658, 284);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(textBoxId);
            Controls.Add(label4);
            Controls.Add(buttonIzmeniNP);
            Controls.Add(textBoxStatus);
            Controls.Add(textBoxTipPlacanja);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormZaIzmenuNacinaPlacanja";
            ShowIcon = false;
            Text = "Izmena načina plaćanja";
            Load += FormZaIzmenuNacinaPlacanja_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxId;
        private Label label4;
        private Button buttonIzmeniNP;
        private TextBox textBoxStatus;
        private TextBox textBoxTipPlacanja;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private DateTimePicker dateTimePicker1;
    }
}