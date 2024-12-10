using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
namespace HealthSystem
{
    public partial class Student : System.Windows.Forms.Form
    {
        public Student()
        {
            InitializeComponent();
        }


        string connectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Relmie\Documents\Healthdb.mdf;Integrated Security=True;Connect Timeout=30");

        private void LoadData()
        {
            string query = "SELECT * FROM StudentTbl";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    StudentGV.DataSource = dt;
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }



        private void StudentGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM StudentTbl";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                StudentGV.DataSource = table;

                btnDelete.Enabled = StudentGV.SelectedRows.Count > 0;

                SearchStudentId.Clear(); // Clear the search textbox
                LoadData();
            }
        }






        private void Student_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtStudentNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            // Input validation: check if any field is empty or invalid
            if (string.IsNullOrWhiteSpace(txtStudentNum.Text) ||
            cmbYearLevel.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtCollege.Text) ||
                string.IsNullOrWhiteSpace(txtCourse.Text) ||
                string.IsNullOrWhiteSpace(dtpDate.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtMiddleName.Text) ||
                cmbExtension.SelectedItem == null ||
                cmbSex.SelectedItem == null ||
                cmbCivilStatus.SelectedItem == null ||
                string.IsNullOrWhiteSpace(dtpBirthday.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text) ||
                string.IsNullOrWhiteSpace(txtHomeAddress.Text) ||
                string.IsNullOrWhiteSpace(txtStreetName.Text) ||
                string.IsNullOrWhiteSpace(txtBarangay.Text) ||
                string.IsNullOrWhiteSpace(txtVillage.Text) ||
                string.IsNullOrWhiteSpace(txtMunicipality.Text) ||
                string.IsNullOrWhiteSpace(txtProvince.Text) ||
                string.IsNullOrWhiteSpace(txtParentGuardianName.Text) ||
                string.IsNullOrWhiteSpace(txtParentGuardianAddress.Text) ||
                string.IsNullOrWhiteSpace(txtParentGuardianContact.Text) ||
                string.IsNullOrWhiteSpace(txtStudentContact.Text))

            {
                MessageBox.Show("Please fill out all required fields.");
                return; // Stop execution if validation fails
            }


            string query = "INSERT INTO StudentTbl (StudentNum, YearLevel, College, Course, Date, LastName, FirstName, MiddleName, Extension, Sex, CivilStatus, Birthday, Age, HomeAddress, StreetName, Barangay, Village, Municipality, Province, ParentGuardianName, ParentGuardianAddress, ParentGuardianContact, StudentContact) " +
               "VALUES (@StudentNum, @YearLevel, @College, @Course, @Date, @LastName, @FirstName, @MiddleName, @Extension, @Sex, @CivilStatus, @Birthday, @Age, @HomeAddress, @StreetName, @Barangay, @Village, @Municipality, @Province, @ParentGuardianName, @ParentGuardianAddress, @ParentGuardianContact, @StudentContact)";


            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add parameters

                        cmd.Parameters.AddWithValue("@StudentNum", txtStudentNum.Text);
                        cmd.Parameters.AddWithValue("@YearLevel", cmbYearLevel.SelectedItem?.ToString() ?? "");
                        cmd.Parameters.AddWithValue("@College", txtCollege.Text);
                        cmd.Parameters.AddWithValue("@Course", txtCourse.Text);
                        cmd.Parameters.AddWithValue("@Date", DateTime.Parse(dtpDate.Text));
                        cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                        cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                        cmd.Parameters.AddWithValue("@MiddleName", txtMiddleName.Text);
                        cmd.Parameters.AddWithValue("@Extension", cmbExtension.SelectedItem?.ToString() ?? "");
                        cmd.Parameters.AddWithValue("@Sex", cmbSex.SelectedItem?.ToString() ?? "");
                        cmd.Parameters.AddWithValue("@CivilStatus", cmbCivilStatus.SelectedItem?.ToString() ?? "");
                        cmd.Parameters.AddWithValue("@Birthday", DateTime.Parse(dtpBirthday.Text));
                        cmd.Parameters.AddWithValue("@Age", int.Parse(txtAge.Text));
                        cmd.Parameters.AddWithValue("@HomeAddress", txtHomeAddress.Text);
                        cmd.Parameters.AddWithValue("@StreetName", txtStreetName.Text);
                        cmd.Parameters.AddWithValue("@Barangay", txtBarangay.Text);
                        cmd.Parameters.AddWithValue("@Village", txtVillage.Text);
                        cmd.Parameters.AddWithValue("@Municipality", txtMunicipality.Text);
                        cmd.Parameters.AddWithValue("@Province", txtProvince.Text);
                        cmd.Parameters.AddWithValue("@ParentGuardianName", txtParentGuardianName.Text);
                        cmd.Parameters.AddWithValue("@ParentGuardianAddress", txtParentGuardianAddress.Text);
                        cmd.Parameters.AddWithValue("@ParentGuardianContact", txtParentGuardianContact.Text);
                        cmd.Parameters.AddWithValue("@StudentContact", txtStudentContact.Text);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Record added successfully!");

                    // Refresh DataGridView
                    LoadData();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (StudentGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record to delete.");
                return;
            }

            // Get the StudentNum from the selected row
            string selectedStudentId = StudentGV.SelectedRows[0].Cells["StudentId"].Value.ToString();

            // Confirm deletion
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete the record with Student Number {selectedStudentId}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM StudentTbl WHERE StudentId = @StudentId";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    try
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            // Add parameter for StudentNum
                            cmd.Parameters.AddWithValue("@StudentId", selectedStudentId);

                            // Execute delete query
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Record deleted successfully!");

                                // Refresh DataGridView
                                LoadData();
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete the record. Please try again.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (StudentGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record to update.");
                return;
            }

            // Get the selected StudentId from the DataGridView
            string selectedStudentId = StudentGV.SelectedRows[0].Cells["StudentId"].Value.ToString();

            // SQL query to update the record
            string query = "UPDATE StudentTbl SET " +
                           "StudentNum = @StudentNum, YearLevel = @YearLevel, College = @College, Course = @Course, " +
                           "Date = @Date, LastName = @LastName, FirstName = @FirstName, MiddleName = @MiddleName, " +
                           "Extension = @Extension, Sex = @Sex, CivilStatus = @CivilStatus, Birthday = @Birthday, " +
                           "Age = @Age, HomeAddress = @HomeAddress, StreetName = @StreetName, Barangay = @Barangay, " +
                           "Village = @Village, Municipality = @Municipality, Province = @Province, " +
                           "ParentGuardianName = @ParentGuardianName, ParentGuardianAddress = @ParentGuardianAddress, " +
                           "ParentGuardianContact = @ParentGuardianContact, StudentContact = @StudentContact " +
                           "WHERE StudentId = @StudentId";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add parameters
                        cmd.Parameters.AddWithValue("@StudentId", selectedStudentId);
                        cmd.Parameters.AddWithValue("@StudentNum", txtStudentNum.Text);
                        cmd.Parameters.AddWithValue("@YearLevel", cmbYearLevel.SelectedItem?.ToString() ?? "");
                        cmd.Parameters.AddWithValue("@College", txtCollege.Text);
                        cmd.Parameters.AddWithValue("@Course", txtCourse.Text);
                        cmd.Parameters.AddWithValue("@Date", DateTime.Parse(dtpDate.Text));
                        cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                        cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                        cmd.Parameters.AddWithValue("@MiddleName", txtMiddleName.Text);
                        cmd.Parameters.AddWithValue("@Extension", cmbExtension.SelectedItem?.ToString() ?? "");
                        cmd.Parameters.AddWithValue("@Sex", cmbSex.SelectedItem?.ToString() ?? "");
                        cmd.Parameters.AddWithValue("@CivilStatus", cmbCivilStatus.SelectedItem?.ToString() ?? "");
                        cmd.Parameters.AddWithValue("@Birthday", DateTime.Parse(dtpBirthday.Text));
                        cmd.Parameters.AddWithValue("@Age", int.Parse(txtAge.Text));
                        cmd.Parameters.AddWithValue("@HomeAddress", txtHomeAddress.Text);
                        cmd.Parameters.AddWithValue("@StreetName", txtStreetName.Text);
                        cmd.Parameters.AddWithValue("@Barangay", txtBarangay.Text);
                        cmd.Parameters.AddWithValue("@Village", txtVillage.Text);
                        cmd.Parameters.AddWithValue("@Municipality", txtMunicipality.Text);
                        cmd.Parameters.AddWithValue("@Province", txtProvince.Text);
                        cmd.Parameters.AddWithValue("@ParentGuardianName", txtParentGuardianName.Text);
                        cmd.Parameters.AddWithValue("@ParentGuardianAddress", txtParentGuardianAddress.Text);
                        cmd.Parameters.AddWithValue("@ParentGuardianContact", txtParentGuardianContact.Text);
                        cmd.Parameters.AddWithValue("@StudentContact", txtStudentContact.Text);

                        // Execute the query
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Record updated successfully!");

                    // Refresh the DataGridView
                    LoadData();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Ensure the user has entered a StudentId to search
            if (string.IsNullOrWhiteSpace(SearchStudentId.Text))
            {
                MessageBox.Show("Please enter a Student ID to search.");
                return;
            }

            string studentId = SearchStudentId.Text; // Get the input StudentId
            string query = "SELECT * FROM StudentTbl WHERE StudentId = @StudentId";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add the parameter for StudentId
                        cmd.Parameters.AddWithValue("@StudentId", studentId);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Bind the result to the DataGridView
                        if (dt.Rows.Count > 0)
                        {
                            StudentGV.DataSource = dt; // Display matching data
                        }
                        else
                        {
                            MessageBox.Show("No record found for the given Student ID.");
                            StudentGV.DataSource = null; // Clear the grid if no record is found
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM StudentTbl";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                StudentGV.DataSource = dt; // Populate DataGridView
                            }
                            else
                            {
                                MessageBox.Show("No records found.");
                                StudentGV.DataSource = null;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

    }
}

        
    




