using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Npgsql;

namespace LabInventory
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void login()
        {
            Database_Class database = new Database_Class();
            string password = database.getLogins(UsernameField.Text);

            String entered_name = UsernameField.Text;
            String entered_pass = PasswordField.Text;

            if ((entered_name == "") || (entered_pass == ""))
            {
                IncorrectCredentials.Show();
            }
            else if (password.Equals(entered_pass))
            {
                //You may login
                //Hide the incorrect credentials message box
                IncorrectCredentials.Hide();
                //Create and show the main menu when login is successful
                Main_Menu _mainMenu = new Main_Menu();
                Hide();
                _mainMenu.Show();
            }
            else
            {
                //You may not login. Incorrect Credentials        
                IncorrectCredentials.Show();
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            login();
        }

        private void PasswordField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                login();
            }
        }
    }
}
