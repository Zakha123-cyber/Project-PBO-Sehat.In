namespace Project_PBO
{
    partial class BMI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BMI));
            button3 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            button4 = new Button();
            label2 = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Control;
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(744, 425);
            button3.Name = "button3";
            button3.Size = new Size(114, 27);
            button3.TabIndex = 35;
            button3.Text = "Kembali";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(810, 14);
            button2.Name = "button2";
            button2.Size = new Size(86, 26);
            button2.TabIndex = 28;
            button2.Text = "PROFIL";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(9, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(887, 2);
            panel1.TabIndex = 27;
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
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.SEHAT_IN_LOGO;
            pictureBox1.Location = new Point(-43, -74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 201);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(717, 14);
            button1.Name = "button1";
            button1.Size = new Size(86, 26);
            button1.TabIndex = 25;
            button1.Text = "ARTIKEL";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._5_1;
            pictureBox2.Location = new Point(350, 34);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(217, 174);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 36;
            pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(338, 246);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(243, 23);
            textBox1.TabIndex = 37;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(338, 306);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(243, 23);
            textBox2.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(338, 226);
            label1.Name = "label1";
            label1.Size = new Size(81, 17);
            label1.TabIndex = 39;
            label1.Text = "Tinggi (cm)*";
            label1.Click += label1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DeepPink;
            button4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(405, 425);
            button4.Name = "button4";
            button4.Size = new Size(114, 27);
            button4.TabIndex = 40;
            button4.Text = "HITUNG BMI";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(338, 286);
            label2.Name = "label2";
            label2.Size = new Size(73, 17);
            label2.TabIndex = 41;
            label2.Text = "Berat (kg)*";
            label2.Click += label2_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.ForeColor = Color.Transparent;
            panel4.Location = new Point(636, 46);
            panel4.Name = "panel4";
            panel4.Size = new Size(2, 469);
            panel4.TabIndex = 42;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.ForeColor = Color.Transparent;
            panel5.Location = new Point(280, 46);
            panel5.Name = "panel5";
            panel5.Size = new Size(2, 469);
            panel5.TabIndex = 43;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(45, 76);
            label3.Name = "label3";
            label3.Size = new Size(185, 32);
            label3.TabIndex = 44;
            label3.Text = "BMI Kalkulator";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(689, 76);
            label4.Name = "label4";
            label4.Size = new Size(169, 32);
            label4.TabIndex = 45;
            label4.Text = "Apa Itu BMI ?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 119);
            label5.Name = "label5";
            label5.Size = new Size(251, 105);
            label5.TabIndex = 63;
            label5.Text = resources.GetString("label5.Text");
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(657, 119);
            label6.Name = "label6";
            label6.Size = new Size(239, 60);
            label6.TabIndex = 64;
            label6.Text = "Body Mass Index (BMI)\r\nadalah cara menghitung berat badan ideal\r\nberdasarkan tinggi dan berat badan.\r\nBMI juga dapat dibedakan berdasarkan usia.";
            // 
            // BMI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 510);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Name = "BMI";
            Text = "BMI";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button1;
        private PictureBox pictureBox2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Button button4;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}