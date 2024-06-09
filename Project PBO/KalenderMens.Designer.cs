namespace Project_PBO
{
    partial class KalenderMens
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
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            button3 = new Button();
            panel4 = new Panel();
            lblmens = new Label();
            label2 = new Label();
            label4 = new Label();
            lblovul = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Vector_5;
            pictureBox2.Location = new Point(-2, 437);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1053, 283);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 37;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(17, 65);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1014, 3);
            panel1.TabIndex = 35;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1014, 3);
            panel2.TabIndex = 23;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.SEHAT_IN_LOGO;
            pictureBox1.Location = new Point(-42, -95);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(262, 268);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label3.ForeColor = Color.DeepPink;
            label3.Location = new Point(543, 101);
            label3.Name = "label3";
            label3.Size = new Size(232, 54);
            label3.TabIndex = 42;
            label3.Text = "Menstruasi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.Location = new Point(381, 101);
            label1.Name = "label1";
            label1.Size = new Size(191, 54);
            label1.TabIndex = 40;
            label1.Text = "Kalender";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Control;
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(851, 568);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(130, 36);
            button3.TabIndex = 43;
            button3.Text = "Kembali";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.HighlightText;
            panel4.Controls.Add(lblovul);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(lblmens);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(281, 175);
            panel4.Name = "panel4";
            panel4.Size = new Size(475, 121);
            panel4.TabIndex = 80;
            // 
            // lblmens
            // 
            lblmens.AutoSize = true;
            lblmens.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblmens.ForeColor = Color.Navy;
            lblmens.Location = new Point(249, 23);
            lblmens.Name = "lblmens";
            lblmens.Size = new Size(59, 28);
            lblmens.TabIndex = 79;
            lblmens.Text = "none";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DeepPink;
            label2.Location = new Point(28, 23);
            label2.Name = "label2";
            label2.Size = new Size(227, 28);
            label2.TabIndex = 73;
            label2.Text = "Prediksi Menstruasi   : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DeepPink;
            label4.Location = new Point(28, 65);
            label4.Name = "label4";
            label4.Size = new Size(226, 28);
            label4.TabIndex = 80;
            label4.Text = "Prediksi Hari Ovulasi : ";
            // 
            // lblovul
            // 
            lblovul.AutoSize = true;
            lblovul.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblovul.ForeColor = Color.Navy;
            lblovul.Location = new Point(249, 65);
            lblovul.Name = "lblovul";
            lblovul.Size = new Size(59, 28);
            lblovul.TabIndex = 81;
            lblovul.Text = "none";
            // 
            // KalenderMens
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 680);
            Controls.Add(panel4);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "KalenderMens";
            Text = "KalenderMens";
            Load += KalenderMens_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label1;
        private Button button3;
        private Panel panel4;
        private Label lblmens;
        private Label label2;
        private Label lblovul;
        private Label label4;
    }
}