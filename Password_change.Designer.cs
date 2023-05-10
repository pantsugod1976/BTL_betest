namespace BTL_update
{
    partial class Password_change
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
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.lbKey = new System.Windows.Forms.Label();
            this.btSubmit = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.tbConfirm = new System.Windows.Forms.TextBox();
            this.lbConfirm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(119, 97);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(255, 20);
            this.tbPassword.TabIndex = 6;
            this.tbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPassword_KeyDown);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(119, 6);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(255, 20);
            this.tbName.TabIndex = 5;
            this.tbName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbName_KeyDown);
            // 
            // lbPassword
            // 
            this.lbPassword.Location = new System.Drawing.Point(12, 100);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(85, 26);
            this.lbPassword.TabIndex = 3;
            this.lbPassword.Text = "New password";
            // 
            // lbName
            // 
            this.lbName.Location = new System.Drawing.Point(12, 9);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(85, 26);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "Email/Username";
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(119, 49);
            this.tbKey.Name = "tbKey";
            this.tbKey.PasswordChar = '*';
            this.tbKey.Size = new System.Drawing.Size(255, 20);
            this.tbKey.TabIndex = 8;
            this.tbKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbKey_KeyDown);
            // 
            // lbKey
            // 
            this.lbKey.Location = new System.Drawing.Point(12, 52);
            this.lbKey.Name = "lbKey";
            this.lbKey.Size = new System.Drawing.Size(85, 26);
            this.lbKey.TabIndex = 7;
            this.lbKey.Text = "Password key";
            // 
            // btSubmit
            // 
            this.btSubmit.Location = new System.Drawing.Point(15, 193);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(75, 23);
            this.btSubmit.TabIndex = 9;
            this.btSubmit.Text = "Submit";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(299, 193);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 10;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // tbConfirm
            // 
            this.tbConfirm.Location = new System.Drawing.Point(119, 147);
            this.tbConfirm.Name = "tbConfirm";
            this.tbConfirm.PasswordChar = '*';
            this.tbConfirm.Size = new System.Drawing.Size(255, 20);
            this.tbConfirm.TabIndex = 12;
            this.tbConfirm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbConfirm_KeyDown);
            // 
            // lbConfirm
            // 
            this.lbConfirm.Location = new System.Drawing.Point(12, 150);
            this.lbConfirm.Name = "lbConfirm";
            this.lbConfirm.Size = new System.Drawing.Size(101, 26);
            this.lbConfirm.TabIndex = 11;
            this.lbConfirm.Text = "Confirm password";
            // 
            // Password_change
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 250);
            this.Controls.Add(this.tbConfirm);
            this.Controls.Add(this.lbConfirm);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.lbKey);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbName);
            this.Name = "Password_change";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Label lbKey;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.TextBox tbConfirm;
        private System.Windows.Forms.Label lbConfirm;
    }
}