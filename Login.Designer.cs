namespace BTL_update
{
    partial class Login
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
            this.lbTiltle = new System.Windows.Forms.Label();
            this.pnTiltle = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btLogin = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnTiltle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTiltle
            // 
            this.lbTiltle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTiltle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTiltle.Location = new System.Drawing.Point(0, 0);
            this.lbTiltle.Name = "lbTiltle";
            this.lbTiltle.Size = new System.Drawing.Size(651, 62);
            this.lbTiltle.TabIndex = 0;
            this.lbTiltle.Text = "ĐĂNG NHẬP";
            this.lbTiltle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnTiltle
            // 
            this.pnTiltle.Controls.Add(this.lbTiltle);
            this.pnTiltle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTiltle.Location = new System.Drawing.Point(0, 0);
            this.pnTiltle.Name = "pnTiltle";
            this.pnTiltle.Size = new System.Drawing.Size(651, 62);
            this.pnTiltle.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 285);
            this.panel1.TabIndex = 2;
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.btCancel);
            this.gbLogin.Controls.Add(this.btLogin);
            this.gbLogin.Controls.Add(this.tbPassword);
            this.gbLogin.Controls.Add(this.tbName);
            this.gbLogin.Controls.Add(this.lbPassword);
            this.gbLogin.Controls.Add(this.lbName);
            this.gbLogin.Location = new System.Drawing.Point(118, 52);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(431, 178);
            this.gbLogin.TabIndex = 0;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Thông tin đăng nhập";
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(324, 136);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 3;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(40, 136);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(75, 23);
            this.btLogin.TabIndex = 3;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(144, 85);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(255, 20);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPassword_KeyDown);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(144, 34);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(255, 20);
            this.tbName.TabIndex = 1;
            this.tbName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbName_KeyDown);
            // 
            // lbPassword
            // 
            this.lbPassword.Location = new System.Drawing.Point(37, 88);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(85, 26);
            this.lbPassword.TabIndex = 0;
            this.lbPassword.Text = "Password";
            // 
            // lbName
            // 
            this.lbName.Location = new System.Drawing.Point(37, 37);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(85, 26);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Email/Username";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 347);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnTiltle);
            this.Name = "Login";
            this.Text = "Login";
            this.pnTiltle.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTiltle;
        private System.Windows.Forms.Panel pnTiltle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}