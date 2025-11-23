namespace Disaster_Relief_Donation_System_Functions
{
    partial class Forgot_Password
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sendCodeBtn = new System.Windows.Forms.Button();
            this.emailAddresstxt = new System.Windows.Forms.TextBox();
            this.backToLogin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your email address:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // sendCodeBtn
            // 
            this.sendCodeBtn.Location = new System.Drawing.Point(62, 328);
            this.sendCodeBtn.Name = "sendCodeBtn";
            this.sendCodeBtn.Size = new System.Drawing.Size(390, 32);
            this.sendCodeBtn.TabIndex = 2;
            this.sendCodeBtn.Text = "Send Verification Code";
            this.sendCodeBtn.UseVisualStyleBackColor = true;
            this.sendCodeBtn.Click += new System.EventHandler(this.sendCodeBtn_Click);
            // 
            // emailAddresstxt
            // 
            this.emailAddresstxt.Location = new System.Drawing.Point(62, 269);
            this.emailAddresstxt.Multiline = true;
            this.emailAddresstxt.Name = "emailAddresstxt";
            this.emailAddresstxt.Size = new System.Drawing.Size(390, 30);
            this.emailAddresstxt.TabIndex = 4;
            // 
            // backToLogin
            // 
            this.backToLogin.AutoSize = true;
            this.backToLogin.Location = new System.Drawing.Point(222, 409);
            this.backToLogin.Name = "backToLogin";
            this.backToLogin.Size = new System.Drawing.Size(73, 13);
            this.backToLogin.TabIndex = 6;
            this.backToLogin.Text = "Back to Login";
            this.backToLogin.Click += new System.EventHandler(this.backToLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Forgot Password?";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(139, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "No worries! Enter your email address and we\'ll send you a verification code to re" +
    "set your password.";
            // 
            // Forgot_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 567);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.backToLogin);
            this.Controls.Add(this.emailAddresstxt);
            this.Controls.Add(this.sendCodeBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Forgot_Password";
            this.Text = "Forgot_Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sendCodeBtn;
        private System.Windows.Forms.TextBox emailAddresstxt;
        private System.Windows.Forms.Label backToLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}