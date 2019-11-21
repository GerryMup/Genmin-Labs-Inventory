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

        //***************************************************************************************************************************************************************************

        //Initialize the Power Tools Control
        public PowerToolsUserControl()
        {
            InitializeComponent();
        }

        //***************************************************************************************************************************************************************************

        private void PowerToolsUserControl_Load(object sender, EventArgs e)
        {
            refresh_dataGridView();
        }

        //***************************************************************************************************************************************************************************

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh_dataGridView();
        }

        //***************************************************************************************************************************************************************************

        public void refresh_dataGridView()
        {
            Display_Manager display_manager = new Display_Manager();
            string category = "PowerTools";
            display_manager.Refresh(PowerToolsGrid, category);
        }

        //**************************************************************************************************************************************************************************

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

        //**************************************************************************************************************************************************************************

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (PowerToolsGrid.SelectedCells.Count > 0)
            {
                Display_Manager _display_manager = new Display_Manager();

                string _verification_message = _display_manager.Delete_Verification_Message(PowerToolsGrid);
                int Item_ID = _display_manager.get_Item_ID(PowerToolsGrid);

                Database_Class database_access = new Database_Class();
                database_access.deleteItem(Item_ID, _verification_message);
                refresh_dataGridView();
                
            }
        }

        //*************************************************************************************************************************************************************************

        private void btnClear_Click(object sender, EventArgs e)
        {
            Display_Manager _display_manager = new Display_Manager();
            _display_manager.ClearInsertionFields(this);
        }

        //*************************************************************************************************************************************************************************

        private void button6_Click(object sender, EventArgs e)
        {

        }

        //*************************************************************************************************************************************************************************

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (!PowerToolsUserControl.Instance.Controls.ContainsKey("ToolsUserControl"))
            {
                ToolsUserControl _tools = new ToolsUserControl();
                _tools.Dock = DockStyle.Fill;
                ToolsUserControl.Instance.Controls.Add(_tools);
            }
            ToolsUserControl.Instance.Controls["ToolsUserControl"].BringToFront();
        }

        //*************************************************************************************************************************************************************************

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtSearch.Text;
            Display_Manager _disp_manager = new Display_Manager();
            _disp_manager.FilterGridView(PowerToolsGrid, name);
        }
    }
}
