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

        //Inialize 
        public MultimetersUserControl()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (!MultimetersUserControl.Instance.Controls.ContainsKey("InstrumentsUserControl"))
            {
                InstrumentsUserControl _instruments = new InstrumentsUserControl();
                _instruments.Dock = DockStyle.Fill;
                InstrumentsUserControl.Instance.Controls.Add(_instruments);
            }
            InstrumentsUserControl.Instance.Controls["InstrumentsUserControl"].BringToFront();
        }

        private void MultimetersUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
