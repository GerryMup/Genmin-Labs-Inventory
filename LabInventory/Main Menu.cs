using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace LabInventory
{
    public partial class Main_Menu : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        LabInventory.Main_Menu obj;
        public Main_Menu()
        {
            InitializeComponent();
            // Start with the expanded panel
            isSlidingPanelExpanded = true;
            expandedPanel();

            obj = this;
            WindowState = FormWindowState.Maximized;
            
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Close the system with this exit button
            Environment.Exit(0);
        }

        private void btnMinMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                LabInventory.Program.main_menu_object.Size = new Size(600, 1200);
            }
            else
            {
                MessageBox.Show("Dimentions " +this.Height + " " +this.Width);
                WindowState = FormWindowState.Maximized;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LoginForm _loginForm = new LoginForm();
            Hide();
            _loginForm.Show();
        }

        private void MainMenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainMenuPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        //What shows when the sliding panel is expanded
        public void expandedPanel()
        {
            //Show all the text and hide all the images
            ToolsButton.Text = "Tools";
            InstrumentsButton.Text = "Instruments";
            EquipmentButton.Text = "Equipment";
            WorkshopButton.Text = "Workshop";

            PanelToggler.ImageAlign = ContentAlignment.MiddleCenter;
            PanelToggler.Image = Properties.Resources.leftArrow;
            ToolsButton.Image = null;
            InstrumentsButton.Image = null;
            EquipmentButton.Image = null;
            WorkshopButton.Image = null;
        }

        //What shows when the sliding panel is retracted
        public void retractedPanel()
        {
            //Hide all the text but show all the images
            ToolsButton.Text = "";
            InstrumentsButton.Text = "";
            EquipmentButton.Text = "";
            WorkshopButton.Text = "";

            PanelToggler.ImageAlign = ContentAlignment.MiddleLeft;
            PanelToggler.Image = Properties.Resources.rightArrow;
            ToolsButton.Image = Properties.Resources.Tools;
            InstrumentsButton.Image = Properties.Resources.Vernier;
            EquipmentButton.Image = Properties.Resources.LightBulb;
            WorkshopButton.Image = Properties.Resources.WeirdMachine;
        }

        //Sliding panel behavior
        bool isSlidingPanelExpanded = true;
        const int MaxSliderWidth = 200;
        const int MinSliderWidth = 60;

        private void PanelToggler_Click(object sender, EventArgs e)
        {
            if (isSlidingPanelExpanded)
            {
                //We are going to the retracted panel now
                
            }
            else
            {
                //We are going to the expanded panel now
                
            }
            SlidingPanelTimer.Start();
        }

        private void SlidingPanelTimer_Tick(object sender, EventArgs e)
        {
            if (isSlidingPanelExpanded)
            {
                //Retract the panel
                
                TogglePanel.Width -= 20;
                if (TogglePanel.Width <= MinSliderWidth)
                {
                    //Stop retracting
                    isSlidingPanelExpanded = false;
                    SlidingPanelTimer.Stop();
                    retractedPanel();
                    Refresh();

                }

            }
            else
            {
                //Expand the panel
                TogglePanel.Width += 20;
                if (TogglePanel.Width >= MaxSliderWidth)
                {
                    //Stop expanding
                    isSlidingPanelExpanded = true;
                    SlidingPanelTimer.Stop();
                    expandedPanel();
                    Refresh();

                }
            }

        }

        private void ToolsButton_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(ToolsUserControl.Instance))
            {
                ContentPanel.Controls.Add(ToolsUserControl.Instance);
                ToolsUserControl.Instance.Dock = DockStyle.Fill;
                ToolsUserControl.Instance.BringToFront();
            }
            else
            {
                ToolsUserControl.Instance.BringToFront();
            }
        }

        private void InstrumentsButton_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(InstrumentsUserControl.Instance))
            {
                ContentPanel.Controls.Add(InstrumentsUserControl.Instance);
                InstrumentsUserControl.Instance.Dock = DockStyle.Fill;
                InstrumentsUserControl.Instance.BringToFront();
            }
            else
            {
                InstrumentsUserControl.Instance.BringToFront();
            }

        }

        private void EquipmentButton_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(EquipmentUserControl.Instance))
            {
                ContentPanel.Controls.Add(EquipmentUserControl.Instance);
                EquipmentUserControl.Instance.Dock = DockStyle.Fill;
                EquipmentUserControl.Instance.BringToFront();
            }
            else
            {
                EquipmentUserControl.Instance.BringToFront();
            }
        }

        private void WorkshopButton_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(WorkshopUserControl.Instance))
            {
                ContentPanel.Controls.Add(WorkshopUserControl.Instance);
                WorkshopUserControl.Instance.Dock = DockStyle.Fill;
                WorkshopUserControl.Instance.BringToFront();
            }
            else
            {
                WorkshopUserControl.Instance.BringToFront();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
