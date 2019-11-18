using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabInventory
{
    public partial class EquipmentUserControl : UserControl
    {
        private static EquipmentUserControl _instance;

        public static EquipmentUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EquipmentUserControl();
                }
                return _instance;
            }
        }


        public EquipmentUserControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
