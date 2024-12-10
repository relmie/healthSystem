using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthSystem
{
    public partial class MedicalHistoryLoad : System.Windows.Forms.Form
    {
        public MedicalHistoryLoad()
        {
            InitializeComponent();
        }
        string connectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Relmie\Documents\Healthdb.mdf;Integrated Security=True;Connect Timeout=30");

        private void LoadData()
        {
            string query = "SELECT * FROM MedicalHistoryTbl"; // SQL Query para kunin ang lahat ng data sa table
            using (SqlConnection con = new SqlConnection(connectionString)) // Gumamit ng SqlConnection
            {
                con.Open(); // Buksan ang koneksyon
                using (SqlCommand cmd = new SqlCommand(query, con)) // Maghanda ng SqlCommand
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd); // Mag-load ng data mula sa database
                    DataTable dt = new DataTable(); // Data container
                    da.Fill(dt); // I-fill ang DataTable gamit ang query result
                    HistoryGV.DataSource = dt; // I-bind ang data sa DataGridView
                }
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void HistoryGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string query = "SELECT * FROM MedicalHistoryTbl";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    HistoryGV.DataSource = dt;
                }
            }
        }

        private void MedicalHistoryLoad_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO MedicalHistory (CovidVaccinationStatus, BloodType, PastMedicalHistory, OtherDisease, Allergies_Medication, Allergies_Food, Allergies_Other, FamilyHistory, FamilyOtherDisease, PersonalSmoking, SmokingDetails, PersonalAlcohol, AlcoholDetails) VALUES (@CovidVaccinationStatus, @BloodType, @PastMedicalHistory, @OtherDisease, @Allergies_Medication, @Allergies_Food, @Allergies_Other, @FamilyHistory, @FamilyOtherDisease, @PersonalSmoking, @SmokingDetails, @PersonalAlcohol, @AlcoholDetails)";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@CovidVaccinationStatus", txtVaccination.Text);
                    cmd.Parameters.AddWithValue("@BloodType", txtBloodType.Text);
                    cmd.Parameters.AddWithValue("@PastMedicalHistory", GetSelectedCheckboxes(PastMedical));
                    cmd.Parameters.AddWithValue("@OtherDisease", txtOtherDisease.Text);
                    cmd.Parameters.AddWithValue("@Allergies_Medication", txtMedication.Text);
                    cmd.Parameters.AddWithValue("@Allergies_Food", txtFood.Text);
                    cmd.Parameters.AddWithValue("@Allergies_Other", txtOther.Text);
                    cmd.Parameters.AddWithValue("@FamilyHistory", GetSelectedCheckboxes(FamilyHistory));
                    cmd.Parameters.AddWithValue("@FamilyOtherDisease", txtOthers.Text);
                    cmd.Parameters.AddWithValue("@PersonalSmoking", chkSmoking.Checked ? "Yes" : "No");
                    cmd.Parameters.AddWithValue("@SmokingDetails", $"{txtDuration.Text}, Quit: {chkQuit.Checked}, When: {Date.Text}");
                    cmd.Parameters.AddWithValue("@PersonalAlcohol", chkAlcohol.Checked ? "Yes" : "No");
                    cmd.Parameters.AddWithValue("@AlcoholDetails", $"{txtMuch.Text}, Quit: {chkQt.Checked}, When: {Dates.Text}");

                  // cmd.ExecuteNronQuey(query );
                    MessageBox.Show("Record Added Successfully!");
                    LoadData();
                    con.Close();
                }
            }
        }

        // Helper Method: Get Selected Checkboxes
        private string GetSelectedCheckboxes(GroupBox groupBox)
        {
            var selected = groupBox.Controls.OfType<CheckBox>().Where(chk => chk.Checked).Select(chk => chk.Text).ToList();
            return string.Join(", ", selected);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "UPDATE MedicalHistoryTbl SET CovidVaccinationStatus=@CovidVaccinationStatus, BloodType=@BloodType, PastMedicalHistory=@PastMedicalHistory, OtherDisease=@OtherDisease, Allergies_Medication=@Allergies_Medication, Allergies_Food=@Allergies_Food, Allergies_Other=@Allergies_Other, FamilyHistory=@FamilyHistory, FamilyOtherDisease=@FamilyOtherDisease, PersonalSmoking=@PersonalSmoking, SmokingDetails=@SmokingDetails, PersonalAlcohol=@PersonalAlcohol, AlcoholDetails=@AlcoholDetails WHERE ID=@ID";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ID", int.Parse(HistoryGV.SelectedRows[0].Cells[0].Value.ToString()));
                    cmd.Parameters.AddWithValue("@CovidVaccinationStatus", txtVaccination.Text);
                    cmd.Parameters.AddWithValue("@BloodType", txtBloodType.Text);
                    cmd.Parameters.AddWithValue("@PastMedicalHistory", GetSelectedCheckboxes(PastMedical));
                    cmd.Parameters.AddWithValue("@OtherDisease", txtOtherDisease.Text);
                    cmd.Parameters.AddWithValue("@Allergies_Medication", txtMedication.Text);
                    cmd.Parameters.AddWithValue("@Allergies_Food", txtFood.Text);
                    cmd.Parameters.AddWithValue("@Allergies_Other", txtOther.Text);
                    cmd.Parameters.AddWithValue("@FamilyHistory", GetSelectedCheckboxes(FamilyHistory));
                    cmd.Parameters.AddWithValue("@FamilyOtherDisease", txtOthers.Text);
                    cmd.Parameters.AddWithValue("@PersonalSmoking", chkSmoking.Checked ? "Yes" : "No");
                    cmd.Parameters.AddWithValue("@SmokingDetails", $"{txtDuration.Text}, Quit: {chkQuit.Checked}, When: {Date.Text}");
                    cmd.Parameters.AddWithValue("@PersonalAlcohol", chkAlcohol.Checked ? "Yes" : "No");
                    cmd.Parameters.AddWithValue("@AlcoholDetails", $"{txtMuch.Text}, Quit: {chkQt.Checked}, When: {Dates.Text}");

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated Successfully!");
                    LoadData();
                    con.Close();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM MedicalHistory WHERE HistoryId=@HistoryId";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ID", int.Parse(HistoryGV.SelectedRows[0].Cells[0].Value.ToString()));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Deleted Successfully!");
                    LoadData();
                    con.Close();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM MedicalHistoryTbl WHERE HistoryId=@HistoryId";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ID", int.Parse(txtID.Text));
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    HistoryGV.DataSource = dt;
                    con.Close();
                }
            }
        }
    }
}




