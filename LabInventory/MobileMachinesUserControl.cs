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
    public partial class MobileMachinesUserControl : UserControl
    {
        private static MobileMachinesUserControl _instance;

        public static MobileMachinesUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MobileMachinesUserControl();
                }
                return _instance;
            }
        }


        public MobileMachinesUserControl()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (!MobileMachinesUserControl.Instance.Controls.ContainsKey("WorkshopUserControl"))
            {
                WorkshopUserControl _workshop = new WorkshopUserControl();
                _workshop.Dock = DockStyle.Fill;
                WorkshopUserControl.Instance.Controls.Add(_workshop);
            }
            WorkshopUserControl.Instance.Controls["WorkshopUserControl"].BringToFront();
        }
    }
}
