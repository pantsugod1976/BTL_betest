namespace BTL_update
{
    partial class server
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
            this.lbServer = new System.Windows.Forms.Label();
            this.lbDatabase = new System.Windows.Forms.Label();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.tbDatabase = new System.Windows.Forms.TextBox();
            this.btChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbServer
            // 
            this.lbServer.AutoSize = true;
            this.lbServer.Location = new System.Drawing.Point(13, 19);
            this.lbServer.Name = "lbServer";
            this.lbServer.Size = new System.Drawing.Size(38, 13);
            this.lbServer.TabIndex = 0;
            this.lbServer.Text = "Server";
            // 
            // lbDatabase
            // 
            this.lbDatabase.AutoSize = true;
            this.lbDatabase.Location = new System.Drawing.Point(13, 137);
            this.lbDatabase.Name = "lbDatabase";
            this.lbDatabase.Size = new System.Drawing.Size(53, 13);
            this.lbDatabase.TabIndex = 1;
            this.lbDatabase.Text = "Database";
            // 
            // tbServer
            // 
            this.tbServer.Location = new System.Drawing.Point(89, 19);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(219, 20);
            this.tbServer.TabIndex = 2;
            // 
            // tbDatabase
            // 
            this.tbDatabase.Location = new System.Drawing.Point(89, 137);
            this.tbDatabase.Name = "tbDatabase";
            this.tbDatabase.Size = new System.Drawing.Size(219, 20);
            this.tbDatabase.TabIndex = 3;
            // 
            // btChange
            // 
            this.btChange.Location = new System.Drawing.Point(233, 232);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(75, 23);
            this.btChange.TabIndex = 4;
            this.btChange.Text = "Thay đổi";
            this.btChange.UseVisualStyleBackColor = true;
            this.btChange.Click += new System.EventHandler(this.btChange_Click);
            // 
            // server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 339);
            this.Controls.Add(this.btChange);
            this.Controls.Add(this.tbDatabase);
            this.Controls.Add(this.tbServer);
            this.Controls.Add(this.lbDatabase);
            this.Controls.Add(this.lbServer);
            this.Name = "server";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbServer;
        private System.Windows.Forms.Label lbDatabase;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.TextBox tbDatabase;
        private System.Windows.Forms.Button btChange;
    }
}