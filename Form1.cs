using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using System.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;

namespace HealthSystem
{
    public partial class FormLoad : System.Windows.Forms.Form
    {



        public FormLoad()
        {
            InitializeComponent();
        }
        string connectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Relmie\Documents\healthdb.mdf;Integrated Security=True;Connect Timeout=30");

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the values from the TextBoxes and ComboBox
                string email = txtEmail.Text.Trim();  // Email from the TextBox
                string password = txtPassword.Text.Trim();  // Password from the TextBox
                string role = cmbRole.SelectedItem?.ToString();  // Role from the ComboBox

                // Ensure email, password, and role are not empty
                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
                {
                    MessageBox.Show("All fields are required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Hardcoded credentials for testing
                string correctEmail = "rel.lumiguid@gmail.com";  // Email
                string correctPassword = "123456789";  // Password
                string correctRole = "Admin";  // Role (for testing purposes)

                // Check if the email, password, and role match the hardcoded values
                if (email == correctEmail && password == correctPassword && role == correctRole)
                {
                    
                    Home h = new Home();  
                    h.Show();
                    this.Hide();  
                }
                else
                {
                    // If not matched, show the error
                    MessageBox.Show("Invalid email, password, or role!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*Home h = new Home();
            h.Show();
            this.Hide();
        }*/


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            {
                txtEmail.Clear();
                txtPassword.Clear();
                cmbRole.SelectedIndex = -1; // Reset the ComboBox
                txtEmail.Focus(); // Set focus to the email field
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
        private void lbl_FailLogin_Click(object sender, EventArgs e)
        {
        }
        private void FormLoad_Load(object sender, EventArgs e)
        {
            // cmbRole.Items.Add("Admin");
            // cmbRole.Items.Add("Staff");
            txtPassword.PasswordChar = '*';
        }
    }
}
    