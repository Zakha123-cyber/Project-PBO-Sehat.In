using System.Drawing;

namespace Project_PBO
{
    partial class BMIKurus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BMIKurus));
            label6 = new Label();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            panel4 = new Panel();
            button3 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label3 = new Label();
            button2 = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel6 = new Panel();
            panel5 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(38, 166);
            label6.Name = "label6";
            label6.Size = new Size(262, 30);
            label6.TabIndex = 81;
            label6.Text = "Pastikan asupan kalori sesuai dengan kebutuhan\r\n     kalori harian dan konsumsi makanan sehat\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(76, 14);
            label5.Name = "label5";
            label5.Size = new Size(175, 28);
            label5.TabIndex = 80;
            label5.Text = "KALKULATOR BMI";
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(114, 67);
            pictureBox3.TabIndex = 82;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 161);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 77;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(758, 161);
            label1.Name = "label1";
            label1.Size = new Size(303, 80);
            label1.TabIndex = 76;
            label1.Text = "Body Mass Index (BMI)\r\nadalah cara menghitung berat badan ideal\r\nberdasarkan tinggi dan berat badan.\r\nBMI juga dapat dibedakan berdasarkan usia.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(791, 100);
            label4.Name = "label4";
            label4.Size = new Size(209, 41);
            label4.TabIndex = 75;
            label4.Text = "Apa Itu BMI ?";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.ForeColor = Color.Transparent;
            panel4.Location = new Point(730, 60);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(2, 625);
            panel4.TabIndex = 72;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Control;
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(854, 565);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(130, 36);
            button3.TabIndex = 71;
            button3.Text = "Kembali";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(14, 60);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1014, 3);
            panel1.TabIndex = 69;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(685, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(67, 133);
            panel2.TabIndex = 42;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.ForeColor = Color.Black;
            panel3.Location = new Point(14, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(65, 629);
            panel3.TabIndex = 42;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.SEHAT_IN_LOGO;
            pictureBox1.Location = new Point(-46, -100);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(262, 268);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 68;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(823, 17);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(98, 35);
            button1.TabIndex = 67;
            button1.Text = "ARTIKEL";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(55, 100);
            label3.Name = "label3";
            label3.Size = new Size(230, 41);
            label3.TabIndex = 74;
            label3.Text = "BMI Kalkulator";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(929, 17);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(98, 35);
            button2.TabIndex = 70;
            button2.Text = "PROFIL";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 161);
            label7.Name = "label7";
            label7.Size = new Size(296, 160);
            label7.TabIndex = 83;
            label7.Text = resources.GetString("label7.Text");
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(85, 121);
            label8.Name = "label8";
            label8.Size = new Size(63, 25);
            label8.TabIndex = 84;
            label8.Text = "label8";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Impact", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Goldenrod;
            label9.Location = new Point(90, 58);
            label9.Name = "label9";
            label9.Size = new Size(142, 54);
            label9.TabIndex = 85;
            label9.Text = "KURUS\r\n";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ButtonHighlight;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(label5);
            panel6.Controls.Add(label8);
            panel6.Controls.Add(label9);
            panel6.Controls.Add(label6);
            panel6.Location = new Point(368, 187);
            panel6.Name = "panel6";
            panel6.Size = new Size(325, 217);
            panel6.TabIndex = 86;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.ForeColor = Color.Transparent;
            panel5.Location = new Point(323, 60);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(2, 625);
            panel5.TabIndex = 73;
            // 
            // BMIKurus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 680);
            Controls.Add(panel6);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BMIKurus";
            Text = "BMIKurus";
            Load += BMIKurus_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private PictureBox pictureBox3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Panel panel4;
        private Button button3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label3;
        private Button button2;
        private Label label7;
        private Label label8;
        private Label label9;
        private Panel panel6;
        private Panel panel5;
    }
}