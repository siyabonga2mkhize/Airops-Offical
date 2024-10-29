using System;
using System.IO;
using System.Windows.Forms;

namespace AirOps_Login
{
    public partial class FrmRetrievePassword : Form
    {
        public FrmRetrievePassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {


            string idNumber = txtIDNumber.Text;
            string filePath = "C:\\Users\\thesm\\OneDrive - Durban University of Technology\\Desktop\\Data.txt";
            string lineRec = "";

            try
            {
                using (StreamReader objSR = new StreamReader(filePath))
                {
                    while ((lineRec = objSR.ReadLine()) != null)
                    {
                        string[] array = lineRec.Split('\t');


                        if (array.Length >= 5 && idNumber == array[3])
                        {

                            lblPassword.Text = $"{array[4]}";
                            return;
                        }
                    }
                }

                MessageBox.Show("ID not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("The file was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
