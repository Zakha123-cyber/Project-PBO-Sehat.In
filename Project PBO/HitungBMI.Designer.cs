namespace Project_PBO
{
    partial class HitungBMI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HitungBMI));
            panel2 = new Panel();
            panel3 = new Panel();
            label4 = new Label();
            label3 = new Label();
            panel5 = new Panel();
            panel4 = new Panel();
            button3 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(692, 74);
            label4.Name = "label4";
            label4.Size = new Size(169, 32);
            label4.TabIndex = 60;
            label4.Text = "Apa Itu BMI ?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(48, 74);
            label3.Name = "label3";
            label3.Size = new Size(185, 32);
            label3.TabIndex = 59;
            label3.Text = "BMI Kalkulator";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.ForeColor = Color.Transparent;
            panel5.Location = new Point(283, 44);
            panel5.Name = "panel5";
            panel5.Size = new Size(2, 469);
            panel5.TabIndex = 58;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.ForeColor = Color.Transparent;
            panel4.Location = new Point(639, 44);
            panel4.Name = "panel4";
            panel4.Size = new Size(2, 469);
            panel4.TabIndex = 57;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Control;
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(747, 423);
            button3.Name = "button3";
            button3.Size = new Size(114, 27);
            button3.TabIndex = 50;
            button3.Text = "Kembali";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(813, 12);
            button2.Name = "button2";
            button2.Size = new Size(86, 26);
            button2.TabIndex = 49;
            button2.Text = "PROFIL";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(887, 2);
            panel1.TabIndex = 48;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.SEHAT_IN_LOGO;
            pictureBox1.Location = new Point(-40, -76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 201);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(720, 12);
            button1.Name = "button1";
            button1.Size = new Size(86, 26);
            button1.TabIndex = 46;
            button1.Text = "ARTIKEL";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(663, 120);
            label1.Name = "label1";
            label1.Size = new Size(239, 60);
            label1.TabIndex = 61;
            label1.Text = "Body Mass Index (BMI)\r\nadalah cara menghitung berat badan ideal\r\nberdasarkan tinggi dan berat badan.\r\nBMI juga dapat dibedakan berdasarkan usia.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 120);
            label2.Name = "label2";
            label2.Size = new Size(251, 105);
            label2.TabIndex = 62;
            label2.Text = resources.GetString("label2.Text");
            // 
            // HitungBMI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 510);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Name = "HitungBMI";
            Text = "HitungBMI";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Panel panel3;
        private Label label4;
        private Label label3;
        private Panel panel5;
        private Panel panel4;
        private Button button3;
        private Button button2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label1;
        private Label label2;
    }
}