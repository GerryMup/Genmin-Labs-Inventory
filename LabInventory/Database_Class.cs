using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Configuration;

namespace LabInventory
{
    class Database_Class
    {

        public SqlConnection database_connection()
        {
            string connection_string = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(connection_string);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to make a database connection: " + ex.Message);
            }
            return connection;
        }


        public void deleteItem(int Item_ID)
        {
            string query_string = "delete from Inventory where Item_ID='"+ Item_ID +"'";
            SqlConnection _connection = database_connection();
            SqlCommand cmd = new SqlCommand(query_string, _connection);
            try
            {
                //Excecute the query
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid SQL Operation: " + ex.Message);
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
    }
}
