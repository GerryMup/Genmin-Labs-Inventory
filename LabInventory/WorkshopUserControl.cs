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
    public partial class WorkshopUserControl : UserControl
    {

        private static WorkshopUserControl _instance;

        public static WorkshopUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new WorkshopUserControl();
                }
                return _instance;
            }
        }


        public WorkshopUserControl()
        {
            InitializeComponent();
        }
    }
}
