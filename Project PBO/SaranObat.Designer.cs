namespace Project_PBO
{
    partial class SaranObat
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
            button3 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            button1 = new Button();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Control;
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(77, 438);
            button3.Name = "button3";
            button3.Size = new Size(114, 27);
            button3.TabIndex = 70;
            button3.Text = "Kembali";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(815, 13);
            button2.Name = "button2";
            button2.Size = new Size(86, 26);
            button2.TabIndex = 69;
            button2.Text = "PROFIL";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(14, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(887, 2);
            panel1.TabIndex = 68;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(599, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(59, 100);
            panel2.TabIndex = 42;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.ForeColor = Color.Black;
            panel3.Location = new Point(12, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(57, 472);
            panel3.TabIndex = 42;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(722, 13);
            button1.Name = "button1";
            button1.Size = new Size(86, 26);
            button1.TabIndex = 66;
            button1.Text = "ARTIKEL";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DeepPink;
            button4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(433, 367);
            button4.Name = "button4";
            button4.Size = new Size(114, 27);
            button4.TabIndex = 72;
            button4.Text = "LANJUTKAN";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.SEHAT_IN_LOGO;
            pictureBox1.Location = new Point(-38, -75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 201);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 67;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "BATUK", "DEMAM", "FLU", "DIARE" });
            comboBox1.Location = new Point(396, 163);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(190, 23);
            comboBox1.TabIndex = 73;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(375, 128);
            label1.Name = "label1";
            label1.Size = new Size(232, 32);
            label1.TabIndex = 74;
            label1.Text = "Pilih Jenis Penyakit";
            // 
            // SaranObat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 510);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(pictureBox1);
            Name = "SaranObat";
            Text = "SaranObat";
            Load += SaranObat_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button3;
        private Button button2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button button1;
        private Button button4;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private Label label1;
    }
}