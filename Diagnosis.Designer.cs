namespace HealthSystem
{
    partial class DiagnosisLoad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiagnosisLoad));
            panel1 = new Panel();
            btnRefresh = new Button();
            txtName = new TextBox();
            txtSearchId = new TextBox();
            btnSearch = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            button1 = new Button();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            dptDate = new DateTimePicker();
            lblDiagnosis = new Label();
            btnHome = new Button();
            DiagnosisGV = new DataGridView();
            txtTreatment = new TextBox();
            txtDiagnosis = new TextBox();
            txtSymptoms = new TextBox();
            cmbVitalSign = new ComboBox();
            txtTime = new TextBox();
            label1 = new Label();
            cmbLabsNeeded = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DiagnosisGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 192);
            panel1.Controls.Add(cmbLabsNeeded);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(txtSearchId);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(dptDate);
            panel1.Controls.Add(lblDiagnosis);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(DiagnosisGV);
            panel1.Controls.Add(txtTreatment);
            panel1.Controls.Add(txtDiagnosis);
            panel1.Controls.Add(txtSymptoms);
            panel1.Controls.Add(cmbVitalSign);
            panel1.Controls.Add(txtTime);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(868, 544);
            panel1.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Yellow;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(219, 354);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(62, 26);
            btnRefresh.TabIndex = 65;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtName
            // 
            txtName.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(226, 168);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name:";
            txtName.Size = new Size(198, 22);
            txtName.TabIndex = 64;
            // 
            // txtSearchId
            // 
            txtSearchId.BackColor = Color.White;
            txtSearchId.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchId.ForeColor = SystemColors.InfoText;
            txtSearchId.Location = new Point(181, 357);
            txtSearchId.Name = "txtSearchId";
            txtSearchId.PlaceholderText = "ID";
            txtSearchId.Size = new Size(32, 21);
            txtSearchId.TabIndex = 62;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Yellow;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Georgia", 9.75F);
            btnSearch.Location = new Point(110, 354);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(65, 24);
            btnSearch.TabIndex = 61;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Yellow;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Georgia", 9.75F);
            btnUpdate.Location = new Point(111, 321);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(65, 24);
            btnUpdate.TabIndex = 60;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Georgia", 9.75F);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(39, 354);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(65, 24);
            btnDelete.TabIndex = 59;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Lime;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Georgia", 9.75F);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(39, 321);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(65, 24);
            btnAdd.TabIndex = 58;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 0, 192);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(263, 28);
            button1.Name = "button1";
            button1.Size = new Size(382, 36);
            button1.TabIndex = 57;
            button1.Text = "UNIVERSITY OF MAKATI\r\n";
            button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(294, 67);
            label5.Name = "label5";
            label5.Size = new Size(288, 32);
            label5.TabIndex = 54;
            label5.Text = "J.P Rizal Extension, West Rembo,Makati Cirty\r\n                     Tel.No 883-1863";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(680, 28);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(106, 88);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 56;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(111, 28);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(110, 96);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 55;
            pictureBox4.TabStop = false;
            // 
            // dptDate
            // 
            dptDate.Location = new Point(226, 205);
            dptDate.Name = "dptDate";
            dptDate.Size = new Size(198, 23);
            dptDate.TabIndex = 52;
            // 
            // lblDiagnosis
            // 
            lblDiagnosis.AutoSize = true;
            lblDiagnosis.Font = new Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiagnosis.ForeColor = Color.White;
            lblDiagnosis.Location = new Point(383, 357);
            lblDiagnosis.Name = "lblDiagnosis";
            lblDiagnosis.Size = new Size(150, 23);
            lblDiagnosis.TabIndex = 50;
            lblDiagnosis.Text = "Diagnosis List";
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Yellow;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.Location = new Point(784, 353);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(65, 24);
            btnHome.TabIndex = 49;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // DiagnosisGV
            // 
            DiagnosisGV.BackgroundColor = Color.White;
            DiagnosisGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DiagnosisGV.Location = new Point(0, 384);
            DiagnosisGV.Name = "DiagnosisGV";
            DiagnosisGV.Size = new Size(872, 148);
            DiagnosisGV.TabIndex = 27;
            DiagnosisGV.CellContentClick += DiagnosisGV_CellContentClick;
            // 
            // txtTreatment
            // 
            txtTreatment.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTreatment.Location = new Point(481, 243);
            txtTreatment.Name = "txtTreatment";
            txtTreatment.PlaceholderText = "Treatment:";
            txtTreatment.Size = new Size(191, 22);
            txtTreatment.TabIndex = 25;
            // 
            // txtDiagnosis
            // 
            txtDiagnosis.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiagnosis.Location = new Point(481, 205);
            txtDiagnosis.Name = "txtDiagnosis";
            txtDiagnosis.PlaceholderText = "Diagnosis:";
            txtDiagnosis.Size = new Size(191, 22);
            txtDiagnosis.TabIndex = 24;
            // 
            // txtSymptoms
            // 
            txtSymptoms.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSymptoms.Location = new Point(481, 168);
            txtSymptoms.Name = "txtSymptoms";
            txtSymptoms.PlaceholderText = "Symptoms:";
            txtSymptoms.Size = new Size(191, 22);
            txtSymptoms.TabIndex = 23;
            // 
            // cmbVitalSign
            // 
            cmbVitalSign.FormattingEnabled = true;
            cmbVitalSign.Items.AddRange(new object[] { "BP (Blood Pressure)", "Body Temperature", "Pulse (Heart Rate)", "Respiratory Rate" });
            cmbVitalSign.Location = new Point(226, 278);
            cmbVitalSign.Name = "cmbVitalSign";
            cmbVitalSign.Size = new Size(198, 23);
            cmbVitalSign.TabIndex = 22;
            cmbVitalSign.Text = "Vital Sign";
            // 
            // txtTime
            // 
            txtTime.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTime.Location = new Point(226, 243);
            txtTime.Name = "txtTime";
            txtTime.PlaceholderText = "Time(hh.mm.ss)";
            txtTime.Size = new Size(198, 22);
            txtTime.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 192);
            label1.Font = new Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(294, 120);
            label1.Name = "label1";
            label1.Size = new Size(284, 23);
            label1.TabIndex = 0;
            label1.Text = "Chief Complains/ Diagnosis";
            // 
            // cmbLabsNeeded
            // 
            cmbLabsNeeded.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbLabsNeeded.FormattingEnabled = true;
            cmbLabsNeeded.Items.AddRange(new object[] { "Yes", "No" });
            cmbLabsNeeded.Location = new Point(481, 278);
            cmbLabsNeeded.Name = "cmbLabsNeeded";
            cmbLabsNeeded.Size = new Size(191, 24);
            cmbLabsNeeded.TabIndex = 66;
            cmbLabsNeeded.Text = "LabsNeeded";
            // 
            // DiagnosisLoad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(896, 568);
            Controls.Add(panel1);
            Name = "DiagnosisLoad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Diagnosis";
            Load += DiagnosisLoad_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)DiagnosisGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtTreatment;
        private TextBox txtDiagnosis;
        private TextBox txtSymptoms;
        private ComboBox cmbVitalSign;
        private TextBox txtTime;
        private DataGridView DiagnosisGV;
        private Button btnHome;
        private Label lblDiagnosis;
        private DateTimePicker dptDate;
        private Button button1;
        private Label label5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private TextBox txtSearchId;
        private Button btnSearch;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private TextBox txtName;
        private Button btnRefresh;
        private ComboBox cmbLabsNeeded;
    }
}