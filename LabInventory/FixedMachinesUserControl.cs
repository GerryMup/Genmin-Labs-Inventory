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
    public partial class FixedMachinesUserControl : UserControl
    {

        private static FixedMachinesUserControl _instance;

        public static FixedMachinesUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FixedMachinesUserControl();
                }
                return _instance;
            }
        }

        public FixedMachinesUserControl()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (!FixedMachinesUserControl.Instance.Controls.ContainsKey("WorkshopUserControl"))
            {
                WorkshopUserControl _equipment = new WorkshopUserControl();
                _equipment.Dock = DockStyle.Fill;
                WorkshopUserControl.Instance.Controls.Add(_equipment);
            }
            WorkshopUserControl.Instance.Controls["WorkshopUserControl"].BringToFront();
        }
    }
}
