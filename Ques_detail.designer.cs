namespace WindowsFormsApp2
{
    partial class Ques_detail
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
            this.tbPoint = new System.Windows.Forms.TextBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.tbD = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbC = new System.Windows.Forms.TextBox();
            this.tbA = new System.Windows.Forms.TextBox();
            this.rbD = new System.Windows.Forms.RadioButton();
            this.lbSubject = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.lbPoint = new System.Windows.Forms.Label();
            this.gbChoice = new System.Windows.Forms.GroupBox();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.lbType = new System.Windows.Forms.Label();
            this.tbType = new System.Windows.Forms.TextBox();
            this.btDel = new System.Windows.Forms.Button();
            this.gbChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPoint
            // 
            this.tbPoint.Location = new System.Drawing.Point(679, 272);
            this.tbPoint.Multiline = true;
            this.tbPoint.Name = "tbPoint";
            this.tbPoint.Size = new System.Drawing.Size(137, 43);
            this.tbPoint.TabIndex = 18;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(741, 396);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 15;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(521, 396);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(75, 23);
            this.btEdit.TabIndex = 16;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(679, 160);
            this.tbSubject.Multiline = true;
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(137, 45);
            this.tbSubject.TabIndex = 14;
            // 
            // tbD
            // 
            this.tbD.Location = new System.Drawing.Point(366, 85);
            this.tbD.Multiline = true;
            this.tbD.Name = "tbD";
            this.tbD.Size = new System.Drawing.Size(218, 34);
            this.tbD.TabIndex = 7;
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(366, 28);
            this.tbB.Multiline = true;
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(218, 34);
            this.tbB.TabIndex = 6;
            // 
            // tbC
            // 
            this.tbC.Location = new System.Drawing.Point(45, 84);
            this.tbC.Multiline = true;
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(218, 34);
            this.tbC.TabIndex = 5;
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(45, 28);
            this.tbA.Multiline = true;
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(218, 34);
            this.tbA.TabIndex = 4;
            // 
            // rbD
            // 
            this.rbD.AutoSize = true;
            this.rbD.Location = new System.Drawing.Point(328, 85);
            this.rbD.Name = "rbD";
            this.rbD.Size = new System.Drawing.Size(33, 17);
            this.rbD.TabIndex = 2;
            this.rbD.TabStop = true;
            this.rbD.Text = "D";
            this.rbD.UseVisualStyleBackColor = true;
            this.rbD.CheckedChanged += new System.EventHandler(this.rbD_CheckedChanged);
            // 
            // lbSubject
            // 
            this.lbSubject.AutoSize = true;
            this.lbSubject.Location = new System.Drawing.Point(676, 129);
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.Size = new System.Drawing.Size(54, 13);
            this.lbSubject.TabIndex = 13;
            this.lbSubject.Text = "Học phần";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(13, 21);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(50, 13);
            this.lbDescription.TabIndex = 12;
            this.lbDescription.Text = "Nội dung";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(12, 46);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(586, 96);
            this.tbDescription.TabIndex = 11;
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.Location = new System.Drawing.Point(6, 85);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(32, 17);
            this.rbC.TabIndex = 3;
            this.rbC.TabStop = true;
            this.rbC.Text = "C";
            this.rbC.UseVisualStyleBackColor = true;
            this.rbC.CheckedChanged += new System.EventHandler(this.rbC_CheckedChanged);
            // 
            // rbB
            // 
            this.rbB.AutoSize = true;
            this.rbB.Location = new System.Drawing.Point(328, 28);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(32, 17);
            this.rbB.TabIndex = 1;
            this.rbB.TabStop = true;
            this.rbB.Text = "B";
            this.rbB.UseVisualStyleBackColor = true;
            this.rbB.CheckedChanged += new System.EventHandler(this.rbB_CheckedChanged);
            // 
            // lbPoint
            // 
            this.lbPoint.AutoSize = true;
            this.lbPoint.Location = new System.Drawing.Point(676, 245);
            this.lbPoint.Name = "lbPoint";
            this.lbPoint.Size = new System.Drawing.Size(31, 13);
            this.lbPoint.TabIndex = 17;
            this.lbPoint.Text = "Điểm";
            // 
            // gbChoice
            // 
            this.gbChoice.Controls.Add(this.tbD);
            this.gbChoice.Controls.Add(this.tbB);
            this.gbChoice.Controls.Add(this.tbC);
            this.gbChoice.Controls.Add(this.tbA);
            this.gbChoice.Controls.Add(this.rbD);
            this.gbChoice.Controls.Add(this.rbC);
            this.gbChoice.Controls.Add(this.rbB);
            this.gbChoice.Controls.Add(this.rbA);
            this.gbChoice.Location = new System.Drawing.Point(12, 196);
            this.gbChoice.Name = "gbChoice";
            this.gbChoice.Size = new System.Drawing.Size(586, 131);
            this.gbChoice.TabIndex = 10;
            this.gbChoice.TabStop = false;
            this.gbChoice.Text = "Lựa chọn";
            // 
            // rbA
            // 
            this.rbA.AutoSize = true;
            this.rbA.Location = new System.Drawing.Point(6, 28);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(32, 17);
            this.rbA.TabIndex = 1;
            this.rbA.TabStop = true;
            this.rbA.Text = "A";
            this.rbA.UseVisualStyleBackColor = true;
            this.rbA.CheckedChanged += new System.EventHandler(this.rbA_CheckedChanged);
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(679, 21);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(66, 13);
            this.lbType.TabIndex = 19;
            this.lbType.Text = "Kiểu câu hỏi";
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(679, 46);
            this.tbType.Multiline = true;
            this.tbType.Name = "tbType";
            this.tbType.ReadOnly = true;
            this.tbType.Size = new System.Drawing.Size(137, 38);
            this.tbType.TabIndex = 20;
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(632, 396);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(75, 23);
            this.btDel.TabIndex = 21;
            this.btDel.Text = "Delete";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // Ques_detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 442);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.tbPoint);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.tbSubject);
            this.Controls.Add(this.lbSubject);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.lbPoint);
            this.Controls.Add(this.gbChoice);
            this.Name = "Ques_detail";
            this.Text = "Properties";
            this.Load += new System.EventHandler(this.Ques_detail_Load);
            this.gbChoice.ResumeLayout(false);
            this.gbChoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPoint;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.TextBox tbD;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.TextBox tbC;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.RadioButton rbD;
        private System.Windows.Forms.Label lbSubject;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.RadioButton rbB;
        private System.Windows.Forms.Label lbPoint;
        private System.Windows.Forms.GroupBox gbChoice;
        private System.Windows.Forms.RadioButton rbA;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.Button btDel;
    }
}