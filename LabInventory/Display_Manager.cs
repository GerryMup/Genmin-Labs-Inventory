﻿using System;
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
    class Display_Manager
    {
        public string Delete_Verification_Message(DataGridView grid)
        {
            string _item_name = grid.CurrentRow.Cells[1].Value.ToString();
            string _number = grid.CurrentRow.Cells[5].Value.ToString();
            return "Confirm Deletion of Item: " + _item_name + ", With the Number: " + _number;
        }

        //**************************************************************************************************************************************************************************

        public int get_Item_ID(DataGridView grid)
        {
            int item_ID = Convert.ToInt32(grid.CurrentRow.Cells[0].Value.ToString());
            return item_ID;
        }

        //***************************************************************************************************************************************************************************

        public string[] Validate_Entries(string[] _items)
        {
            //Make sure the user does not try to add items where there are empty fields
            _items[5] = _items[5].ToLower();
            if ((_items[0] == "") || (_items[1] == "") || (_items[2] == "") || (_items[3] == "") || (_items[4] == "") || (_items[5] == "") || (_items[6] == ""))
            {
                MessageBox.Show("Please ensure that there are no empty fields");
                string[] result = null;
                return result;
            }
            else if ((_items[5].Length > 3))
            {
                MessageBox.Show("The value for 'Available' should be either Yes or No!");
                string[] result = null;
                return result;
            }
            else if ((_items[5] == "yes") || (_items[5] == "no"))
            {
                return _items;
            }
            else
            {
                MessageBox.Show("The value for 'Available' should be either Yes or No!");
                string[] result = null;
                return result;
            }
        }

        //*******************************************************************************************************************************************************************************

        public void Refresh(DataGridView grid, string category, string filter_string)
        {
            Database_Class database_access = new Database_Class();
            DataSet dataset = new DataSet();

            database_access.SelectItems(ref dataset, category, filter_string);
                
            //Chosing the data to be displayed in the Grid View on the Screen
            grid.DataSource = dataset.Tables[0];

            //Making sure that the data grid view uses up all the space avaibale on the screen
            grid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            grid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            grid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //Hide the Item_ID and the Category from the grid view
            grid.Columns["Item_ID"].Visible = false;
            grid.Columns["Category"].Visible = false;

            // Control The Edit Previlleges
            // Columns 6 and 9 are: Item Availability and Borrower
            // These columns need to ne editable
            grid.ReadOnly = false;
            grid.Columns[1].ReadOnly = true;
            grid.Columns[2].ReadOnly = true;
            grid.Columns[3].ReadOnly = true;
            grid.Columns[4].ReadOnly = true;
            grid.Columns[5].ReadOnly = true;
            grid.Columns[7].ReadOnly = true;
            grid.Columns[8].ReadOnly = true;
            grid.EditMode = DataGridViewEditMode.EditOnEnter;
        }

        //******************************************************************************************************************************************************************************

        public void ClearInsertionFields(Control control)
        {
            foreach (Control _control in control.Controls)
            {
                if (_control.GetType() == typeof(TextBox))
                {
                    _control.Text = String.Empty;
                }
            }
        }

        //*************************************************************************************************************************************************************************

        public void FilterGridView(DataGridView grid, string _name)
        {
            (grid.DataSource as DataTable).DefaultView.RowFilter = string.Format("Name = '%{0}%'", _name);
        }
    }
}
