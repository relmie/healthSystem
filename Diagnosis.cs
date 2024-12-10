using Guna.UI2.WinForms.Suite;
using HealthSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace HealthSystem
{
    public partial class DiagnosisLoad : System.Windows.Forms.Form
    {


        public DiagnosisLoad()
        {
            InitializeComponent();
        }



        string connectionString = (@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Relmie\Documents\healthdb.mdf;Integrated Security = True; Connect Timeout = 30");

        private void LoadData()
        {
            string query = "SELECT * FROM DiagnosisTbl";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    DiagnosisGV.DataSource = dt;
                }
            }
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void DiagnosisGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string query = "SELECT * FROM DiagnosisTbl";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    DiagnosisGV.DataSource = dt;

                    int DiagId = Convert.ToInt32(DiagnosisGV.SelectedRows[0].Cells["DiagId"].Value);

                    DataGridViewRow row = DiagnosisGV.Rows[e.RowIndex];

                }
            }
        }


        private void DiagnosisLoad_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            // Input validation: check if any field is empty or invalid
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                cmbVitalSign.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtSymptoms.Text) ||
                string.IsNullOrWhiteSpace(txtDiagnosis.Text) ||
                string.IsNullOrWhiteSpace(txtTreatment.Text) ||
                string.IsNullOrWhiteSpace(cmbLabsNeeded.Text))
            {
                MessageBox.Show("Please fill out all required fields.");
                return; // Stop execution if validation fails
            }

            // SQL query to insert data
            string query = "INSERT INTO DiagnosisTbl (Name, Date, Time, VitalSign, Symptoms, Diagnosis, Treatment, LabsNeeded) " +
               "VALUES (@Name, @Date, @Time, @VitalSign, @Symptoms, @Diagnosis, @Treatment, @LabsNeeded)";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add parameters with values
                        cmd.Parameters.AddWithValue("@Name", txtName.Text);
                        cmd.Parameters.AddWithValue("@Date", dptDate.Value.Date); // Only the date part
                        cmd.Parameters.AddWithValue("@Time", txtTime.Text);
                        cmd.Parameters.AddWithValue("@VitalSign", cmbVitalSign.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@Symptoms", txtSymptoms.Text);
                        cmd.Parameters.AddWithValue("@Diagnosis", txtDiagnosis.Text);
                        cmd.Parameters.AddWithValue("@Treatment", txtTreatment.Text);
                        cmd.Parameters.AddWithValue("@LabsNeeded", cmbLabsNeeded.Text);

                        // Execute the query
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Record added successfully!");
                    }

                    // Refresh the DataGridView
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (DiagnosisGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record to update.");
                return;
            }

            string selectedDiagId = DiagnosisGV.SelectedRows[0].Cells["DiagId"].Value.ToString();

            string query = "UPDATE DiagnosisTbl SET " +
                           "Name = @Name, Date = @Date, Time = @Time, VitalSign = @VitalSign, Symptoms = @Symptoms, Diagnosis = @Diagnosis, Treatment = @Treatment, LabsNeeded = @LabsNeeded " +
                           "WHERE DiagId = @DiagId";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add parameters
                        cmd.Parameters.AddWithValue("@DiagId", selectedDiagId);
                        cmd.Parameters.AddWithValue("@Name", txtName.Text);
                        cmd.Parameters.AddWithValue("@Date", dptDate.Value.Date); // Only the date part
                        cmd.Parameters.AddWithValue("@Time", txtTime.Text);

                        // Check if VitalSign is null or empty, and provide a fallback
                        if (cmbVitalSign.SelectedItem == null || string.IsNullOrWhiteSpace(cmbVitalSign.SelectedItem.ToString()))
                        {
                            cmd.Parameters.AddWithValue("@VitalSign", DBNull.Value); // Use DBNull.Value for null
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@VitalSign", cmbVitalSign.SelectedItem.ToString());
                        }

                        cmd.Parameters.AddWithValue("@Symptoms", txtSymptoms.Text);
                        cmd.Parameters.AddWithValue("@Diagnosis", txtDiagnosis.Text);
                        cmd.Parameters.AddWithValue("@Treatment", txtTreatment.Text);
                        cmd.Parameters.AddWithValue("@LabsNeeded", cmbLabsNeeded.Text);

                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record updated successfully!");

                            // Refresh the DataGridView
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Update failed. No records were affected.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            // Ensure a row is selected
            if (DiagnosisGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record to delete.");
                return;
            }

            // Get the selected record's DiagId
            int DiagId = Convert.ToInt32(DiagnosisGV.SelectedRows[0].Cells["DiagId"].Value);

            // Confirm deletion
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this record?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM DiagnosisTbl WHERE DiagId = @DiagId";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    try
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            // Set parameter for the record ID
                            cmd.Parameters.AddWithValue("@DiagId", DiagId);

                            // Execute the query
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Record successfully deleted!");

                                // Refresh DataGridView
                                LoadData();
                            }
                            else
                            {
                                MessageBox.Show("No record was deleted. Please try again.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string diagId = txtSearchId.Text;

            if (string.IsNullOrWhiteSpace(diagId))
            {
                MessageBox.Show("Please enter a valid ID to search.");
                return;
            }

            string query = "SELECT * FROM DiagnosisTbl WHERE DiagId = @DiagId";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@DiagId", diagId);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                DiagnosisGV.DataSource = dt;
                            }
                            else
                            {
                                MessageBox.Show("No record found for the entered ID.");
                                DiagnosisGV.DataSource = null;
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

        // Clear fields (optional helper method)
        private void ClearFields()
        {
            txtSearchId.Clear();
            DiagnosisGV.DataSource = null; // Clear the DataGridView
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM DiagnosisTbl";

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
                                DiagnosisGV.DataSource = dt; // Populate DataGridView
                            }
                            else
                            {
                                MessageBox.Show("No records found.");
                                DiagnosisGV.DataSource = null;
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


        

    
