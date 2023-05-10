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
    public partial class Password_change : Form
    {
        public Password_change()
        {
            InitializeComponent();
        }

        private void tbName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                tbKey.Focus();
            }
        }

        private void tbKey_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            tbPassword.Focus();
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            tbConfirm.Focus();
        }

        private void tbConfirm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            btSubmit.PerformClick();
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbName.Text))
            {
                ToolTip t = new ToolTip();
                t.Show("Email/username is empty", tbName, 0, 20, 1000);
                tbName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(tbKey.Text))
            {
                ToolTip t = new ToolTip();
                t.Show("Email/username is empty", tbKey, 0, 20, 1000);
                tbKey.Focus();
                return;
            }
            if (string.IsNullOrEmpty(tbPassword.Text))
            {
                ToolTip t = new ToolTip();
                t.Show("Email/username is empty", tbPassword, 0, 20, 1000);
                tbPassword.Focus();
                return;
            }
            if (tbConfirm.Text != tbPassword.Text)
            {
                ToolTip t = new ToolTip();
                t.Show("Confirm password not similar", tbConfirm, 0, 20, 1000);
                tbConfirm.Focus();
                return;
            }
            DialogResult res = MessageBox.Show("Bạn có muốn đặt lại mật khẩu ?", "Password change", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                string query = string.Format("update account set password = \'{0}\' where (username = \'{1}\' or email = \'{1}\') and password_key = \'{2}\'", tbPassword.Text, tbName.Text, tbKey.Text);
                Connection connect = new Connection();
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Password change succesfull", null, MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
