using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_update
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
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
            panelND.Controls.Add(child_form);
            panelND.Tag = child_form;
            child_form.BringToFront();
            child_form.Show();
        }

        private void btServer_Click(object sender, EventArgs e)
        {
            open_ChildForm(new server());
        }

        private void btData_Click(object sender, EventArgs e)
        {
            open_ChildForm(new data());
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            Login f = (Login)Application.OpenForms["Login"];
            if(f.role == 0)
            {
                btServer.Enabled = false;
                btData.Enabled = false;
                open_ChildForm(new Account());
            }
            else
            open_ChildForm(new server());
        }

        private void btAccount_Click(object sender, EventArgs e)
        {
            open_ChildForm(new Account());
        }
    }
}
