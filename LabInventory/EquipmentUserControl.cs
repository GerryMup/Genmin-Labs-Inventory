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
    public partial class EquipmentUserControl : UserControl
    {
        private static EquipmentUserControl _instance;

        public static EquipmentUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EquipmentUserControl();
                }
                return _instance;
            }
        }


        public EquipmentUserControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnDCMotors_Click(object sender, EventArgs e)
        {
            if (!EquipmentUserControl.Instance.Controls.ContainsKey("DCMotorsUserControl"))
            {
                DCMotorsUserControl _equip = new DCMotorsUserControl();
                _equip.Dock = DockStyle.Fill;
                EquipmentUserControl.Instance.Controls.Add(_equip);
            }
            EquipmentUserControl.Instance.Controls["DCMotorsUserControl"].BringToFront();
        }

        private void btnSinglePhase_Click(object sender, EventArgs e)
        {
            if (!EquipmentUserControl.Instance.Controls.ContainsKey("SinglePhaseUserControl"))
            {
                SinglePhaseUserControl _equip = new SinglePhaseUserControl();
                _equip.Dock = DockStyle.Fill;
                EquipmentUserControl.Instance.Controls.Add(_equip);
            }
            EquipmentUserControl.Instance.Controls["SinglePhaseUserControl"].BringToFront();
        }

        private void btnThreePhase_Click(object sender, EventArgs e)
        {
            if (!EquipmentUserControl.Instance.Controls.ContainsKey("ThreePhaseUserControl"))
            {
                ThreePhaseUserControl _equip = new ThreePhaseUserControl();
                _equip.Dock = DockStyle.Fill;
                EquipmentUserControl.Instance.Controls.Add(_equip);
            }
            EquipmentUserControl.Instance.Controls["ThreePhaseUserControl"].BringToFront();
        }
    }
}
