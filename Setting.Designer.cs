namespace BTL_update
{
    partial class Setting
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
            this.panelButton = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btData = new System.Windows.Forms.Button();
            this.btServer = new System.Windows.Forms.Button();
            this.panelND = new System.Windows.Forms.Panel();
            this.panelButton.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.tableLayoutPanel1);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButton.Location = new System.Drawing.Point(0, 0);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(118, 450);
            this.panelButton.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btData, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btServer, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(118, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btData
            // 
            this.btData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btData.Location = new System.Drawing.Point(3, 53);
            this.btData.Name = "btData";
            this.btData.Size = new System.Drawing.Size(112, 44);
            this.btData.TabIndex = 1;
            this.btData.Text = "Data";
            this.btData.UseVisualStyleBackColor = true;
            this.btData.Click += new System.EventHandler(this.btData_Click);
            // 
            // btServer
            // 
            this.btServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btServer.Location = new System.Drawing.Point(3, 3);
            this.btServer.Name = "btServer";
            this.btServer.Size = new System.Drawing.Size(112, 44);
            this.btServer.TabIndex = 0;
            this.btServer.Text = "Server";
            this.btServer.UseVisualStyleBackColor = true;
            this.btServer.Click += new System.EventHandler(this.btServer_Click);
            // 
            // panelND
            // 
            this.panelND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelND.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelND.Location = new System.Drawing.Point(118, 0);
            this.panelND.Name = "panelND";
            this.panelND.Size = new System.Drawing.Size(682, 450);
            this.panelND.TabIndex = 1;
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelND);
            this.Controls.Add(this.panelButton);
            this.Name = "Setting";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.panelButton.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Panel panelND;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btData;
        private System.Windows.Forms.Button btServer;
    }
}