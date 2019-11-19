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
    public partial class ExtinguiashersUserControl : UserControl
    {
        private static ExtinguiashersUserControl _instance;

        public static ExtinguiashersUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ExtinguiashersUserControl();
                }
                return _instance;
            }
        }

        public ExtinguiashersUserControl()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (!ExtinguiashersUserControl.Instance.Controls.ContainsKey("EquipmentUserControl"))
            {
                EquipmentUserControl _equipment = new EquipmentUserControl();
                _equipment.Dock = DockStyle.Fill;
                EquipmentUserControl.Instance.Controls.Add(_equipment);
            }
            EquipmentUserControl.Instance.Controls["EquipmentUserControl"].BringToFront();
        }
    }
}
