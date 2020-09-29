using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P4_Code;

namespace P4_Code
{
    public partial class FormLogin : Form
    {
        FakeAppUserRepository userDatabase = new FakeAppUserRepository();
        public AppUser user;
        public bool IsOpen = false;
        public bool IsAuthenticated = false;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void UserNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            String userName = UserNameTextBox.Text;
            String password = PasswordTextBox.Text;

            // Successful Authentication
            if (userDatabase.Login(userName, password))
            {
                userDatabase.SetAuthentication(userName, true);
                user = userDatabase.GetByUserName(userName);
                IsAuthenticated = true;
                this.Close();
            }
            // Failure to Authenticate
            else
            {
                MessageBox.Show("Incorrect Username or Password.", "Attention");
                UserNameTextBox.Clear();
                PasswordTextBox.Clear();

            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            IsOpen = true;
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            IsOpen = false;
        }
    }
}
