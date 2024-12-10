using healthSystem;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthSystem
{
    public partial class Home : System.Windows.Forms.Form
    {
        public Home()

        {
            InitializeComponent();
        }
        // string searchQuery = txtSearch.Text.Trim().ToLower();

        private void lblLogBook_Click(object sender, EventArgs e)
        {
            LoadLogBookData LogBook = new LoadLogBookData();
            LogBook.Show();
            this.Hide();
        }

        private void lblStudent_Click(object sender, EventArgs e)
        {
            Student Student = new Student();
            Student.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string searchQuery = txtSearch.Text.Trim().ToLower();

            switch (searchQuery)
            {
                case "log book":
                    new LoadLogBookData().Show();
                    this.Hide();
                    break;

                case "student":
                    new Student().Show();
                    this.Hide();
                    break;


                case "medical history":
                    new MedicalHistoryLoad().Show();
                    this.Hide();
                    break;

                case "diagnosis":
                    new DiagnosisLoad().Show();
                    this.Hide();
                    break;

                case "doctors":
                    new Doctor().Show();
                    this.Hide();
                    break;

                case "staff":
                    new Staff().Show();
                    this.Hide();
                    break;

                default:

                    MessageBox.Show("Form not found. Please check your search query.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }

        }


        private void lblMedicalHistory_Click(object sender, EventArgs e)
        {
            MedicalHistoryLoad medicalHistory = new MedicalHistoryLoad();
            medicalHistory.Show();
            this.Hide();
        }

        private void lblDiagnosis_Click(object sender, EventArgs e)
        {
            DiagnosisLoad diagnosis = new DiagnosisLoad();
            diagnosis.Show();
            this.Hide();
        }

        private void lblDoctors_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor();
            doctor.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cmbMore_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cmbMore.SelectedItem.ToString();
            switch (selectedValue)
            {
                case "Student":
                    Student student = new Student();
                    student.Show();
                    break;



                case "Medical History":
                    MedicalHistoryLoad medicalHistoryLoad = new MedicalHistoryLoad();
                    medicalHistoryLoad.Show();
                    break;

                case "Diagnosis":
                    DiagnosisLoad diagnosisLoad = new DiagnosisLoad();
                    diagnosisLoad.Show();
                    break;

                case "Doctors":
                    Doctor doctor = new Doctor();
                    doctor.Show();
                    break;

                case "Staff":
                    Staff staff = new Staff();
                    staff.Show();
                    break;

                default:

                    MessageBox.Show("Invalid Selection");
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox1.SelectedItem.ToString();
            switch (selectedValue)
            {
                case "Medical Certificate":
                    MedCert medCert = new MedCert();
                    medCert.Show();
                    break;

                case "Certificate of Illness":
                    IllnessCert illness = new IllnessCert();
                    illness.Show();
                    break;

                case "Laboratory Request Form":
                    Laboratory_Request_Form laboratory_Request_ = new Laboratory_Request_Form();
                    laboratory_Request_.Show();
                    break;

                default:

                    MessageBox.Show("Invalid Selection");
                    break;
            }
        }

        private void btnLogBook_Click(object sender, EventArgs e)
        {
            LoadLogBookData logBook = new LoadLogBookData();
            logBook.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxQRCode_Click(object sender, EventArgs e)
        {
            // Palitan ito ng impormasyon ng user
            string userInfo = "Name: Juan Dela Cruz\nID: 12345\nDepartment: IT";

            // Generate QR Code
            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            {
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(userInfo, QRCodeGenerator.ECCLevel.Q);
                using (QRCode qrCode = new QRCode(qrCodeData))
                {
                    Bitmap qrCodeImage = qrCode.GetGraphic(20); // Generate QR Code image
                    pictureBoxQRCode.Image = qrCodeImage; // Display sa PictureBox
                }
            }
        }

        private void cmbItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox2.SelectedItem.ToString();
            switch (selectedValue)
            {
                case "Medicine":
                    MedicineTable medicine = new MedicineTable();
                    medicine.Show();
                    break;

                default:

                    MessageBox.Show("Invalid Selection");
                    break;
            }
        }
    }
}


        
 