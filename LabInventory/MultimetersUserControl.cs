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
    public partial class MultimetersUserControl : UserControl
    {

        private static MultimetersUserControl _instance;

        public static MultimetersUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MultimetersUserControl();
                }
                return _instance;
            }
        }

        public MultimetersUserControl()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (!MultimetersUserControl.Instance.Controls.ContainsKey("InstrumentsUserControl"))
            {
                InstrumentsUserControl _tools = new InstrumentsUserControl();
                _tools.Dock = DockStyle.Fill;
                InstrumentsUserControl.Instance.Controls.Add(_tools);
            }
            InstrumentsUserControl.Instance.Controls["InstrumentsUserControl"].BringToFront();
        }
    }
}
