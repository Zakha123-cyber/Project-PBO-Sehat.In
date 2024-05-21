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
            dataGridView1 = new DataGridView();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(146, 156);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(656, 126);
            dataGridView1.TabIndex = 39;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Vector_5;
            pictureBox2.Location = new Point(-2, 328);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(921, 212);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 37;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(15, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(887, 2);
            panel1.TabIndex = 35;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(887, 2);
            panel2.TabIndex = 23;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.SEHAT_IN_LOGO;
            pictureBox1.Location = new Point(-37, -71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 201);
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
            label3.Location = new Point(475, 76);
            label3.Name = "label3";
            label3.Size = new Size(185, 45);
            label3.TabIndex = 42;
            label3.Text = "Menstruasi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.Location = new Point(333, 76);
            label1.Name = "label1";
            label1.Size = new Size(153, 45);
            label1.TabIndex = 40;
            label1.Text = "Kalender";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Control;
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(745, 426);
            button3.Name = "button3";
            button3.Size = new Size(114, 27);
            button3.TabIndex = 43;
            button3.Text = "Kembali";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // KalenderMens
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 510);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "KalenderMens";
            Text = "KalenderMens";
            Load += KalenderMens_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label1;
        private Button button3;
    }
}