using HealthSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace healthSystem
{
    public partial class IllnessCert : System.Windows.Forms.Form
    {
        public IllnessCert()
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
            // Define fonts
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
            e.Graphics.DrawString("Medical and Dental Office", footerFont, Brushes.Black, pageCenter, yPosition, centerAlign);

            // Draw Separator Line
            yPosition += 90;
            e.Graphics.DrawLine(Pens.Black, 150, yPosition, 700, yPosition);

            // Draw Certificate Title
            yPosition += 30;
            e.Graphics.DrawString("CERTIFICATE OF ILLNESS", titleFont, Brushes.Black, pageCenter, yPosition, centerAlign);

            // Draw Date (on the Right Side)
            yPosition += 70;
            e.Graphics.DrawString(
                $"Date: {dtpDate.Value.ToString("dd MMMM , yyyy")}",
                labelFont,
                Brushes.Black,
                450, // Right-aligned X-coordinate
                yPosition
            );

            
            // Starting position
            yPosition += 60;
            e.Graphics.DrawString("This is to certify that Mr./Ms.", labelFont, Brushes.Black, 50, yPosition);

            // Name Line and Input
            e.Graphics.DrawString(txtMs.Text, contentFont, Brushes.Black, 308, yPosition - 1); // Name input (aligned with "Mr./Ms.")
            e.Graphics.DrawLine(Pens.Black, 310, yPosition + 20, 550, yPosition + 20); // Line for Name
            yPosition += 40; // Move down to the next section

            // Starting Position
            yPosition += 40;

            // "was under treatment for" text
            e.Graphics.DrawString("was under treatment for", labelFont, Brushes.Black, 50, yPosition);

            // Treatment Line and Input
            float treatmentStartX = 270; // Start X position for the treatment line
            e.Graphics.DrawString(txtTreatment.Text, contentFont, Brushes.Black, treatmentStartX, yPosition - 1); // Treatment input
            e.Graphics.DrawLine(Pens.Black, treatmentStartX, yPosition + 20, treatmentStartX + 360, yPosition + 20); // Line for Treatment

            // "On" and Date (aligned on the same line)
            float onStartX = treatmentStartX + 370; // Adjusted X position for "On"
            e.Graphics.DrawString("On", labelFont, Brushes.Black, onStartX, yPosition); // Static "On" text

            float dateStartX = onStartX + 35; // Adjusted X position for the date after "On"
            e.Graphics.DrawString(OnDate.Value.ToString("dd MMM, yyyy"), contentFont, Brushes.Black, dateStartX, yPosition + 0); // Date input


            // Footer: Physician's Name
            yPosition += 400; // Add space above the name
            e.Graphics.DrawString(
                "Alan Angelo N. Raymundo, MD",         // Physician's Name
                new Font("Georgia", 12, FontStyle.Bold), // Font: Bold, Size 12
                Brushes.Black,                         // Color
                450,                                   // X-coordinate for alignment
                yPosition
            );

            // Footer: Position
            yPosition += 20; // Add space below the name
            e.Graphics.DrawString(
                "Medical Officer III",                 // Position
                new Font("Georgia", 14, FontStyle.Regular), // Font: Regular, Size 11
                Brushes.Black,                         // Color
                510,                                   // X-coordinate for alignment
                yPosition
            );
        }

            private void Logo_Click(object sender, EventArgs e)
        {

        }

        private void Dental_Click(object sender, EventArgs e)
        {

        }
    }
}


