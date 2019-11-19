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
    public partial class InstrumentsUserControl : UserControl
    {

        private static InstrumentsUserControl _instance;

        public static InstrumentsUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new InstrumentsUserControl();
                }
                return _instance;
            }
        }


        public InstrumentsUserControl()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void InstrumentsUserControl_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// 
        private void OscilloscopesButton_Click_1(object sender, EventArgs e)
        {
            if (!ToolsUserControl.Instance.Controls.ContainsKey("OscilloscopesUserControl"))
            {
                OscilloscopesUserControl _scopes = new OscilloscopesUserControl();
                _scopes.Dock = DockStyle.Fill;
                InstrumentsUserControl.Instance.Controls.Add(_scopes);
            }
            InstrumentsUserControl.Instance.Controls["OscilloscopesUserControl"].BringToFront();
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void MultimetersButton_Click_1(object sender, EventArgs e)
        {
            if (!ToolsUserControl.Instance.Controls.ContainsKey("MultimetersUserControl"))
            {
                MultimetersUserControl _multimeters = new MultimetersUserControl();
                _multimeters.Dock = DockStyle.Fill;
                InstrumentsUserControl.Instance.Controls.Add(_multimeters);
            }
            InstrumentsUserControl.Instance.Controls["MultimetersUserControl"].BringToFront();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void ClampMetersButton_Click_1(object sender, EventArgs e)
        {
            if (!ToolsUserControl.Instance.Controls.ContainsKey("ClampMetersUserControl"))
            {
                ClampMetersUserControl _clamps = new ClampMetersUserControl();
                _clamps.Dock = DockStyle.Fill;
                InstrumentsUserControl.Instance.Controls.Add(_clamps);
            }
            InstrumentsUserControl.Instance.Controls["ClampMetersUserControl"].BringToFront();
        }

        private void CurrentSensorsButton_Click(object sender, EventArgs e)
        {
            if (!ToolsUserControl.Instance.Controls.ContainsKey("CurrentSensorsUserControl"))
            {
                CurrentSensorsUserControl _currentSensors = new CurrentSensorsUserControl();
                _currentSensors.Dock = DockStyle.Fill;
                InstrumentsUserControl.Instance.Controls.Add(_currentSensors);
            }
            InstrumentsUserControl.Instance.Controls["CurrentSensorsUserControl"].BringToFront();
        }

        private void StroboScopesButton_Click(object sender, EventArgs e)
        {
            if (!ToolsUserControl.Instance.Controls.ContainsKey("StroboScopesUserControl"))
            {
                StroboScopesUserControl _strobos = new StroboScopesUserControl();
                _strobos.Dock = DockStyle.Fill;
                InstrumentsUserControl.Instance.Controls.Add(_strobos);
            }
            InstrumentsUserControl.Instance.Controls["StroboScopesUserControl"].BringToFront();
        }

        private void btnThermometers_Click(object sender, EventArgs e)
        {
            if (!ToolsUserControl.Instance.Controls.ContainsKey("ThermometersUserControl"))
            {
                ThermometersUserControl _thermos = new ThermometersUserControl();
                _thermos.Dock = DockStyle.Fill;
                InstrumentsUserControl.Instance.Controls.Add(_thermos);
            }
            InstrumentsUserControl.Instance.Controls["ThermometersUserControl"].BringToFront();
        }
    }
}
