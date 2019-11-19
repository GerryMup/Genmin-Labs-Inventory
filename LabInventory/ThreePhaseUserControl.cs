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
    public partial class ThreePhaseUserControl : UserControl
    {

        private static ThreePhaseUserControl _instance;

        public static ThreePhaseUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ThreePhaseUserControl();
                }
                return _instance;
            }
        }

        public ThreePhaseUserControl()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (!ThreePhaseUserControl.Instance.Controls.ContainsKey("EquipmentUserControl"))
            {
                EquipmentUserControl _equipment = new EquipmentUserControl();
                _equipment.Dock = DockStyle.Fill;
                EquipmentUserControl.Instance.Controls.Add(_equipment);
            }
            EquipmentUserControl.Instance.Controls["EquipmentUserControl"].BringToFront();
        }
    }
}
