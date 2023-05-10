namespace BTL_update
{
    partial class Account
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
            this.lbName = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbRole = new System.Windows.Forms.Label();
            this.btSignout = new System.Windows.Forms.Button();
            this.btChange = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbRole = new System.Windows.Forms.TextBox();
            this.btPass = new System.Windows.Forms.Button();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.lbKey = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(28, 60);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(58, 13);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "User name";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(28, 127);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 1;
            this.lbEmail.Text = "Email";
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Location = new System.Drawing.Point(28, 188);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(29, 13);
            this.lbRole.TabIndex = 1;
            this.lbRole.Text = "Role";
            // 
            // btSignout
            // 
            this.btSignout.Location = new System.Drawing.Point(31, 286);
            this.btSignout.Name = "btSignout";
            this.btSignout.Size = new System.Drawing.Size(75, 23);
            this.btSignout.TabIndex = 2;
            this.btSignout.Text = "Đăng xuất";
            this.btSignout.UseVisualStyleBackColor = true;
            this.btSignout.Click += new System.EventHandler(this.btSignout_Click);
            // 
            // btChange
            // 
            this.btChange.Location = new System.Drawing.Point(163, 286);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(102, 23);
            this.btChange.TabIndex = 2;
            this.btChange.Text = "Cập nhật thông tin";
            this.btChange.UseVisualStyleBackColor = true;
            this.btChange.Click += new System.EventHandler(this.btChange_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(218, 60);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(197, 20);
            this.tbName.TabIndex = 3;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(218, 120);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(197, 20);
            this.tbEmail.TabIndex = 3;
            // 
            // tbRole
            // 
            this.tbRole.Location = new System.Drawing.Point(218, 181);
            this.tbRole.Name = "tbRole";
            this.tbRole.Size = new System.Drawing.Size(197, 20);
            this.tbRole.TabIndex = 3;
            // 
            // btPass
            // 
            this.btPass.Location = new System.Drawing.Point(323, 286);
            this.btPass.Name = "btPass";
            this.btPass.Size = new System.Drawing.Size(92, 23);
            this.btPass.TabIndex = 2;
            this.btPass.Text = "Đổi mật khẩu";
            this.btPass.UseVisualStyleBackColor = true;
            this.btPass.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(218, 238);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(197, 20);
            this.tbKey.TabIndex = 5;
            // 
            // lbKey
            // 
            this.lbKey.AutoSize = true;
            this.lbKey.Location = new System.Drawing.Point(28, 245);
            this.lbKey.Name = "lbKey";
            this.lbKey.Size = new System.Drawing.Size(73, 13);
            this.lbKey.TabIndex = 4;
            this.lbKey.Text = "Password key";
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.lbKey);
            this.Controls.Add(this.tbRole);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btPass);
            this.Controls.Add(this.btChange);
            this.Controls.Add(this.btSignout);
            this.Controls.Add(this.lbRole);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbName);
            this.Name = "Account";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Account_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.Button btSignout;
        private System.Windows.Forms.Button btChange;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbRole;
        private System.Windows.Forms.Button btPass;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Label lbKey;
    }
}