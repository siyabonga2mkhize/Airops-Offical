using System;
using System.IO;
using System.Windows.Forms;


namespace AirOps_Login
{
    public partial class frmLogin : Form
    {
        private int loginAttempts = 0;
        private const int maxLoginAttempts = 3;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void linklblCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmCreateAccount frmCreateAccount = new frmCreateAccount();
            frmCreateAccount.Show();

        }

        private void btnforgotPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRetrievePassword frmRetrievePassword = new FrmRetrievePassword();
            frmRetrievePassword.Show();

        }
        //Login Button Code
        private void button1_Click(object sender, EventArgs e)
        {
            string email = txtEmailAddress.Text.Trim().ToLower();
            string password = txtPassword.Text;

            if (email == "admin")
            {
                if (password == "QWERTY")
                {
                    frmAdmin admin = new frmAdmin();
                    this.Hide();
                    admin.Show();
                }
                else
                {
                    loginAttempts++;
                    if (loginAttempts >= maxLoginAttempts)
                    {
                        MessageBox.Show("Maximum login attempts exceeded. Access denied.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnLogin.Enabled = false; // Disable the login button
                    }
                    else
                    {
                        MessageBox.Show($"Invalid credentials. You have {maxLoginAttempts - loginAttempts} attempts left.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }

            else
            {
                string LineRec = " ";
                string[] Array = new string[6];
                string Email = txtEmailAddress.Text, Password = txtPassword.Text;
                string Path = @"C:\Users\thesm\OneDrive - Durban University of Technology\Desktop\Data.txt";

                // Open the file for reading
                using (StreamReader objSR = new StreamReader(Path))
                {


                    // Variables to track if email/password are correct
                    bool emailFound = false;
                    bool passwordCorrect = false;

                    // Read each line from the file
                    while ((LineRec = objSR.ReadLine()) != null)
                    {
                        // Split the line into an array based on the tab delimiter
                        Array = LineRec.Split('\t');

                        // Ensure that the array has at least 5 elements (to avoid out-of-bounds errors)
                        if (Array.Length < 5) continue;

                        try
                        {
                            // Check if the email matches
                            if (Email == Array[2])
                            {
                                emailFound = true; // Set email found to true

                                // Check if the password matches
                                if (Password == Array[4])
                                {
                                    passwordCorrect = true;

                                    // Show the success message
                                    DialogResult result = MessageBox.Show("You are successfully logged in.", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    if (result == DialogResult.OK)
                                    {
                                        // Open the welcome form and hide the current form
                                        FrmSearchFlights welcome = new FrmSearchFlights();
                                        welcome.Show();
                                        this.Hide();  // Hides the current form without closing the application
                                    }
                                    break; // Exit the loop once login is successful
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message); // Show any exceptions
                        }
                    }

                    // After checking all lines, if the email wasn't found
                    if (!emailFound)
                    {
                        MessageBox.Show("Email not found.", "Login Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    // If the email was found, but the password was incorrect
                    else if (!passwordCorrect)
                    {
                        MessageBox.Show("Password incorrect.", "Login Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }


        private void chkShowPassword_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}