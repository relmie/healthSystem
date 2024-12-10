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
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HealthSystem
{
    public partial class LoadLogBookData : System.Windows.Forms.Form
    {
        public LoadLogBookData()
        {
            InitializeComponent();
        }
        string connectionString = (@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Relmie\Documents\Healthdb.mdf;Integrated Security = True; Connect Timeout = 30");

        private void LoadData()
        {
            string query = "SELECT * FROM LogbookTbl";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    LogBookGV.DataSource = dt;
                }
            }
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void LogBookGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string query = "SELECT * FROM LogbookTbl"; // Modify this if you want to select specific columns
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    LogBookGV.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void LogBook_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Check if required fields are empty
            if (string.IsNullOrWhiteSpace(txtCompleteName.Text) ||
                cmbClientCategory.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtDepartment.Text) ||
                string.IsNullOrWhiteSpace(txtCourse.Text) ||
                string.IsNullOrWhiteSpace(txtConsultation.Text) ||
                string.IsNullOrWhiteSpace(txtAttendedBy.Text))
            {
                MessageBox.Show("Please fill out all required fields.");
                return;
            }

            // SQL Insert Query
            string query = "INSERT INTO LogbookTbl (Date, TimeIn, CompleteName, ClientCategory, Department, " +
               "Course, Gender, Consultation, ServicesRendered, Ape, IssuanceOfMedCert, BP, HeightAndWeight, " +
               "Referral, Rx, MedicineIssuance, SigningClearance, Others, TimeOut, Signature, AttendedBy) " +
               "VALUES (@Date, @TimeIn, @CompleteName, @ClientCategory, @Department, @Course, @Gender, @Consultation, " +
               "@ServicesRendered, @Ape, @IssuanceOfMedCert, @BP, @HeightAndWeight, @Referral, @Rx, @MedicineIssuance, " +
               "@SigningClearance, @Others, @TimeOut, @Signature, @AttendedBy)";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add parameters for each field
                        cmd.Parameters.AddWithValue("@Date", dptDate.Value.Date);
                        cmd.Parameters.AddWithValue("@TimeIn", txtTimeIn.Text);
                        cmd.Parameters.AddWithValue("@CompleteName", txtCompleteName.Text);
                        cmd.Parameters.AddWithValue("@ClientCategory", cmbClientCategory.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Department", txtDepartment.Text);
                        cmd.Parameters.AddWithValue("@Course", txtCourse.Text);
                        cmd.Parameters.AddWithValue("@Gender", cmbGender.SelectedItem != null ? cmbGender.SelectedItem.ToString() : DBNull.Value);
                        cmd.Parameters.AddWithValue("@Consultation", txtConsultation.Text);
                        cmd.Parameters.AddWithValue("@ServicesRendered", grpServicesRendered.Text);
                        cmd.Parameters.AddWithValue("@Ape", chkAPE.Checked ? 1 : 0);
                        cmd.Parameters.AddWithValue("@IssuanceOfMedCert", chkIssuanceOfMedCert.Checked ? 1 : 0); // Same for checkboxes
                        cmd.Parameters.AddWithValue("@BP", chkBP.Checked ? 1 : 0);
                        cmd.Parameters.AddWithValue("@HeightAndWeight", chkHeightandWeight.Checked ? 1 : 0);
                        cmd.Parameters.AddWithValue("@Referral", chkReferral.Checked ? 1 : 0);
                        cmd.Parameters.AddWithValue("@Rx", chkRx.Checked ? 1 : 0);
                        cmd.Parameters.AddWithValue("@MedicineIssuance", chkMedicineIssuance.Checked ? 1 : 0);
                        cmd.Parameters.AddWithValue("@SigningClearance", chkSigningClearance.Checked ? 1 : 0);
                        cmd.Parameters.AddWithValue("@Others", chkOthers.Checked ? 1 : 0);
                        cmd.Parameters.AddWithValue("@TimeOut", txtTimeOut.Text);
                        cmd.Parameters.AddWithValue("@Signature", txtSignature.Text);
                        cmd.Parameters.AddWithValue("@AttendedBy", txtAttendedBy.Text);

                        // Execute the Insert query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record added successfully!");

                            // Optionally, refresh the DataGridView to show the new data
                            //    LoadData();
                        }
                        else
                        {
                            MessageBox.Show("No records were added.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (LogBookGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record to update.");
                return;
            }

            // Get the selected LogId (primary key or unique identifier)
            string selectedLogId = LogBookGV.SelectedRows[0].Cells["LogId"].Value.ToString();

            // SQL query for updating the record
            string query = "UPDATE LogbookTbl SET " +
                "Date = @Date, TimeIn = @TimeIn, CompleteName = @CompleteName, ClientCategory = @ClientCategory, " +
                "Department = @Department, Course = @Course, Gender = @Gender, Consultation = @Consultation, " +
                "ServicesRendered = @ServicesRendered, Ape = @Ape, IssuanceOfMedCert = @IssuanceOfMedCert, BP = @BP, " +
                "HeightAndWeight = @HeightAndWeight, Referral = @Referral, Rx = @Rx, MedicineIssuance = @MedicineIssuance, " +
                "SigningClearance = @SigningClearance, Others = @Others, TimeOut = @TimeOut, Signature = @Signature, " +
                "AttendedBy = @AttendedBy " +
                "WHERE LogId = @LogId"; // Ensure you use the primary key to identify the record to update

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add parameters for the query
                        cmd.Parameters.AddWithValue("@Date", dptDate.Value.Date);
                        cmd.Parameters.AddWithValue("@TimeIn", txtTimeIn.Text);
                        cmd.Parameters.AddWithValue("@CompleteName", txtCompleteName.Text);
                        cmd.Parameters.AddWithValue("@ClientCategory", cmbClientCategory.Text);
                        cmd.Parameters.AddWithValue("@Department", txtDepartment.Text);
                        cmd.Parameters.AddWithValue("@Course", txtCourse.Text);
                        cmd.Parameters.AddWithValue("@Gender", cmbGender.Text);
                        cmd.Parameters.AddWithValue("@Consultation", txtConsultation.Text);
                        cmd.Parameters.AddWithValue("@ServicesRendered", grpServicesRendered.Text);
                        cmd.Parameters.AddWithValue("@Ape", chkAPE.Checked ? 1 : 0);
                        cmd.Parameters.AddWithValue("@IssuanceOfMedCert", chkIssuanceOfMedCert.Checked ? 1 : 0);
                        cmd.Parameters.AddWithValue("@BP", chkBP.Checked ? 1 : 0);
                        cmd.Parameters.AddWithValue("@HeightAndWeight", chkHeightandWeight.Checked ? 1 : 0);
                        cmd.Parameters.AddWithValue("@Referral", chkReferral.Checked ? 1 : 0);
                        cmd.Parameters.AddWithValue("@Rx", chkRx.Checked ? 1 : 0);
                        cmd.Parameters.AddWithValue("@MedicineIssuance", chkMedicineIssuance.Checked ? 1 : 0);
                        cmd.Parameters.AddWithValue("@SigningClearance", chkSigningClearance.Checked ? 1 : 0);
                        cmd.Parameters.AddWithValue("@Others", chkOthers.Checked ? 1 : 0);
                        cmd.Parameters.AddWithValue("@TimeOut", txtTimeOut.Text);
                        cmd.Parameters.AddWithValue("@Signature", txtSignature.Text);
                        cmd.Parameters.AddWithValue("@AttendedBy", txtAttendedBy.Text);
                        cmd.Parameters.AddWithValue("@LogId", selectedLogId); // Add the primary key parameter

                        // Execute the update query
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (LogBookGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record to delete.");
                return;
            }

            // Get the selected LogId (primary key or unique identifier)
            string selectedLogId = LogBookGV.SelectedRows[0].Cells["LogId"].Value.ToString();

            // Confirm deletion
            var confirmResult = MessageBox.Show(
                "Are you sure you want to delete this record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                // SQL query for deleting the record
                string query = "DELETE FROM LogbookTbl WHERE LogId = @LogId";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    try
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            // Add parameter for LogId
                            cmd.Parameters.AddWithValue("@LogId", selectedLogId);

                            // Execute the delete query
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Record deleted successfully!");

                                // Refresh the DataGridView
                                LoadData();
                            }
                            else
                            {
                                MessageBox.Show("Delete failed. No records were affected.");
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Please enter a Log ID to search.");
                return;
            }

            // Get the LogId from the search TextBox
            string searchLogId = txtID.Text;

            // SQL query to search for the record
            string query = "SELECT * FROM LogbookTbl WHERE LogId = @LogId";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add the parameter for the LogId
                        cmd.Parameters.AddWithValue("@LogId", searchLogId);

                        // Execute the query and load the result into a DataTable
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                // Bind the result to the DataGridView
                                LogBookGV.DataSource = dt;
                            }
                            else
                            {
                                MessageBox.Show("No records found for the given Log ID.");
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM LogbookTbl";

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
                                LogBookGV.DataSource = dt; // Populate DataGridView
                            }
                            else
                            {
                                MessageBox.Show("No records found.");
                                LogBookGV.DataSource = null;
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
        
    



