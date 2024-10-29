using System;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace AirOps_Login
{
    public partial class frmCreateAccount : Form
    {
        public frmCreateAccount()
        {
            InitializeComponent();
            lblPasswordStrength.Visible = false;
        }

        private string GetPasswordStrength(string password, out string feedback)
        {
            feedback = "";
            if (password.Length < 6)
            {
                feedback = "Your password is too short. ";
                return "Weak";
            }
            bool hasLetter = Regex.IsMatch(password, "[a-zA-Z]");
            bool hasDigit = Regex.IsMatch(password, "[0-9]");
            bool hasSpecialChar = Regex.IsMatch(password, "[^a-zA-Z0-9]");
            if (!hasLetter) feedback += "Include at least one letter. ";
            if (!hasDigit) feedback += "Include at least one number. ";
            if (!hasSpecialChar) feedback += "Include at least one special character. ";
            if (password.Length >= 8 && hasLetter && hasDigit && hasSpecialChar)
            {
                feedback = "Great! Your password is strong.";
                return "Strong";

            }
            else if (password.Length >= 6 && hasLetter && hasDigit)
            {
                feedback += "Consider adding a special character to strengthen your password.";
                return "Medium";
            }
            else
            {
                feedback += "Your password is weak. Consider including letters, numbers, and special characters to make it stronger.";
                return "Weak";
            }
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            string password = txtPassword.Text;
            string feedback;
            string strength = GetPasswordStrength(password, out feedback);
            lblPasswordStrength.Text = $"Password Strength: {strength}\n{feedback}";


            if (strength == "Weak")
            {
                lblPasswordStrength.ForeColor = System.Drawing.Color.Red;
                lblPasswordStrength.Visible = true;


            }
            else if (strength == "Medium")
            {
                lblPasswordStrength.ForeColor = System.Drawing.Color.Orange;
                lblPasswordStrength.Visible = true;
                return;
            }
            else if (strength == "Strong")
            {
                lblPasswordStrength.ForeColor = System.Drawing.Color.Green;
                lblPasswordStrength.Visible = true;
            }
            else
            {
                lblPasswordStrength.Visible = false;
            }


        }


        private void btnCreate_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(txtName.Text) ||
       string.IsNullOrWhiteSpace(txtSurname.Text) ||
       string.IsNullOrWhiteSpace(txtEmail.Text) ||
       string.IsNullOrWhiteSpace(txtPassportID.Text) ||
       string.IsNullOrWhiteSpace(txtPassword.Text) ||
       string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                MessageBox.Show("All fields must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit if any textbox is empty
            }

            string password = txtPassword.Text;
            string feedback;
            string passwordStrength = GetPasswordStrength(password, out feedback);

            // Check if the password strength is "Weak"
            if (passwordStrength == "Weak")
            {
                MessageBox.Show("Your password is too weak. Please choose a stronger password.", "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit if the password is weak
            }
            else if (passwordStrength == "Medium")
            {
                MessageBox.Show("Your password is not strong enough. Please choose a stronger password.", "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit if the password is weak
            }


            // Collect the information from the textboxes
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string email = txtEmail.Text;
            string passportID = txtPassportID.Text;

            // Validate email domain
            if (!(email.Contains("@gmail.com") || email.Contains("@yahoo.com") || email.Contains("@outlook.com")))
            {
                MessageBox.Show("Please enter a valid email address ending with \n@gmail.com \n@yahoo.com\n @outlook.com.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit if email domain is invalid


            }
            // Validate passport ID length
            if (passportID.Length != 13)
            {
                MessageBox.Show("The passport ID must contain exactly 13 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method
            }

            // Validate date part of the passport ID
            string yearPart = passportID.Substring(0, 2);
            string monthPart = passportID.Substring(2, 2);
            string dayPart = passportID.Substring(4, 2);
            string datePart;
            int yearPrefix;
            int year = int.Parse(yearPart);

            if (year >= 0 && year <= DateTime.Now.Year % 100)
            {
                yearPrefix = 2000;
            }
            else
            {
                yearPrefix = 1900;
            }

            datePart = $"{yearPrefix + year}-{monthPart}-{dayPart}";

            DateTime parsedDate;
            if (!DateTime.TryParseExact(datePart, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate))
            {
                MessageBox.Show("The Passport/ID must start with a valid date (YYMMDD).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method
            }
            // Check if age is at least 18 years
            DateTime today = DateTime.Today;
            int age = today.Year - parsedDate.Year;
            if (parsedDate.Date > today.AddYears(-age)) age--;

            if (age < 18)
            {
                MessageBox.Show("The Passport/ID Number indicates an age less than 18.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method
            }
            //string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string FilePath = "C:\\Users\\thesm\\OneDrive - Durban University of Technology\\Desktop\\Data.txt";

            // Check if passwords match
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Clear the password fields
                txtPassword.Clear();
                txtConfirmPassword.Clear();
                return;
            }

            try
            {
                // Read the file to check for existing user
                if (File.Exists(FilePath))
                {
                    using (StreamReader reader = new StreamReader(FilePath))
                    {
                        string lineRec = reader.ReadLine();

                        while (lineRec != null)
                        {
                            // Split line into parts and check if the email or passport ID matches
                            string[] LineArray = lineRec.Split('\t');
                            if (LineArray.Length >= 4) // Ensure there are enough parts
                            {
                                string existingEmail = LineArray[2];
                                string existingPassportID = LineArray[3];
                                if (email == existingEmail || passportID == existingPassportID)
                                {
                                    MessageBox.Show("User already exists with the provided Email or Passport/ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return; // Exit the method
                                }
                            }
                            lineRec = reader.ReadLine(); // Move to the next line
                        }
                    }
                }

                // Append new customer data
                using (StreamWriter writer = new StreamWriter(FilePath, true)) // 'true' to append data
                {
                    // Write headers if the file is new or empty
                    if (new FileInfo(FilePath).Length == 0)
                    {
                        writer.WriteLine("Name\tSurname\tEmail\tPassport/ID\tPassword");
                    }

                    // Write the new customer data, separated by tabs
                    writer.WriteLine("\n" + name + "\t" + surname + "\t" + email + "\t" + passportID + "\t" + password);
                }

                MessageBox.Show("Account created and saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear the textboxes
                txtName.Clear();
                txtSurname.Clear();
                txtEmail.Clear();
                txtPassportID.Clear();
                txtPassword.Clear();
                txtConfirmPassword.Clear();
            }
            catch (Exception ex)
            {
                // Handle any errors that may occur
                MessageBox.Show("An error occurred while saving the information: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }

        private void lblPasswordStrength_Click(object sender, EventArgs e)
        {
            lblPasswordStrength.Visible = false;
        }
    }
}
