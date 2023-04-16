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
    public partial class server : Form
    {
        public server()
        {
            InitializeComponent();
        }
        private string prev_server;
        private string prev_database;
        private void btChange_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn thay đổi kết nối server?", "Server connect", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                Connection connect = new Connection();
                connect.Server = tbServer.Text.Trim();
                connect.Database = tbDatabase.Text.Trim();
            }
            else
            {
                tbServer.Text = prev_server; 
                tbDatabase.Text = prev_database;
            }
        }

        private void server_Load(object sender, EventArgs e)
        {
            prev_database = tbDatabase.Text.Trim();
            prev_server = tbServer.Text.Trim();
        }
    }
}
