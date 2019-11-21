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

    public partial class ToolsUserControl : UserControl
    {
        private static ToolsUserControl _instance;

        public static ToolsUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ToolsUserControl();
                }
                return _instance;
            }
        }

        public ToolsUserControl()
        {
            InitializeComponent();
        }

        private void PowerToolsButton_Click(object sender, EventArgs e)
        {
            //Show the power tools tab
            if (!ToolsUserControl.Instance.Controls.ContainsKey("PowerToolsUserControl"))
            {
                PowerToolsUserControl _powerTools = new PowerToolsUserControl();
                _powerTools.Dock = DockStyle.Fill;
                ToolsUserControl.Instance.Controls.Add(_powerTools);
                _powerTools.refresh_dataGridView();
            }
            ToolsUserControl.Instance.Controls["PowerToolsUserControl"].BringToFront();
        }

        private void ElectronicToolsButton_Click(object sender, EventArgs e)
        {
            //Show the electronic tools tab
            if (!ToolsUserControl.Instance.Controls.ContainsKey("ElectronicToolsUserControl"))
            {
                ElectronicToolsUserControl _electronicTools = new ElectronicToolsUserControl();
                _electronicTools.Dock = DockStyle.Fill;
                ToolsUserControl.Instance.Controls.Add(_electronicTools);
                _electronicTools.refresh_dataGridView();
            }
            ToolsUserControl.Instance.Controls["ElectronicToolsUserControl"].BringToFront();
        }

        private void ToolsUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
