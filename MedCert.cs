using HealthSystem;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace healthSystem
{
    public partial class MedCert : System.Windows.Forms.Form
    {
        public MedCert()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            previewDialog.Document = printDocument1; // Link to PrintDocument
            previewDialog.ShowDialog();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font titleFont = new Font("Georgia", 20, FontStyle.Bold);
            Font labelFont = new Font("Georgia", 14, FontStyle.Regular);
            Font contentFont = new Font("Georgia", 14, FontStyle.Regular);
            Font footerFont = new Font("Georgia", 18, FontStyle.Bold);

            float yPosition = 50; // Starting vertical position

            // Calculate the center of the page (horizontal)
            float pageCenter = e.PageBounds.Width / 2;

            // Center-align format
            StringFormat centerAlign = new StringFormat()
            {
                Alignment = StringAlignment.Center, // Horizontal alignment
                LineAlignment = StringAlignment.Near // Top-aligned vertically
            };

            Image logoImage = Logo.Image;
            Image dentalImage = Dental.Image;

            e.Graphics.DrawImage(logoImage, 50, 80, 120, 120); // Left side
            e.Graphics.DrawImage(dentalImage, e.PageBounds.Width - 150, 80, 120, 120); // Right side

            // Draw Centered Title and Address


            // Draw Centered Title and Address
            yPosition = 80; // Adjust position below logos
            e.Graphics.DrawString("UNIVERSITY OF MAKATI", titleFont, Brushes.Black, pageCenter, yPosition, centerAlign);
            yPosition += 30;
            e.Graphics.DrawString("J.P Rizal St. West Rembo, Makati City", labelFont, Brushes.Black, pageCenter, yPosition, centerAlign);
            yPosition += 20;
            e.Graphics.DrawString("Tel.No. 8-883-1863", labelFont, Brushes.Black, pageCenter, yPosition, centerAlign);

            // Draw Footer Title
            yPosition += 30;
            e.Graphics.DrawString("MEDICAL AND DENTAL OFFICE", footerFont, Brushes.Black, pageCenter, yPosition, centerAlign);

            // Draw Separator Line
            yPosition += 90;
            e.Graphics.DrawLine(Pens.Black, 150, yPosition, 700, yPosition);

            // Draw Certificate Title
            yPosition += 30;
            e.Graphics.DrawString("MEDICAL CERTIFICATE", titleFont, Brushes.Black, pageCenter, yPosition, centerAlign);

            // Draw Date (on the Right Side)
            yPosition += 70;
            e.Graphics.DrawString(
                $"Date: {dtpDate.Value.ToString("dd MMMM , yyyy")}",
                labelFont,
                Brushes.Black,
                450, // Right-aligned X-coordinate
                yPosition
            );
            // Draw Certificate Details

            yPosition += 80;
            e.Graphics.DrawString("To whome it may concern:", labelFont, Brushes.Black, 50, yPosition);

            yPosition += 40;
            e.Graphics.DrawString("This is to certify that Mr./Ms.", labelFont, Brushes.Black, 80, yPosition);

            // Name Line and Tex
            float nameStartX = 350; // X-position for the name line
            e.Graphics.DrawString(txtName.Text, contentFont, Brushes.Black, nameStartX, yPosition - 5); // Input text above the line
            e.Graphics.DrawLine(Pens.Black, nameStartX, yPosition + 15, nameStartX + 200, yPosition + 15); // Line for Name
            yPosition += 20;
            e.Graphics.DrawString("(Name of Patient)", labelFont, Brushes.Black, 380, yPosition);

            // Comma and Age
            e.Graphics.DrawString(", ", contentFont, Brushes.Black, nameStartX + 198, yPosition - 20); // Adjusted comma position

            // Age Line and Text
            float ageStartX = nameStartX + 207; // X-position for the age line
            e.Graphics.DrawString(txtOld.Text, contentFont, Brushes.Black, ageStartX, yPosition - 30); // Input text above the line
            e.Graphics.DrawLine(Pens.Black, ageStartX, yPosition - 5, ageStartX + 50, yPosition -5); // Line for Age
            e.Graphics.DrawString(" years old,", contentFont, Brushes.Black, ageStartX + 50, yPosition - 20); // "years old" aligned with the input text

            // Address Section
            yPosition += 40;
            e.Graphics.DrawString("presently residing at", labelFont, Brushes.Black, 50, yPosition);
            e.Graphics.DrawString(txtAddress.Text, contentFont, Brushes.Black, 242, yPosition - 5); // Input text above the line
            e.Graphics.DrawLine(Pens.Black, 242, yPosition + 15, 500, yPosition + 15); // Line for Address
            yPosition += 20;
            e.Graphics.DrawString("(Address)", labelFont, Brushes.Black, 300, yPosition);

            yPosition += 40;
            e.Graphics.DrawString("has been examined and found to be essentially normal at the time of Physical Examination.", labelFont, Brushes.Black, 50, yPosition);

            // Application Purpose Section
            yPosition += 40;
            e.Graphics.DrawString("This certificate is issued upon request in connection with his/her application for", labelFont, Brushes.Black, 80, yPosition);
            yPosition += 40;
            e.Graphics.DrawString(txtHer.Text, contentFont, Brushes.Black, 100, yPosition - 5); // Input text above the line
            e.Graphics.DrawLine(Pens.Black, 50, yPosition + 15, 600, yPosition + 15); // Line for Purpose

            // Footer (Physician's Name and Title)
            yPosition += 350; // Add space before the footer
            float physicianStartX = 400; // Adjusted to position the physician's name to the right
            e.Graphics.DrawString(txtPhysician.Text, contentFont, Brushes.Black, physicianStartX, yPosition - 20); // Input text above the line
            e.Graphics.DrawLine(Pens.Black, physicianStartX, yPosition, physicianStartX + 250, yPosition); // Line for Physician
            yPosition += 8; // Space between line and physician's title
            e.Graphics.DrawString("University Physician", labelFont, Brushes.Black, physicianStartX + 30, yPosition);
        }
    }
}