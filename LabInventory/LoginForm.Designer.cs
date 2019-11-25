namespace LabInventory
{
    partial class LoginForm
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
            this.LoginButton = new System.Windows.Forms.Button();
            this.UsernameField = new System.Windows.Forms.TextBox();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.IncorrectCredentials = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Location = new System.Drawing.Point(83, 288);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(202, 36);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Log In";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // UsernameField
            // 
            this.UsernameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameField.Location = new System.Drawing.Point(83, 131);
            this.UsernameField.Name = "UsernameField";
            this.UsernameField.Size = new System.Drawing.Size(182, 23);
            this.UsernameField.TabIndex = 1;
            // 
            // PasswordField
            // 
            this.PasswordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordField.Location = new System.Drawing.Point(83, 181);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.PasswordChar = '*';
            this.PasswordField.Size = new System.Drawing.Size(182, 23);
            this.PasswordField.TabIndex = 3;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(280, 137);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(79, 17);
            this.username.TabIndex = 4;
            this.username.Text = "User Name";
            
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(280, 186);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(69, 17);
            this.password.TabIndex = 5;
            this.password.Text = "Password";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(119)))), ((int)(((byte)(138)))));
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Title.Location = new System.Drawing.Point(78, 41);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(487, 29);
            this.Title.TabIndex = 6;
            this.Title.Text = "Wits Genmin and High Voltage Lab Inventory";
           
            // 
            // IncorrectCredentials
            // 
            this.IncorrectCredentials.AutoSize = true;
            this.IncorrectCredentials.BackColor = System.Drawing.Color.Red;
            this.IncorrectCredentials.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncorrectCredentials.Location = new System.Drawing.Point(80, 230);
            this.IncorrectCredentials.Name = "IncorrectCredentials";
            this.IncorrectCredentials.Size = new System.Drawing.Size(175, 22);
            this.IncorrectCredentials.TabIndex = 7;
            this.IncorrectCredentials.Text = "Incorrect Credentials";
            this.IncorrectCredentials.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.IncorrectCredentials.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::LabInventory.Properties.Resources.LoginBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(709, 498);
            this.Controls.Add(this.IncorrectCredentials);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.UsernameField);
            this.Controls.Add(this.LoginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.Text = "Lab Inventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox UsernameField;
        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label IncorrectCredentials;
    }
}

