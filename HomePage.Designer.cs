namespace BTL_update
{
    partial class HomePage
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
            this.tbPanelButton = new System.Windows.Forms.TableLayoutPanel();
            this.btSetting = new System.Windows.Forms.Button();
            this.btTest = new System.Windows.Forms.Button();
            this.btQues = new System.Windows.Forms.Button();
            this.panelProgram = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.tbPanelButton.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPanelButton
            // 
            this.tbPanelButton.ColumnCount = 3;
            this.tbPanelButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbPanelButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbPanelButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tbPanelButton.Controls.Add(this.btSetting, 2, 0);
            this.tbPanelButton.Controls.Add(this.btTest, 1, 0);
            this.tbPanelButton.Controls.Add(this.btQues, 0, 0);
            this.tbPanelButton.Location = new System.Drawing.Point(3, 3);
            this.tbPanelButton.Name = "tbPanelButton";
            this.tbPanelButton.RowCount = 1;
            this.tbPanelButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbPanelButton.Size = new System.Drawing.Size(267, 57);
            this.tbPanelButton.TabIndex = 4;
            // 
            // btSetting
            // 
            this.btSetting.Location = new System.Drawing.Point(177, 3);
            this.btSetting.Name = "btSetting";
            this.btSetting.Size = new System.Drawing.Size(87, 49);
            this.btSetting.TabIndex = 2;
            this.btSetting.Text = "Cài đặt";
            this.btSetting.UseVisualStyleBackColor = true;
            this.btSetting.Click += new System.EventHandler(this.btSetting_Click);
            // 
            // btTest
            // 
            this.btTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btTest.Location = new System.Drawing.Point(90, 3);
            this.btTest.Name = "btTest";
            this.btTest.Size = new System.Drawing.Size(81, 51);
            this.btTest.TabIndex = 1;
            this.btTest.Text = "Đề thi";
            this.btTest.UseVisualStyleBackColor = true;
            this.btTest.Click += new System.EventHandler(this.btTest_Click);
            // 
            // btQues
            // 
            this.btQues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btQues.Location = new System.Drawing.Point(3, 3);
            this.btQues.Name = "btQues";
            this.btQues.Size = new System.Drawing.Size(81, 51);
            this.btQues.TabIndex = 0;
            this.btQues.Text = "Quản lí câu hỏi";
            this.btQues.UseVisualStyleBackColor = true;
            this.btQues.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelProgram
            // 
            this.panelProgram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProgram.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelProgram.Location = new System.Drawing.Point(0, 61);
            this.panelProgram.Name = "panelProgram";
            this.panelProgram.Size = new System.Drawing.Size(835, 489);
            this.panelProgram.TabIndex = 5;
            // 
            // panelTop
            // 
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop.Controls.Add(this.tbPanelButton);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(835, 62);
            this.panelTop.TabIndex = 6;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 550);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelProgram);
            this.Name = "HomePage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.tbPanelButton.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tbPanelButton;
        private System.Windows.Forms.Button btSetting;
        private System.Windows.Forms.Button btTest;
        private System.Windows.Forms.Button btQues;
        private System.Windows.Forms.Panel panelProgram;
        private System.Windows.Forms.Panel panelTop;
    }
}

