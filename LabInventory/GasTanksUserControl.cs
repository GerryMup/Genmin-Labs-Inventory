﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using parentClass = LabInventory.EquipmentUserControl;

namespace LabInventory
{
    public partial class GasTanksUserControl : UserControl
    {

        const string CATEGORY = "GasTanks";
        const string PARENT_USER_CONTROL = "EquipmentUserControl"; 

        private static GasTanksUserControl _instance;

        public static GasTanksUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GasTanksUserControl();
                }
                return _instance;
            }
        }

        public GasTanksUserControl()
        {
            InitializeComponent();
        }

        //*********************************************************************************************

        private DataGridView thisGridView()
        {
            return GasTanksGrid;
        }

        //*******************************************************************************************

        public void refresh_dataGridView()
        {
            Display_Manager display_manager = new Display_Manager();
            string filter_string = null;
            display_manager.Refresh(thisGridView(), CATEGORY, filter_string);
        }

        //*******************************************************************************************

        private void GasTanksUserControl_Load(object sender, EventArgs e)
        {
            refresh_dataGridView();
        }

        //*******************************************************************************************

        private void btnBack_Click(object sender, EventArgs e)
        {
            refresh_dataGridView();

            //Manually invoke the clearing event to clear all the search fields.
            btnClear_Click(sender, e);

            if (!Controls.ContainsKey(PARENT_USER_CONTROL))
            {
                parentClass obj = new parentClass();
                obj.Dock = DockStyle.Fill;
                parentClass.Instance.Controls.Add(obj);
            }

            parentClass.Instance.Controls[PARENT_USER_CONTROL].BringToFront();
        }

        //********************************************************************************************

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Display_Manager display_manager = new Display_Manager();
            string category = CATEGORY;
            string filter_string = txtSearch.Text;
            display_manager.Refresh(thisGridView(), category, filter_string);
        }

        //*********************************************************************************************

        private void AddNewButton_Click(object sender, EventArgs e)
        {
            Display_Manager _display_manager = new Display_Manager();

            string[] _items = { txtName.Text, txtDescription.Text, txtManufacturer.Text, CATEGORY, txtNumber.Text, CB_Available.Text, txtCondition.Text, txtLocation.Text };
            string[] _entries = _display_manager.Validate_Entries(_items);

            if (_entries != null)
            {
                //Load entries into the database
                Database_Class database_access = new Database_Class();

                database_access.addItem(_items);
                refresh_dataGridView(); // Refresh the viewed data after you finish adding an item
            }
        }

        //****************************************************************************************
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh_dataGridView();
        }

        //*******************************************************************************************

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (thisGridView().SelectedCells.Count > 0)
            {
                Display_Manager _display_manager = new Display_Manager();

                string _verification_message = _display_manager.Delete_Verification_Message(thisGridView());
                int Item_ID = _display_manager.get_Item_ID(thisGridView());

                Database_Class database_access = new Database_Class();
                database_access.deleteItem(Item_ID, _verification_message);
                refresh_dataGridView();
            }
        }

        //*******************************************************************************************

        private void btnClear_Click(object sender, EventArgs e)
        {
            Display_Manager _display_manager = new Display_Manager();
            _display_manager.ClearInsertionFields(this);
        }


    }
}
