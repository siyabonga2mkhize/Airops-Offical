using System;
using System.IO;
using System.Windows.Forms;

namespace AirOps_Login
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string FilePath = "C:\\Users\\thesm\\OneDrive - Durban University of Technology\\Desktop\\Data.txt";
            txtOutput.ReadOnly = true; // Set the TextBox to read-only
            using (StreamReader reader = new StreamReader(FilePath))
            {
                string lineRec;
                txtOutput.Text = ""; // Clear previous content
                while ((lineRec = reader.ReadLine()) != null)
                {
                    txtOutput.Text += lineRec + Environment.NewLine; // Append each line with a newline
                }
            }
        }

        // Enable editing of the text
        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtOutput.ReadOnly = false; // Allow editing
            btnSave.Visible = true; // Make the Save button visible
        }

        // Save the edited content back to the file
        private void btnSave_Click(object sender, EventArgs e)
        {
            string FilePath = "C:\\Users\\thesm\\OneDrive - Durban University of Technology\\Desktop\\Data.txt";
            using (StreamWriter writer = new StreamWriter(FilePath))
            {
                writer.Write(txtOutput.Text); // Write the edited content back to the file
            }
            txtOutput.ReadOnly = true; // Set back to read-only after saving
            btnSave.Visible = false; // Optionally hide the Save button after saving
            MessageBox.Show("File saved successfully!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}