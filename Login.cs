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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private Connection connect = new Connection();
        public int role;
        public int id;
        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private int getLogin(string username, string password)
        {
            string query = string.Format("select * from account where (username = \'{0}\' or email = \'{0}\') and password = \'{1}\'", username, password);
            using (SqlConnection conn = connect.connectSQL())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            id = Convert.ToInt32(reader["id"]);
                            return (int)reader["role"];
                        }
                    }
                }
            }
            return 2;
        }
        private void btLogin_Click(object sender, EventArgs e)
        {
            role = getLogin(tbName.Text, tbPassword.Text);
            if (role != 2)
            {
                HomePage f = new HomePage();
                this.Hide();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai thông tin đăng nhập", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbName.Focus();
            }
        }

        private void tbName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(tbName.Text))
                {
                    toolTip1 = new ToolTip();
                    toolTip1.Show("User name empty", tbName, 0, 20, 1000);
                    tbName.Focus();
                    return;
                }
                tbPassword.Focus();
            }
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(tbName.Text))
                {
                    toolTip1 = new ToolTip();
                    toolTip1.Show("User name empty", tbName, 0, 20, 1000);
                    tbName.Focus();
                    return;
                }
                btLogin.PerformClick();
            }
        }

        private void lbPasschange_Click(object sender, EventArgs e)
        {
            Password_change f = new Password_change();
            f.ShowDialog();
        }

        private void Login_VisibleChanged(object sender, EventArgs e)
        {
            tbName.Clear();
            tbPassword.Clear();
            tbName.Focus();
        }
    }
}
