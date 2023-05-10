using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_update
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }
        public int role;
        public HomePage(int role)
        {
            InitializeComponent();
            this.role = role;
        }
        private Form cur_childForm;
        private void open_ChildForm(Form child_form)
        {
            if (cur_childForm != null)
            {
                cur_childForm.Close();
            }
            cur_childForm = child_form;
            child_form.TopLevel = false;
            child_form.FormBorderStyle = FormBorderStyle.None;
            child_form.Dock = DockStyle.Fill;
            panelProgram.Controls.Add(child_form);
            panelProgram.Tag = child_form;
            child_form.BringToFront();
            child_form.Show();
        }
        private void HomePage_Load(object sender, EventArgs e)
        {
            if (role == 0)
            {
                btTest.Visible = false;
                btSetting.Visible = false;
            }
            open_ChildForm(new QuestionManage());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            open_ChildForm(new QuestionManage());
        }

        private void btTest_Click(object sender, EventArgs e)
        {
            open_ChildForm(new TestGenerate());
        }

        private void btSetting_Click(object sender, EventArgs e)
        {
            open_ChildForm(new Setting());
        }

        private void HomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
