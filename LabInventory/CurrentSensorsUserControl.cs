﻿using System;
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
    public partial class CurrentSensorsUserControl : UserControl
    {
        private static CurrentSensorsUserControl _instance;

        public static CurrentSensorsUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CurrentSensorsUserControl();
                }
                return _instance;
            }
        }

        public CurrentSensorsUserControl()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (!CurrentSensorsUserControl.Instance.Controls.ContainsKey("InstrumentsUserControl"))
            {
                InstrumentsUserControl _tools = new InstrumentsUserControl();
                _tools.Dock = DockStyle.Fill;
                InstrumentsUserControl.Instance.Controls.Add(_tools);
            }
            InstrumentsUserControl.Instance.Controls["InstrumentsUserControl"].BringToFront();
        }
    }
}