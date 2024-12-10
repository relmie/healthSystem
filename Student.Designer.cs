namespace HealthSystem
{
    partial class Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            panel1 = new Panel();
            btnRefresh = new Button();
            lblBirthday = new Label();
            dtpBirthday = new DateTimePicker();
            SearchStudentId = new TextBox();
            btnSearch = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            dtpDate = new DateTimePicker();
            button1 = new Button();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            txtVillage = new TextBox();
            txtCourse = new TextBox();
            label4 = new Label();
            txtCollege = new TextBox();
            btnHome = new Button();
            StudentGV = new DataGridView();
            txtParentGuardianName = new TextBox();
            txtStudentContact = new TextBox();
            txtParentGuardianAddress = new TextBox();
            txtParentGuardianContact = new TextBox();
            txtProvince = new TextBox();
            txtMunicipality = new TextBox();
            txtBarangay = new TextBox();
            txtStreetName = new TextBox();
            txtHomeAddress = new TextBox();
            cmbExtension = new ComboBox();
            txtAge = new TextBox();
            txtFirstName = new TextBox();
            cmbCivilStatus = new ComboBox();
            cmbSex = new ComboBox();
            cmbYearLevel = new ComboBox();
            txtLastName = new TextBox();
            txtMiddleName = new TextBox();
            txtStudentNum = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StudentGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 192);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(lblBirthday);
            panel1.Controls.Add(dtpBirthday);
            panel1.Controls.Add(SearchStudentId);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(dtpDate);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(txtVillage);
            panel1.Controls.Add(txtCourse);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtCollege);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(StudentGV);
            panel1.Controls.Add(txtParentGuardianName);
            panel1.Controls.Add(txtStudentContact);
            panel1.Controls.Add(txtParentGuardianAddress);
            panel1.Controls.Add(txtParentGuardianContact);
            panel1.Controls.Add(txtProvince);
            panel1.Controls.Add(txtMunicipality);
            panel1.Controls.Add(txtBarangay);
            panel1.Controls.Add(txtStreetName);
            panel1.Controls.Add(txtHomeAddress);
            panel1.Controls.Add(cmbExtension);
            panel1.Controls.Add(txtAge);
            panel1.Controls.Add(txtFirstName);
            panel1.Controls.Add(cmbCivilStatus);
            panel1.Controls.Add(cmbSex);
            panel1.Controls.Add(cmbYearLevel);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(txtMiddleName);
            panel1.Controls.Add(txtStudentNum);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1209, 632);
            panel1.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Yellow;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(269, 435);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(62, 26);
            btnRefresh.TabIndex = 72;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBirthday.ForeColor = Color.White;
            lblBirthday.Location = new Point(286, 362);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(66, 18);
            lblBirthday.TabIndex = 71;
            lblBirthday.Text = "Birthday";
            // 
            // dtpBirthday
            // 
            dtpBirthday.CalendarFont = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpBirthday.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpBirthday.Location = new Point(358, 362);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(219, 22);
            dtpBirthday.TabIndex = 70;
            // 
            // SearchStudentId
            // 
            SearchStudentId.BackColor = Color.White;
            SearchStudentId.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchStudentId.ForeColor = SystemColors.InfoText;
            SearchStudentId.Location = new Point(235, 437);
            SearchStudentId.Name = "SearchStudentId";
            SearchStudentId.PlaceholderText = "ID";
            SearchStudentId.Size = new Size(28, 21);
            SearchStudentId.TabIndex = 67;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Yellow;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Georgia", 9.75F);
            btnSearch.Location = new Point(162, 434);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(65, 24);
            btnSearch.TabIndex = 66;
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
            btnUpdate.Location = new Point(162, 402);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(65, 24);
            btnUpdate.TabIndex = 65;
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
            btnDelete.Location = new Point(90, 435);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(65, 24);
            btnDelete.TabIndex = 64;
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
            btnAdd.Location = new Point(90, 402);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(65, 24);
            btnAdd.TabIndex = 63;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(90, 321);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(189, 23);
            dtpDate.TabIndex = 62;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 0, 192);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(448, 8);
            button1.Name = "button1";
            button1.Size = new Size(382, 33);
            button1.TabIndex = 61;
            button1.Text = "UNIVERSITY OF MAKATI\r\n";
            button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(479, 47);
            label5.Name = "label5";
            label5.Size = new Size(288, 32);
            label5.TabIndex = 58;
            label5.Text = "J.P Rizal Extension, West Rembo,Makati Cirty\r\n                     Tel.No 883-1863";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(924, 8);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(122, 107);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 60;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(180, 8);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(130, 113);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 59;
            pictureBox4.TabStop = false;
            // 
            // txtVillage
            // 
            txtVillage.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVillage.Location = new Point(627, 321);
            txtVillage.Name = "txtVillage";
            txtVillage.PlaceholderText = "Village:";
            txtVillage.Size = new Size(229, 22);
            txtVillage.TabIndex = 41;
            // 
            // txtCourse
            // 
            txtCourse.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCourse.Location = new Point(90, 278);
            txtCourse.Name = "txtCourse";
            txtCourse.PlaceholderText = "Course:";
            txtCourse.Size = new Size(189, 22);
            txtCourse.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 14F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(563, 439);
            label4.Name = "label4";
            label4.Size = new Size(131, 23);
            label4.TabIndex = 39;
            label4.Text = "Student List";
            // 
            // txtCollege
            // 
            txtCollege.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCollege.Location = new Point(90, 238);
            txtCollege.Name = "txtCollege";
            txtCollege.PlaceholderText = "College:";
            txtCollege.Size = new Size(187, 22);
            txtCollege.TabIndex = 38;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Yellow;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.Location = new Point(1116, 437);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(65, 24);
            btnHome.TabIndex = 37;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // StudentGV
            // 
            StudentGV.BackgroundColor = Color.White;
            StudentGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentGV.Location = new Point(0, 465);
            StudentGV.Name = "StudentGV";
            StudentGV.Size = new Size(1210, 155);
            StudentGV.TabIndex = 30;
            StudentGV.CellContentClick += StudentGV_CellContentClick;
            // 
            // txtParentGuardianName
            // 
            txtParentGuardianName.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtParentGuardianName.Location = new Point(893, 197);
            txtParentGuardianName.Name = "txtParentGuardianName";
            txtParentGuardianName.PlaceholderText = "Name of Parents or Guardian:";
            txtParentGuardianName.Size = new Size(229, 22);
            txtParentGuardianName.TabIndex = 29;
            // 
            // txtStudentContact
            // 
            txtStudentContact.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStudentContact.Location = new Point(893, 325);
            txtStudentContact.Name = "txtStudentContact";
            txtStudentContact.PlaceholderText = "Contact Number of Student:";
            txtStudentContact.Size = new Size(229, 22);
            txtStudentContact.TabIndex = 28;
            // 
            // txtParentGuardianAddress
            // 
            txtParentGuardianAddress.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtParentGuardianAddress.Location = new Point(893, 238);
            txtParentGuardianAddress.Name = "txtParentGuardianAddress";
            txtParentGuardianAddress.PlaceholderText = "Address of Parent or Guardian:";
            txtParentGuardianAddress.Size = new Size(229, 22);
            txtParentGuardianAddress.TabIndex = 27;
            // 
            // txtParentGuardianContact
            // 
            txtParentGuardianContact.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtParentGuardianContact.Location = new Point(893, 280);
            txtParentGuardianContact.Name = "txtParentGuardianContact";
            txtParentGuardianContact.PlaceholderText = "Contact Number of Parent or Guardian:";
            txtParentGuardianContact.Size = new Size(229, 22);
            txtParentGuardianContact.TabIndex = 26;
            // 
            // txtProvince
            // 
            txtProvince.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProvince.Location = new Point(893, 158);
            txtProvince.Name = "txtProvince";
            txtProvince.PlaceholderText = "Province:";
            txtProvince.Size = new Size(229, 22);
            txtProvince.TabIndex = 25;
            // 
            // txtMunicipality
            // 
            txtMunicipality.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMunicipality.Location = new Point(627, 364);
            txtMunicipality.Name = "txtMunicipality";
            txtMunicipality.PlaceholderText = "Municipality City:";
            txtMunicipality.Size = new Size(229, 22);
            txtMunicipality.TabIndex = 24;
            // 
            // txtBarangay
            // 
            txtBarangay.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBarangay.Location = new Point(627, 278);
            txtBarangay.Name = "txtBarangay";
            txtBarangay.PlaceholderText = "Barangay:";
            txtBarangay.Size = new Size(229, 22);
            txtBarangay.TabIndex = 23;
            // 
            // txtStreetName
            // 
            txtStreetName.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStreetName.Location = new Point(627, 238);
            txtStreetName.Name = "txtStreetName";
            txtStreetName.PlaceholderText = "Street Name:";
            txtStreetName.Size = new Size(229, 22);
            txtStreetName.TabIndex = 22;
            // 
            // txtHomeAddress
            // 
            txtHomeAddress.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHomeAddress.Location = new Point(627, 197);
            txtHomeAddress.Name = "txtHomeAddress";
            txtHomeAddress.PlaceholderText = "Home Address(Lot # Blk # Unit #)";
            txtHomeAddress.Size = new Size(229, 22);
            txtHomeAddress.TabIndex = 21;
            // 
            // cmbExtension
            // 
            cmbExtension.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbExtension.FormattingEnabled = true;
            cmbExtension.Items.AddRange(new object[] { "Jr", "Sr", "None" });
            cmbExtension.Location = new Point(358, 238);
            cmbExtension.Name = "cmbExtension";
            cmbExtension.Size = new Size(219, 24);
            cmbExtension.TabIndex = 20;
            cmbExtension.Text = "Extension";
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAge.Location = new Point(627, 158);
            txtAge.Name = "txtAge";
            txtAge.PlaceholderText = "Age:";
            txtAge.Size = new Size(229, 22);
            txtAge.TabIndex = 19;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(90, 364);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "FirstName:";
            txtFirstName.Size = new Size(190, 22);
            txtFirstName.TabIndex = 16;
            // 
            // cmbCivilStatus
            // 
            cmbCivilStatus.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCivilStatus.FormattingEnabled = true;
            cmbCivilStatus.Items.AddRange(new object[] { "Single", "Married", "Widow", "Others" });
            cmbCivilStatus.Location = new Point(358, 323);
            cmbCivilStatus.Name = "cmbCivilStatus";
            cmbCivilStatus.Size = new Size(219, 24);
            cmbCivilStatus.TabIndex = 15;
            cmbCivilStatus.Text = "Civil Status";
            // 
            // cmbSex
            // 
            cmbSex.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSex.FormattingEnabled = true;
            cmbSex.Items.AddRange(new object[] { "Male", "Female" });
            cmbSex.Location = new Point(358, 278);
            cmbSex.Name = "cmbSex";
            cmbSex.Size = new Size(219, 24);
            cmbSex.TabIndex = 14;
            cmbSex.Text = "Sex";
            // 
            // cmbYearLevel
            // 
            cmbYearLevel.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbYearLevel.FormattingEnabled = true;
            cmbYearLevel.Items.AddRange(new object[] { "Grade 11", "Grade 12", "1st Year", "2nd Year", "3rd Year", "4th Year" });
            cmbYearLevel.Location = new Point(91, 195);
            cmbYearLevel.Name = "cmbYearLevel";
            cmbYearLevel.Size = new Size(188, 24);
            cmbYearLevel.TabIndex = 12;
            cmbYearLevel.Text = "Year Level";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(358, 158);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "LastName:";
            txtLastName.Size = new Size(219, 22);
            txtLastName.TabIndex = 11;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMiddleName.Location = new Point(358, 197);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.PlaceholderText = "MiddleName:";
            txtMiddleName.Size = new Size(219, 22);
            txtMiddleName.TabIndex = 10;
            // 
            // txtStudentNum
            // 
            txtStudentNum.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStudentNum.Location = new Point(93, 158);
            txtStudentNum.Name = "txtStudentNum";
            txtStudentNum.PlaceholderText = "Student Num";
            txtStudentNum.Size = new Size(187, 22);
            txtStudentNum.TabIndex = 8;
            txtStudentNum.TextChanged += txtStudentNo_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(438, 108);
            label1.Name = "label1";
            label1.Size = new Size(441, 31);
            label1.TabIndex = 0;
            label1.Text = "Student Records Management ";
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(1234, 653);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Student";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student";
            Load += Student_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)StudentGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ComboBox cmbCivilStatus;
        private ComboBox cmbSex;
        private ComboBox cmbYearLevel;
        private TextBox txtLastName;
        private TextBox txtMiddleName;
        private TextBox txtStudentNum;
        private TextBox txtFirstName;
        private ComboBox cmbExtension;
        private TextBox txtAge;
        private TextBox txtMunicipality;
        private TextBox txtBarangay;
        private TextBox txtStreetName;
        private TextBox txtHomeAddress;
        private TextBox txtParentGuardianName;
        private TextBox txtStudentContact;
        private TextBox txtParentGuardianAddress;
        private TextBox txtParentGuardianContact;
        private TextBox txtProvince;
        private DataGridView StudentGV;
        private TextBox txtCollege;
        private Button btnHome;
        private Label label4;
        private TextBox txtVillage;
        private TextBox txtCourse;
        private DateTimePicker dtpDate;
        private Button button1;
        private Label label5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private TextBox SearchStudentId;
        private Button btnSearch;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private Label lblBirthday;
        private DateTimePicker dtpBirthday;
        private Button btnRefresh;
    }
}