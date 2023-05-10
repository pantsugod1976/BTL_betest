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
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }
        private Connection connect = new Connection();
        private string key;
        private void button1_Click(object sender, EventArgs e)
        {
            Password_change f = new Password_change();
            f.ShowDialog();
        }

        private void btChange_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn cập nhật?", null, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            string query = string.Format("update account set username = coalesce('{0}', username), email = coalesce('{1}', email) where password_key = \'{2}\'", tbName.Text, tbEmail.Text, key);
            if (res == DialogResult.OK)
            {
                using (SqlConnection conn = connect.connectSQL())
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = query;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            MessageBox.Show("Update successfull");
        }

        private void Account_Load(object sender, EventArgs e)
        {
            Login f = (Login)Application.OpenForms["Login"];
            int id = f.id;
            string query = "select * from account where id = \'" + id.ToString() + "\'"; 
            using (SqlConnection conn = connect.connectSQL())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tbName.Text = reader["username"].ToString();
                            tbEmail.Text = reader["email"].ToString();
                            tbKey.Text = reader["password_key"].ToString();
                            key = reader["password_key"].ToString();
                            tbRole.Text = reader["role"].ToString();
                        }
                    }
                }
            }
            tbKey.ReadOnly = true;
            tbRole.ReadOnly = true;
        }

        private void btSignout_Click(object sender, EventArgs e)
        {
            Application.OpenForms["HomePage"].Close();
        }
    }
}
