namespace HealthSystem
{
    partial class Splash
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            Myprogressbar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 192);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Myprogressbar);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(664, 280);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(556, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(91, 85);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(18, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(275, 249);
            label2.Name = "label2";
            label2.Size = new Size(143, 18);
            label2.TabIndex = 2;
            label2.Text = "AlagangKulitGroup";
            // 
            // Myprogressbar
            // 
            Myprogressbar.FillColor = Color.White;
            Myprogressbar.FillThickness = 25;
            Myprogressbar.Font = new Font("Segoe UI", 12F);
            Myprogressbar.ForeColor = Color.White;
            Myprogressbar.Location = new Point(253, 68);
            Myprogressbar.Minimum = 0;
            Myprogressbar.Name = "Myprogressbar";
            Myprogressbar.ProgressColor = Color.Yellow;
            Myprogressbar.ProgressColor2 = Color.Yellow;
            Myprogressbar.ShadowDecoration.CustomizableEdges = customizableEdges1;
            Myprogressbar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            Myprogressbar.Size = new Size(178, 178);
            Myprogressbar.TabIndex = 1;
            Myprogressbar.Text = "Myprogressbar";
            Myprogressbar.ValueChanged += Myprogressbar_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 192);
            label1.Font = new Font("Georgia", 14F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(123, 14);
            label1.Name = "label1";
            label1.Size = new Size(433, 46);
            label1.TabIndex = 0;
            label1.Text = "Design and Development of HealthHive: A Record\r\nManagement System for the University of Makati.";
            // 
            // timer1
            // 
            timer1.Interval = 30;
            timer1.Tick += timer1_Tick;
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(686, 304);
            Controls.Add(panel1);
            Name = "Splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Splash";
            Load += Splash_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar Myprogressbar;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}