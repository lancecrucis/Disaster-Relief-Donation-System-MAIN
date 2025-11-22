namespace Disaster_Relief_Donation_System_Functions
{
    partial class Form1
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
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.forgotPassword = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.register = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(48, 132);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(55, 13);
            this.username.TabIndex = 0;
            this.username.Text = "Username";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(53, 225);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(53, 13);
            this.password.TabIndex = 1;
            this.password.Text = "Password";
            // 
            // usernametxt
            // 
            this.usernametxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.usernametxt.Location = new System.Drawing.Point(56, 252);
            this.usernametxt.Multiline = true;
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(480, 37);
            this.usernametxt.TabIndex = 2;
            // 
            // passwordtxt
            // 
            this.passwordtxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passwordtxt.Location = new System.Drawing.Point(56, 157);
            this.passwordtxt.Multiline = true;
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.PasswordChar = '*';
            this.passwordtxt.Size = new System.Drawing.Size(480, 37);
            this.passwordtxt.TabIndex = 3;
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loginButton.Location = new System.Drawing.Point(56, 319);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(480, 51);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            // 
            // forgotPassword
            // 
            this.forgotPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.forgotPassword.AutoSize = true;
            this.forgotPassword.ForeColor = System.Drawing.Color.Red;
            this.forgotPassword.Location = new System.Drawing.Point(444, 303);
            this.forgotPassword.Name = "forgotPassword";
            this.forgotPassword.Size = new System.Drawing.Size(92, 13);
            this.forgotPassword.TabIndex = 5;
            this.forgotPassword.Text = "Forgot Password?";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Don\'t have an account?";
            // 
            // register
            // 
            this.register.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.register.AutoSize = true;
            this.register.ForeColor = System.Drawing.Color.Red;
            this.register.Location = new System.Drawing.Point(331, 377);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(46, 13);
            this.register.TabIndex = 7;
            this.register.Text = "Register";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 541);
            this.Controls.Add(this.register);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.forgotPassword);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.usernametxt);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label forgotPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label register;
    }
}

