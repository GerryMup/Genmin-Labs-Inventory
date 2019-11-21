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

        public void addItem(string [] _items)
        {
            SqlConnection connection = database_connection();
            MessageBox.Show("Now Attempting to Add");
            string query_string = "insert into Inventory(Name,Description,Manufacturer,Category,Number,Available,Condition,Location) values(@Name,@Description,@Manufacturer,@Category,@Number,@Available,@Condition,@Location)";
            SqlCommand cmd = new SqlCommand(query_string, connection);

            //Fecth the contents from the entered text fields
            cmd.Parameters.AddWithValue("@Name", _items[0]);
            cmd.Parameters.AddWithValue("@Description", _items[1]);
            cmd.Parameters.AddWithValue("@Manufacturer", _items[2]);
            cmd.Parameters.AddWithValue("@Category", _items[3]);
            cmd.Parameters.AddWithValue("@Number", _items[4]);
            cmd.Parameters.AddWithValue("@Available", _items[5]);
            cmd.Parameters.AddWithValue("@Condition", _items[6]);
            cmd.Parameters.AddWithValue("@Location", _items[7]);
            try
            {
                //Excecute the query
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid SQL Operation: " + ex);
            }
            finally
            {
                cmd.Connection.Close();
            }
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
