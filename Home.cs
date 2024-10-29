using System;
using System.Windows.Forms;

namespace AirOps_Login
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCreateAccount frmCreateAccount = new frmCreateAccount();
            this.Hide();
            frmCreateAccount.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Hide();
            login.Show();
        }

        private void linkFlight_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSearchFlights searchFlights = new FrmSearchFlights();
            this.Hide();
            searchFlights.Show();
        }
    }
}
