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
    public partial class ThermometersUserControl : UserControl
    {

        private static ThermometersUserControl _instance;

        public static ThermometersUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ThermometersUserControl();
                }
                return _instance;
            }
        }

        public ThermometersUserControl()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (!ThermometersUserControl.Instance.Controls.ContainsKey("InstrumentsUserControl"))
            {
                InstrumentsUserControl _instruments = new InstrumentsUserControl();
                _instruments.Dock = DockStyle.Fill;
                InstrumentsUserControl.Instance.Controls.Add(_instruments);
            }
            InstrumentsUserControl.Instance.Controls["InstrumentsUserControl"].BringToFront();
        }
    }
}
