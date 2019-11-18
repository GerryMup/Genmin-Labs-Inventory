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

        //Make a connection to the SQL Database
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database1.mdf\";Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader reader;

       private string getLogins(String _name)
        {
            //Function for getting data from the database
                       connection.Open();
                       String queryString = "SELECT * FROM LoginCredentials WHERE Name = '" + _name + "'";
                       cmd = new SqlCommand(queryString, connection);
                       reader = cmd.ExecuteReader();
                       reader.Read();
                       string _data = "";

                        try
                        {
                            _data = "" + reader[1].ToString();
                        }
                        catch (Exception e)
                        {
                           // MessageBox.Show(e.Message);
                        }
            
                       connection.Close();
                       return _data;
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
                MessageBox.Show("Login Successful");
            }
            else
            {
                //You may not login. Incorrect Credentials        
                IncorrectCredentials.Show();
            }
        }
    }
}
