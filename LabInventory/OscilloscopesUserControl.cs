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

    public partial class OscilloscopesUserControl : UserControl
    {
        private static OscilloscopesUserControl _instance;

        public static OscilloscopesUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new OscilloscopesUserControl();
                }
                return _instance;
            }
        }


        public OscilloscopesUserControl()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (!OscilloscopesUserControl.Instance.Controls.ContainsKey("InstrumentsUserControl"))
            {
                InstrumentsUserControl _tools = new InstrumentsUserControl();
                _tools.Dock = DockStyle.Fill;
                InstrumentsUserControl.Instance.Controls.Add(_tools);
            }
            InstrumentsUserControl.Instance.Controls["InstrumentsUserControl"].BringToFront();
        }
    }
}
