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
    public partial class GeneratorsUserControl : UserControl
    {

        private static GeneratorsUserControl _instance;

        public static GeneratorsUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GeneratorsUserControl();
                }
                return _instance;
            }
        }

        public GeneratorsUserControl()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (!GeneratorsUserControl.Instance.Controls.ContainsKey("EquipmentUserControl"))
            {
                EquipmentUserControl _equipment = new EquipmentUserControl();
                _equipment.Dock = DockStyle.Fill;
                EquipmentUserControl.Instance.Controls.Add(_equipment);
            }
            EquipmentUserControl.Instance.Controls["EquipmentUserControl"].BringToFront();
        }
    }
}
