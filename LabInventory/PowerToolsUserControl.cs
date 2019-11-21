using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace LabInventory
{
    public partial class PowerToolsUserControl : UserControl
    {

        private static PowerToolsUserControl _instance;

        public static PowerToolsUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PowerToolsUserControl();
                }
                return _instance;
            }
        }


        //Initialize the Power Tools Control
        public PowerToolsUserControl()
        {
            InitializeComponent();
        }

        //Make a connection to the SQL Database

        //SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");

        private void PowerToolsUserControl_Load(object sender, EventArgs e)
        {
            refresh_dataGridView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            refresh_dataGridView();
        }

        public void refresh_dataGridView()
        {

            //SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");

            //SqlConnection connection = LabInventory.Program.main_menu_object.datatbase_connection();
            //SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");
            try
            {
                SqlConnection connection = LabInventory.Program.main_menu_object.datatbase_connection();
                string query_string = "select * from Inventory where Category='PowerTools'";
                SqlCommand cmd = new SqlCommand(query_string, connection);

                SqlDataAdapter adaptor = new SqlDataAdapter(cmd);
                DataSet dataset = new DataSet(); //Data set for filling in the data in the Grid View
                adaptor.Fill(dataset);

                connection.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid SQL operation: " + ex);
                }
                connection.Close();

                //Chosing the data to be displayed in the Grid View on the Screen
                PowerToolsGrid.DataSource = dataset.Tables[0];

                //Making sure that the data grid view uses up all the space avaibale on the screen
                PowerToolsGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                PowerToolsGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                PowerToolsGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                PowerToolsGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                PowerToolsGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                PowerToolsGrid.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }


        //Adding new power items to the database
        private void AddNewItemButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = LabInventory.Program.main_menu_object.datatbase_connection();
            //Make sure the user does not try to add items where there are empty fields
            if ((txtName.Text == "") || (txtDescription.Text == "") || (txtManufacturer.Text == "") ||
               (txtNumber.Text == "") || (txtCondition.Text == "") ||
                (txtAvailable.Text == "") || (txtLocation.Text == ""))
            {
                MessageBox.Show("Please ensure that there are no empty fields");
            }
            else if ((txtAvailable.TextLength > 3))
            {
                MessageBox.Show("The value for 'Available' should be either Yes or No!");
            }
            else if ((txtAvailable.Text == "Yes") || (txtAvailable.Text == "No"))
            {
                string[] _items = { txtName.Text, txtDescription.Text, txtManufacturer.Text, "PowerTools", txtNumber.Text, txtAvailable.Text, txtCondition.Text, txtLocation.Text };

                //Fecth the contents from the entered text fields

                Database_Class database_access = new Database_Class();
                database_access.addItem(_items);
                refresh_dataGridView(); // Refresh the viewed data after you finish adding an item
            }
            else
            {
                MessageBox.Show("The value for 'Available' should be either Yes or No!");
            }
           

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (PowerToolsGrid.SelectedCells.Count > 0)
            {
                string _item_name = PowerToolsGrid.CurrentRow.Cells[1].Value.ToString();
                string _number = PowerToolsGrid.CurrentRow.Cells[5].Value.ToString();
                int Item_ID = Convert.ToInt32(PowerToolsGrid.CurrentRow.Cells[0].Value.ToString());
                string _verification_message = LabInventory.Program.main_menu_object.delete_verication_message(_item_name, _number);

                if (MessageBox.Show(_verification_message, "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Database_Class database_access = new Database_Class();
                    database_access.deleteItem(Item_ID);
                    refresh_dataGridView();
                }
                else
                {
                    MessageBox.Show("Do Nothing");
                }
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (!PowerToolsUserControl.Instance.Controls.ContainsKey("ToolsUserControl"))
            {
                ToolsUserControl _tools = new ToolsUserControl();
                _tools.Dock = DockStyle.Fill;
                ToolsUserControl.Instance.Controls.Add(_tools);
            }
            ToolsUserControl.Instance.Controls["ToolsUserControl"].BringToFront();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
    }
}
