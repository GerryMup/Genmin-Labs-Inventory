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
    public partial class ElectronicToolsUserControl : UserControl
    {

        private static ElectronicToolsUserControl _instance;

        public static ElectronicToolsUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ElectronicToolsUserControl();
                }
                return _instance;
            }
        }

        public ElectronicToolsUserControl()
        {
            InitializeComponent();
        }

        // Button for going back
        private void button14_Click(object sender, EventArgs e)
        {
            if (!ElectronicToolsUserControl.Instance.Controls.ContainsKey("ToolsUserControl"))
            {
                ToolsUserControl _tools = new ToolsUserControl();
                _tools.Dock = DockStyle.Fill;
                ToolsUserControl.Instance.Controls.Add(_tools);
            }
            ToolsUserControl.Instance.Controls["ToolsUserControl"].BringToFront();
        }
    }
}
