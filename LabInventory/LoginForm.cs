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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private string getLogins(String _name)
        {

            string connstring = String.Format("Server={0};Port={1};" +
            "User Id={2};Password={3};Database={4};",
            "PostgreSQL.school.eie.wits.ac.za", "5432", "inventory",
            "!inventory!", "inventory");

            string connection_string = "Server=146.141.16.251;Port=5432;User Id=inventory;Password=!inventory!;Database=inventory;";
            // Making connection with Npgsql provider
            NpgsqlConnection connection = new NpgsqlConnection(connection_string);

            try
            {
                //Try to open a connection
                connection.Open();
            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
            }
            finally
            {
                connection.Close();
            }
            return "Ronny";
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string password = getLogins(UsernameField.Text);

            String entered_name = UsernameField.Text;
            String entered_pass = PasswordField.Text;

            if (password.Equals(entered_pass))
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
    }
}
