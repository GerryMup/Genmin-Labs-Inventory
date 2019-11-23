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
            string child_user_control = "OscilloscopesUserControl";
            if (!Instance.Controls.ContainsKey(child_user_control))
            {
                OscilloscopesUserControl _scopes = new OscilloscopesUserControl();
                _scopes.Dock = DockStyle.Fill;
                Instance.Controls.Add(_scopes);
            }
            Instance.Controls[child_user_control].BringToFront();
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void MultimetersButton_Click_1(object sender, EventArgs e)
        {
            string child_user_control = "MultimetersUserControl";

            if (!Instance.Controls.ContainsKey(child_user_control))
            {
                MultimetersUserControl _multimeters = new MultimetersUserControl();
                _multimeters.Dock = DockStyle.Fill;
                Instance.Controls.Add(_multimeters);
            }
            Instance.Controls[child_user_control].BringToFront();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void ClampMetersButton_Click_1(object sender, EventArgs e)
        {
            string child_user_control = "ClampMetersUserControl";
            if (!Instance.Controls.ContainsKey(child_user_control))
            {
                ClampMetersUserControl _clamps = new ClampMetersUserControl();
                _clamps.Dock = DockStyle.Fill;
                Instance.Controls.Add(_clamps);
            }
            Instance.Controls[child_user_control].BringToFront();
        }

        //**********************************************************************************************************

        private void CurrentSensorsButton_Click(object sender, EventArgs e)
        {
            string child_user_control = "CurrentSensorsUserControl";
            if (!Instance.Controls.ContainsKey(child_user_control))
            {
                CurrentSensorsUserControl _currentSensors = new CurrentSensorsUserControl();
                _currentSensors.Dock = DockStyle.Fill;
                Instance.Controls.Add(_currentSensors);
            }
            Instance.Controls[child_user_control].BringToFront();
        }

        //**************************************************************************************************************

        private void StroboScopesButton_Click(object sender, EventArgs e)
        {
            string child_user_control = "StroboScopesUserControl";
            if (!Instance.Controls.ContainsKey(child_user_control))
            {
                StroboScopesUserControl _strobos = new StroboScopesUserControl();
                _strobos.Dock = DockStyle.Fill;
                Instance.Controls.Add(_strobos);
            }
            Instance.Controls[child_user_control].BringToFront();
        }

        //***************************************************************************************************************

        private void btnThermometers_Click(object sender, EventArgs e)
        {
            string child_user_control = "ThermometersUserControl";
            if (!Instance.Controls.ContainsKey(child_user_control))
            {
                ThermometersUserControl _thermos = new ThermometersUserControl();
                _thermos.Dock = DockStyle.Fill;
                Instance.Controls.Add(_thermos);
            }
            Instance.Controls[child_user_control].BringToFront();
        }

        //****************************************************************************************************************

        private void OtherInstrumentsButton_Click_1(object sender, EventArgs e)
        {
            string child_user_control = "OtherInstruments"; 
            if (!Instance.Controls.ContainsKey(child_user_control))
            {
                OtherInstruments _thermos = new OtherInstruments();
                _thermos.Dock = DockStyle.Fill;
                Instance.Controls.Add(_thermos);
            }
            Instance.Controls[child_user_control].BringToFront();
        }
    }
}
