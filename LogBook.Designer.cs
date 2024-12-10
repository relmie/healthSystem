namespace HealthSystem
{
    partial class LoadLogBookData
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
            panel1 = new Panel();
            txtCourse = new TextBox();
            grpServicesRendered = new GroupBox();
            chkRx = new CheckBox();
            chkAPE = new CheckBox();
            chkIssuanceOfMedCert = new CheckBox();
            chkSigningClearance = new CheckBox();
            chkBP = new CheckBox();
            chkHeightandWeight = new CheckBox();
            chkReferral = new CheckBox();
            chkMedicineIssuance = new CheckBox();
            chkOthers = new CheckBox();
            btnRefresh = new Button();
            dptDate = new DateTimePicker();
            btnHome = new Button();
            txtID = new TextBox();
            btnSearch = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            label1 = new Label();
            LogBookGV = new DataGridView();
            txtAttendedBy = new TextBox();
            txtSignature = new TextBox();
            txtTimeOut = new TextBox();
            txtConsultation = new TextBox();
            lblLogBook = new Label();
            cmbClientCategory = new ComboBox();
            cmbGender = new ComboBox();
            txtDepartment = new TextBox();
            txtCompleteName = new TextBox();
            txtTimeIn = new TextBox();
            panel1.SuspendLayout();
            grpServicesRendered.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogBookGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 192);
            panel1.Controls.Add(txtCourse);
            panel1.Controls.Add(grpServicesRendered);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(dptDate);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(LogBookGV);
            panel1.Controls.Add(txtAttendedBy);
            panel1.Controls.Add(txtSignature);
            panel1.Controls.Add(txtTimeOut);
            panel1.Controls.Add(txtConsultation);
            panel1.Controls.Add(lblLogBook);
            panel1.Controls.Add(cmbClientCategory);
            panel1.Controls.Add(cmbGender);
            panel1.Controls.Add(txtDepartment);
            panel1.Controls.Add(txtCompleteName);
            panel1.Controls.Add(txtTimeIn);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(883, 703);
            panel1.TabIndex = 0;
            // 
            // txtCourse
            // 
            txtCourse.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCourse.Location = new Point(80, 311);
            txtCourse.Name = "txtCourse";
            txtCourse.PlaceholderText = "Course:";
            txtCourse.Size = new Size(189, 22);
            txtCourse.TabIndex = 33;
            // 
            // grpServicesRendered
            // 
            grpServicesRendered.Controls.Add(chkRx);
            grpServicesRendered.Controls.Add(chkAPE);
            grpServicesRendered.Controls.Add(chkIssuanceOfMedCert);
            grpServicesRendered.Controls.Add(chkSigningClearance);
            grpServicesRendered.Controls.Add(chkBP);
            grpServicesRendered.Controls.Add(chkHeightandWeight);
            grpServicesRendered.Controls.Add(chkReferral);
            grpServicesRendered.Controls.Add(chkMedicineIssuance);
            grpServicesRendered.Controls.Add(chkOthers);
            grpServicesRendered.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpServicesRendered.ForeColor = Color.White;
            grpServicesRendered.Location = new Point(339, 153);
            grpServicesRendered.Name = "grpServicesRendered";
            grpServicesRendered.Size = new Size(444, 134);
            grpServicesRendered.TabIndex = 32;
            grpServicesRendered.TabStop = false;
            grpServicesRendered.Text = "SERVICES RENDERED";
            // 
            // chkRx
            // 
            chkRx.AutoSize = true;
            chkRx.Font = new Font("Georgia", 9.75F);
            chkRx.ForeColor = Color.White;
            chkRx.Location = new Point(86, 66);
            chkRx.Name = "chkRx";
            chkRx.Size = new Size(43, 20);
            chkRx.TabIndex = 13;
            chkRx.Text = "Rx";
            chkRx.UseVisualStyleBackColor = true;
            // 
            // chkAPE
            // 
            chkAPE.AutoSize = true;
            chkAPE.Font = new Font("Georgia", 9.75F);
            chkAPE.ForeColor = Color.White;
            chkAPE.Location = new Point(14, 31);
            chkAPE.Name = "chkAPE";
            chkAPE.Size = new Size(52, 20);
            chkAPE.TabIndex = 8;
            chkAPE.Text = "APE";
            chkAPE.UseVisualStyleBackColor = true;
            // 
            // chkIssuanceOfMedCert
            // 
            chkIssuanceOfMedCert.AutoSize = true;
            chkIssuanceOfMedCert.Font = new Font("Georgia", 9.75F);
            chkIssuanceOfMedCert.ForeColor = Color.White;
            chkIssuanceOfMedCert.Location = new Point(72, 31);
            chkIssuanceOfMedCert.Name = "chkIssuanceOfMedCert";
            chkIssuanceOfMedCert.Size = new Size(156, 20);
            chkIssuanceOfMedCert.TabIndex = 9;
            chkIssuanceOfMedCert.Text = "Issuance Of Med Cert";
            chkIssuanceOfMedCert.UseVisualStyleBackColor = true;
            // 
            // chkSigningClearance
            // 
            chkSigningClearance.AutoSize = true;
            chkSigningClearance.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkSigningClearance.ForeColor = Color.White;
            chkSigningClearance.Location = new Point(289, 66);
            chkSigningClearance.Name = "chkSigningClearance";
            chkSigningClearance.Size = new Size(150, 20);
            chkSigningClearance.TabIndex = 29;
            chkSigningClearance.Text = "Signing of Clearance";
            chkSigningClearance.UseVisualStyleBackColor = true;
            // 
            // chkBP
            // 
            chkBP.AutoSize = true;
            chkBP.Font = new Font("Georgia", 9.75F);
            chkBP.ForeColor = Color.White;
            chkBP.Location = new Point(241, 29);
            chkBP.Name = "chkBP";
            chkBP.Size = new Size(42, 20);
            chkBP.TabIndex = 10;
            chkBP.Text = "BP";
            chkBP.UseVisualStyleBackColor = true;
            // 
            // chkHeightandWeight
            // 
            chkHeightandWeight.AutoSize = true;
            chkHeightandWeight.Font = new Font("Georgia", 9.75F);
            chkHeightandWeight.ForeColor = Color.White;
            chkHeightandWeight.Location = new Point(289, 29);
            chkHeightandWeight.Name = "chkHeightandWeight";
            chkHeightandWeight.Size = new Size(139, 20);
            chkHeightandWeight.TabIndex = 11;
            chkHeightandWeight.Text = "Height and Weight";
            chkHeightandWeight.UseVisualStyleBackColor = true;
            // 
            // chkReferral
            // 
            chkReferral.AutoSize = true;
            chkReferral.Font = new Font("Georgia", 9.75F);
            chkReferral.ForeColor = Color.White;
            chkReferral.Location = new Point(14, 66);
            chkReferral.Name = "chkReferral";
            chkReferral.Size = new Size(76, 20);
            chkReferral.TabIndex = 12;
            chkReferral.Text = "Referral";
            chkReferral.UseVisualStyleBackColor = true;
            // 
            // chkMedicineIssuance
            // 
            chkMedicineIssuance.AutoSize = true;
            chkMedicineIssuance.Font = new Font("Georgia", 9.75F);
            chkMedicineIssuance.ForeColor = Color.White;
            chkMedicineIssuance.Location = new Point(125, 66);
            chkMedicineIssuance.Name = "chkMedicineIssuance";
            chkMedicineIssuance.Size = new Size(149, 20);
            chkMedicineIssuance.TabIndex = 14;
            chkMedicineIssuance.Text = "Medicine Insurance";
            chkMedicineIssuance.UseVisualStyleBackColor = true;
            // 
            // chkOthers
            // 
            chkOthers.AutoSize = true;
            chkOthers.Font = new Font("Georgia", 9.75F);
            chkOthers.ForeColor = Color.White;
            chkOthers.Location = new Point(14, 92);
            chkOthers.Name = "chkOthers";
            chkOthers.Size = new Size(67, 20);
            chkOthers.TabIndex = 16;
            chkOthers.Text = "Others";
            chkOthers.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Yellow;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(257, 427);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(62, 23);
            btnRefresh.TabIndex = 31;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dptDate
            // 
            dptDate.Location = new Point(80, 116);
            dptDate.Name = "dptDate";
            dptDate.Size = new Size(189, 23);
            dptDate.TabIndex = 30;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Yellow;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.Location = new Point(806, 429);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(65, 24);
            btnHome.TabIndex = 28;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // txtID
            // 
            txtID.BackColor = Color.White;
            txtID.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtID.ForeColor = SystemColors.InfoText;
            txtID.Location = new Point(223, 430);
            txtID.Name = "txtID";
            txtID.PlaceholderText = "ID";
            txtID.Size = new Size(28, 21);
            txtID.TabIndex = 27;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Yellow;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Georgia", 9.75F);
            btnSearch.Location = new Point(152, 427);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(65, 24);
            btnSearch.TabIndex = 25;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Yellow;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Georgia", 9.75F);
            btnUpdate.Location = new Point(152, 394);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(65, 24);
            btnUpdate.TabIndex = 24;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Georgia", 9.75F);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(80, 427);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(65, 24);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Lime;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Georgia", 9.75F);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(80, 394);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(65, 24);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(427, 433);
            label1.Name = "label1";
            label1.Size = new Size(144, 23);
            label1.TabIndex = 21;
            label1.Text = "Log Book List";
            // 
            // LogBookGV
            // 
            LogBookGV.BackgroundColor = Color.White;
            LogBookGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LogBookGV.GridColor = Color.White;
            LogBookGV.Location = new Point(0, 461);
            LogBookGV.Name = "LogBookGV";
            LogBookGV.Size = new Size(936, 229);
            LogBookGV.TabIndex = 20;
            LogBookGV.CellContentClick += LogBookGV_CellContentClick;
            // 
            // txtAttendedBy
            // 
            txtAttendedBy.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAttendedBy.Location = new Point(337, 382);
            txtAttendedBy.Name = "txtAttendedBy";
            txtAttendedBy.PlaceholderText = "Attended by:";
            txtAttendedBy.Size = new Size(446, 22);
            txtAttendedBy.TabIndex = 19;
            // 
            // txtSignature
            // 
            txtSignature.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSignature.Location = new Point(337, 338);
            txtSignature.Name = "txtSignature";
            txtSignature.PlaceholderText = "Signature";
            txtSignature.Size = new Size(446, 25);
            txtSignature.TabIndex = 18;
            // 
            // txtTimeOut
            // 
            txtTimeOut.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimeOut.Location = new Point(339, 300);
            txtTimeOut.Name = "txtTimeOut";
            txtTimeOut.PlaceholderText = "Time Out:";
            txtTimeOut.Size = new Size(444, 22);
            txtTimeOut.TabIndex = 17;
            // 
            // txtConsultation
            // 
            txtConsultation.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConsultation.Location = new Point(339, 116);
            txtConsultation.Name = "txtConsultation";
            txtConsultation.PlaceholderText = "Consultation:";
            txtConsultation.Size = new Size(446, 22);
            txtConsultation.TabIndex = 7;
            // 
            // lblLogBook
            // 
            lblLogBook.AutoSize = true;
            lblLogBook.Font = new Font("Georgia", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogBook.ForeColor = Color.White;
            lblLogBook.Location = new Point(244, 27);
            lblLogBook.Name = "lblLogBook";
            lblLogBook.Size = new Size(454, 31);
            lblLogBook.TabIndex = 6;
            lblLogBook.Text = "Log Book Records Management";
            // 
            // cmbClientCategory
            // 
            cmbClientCategory.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbClientCategory.FormattingEnabled = true;
            cmbClientCategory.Items.AddRange(new object[] { "Employee", "Student", "Extension" });
            cmbClientCategory.Location = new Point(80, 230);
            cmbClientCategory.Name = "cmbClientCategory";
            cmbClientCategory.Size = new Size(189, 24);
            cmbClientCategory.TabIndex = 5;
            cmbClientCategory.Text = "Client's Category";
            // 
            // cmbGender
            // 
            cmbGender.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(80, 349);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(189, 24);
            cmbGender.TabIndex = 4;
            cmbGender.Text = "Gender";
            // 
            // txtDepartment
            // 
            txtDepartment.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDepartment.Location = new Point(80, 271);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.PlaceholderText = "Department:";
            txtDepartment.Size = new Size(189, 22);
            txtDepartment.TabIndex = 3;
            // 
            // txtCompleteName
            // 
            txtCompleteName.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCompleteName.Location = new Point(80, 193);
            txtCompleteName.Name = "txtCompleteName";
            txtCompleteName.PlaceholderText = " Complete Name:";
            txtCompleteName.Size = new Size(189, 22);
            txtCompleteName.TabIndex = 2;
            // 
            // txtTimeIn
            // 
            txtTimeIn.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimeIn.Location = new Point(80, 153);
            txtTimeIn.Name = "txtTimeIn";
            txtTimeIn.PlaceholderText = "Time In:";
            txtTimeIn.Size = new Size(189, 22);
            txtTimeIn.TabIndex = 1;
            // 
            // LoadLogBookData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(907, 727);
            Controls.Add(panel1);
            Name = "LoadLogBookData";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogBook";
            Load += LogBook_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            grpServicesRendered.ResumeLayout(false);
            grpServicesRendered.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LogBookGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox cmbClientCategory;
        private ComboBox cmbGender;
        private TextBox txtDepartment;
        private TextBox txtCompleteName;
        private TextBox txtTimeIn;
        private Label lblLogBook;
        private CheckBox chkMedicineIssuance;
        private CheckBox chkRx;
        private CheckBox chkReferral;
        private CheckBox chkHeightandWeight;
        private CheckBox chkBP;
        private CheckBox chkIssuanceOfMedCert;
        private CheckBox chkAPE;
        private TextBox txtConsultation;
        private CheckBox chkOthers;
        private TextBox txtAttendedBy;
        private TextBox txtSignature;
        private TextBox txtTimeOut;
        private Label label1;
        private DataGridView LogBookGV;
        private Button btnSearch;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private TextBox txtID;
        private Button btnHome;
        private CheckBox chkSigningClearance;
        private DateTimePicker dptDate;
        private Button btnRefresh;
        private GroupBox grpServicesRendered;
        private TextBox txtCourse;
    }
}