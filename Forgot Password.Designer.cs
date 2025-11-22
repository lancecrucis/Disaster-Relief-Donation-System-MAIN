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
            this.resetBtn = new System.Windows.Forms.Button();
            this.emailAddresstxt = new System.Windows.Forms.TextBox();
            this.verifyCodetxt = new System.Windows.Forms.TextBox();
            this.backToLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email address:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Verify Code:";
            // 
            // sendCodeBtn
            // 
            this.sendCodeBtn.Location = new System.Drawing.Point(50, 362);
            this.sendCodeBtn.Name = "sendCodeBtn";
            this.sendCodeBtn.Size = new System.Drawing.Size(432, 32);
            this.sendCodeBtn.TabIndex = 2;
            this.sendCodeBtn.Text = "Send Code";
            this.sendCodeBtn.UseVisualStyleBackColor = true;
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(50, 410);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(432, 34);
            this.resetBtn.TabIndex = 3;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            // 
            // emailAddresstxt
            // 
            this.emailAddresstxt.Location = new System.Drawing.Point(50, 223);
            this.emailAddresstxt.Multiline = true;
            this.emailAddresstxt.Name = "emailAddresstxt";
            this.emailAddresstxt.Size = new System.Drawing.Size(432, 30);
            this.emailAddresstxt.TabIndex = 4;
            // 
            // verifyCodetxt
            // 
            this.verifyCodetxt.Location = new System.Drawing.Point(50, 307);
            this.verifyCodetxt.Multiline = true;
            this.verifyCodetxt.Name = "verifyCodetxt";
            this.verifyCodetxt.Size = new System.Drawing.Size(432, 29);
            this.verifyCodetxt.TabIndex = 5;
            // 
            // backToLogin
            // 
            this.backToLogin.AutoSize = true;
            this.backToLogin.Location = new System.Drawing.Point(230, 456);
            this.backToLogin.Name = "backToLogin";
            this.backToLogin.Size = new System.Drawing.Size(73, 13);
            this.backToLogin.TabIndex = 6;
            this.backToLogin.Text = "Back to Login";
            this.backToLogin.Click += new System.EventHandler(this.backToLogin_Click);
            // 
            // Forgot_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 567);
            this.Controls.Add(this.backToLogin);
            this.Controls.Add(this.verifyCodetxt);
            this.Controls.Add(this.emailAddresstxt);
            this.Controls.Add(this.resetBtn);
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
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.TextBox emailAddresstxt;
        private System.Windows.Forms.TextBox verifyCodetxt;
        private System.Windows.Forms.Label backToLogin;
    }
}