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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            this.TogglePanel = new System.Windows.Forms.Panel();
            this.WorkshopButton = new System.Windows.Forms.Button();
            this.EquipmentButton = new System.Windows.Forms.Button();
            this.InstrumentsButton = new System.Windows.Forms.Button();
            this.ToolsButton = new System.Windows.Forms.Button();
            this.PanelToggler = new System.Windows.Forms.Button();
            this.SlidingPanelTimer = new System.Windows.Forms.Timer(this.components);
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.TogglePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TogglePanel
            // 
            this.TogglePanel.BackColor = System.Drawing.Color.LightBlue;
            this.TogglePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TogglePanel.Controls.Add(this.btnLogout);
            this.TogglePanel.Controls.Add(this.WorkshopButton);
            this.TogglePanel.Controls.Add(this.EquipmentButton);
            this.TogglePanel.Controls.Add(this.InstrumentsButton);
            this.TogglePanel.Controls.Add(this.ToolsButton);
            this.TogglePanel.Controls.Add(this.PanelToggler);
            this.TogglePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TogglePanel.Location = new System.Drawing.Point(0, 0);
            this.TogglePanel.Name = "TogglePanel";
            this.TogglePanel.Size = new System.Drawing.Size(200, 726);
            this.TogglePanel.TabIndex = 2;
            // 
            // WorkshopButton
            // 
            this.WorkshopButton.BackColor = System.Drawing.Color.Transparent;
            this.WorkshopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WorkshopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkshopButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.WorkshopButton.Image = global::LabInventory.Properties.Resources.WeirdMachine;
            this.WorkshopButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WorkshopButton.Location = new System.Drawing.Point(-1, 300);
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
            this.EquipmentButton.Location = new System.Drawing.Point(0, 226);
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
            this.InstrumentsButton.Location = new System.Drawing.Point(-1, 150);
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
            this.ToolsButton.Location = new System.Drawing.Point(-1, 74);
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
            this.PanelToggler.Location = new System.Drawing.Point(-1, -1);
            this.PanelToggler.Name = "PanelToggler";
            this.PanelToggler.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.PanelToggler.Size = new System.Drawing.Size(200, 76);
            this.PanelToggler.TabIndex = 1;
            this.PanelToggler.UseVisualStyleBackColor = false;
            this.PanelToggler.Click += new System.EventHandler(this.PanelToggler_Click);
            // 
            // SlidingPanelTimer
            // 
            this.SlidingPanelTimer.Interval = 15;
            this.SlidingPanelTimer.Tick += new System.EventHandler(this.SlidingPanelTimer_Tick);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentPanel.Location = new System.Drawing.Point(196, 0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(1004, 726);
            this.ContentPanel.TabIndex = 3;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnLogout.Image = global::LabInventory.Properties.Resources.LogOut;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(-1, 610);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(200, 77);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1200, 726);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.TogglePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(12, 0);
            this.MinimumSize = new System.Drawing.Size(1200, 726);
            this.Name = "Main_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wits: Genmin and HV Lab Inventory";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Main_Menu_Load);
            this.TogglePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button PanelToggler;
        private System.Windows.Forms.Panel TogglePanel;
        private System.Windows.Forms.Button WorkshopButton;
        private System.Windows.Forms.Button EquipmentButton;
        private System.Windows.Forms.Button InstrumentsButton;
        private System.Windows.Forms.Button ToolsButton;
        private System.Windows.Forms.Timer SlidingPanelTimer;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Button btnLogout;
    }
}