namespace HealthSystem
{
    partial class FormLoad
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnLogin = new Button();
            cmbRole = new ComboBox();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            lbl_FailLogin = new Label();
            lblClear = new Label();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(6, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(289, 306);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Yellow;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(128, 0);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(73, 28);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // cmbRole
            // 
            cmbRole.BackColor = Color.White;
            cmbRole.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRole.ForeColor = SystemColors.InfoText;
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Admin", "Staff" });
            cmbRole.Location = new Point(86, 65);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(162, 24);
            cmbRole.TabIndex = 0;
            cmbRole.Text = "Role";
            cmbRole.SelectedIndexChanged += cmbRole_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 192);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(cmbRole);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtPassword);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(286, 217);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(66, 9);
            label1.Name = "label1";
            label1.Size = new Size(192, 29);
            label1.TabIndex = 7;
            label1.Text = "Login Account";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 0, 192);
            panel3.Controls.Add(lbl_FailLogin);
            panel3.Controls.Add(btnLogin);
            panel3.Controls.Add(lblClear);
            panel3.Location = new Point(0, 214);
            panel3.Name = "panel3";
            panel3.Size = new Size(286, 92);
            panel3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(34, 127);
            label3.Name = "label3";
            label3.Size = new Size(46, 16);
            label3.TabIndex = 6;
            label3.Text = "Email:";
            // 
            // lbl_FailLogin
            // 
            lbl_FailLogin.AutoSize = true;
            lbl_FailLogin.Location = new Point(86, 28);
            lbl_FailLogin.Name = "lbl_FailLogin";
            lbl_FailLogin.Size = new Size(0, 15);
            lbl_FailLogin.TabIndex = 5;
            lbl_FailLogin.Click += lbl_FailLogin_Click;
            // 
            // lblClear
            // 
            lblClear.AutoSize = true;
            lblClear.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClear.ForeColor = Color.White;
            lblClear.Location = new Point(142, 40);
            lblClear.Name = "lblClear";
            lblClear.Size = new Size(45, 18);
            lblClear.TabIndex = 4;
            lblClear.Text = "Clear";
            lblClear.Click += lblClear_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(86, 168);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "*****************";
            txtPassword.Size = new Size(162, 22);
            txtPassword.TabIndex = 2;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(86, 127);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = " Email";
            txtEmail.Size = new Size(162, 22);
            txtEmail.TabIndex = 1;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(16, 168);
            label2.Name = "label2";
            label2.Size = new Size(70, 16);
            label2.TabIndex = 6;
            label2.Text = "Password:";
            // 
            // FormLoad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(300, 325);
            Controls.Add(panel1);
            Name = "FormLoad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FormLoad_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtEmail;
        private ComboBox cmbRole;
        private Button btnLogin;
        private TextBox txtPassword;
        private Label lblClear;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Label lbl_FailLogin;
        private Label label3;
        private Label label2;
    }
}
