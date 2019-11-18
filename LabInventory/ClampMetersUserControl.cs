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
    public partial class ClampMetersUserControl : UserControl
    {

        private static ClampMetersUserControl _instance;

        public static ClampMetersUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ClampMetersUserControl();
                }
                return _instance;
            }
        }
        
        //Initialize 
        public ClampMetersUserControl()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (!ClampMetersUserControl.Instance.Controls.ContainsKey("InstrumentsUserControl"))
            {
                InstrumentsUserControl _tools = new InstrumentsUserControl();
                _tools.Dock = DockStyle.Fill;
                InstrumentsUserControl.Instance.Controls.Add(_tools);
            }
            InstrumentsUserControl.Instance.Controls["InstrumentsUserControl"].BringToFront();
        }
    }
}
