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
    class Display_Manager
    {
        public string Delete_Verification_Message(DataGridView grid)
        {
            string _item_name = grid.CurrentRow.Cells[1].Value.ToString();
            string _number = grid.CurrentRow.Cells[5].Value.ToString();
            return "Confirm Deletion of Item: " + _item_name + ", With the Number: " + _number;
        }

        public int get_Item_ID(DataGridView grid)
        {
            int item_ID = Convert.ToInt32(grid.CurrentRow.Cells[0].Value.ToString());
            return item_ID;
        }
    }
}
