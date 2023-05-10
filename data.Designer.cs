namespace BTL_update
{
    partial class data
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
            this.btBackUp = new System.Windows.Forms.Button();
            this.btRestore = new System.Windows.Forms.Button();
            this.gbImport = new System.Windows.Forms.GroupBox();
            this.btFile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbFile = new System.Windows.Forms.TextBox();
            this.lbFile = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lbTable = new System.Windows.Forms.Label();
            this.gbImport.SuspendLayout();
            this.SuspendLayout();
            // 
            // btBackUp
            // 
            this.btBackUp.Location = new System.Drawing.Point(3, 2);
            this.btBackUp.Name = "btBackUp";
            this.btBackUp.Size = new System.Drawing.Size(76, 41);
            this.btBackUp.TabIndex = 0;
            this.btBackUp.Text = "Back up";
            this.btBackUp.UseVisualStyleBackColor = true;
            this.btBackUp.Click += new System.EventHandler(this.btBackUp_Click);
            // 
            // btRestore
            // 
            this.btRestore.Location = new System.Drawing.Point(160, 2);
            this.btRestore.Name = "btRestore";
            this.btRestore.Size = new System.Drawing.Size(76, 41);
            this.btRestore.TabIndex = 1;
            this.btRestore.Text = "Restore";
            this.btRestore.UseVisualStyleBackColor = true;
            this.btRestore.Click += new System.EventHandler(this.btRestore_Click);
            // 
            // gbImport
            // 
            this.gbImport.Controls.Add(this.btFile);
            this.gbImport.Controls.Add(this.button1);
            this.gbImport.Controls.Add(this.tbFile);
            this.gbImport.Controls.Add(this.lbFile);
            this.gbImport.Controls.Add(this.cbType);
            this.gbImport.Controls.Add(this.lbTable);
            this.gbImport.Location = new System.Drawing.Point(12, 84);
            this.gbImport.Name = "gbImport";
            this.gbImport.Size = new System.Drawing.Size(760, 189);
            this.gbImport.TabIndex = 2;
            this.gbImport.TabStop = false;
            this.gbImport.Text = "Import Data";
            // 
            // btFile
            // 
            this.btFile.Location = new System.Drawing.Point(202, 160);
            this.btFile.Name = "btFile";
            this.btFile.Size = new System.Drawing.Size(75, 23);
            this.btFile.TabIndex = 13;
            this.btFile.Text = "Browser";
            this.btFile.UseVisualStyleBackColor = true;
            this.btFile.Click += new System.EventHandler(this.btFile_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(417, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Restore";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbFile
            // 
            this.tbFile.Location = new System.Drawing.Point(202, 109);
            this.tbFile.Name = "tbFile";
            this.tbFile.Size = new System.Drawing.Size(290, 20);
            this.tbFile.TabIndex = 10;
            // 
            // lbFile
            // 
            this.lbFile.Location = new System.Drawing.Point(6, 109);
            this.lbFile.Name = "lbFile";
            this.lbFile.Size = new System.Drawing.Size(100, 21);
            this.lbFile.TabIndex = 9;
            this.lbFile.Text = "FIle path";
            // 
            // cbType
            // 
            this.cbType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(202, 36);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(203, 21);
            this.cbType.TabIndex = 8;
            // 
            // lbTable
            // 
            this.lbTable.Location = new System.Drawing.Point(6, 36);
            this.lbTable.Name = "lbTable";
            this.lbTable.Size = new System.Drawing.Size(100, 21);
            this.lbTable.TabIndex = 7;
            this.lbTable.Text = "Kiểu câu hỏi";
            // 
            // data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbImport);
            this.Controls.Add(this.btRestore);
            this.Controls.Add(this.btBackUp);
            this.Name = "data";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.data_Load);
            this.gbImport.ResumeLayout(false);
            this.gbImport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btBackUp;
        private System.Windows.Forms.Button btRestore;
        private System.Windows.Forms.GroupBox gbImport;
        private System.Windows.Forms.Button btFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbFile;
        private System.Windows.Forms.Label lbFile;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lbTable;
    }
}