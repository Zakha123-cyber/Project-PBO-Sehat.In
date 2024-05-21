namespace Project_PBO
{
    partial class UsArtikel
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
            pictureBox2 = new PictureBox();
            button2 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.Location = new Point(395, 69);
            label1.Name = "label1";
            label1.Size = new Size(146, 45);
            label1.TabIndex = 31;
            label1.Text = "ARTIKEL";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Vector_5;
            pictureBox2.Location = new Point(-2, 327);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(921, 212);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(816, 16);
            button2.Name = "button2";
            button2.Size = new Size(86, 26);
            button2.TabIndex = 26;
            button2.Text = "PROFIL";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(15, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(887, 2);
            panel1.TabIndex = 25;
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
            pictureBox1.Location = new Point(-37, -72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 201);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(723, 16);
            button1.Name = "button1";
            button1.Size = new Size(86, 26);
            button1.TabIndex = 23;
            button1.Text = "ARTIKEL";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 135);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(890, 215);
            dataGridView1.TabIndex = 32;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // UsArtikel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 510);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Name = "UsArtikel";
            Text = "UsArtikel";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private PictureBox pictureBox2;
        private Button button2;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button button1;
        private DataGridView dataGridView1;
    }
}