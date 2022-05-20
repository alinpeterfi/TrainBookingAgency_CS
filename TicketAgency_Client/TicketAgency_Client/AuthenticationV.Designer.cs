
namespace TicketAgency_Client
{
    partial class AuthenticationV
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
            this.btnAuthentication = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.l2User = new System.Windows.Forms.Label();
            this.lUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAuthentication
            // 
            this.btnAuthentication.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAuthentication.Location = new System.Drawing.Point(13, 132);
            this.btnAuthentication.Margin = new System.Windows.Forms.Padding(4);
            this.btnAuthentication.Name = "btnAuthentication";
            this.btnAuthentication.Size = new System.Drawing.Size(172, 44);
            this.btnAuthentication.TabIndex = 9;
            this.btnAuthentication.Text = "AUTHENTICATION";
            this.btnAuthentication.UseVisualStyleBackColor = true;
            this.btnAuthentication.Click += new System.EventHandler(this.btnAuthentication_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(13, 91);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(171, 22);
            this.txtPassword.TabIndex = 8;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(13, 33);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(171, 22);
            this.txtUsername.TabIndex = 7;
            // 
            // l2User
            // 
            this.l2User.AutoSize = true;
            this.l2User.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.l2User.Location = new System.Drawing.Point(13, 71);
            this.l2User.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l2User.Name = "l2User";
            this.l2User.Size = new System.Drawing.Size(91, 20);
            this.l2User.TabIndex = 6;
            this.l2User.Text = "PASSWORD";
            // 
            // lUser
            // 
            this.lUser.AutoSize = true;
            this.lUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lUser.Location = new System.Drawing.Point(13, 14);
            this.lUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lUser.Name = "lUser";
            this.lUser.Size = new System.Drawing.Size(46, 20);
            this.lUser.TabIndex = 5;
            this.lUser.Text = "USER";
            // 
            // AuthenticationV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 198);
            this.Controls.Add(this.btnAuthentication);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.l2User);
            this.Controls.Add(this.lUser);
            this.Name = "AuthenticationV";
            this.Text = "AuthenticationV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAuthentication;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label l2User;
        private System.Windows.Forms.Label lUser;
    }
}