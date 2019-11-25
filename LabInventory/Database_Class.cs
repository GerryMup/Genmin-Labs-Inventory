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
        //**********************************************************************************************************************************************************************

        public SqlConnection database_connection()
        {
            string connection_string = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\InventoryDB.mdf;Integrated Security=True";
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

        //***********************************************************************************************************************************************************************

        public string getLogins(string username)
        {
            string query = "select * from Logins where Name='"+ username +"'";

            SqlConnection connection = database_connection();
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adaptor = new SqlDataAdapter(cmd);
            SqlDataReader reader;
            string Password = "";
            int password_index = 2;

            try
            {
                cmd.Connection.Open();
                reader = cmd.ExecuteReader();
                reader.Read();
                Password = reader[password_index].ToString();
            }
            catch (Exception ex)
            {
                //throw (ex);
            }
            finally
            {
                connection.Close();
            }
            return Password;
        }    
        //***********************************************************************************************************************************************************************
        public void addItem(string [] _items)
        {
            string _verification_message = "Confirm that you want to add a new Item";
            if (MessageBox.Show(_verification_message, "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlConnection connection = database_connection();
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
        }

        //*************************************************************************************************************************************************************************

        public void deleteItem(int Item_ID, string verification_message)
        {

            if (MessageBox.Show(verification_message, "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                string query_string = "delete from Inventory where Item_ID='" + Item_ID + "'";
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

        //************************************************************************************************************************************************************************

        public void SelectItems(ref DataSet dataset, string category, string filter_string)
        {
            
            string query_string;
            if (filter_string == null)
            {
                query_string = "select * from Inventory where Category='" + category + "'";
            }
            else
            {
                //This query is used when the search box is used to filter ITEMS
                query_string = "select * from Inventory where Category='" + category + "' and Name LIKE '%" + filter_string + "%'";
            }

            SqlConnection connection = database_connection();
            SqlCommand cmd = new SqlCommand(query_string, connection);
            SqlDataAdapter adaptor = new SqlDataAdapter(cmd);

            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                adaptor.Fill(dataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid SQL operation: " + ex);
            }
            finally
            {
                connection.Close();
            }
        }
        //**********************************************************************************************************************************************************

        public void editItems(string Borrower, int Item_ID, string Availabilty)
        {
            Availabilty.ToLower();
            if ((Availabilty != "yes") || (Availabilty != "no"))
            {
                MessageBox.Show("The value for availability must be either 'Yes' or 'No'");
            }
            else if ((Availabilty == "no") && (Borrower == ""))
            {
                MessageBox.Show("Please specify the name of the person borrowing this item");
            }
            else
            {
                MessageBox.Show("Now editing");
            }
        }

    }
}
