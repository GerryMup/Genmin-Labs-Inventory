namespace LabInventory
{
    partial class Main_Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainMenuPanel = new System.Windows.Forms.Panel();
            this.TogglePanel = new System.Windows.Forms.Panel();
            this.SlidingPanelTimer = new System.Windows.Forms.Timer(this.components);
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.WorkshopButton = new System.Windows.Forms.Button();
            this.EquipmentButton = new System.Windows.Forms.Button();
            this.InstrumentsButton = new System.Windows.Forms.Button();
            this.ToolsButton = new System.Windows.Forms.Button();
            this.PanelToggler = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.MainMenuPanel.SuspendLayout();
            this.TogglePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuPanel
            // 
            this.MainMenuPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.MainMenuPanel.Controls.Add(this.button1);
            this.MainMenuPanel.Controls.Add(this.button8);
            this.MainMenuPanel.Controls.Add(this.button7);
            this.MainMenuPanel.Controls.Add(this.button6);
            this.MainMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MainMenuPanel.Name = "MainMenuPanel";
            this.MainMenuPanel.Size = new System.Drawing.Size(1200, 31);
            this.MainMenuPanel.TabIndex = 0;
            this.MainMenuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainMenuPanel_Paint);
            this.MainMenuPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainMenuPanel_MouseDown);
            // 
            // TogglePanel
            // 
            this.TogglePanel.BackColor = System.Drawing.Color.LightBlue;
            this.TogglePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TogglePanel.Controls.Add(this.WorkshopButton);
            this.TogglePanel.Controls.Add(this.EquipmentButton);
            this.TogglePanel.Controls.Add(this.InstrumentsButton);
            this.TogglePanel.Controls.Add(this.ToolsButton);
            this.TogglePanel.Controls.Add(this.PanelToggler);
            this.TogglePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TogglePanel.Location = new System.Drawing.Point(0, 31);
            this.TogglePanel.Name = "TogglePanel";
            this.TogglePanel.Size = new System.Drawing.Size(200, 569);
            this.TogglePanel.TabIndex = 2;
            // 
            // SlidingPanelTimer
            // 
            this.SlidingPanelTimer.Interval = 15;
            this.SlidingPanelTimer.Tick += new System.EventHandler(this.SlidingPanelTimer_Tick);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ContentPanel.Location = new System.Drawing.Point(200, 31);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(1000, 569);
            this.ContentPanel.TabIndex = 3;
            // 
            // WorkshopButton
            // 
            this.WorkshopButton.BackColor = System.Drawing.Color.Transparent;
            this.WorkshopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WorkshopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkshopButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.WorkshopButton.Image = global::LabInventory.Properties.Resources.WeirdMachine;
            this.WorkshopButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WorkshopButton.Location = new System.Drawing.Point(0, 277);
            this.WorkshopButton.Name = "WorkshopButton";
            this.WorkshopButton.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.WorkshopButton.Size = new System.Drawing.Size(200, 77);
            this.WorkshopButton.TabIndex = 5;
            this.WorkshopButton.Text = "Workshop";
            this.WorkshopButton.UseVisualStyleBackColor = false;
            this.WorkshopButton.Click += new System.EventHandler(this.WorkshopButton_Click);
            // 
            // EquipmentButton
            // 
            this.EquipmentButton.BackColor = System.Drawing.Color.Transparent;
            this.EquipmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EquipmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EquipmentButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.EquipmentButton.Image = global::LabInventory.Properties.Resources.LightBulb;
            this.EquipmentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EquipmentButton.Location = new System.Drawing.Point(0, 202);
            this.EquipmentButton.Name = "EquipmentButton";
            this.EquipmentButton.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.EquipmentButton.Size = new System.Drawing.Size(200, 77);
            this.EquipmentButton.TabIndex = 4;
            this.EquipmentButton.Text = "Equipment";
            this.EquipmentButton.UseVisualStyleBackColor = false;
            this.EquipmentButton.Click += new System.EventHandler(this.EquipmentButton_Click);
            // 
            // InstrumentsButton
            // 
            this.InstrumentsButton.BackColor = System.Drawing.Color.Transparent;
            this.InstrumentsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InstrumentsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstrumentsButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.InstrumentsButton.Image = global::LabInventory.Properties.Resources.Vernier;
            this.InstrumentsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InstrumentsButton.Location = new System.Drawing.Point(0, 127);
            this.InstrumentsButton.Name = "InstrumentsButton";
            this.InstrumentsButton.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.InstrumentsButton.Size = new System.Drawing.Size(200, 77);
            this.InstrumentsButton.TabIndex = 3;
            this.InstrumentsButton.Text = "Instruments";
            this.InstrumentsButton.UseVisualStyleBackColor = false;
            this.InstrumentsButton.Click += new System.EventHandler(this.InstrumentsButton_Click);
            // 
            // ToolsButton
            // 
            this.ToolsButton.BackColor = System.Drawing.Color.Transparent;
            this.ToolsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToolsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolsButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ToolsButton.Image = global::LabInventory.Properties.Resources.Tools;
            this.ToolsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolsButton.Location = new System.Drawing.Point(0, 52);
            this.ToolsButton.Name = "ToolsButton";
            this.ToolsButton.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.ToolsButton.Size = new System.Drawing.Size(200, 77);
            this.ToolsButton.TabIndex = 2;
            this.ToolsButton.Text = "Tools";
            this.ToolsButton.UseVisualStyleBackColor = false;
            this.ToolsButton.Click += new System.EventHandler(this.ToolsButton_Click);
            // 
            // PanelToggler
            // 
            this.PanelToggler.BackColor = System.Drawing.Color.Transparent;
            this.PanelToggler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PanelToggler.ForeColor = System.Drawing.SystemColors.Desktop;
            this.PanelToggler.Image = global::LabInventory.Properties.Resources.leftArrow;
            this.PanelToggler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PanelToggler.Location = new System.Drawing.Point(0, 0);
            this.PanelToggler.Name = "PanelToggler";
            this.PanelToggler.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.PanelToggler.Size = new System.Drawing.Size(200, 54);
            this.PanelToggler.TabIndex = 1;
            this.PanelToggler.UseVisualStyleBackColor = false;
            this.PanelToggler.Click += new System.EventHandler(this.PanelToggler_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Image = global::LabInventory.Properties.Resources.WitsEIE;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(382, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(459, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Wits University: Genmin Lab and HV Lab Inventory";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.BackgroundImage = global::LabInventory.Properties.Resources.minimize;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.Silver;
            this.button8.Location = new System.Drawing.Point(1129, -1);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(34, 29);
            this.button8.TabIndex = 5;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.BackgroundImage = global::LabInventory.Properties.Resources.LogOut;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.Silver;
            this.button7.Location = new System.Drawing.Point(1092, -1);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(34, 29);
            this.button7.TabIndex = 4;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImage = global::LabInventory.Properties.Resources.exit;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.Silver;
            this.button6.Location = new System.Drawing.Point(1166, -1);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(34, 29);
            this.button6.TabIndex = 3;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.TogglePanel);
            this.Controls.Add(this.MainMenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_Menu";
            this.Load += new System.EventHandler(this.Main_Menu_Load);
            this.MainMenuPanel.ResumeLayout(false);
            this.TogglePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainMenuPanel;
        private System.Windows.Forms.Button PanelToggler;
        private System.Windows.Forms.Panel TogglePanel;
        private System.Windows.Forms.Button WorkshopButton;
        private System.Windows.Forms.Button EquipmentButton;
        private System.Windows.Forms.Button InstrumentsButton;
        private System.Windows.Forms.Button ToolsButton;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Timer SlidingPanelTimer;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Button button1;
    }
}