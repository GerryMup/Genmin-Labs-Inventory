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

        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void AddNewItemButton_Click(object sender, EventArgs e)
        {
            Display_Manager _display_manager = new Display_Manager();

            string[] _items = { txtName.Text, txtDescription.Text, txtManufacturer.Text, "PowerTools", txtNumber.Text, txtAvailable.Text, txtCondition.Text, txtLocation.Text };
            string[] _entries = _display_manager.Validate_Entries(_items);

            if (_entries != null)
            {
                //Load entries into the database
                Database_Class database_access = new Database_Class();
                database_access.addItem(_items);
                refresh_dataGridView(); // Refresh the viewed data after you finish adding an item
            }
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (PowerToolsGrid.SelectedCells.Count > 0)
            {
                Display_Manager _display_manager = new Display_Manager();

                string _verification_message = _display_manager.Delete_Verification_Message(PowerToolsGrid);
                int Item_ID = _display_manager.get_Item_ID(PowerToolsGrid);

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
