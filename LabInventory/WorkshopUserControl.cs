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
    public partial class WorkshopUserControl : UserControl
    {

        private static WorkshopUserControl _instance;

        public static WorkshopUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new WorkshopUserControl();
                }
                return _instance;
            }
        }


        public WorkshopUserControl()
        {
            InitializeComponent();
        }

        private void btnFixedMachines_Click(object sender, EventArgs e)
        {
            if (!WorkshopUserControl.Instance.Controls.ContainsKey("FixedMachinesUserControl"))
            {
                FixedMachinesUserControl _fixedMachines = new FixedMachinesUserControl();
                _fixedMachines.Dock = DockStyle.Fill;
                WorkshopUserControl.Instance.Controls.Add(_fixedMachines);
            }
            WorkshopUserControl.Instance.Controls["FixedMachinesUserControl"].BringToFront();
        }

        private void btnMobileMachines_Click(object sender, EventArgs e)
        {
            if (!WorkshopUserControl.Instance.Controls.ContainsKey("MobileMachinesUserControl"))
            {
                MobileMachinesUserControl _fixedMachines = new MobileMachinesUserControl();
                _fixedMachines.Dock = DockStyle.Fill;
                WorkshopUserControl.Instance.Controls.Add(_fixedMachines);
            }
            WorkshopUserControl.Instance.Controls["MobileMachinesUserControl"].BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
