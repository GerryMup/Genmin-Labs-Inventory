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
    public partial class StroboScopesUserControl : UserControl
    {

        private static StroboScopesUserControl _instance;

        public static StroboScopesUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new StroboScopesUserControl();
                }
                return _instance;
            }
        }

        public StroboScopesUserControl()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (!StroboScopesUserControl.Instance.Controls.ContainsKey("InstrumentsUserControl"))
            {
                InstrumentsUserControl _instruments = new InstrumentsUserControl();
                _instruments.Dock = DockStyle.Fill;
                InstrumentsUserControl.Instance.Controls.Add(_instruments);
            }
            InstrumentsUserControl.Instance.Controls["InstrumentsUserControl"].BringToFront();
        }
    }
}
