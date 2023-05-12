using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

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
        private static void SetSetting(string key, string value)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings[key].Value = value;
            configuration.Save(ConfigurationSaveMode.Full, true);
            ConfigurationManager.RefreshSection("appSettings");
        }
        private void btChange_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn thay đổi kết nối server?", "Server connect", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                SetSetting("ServerName", tbServer.Text);
                SetSetting("DatabaseName", tbDatabase.Text);
                using (SqlConnection conn = new Connection().connectSQL())
                {
                    try
                    {
                        conn.Open();
                    }
                    catch(SqlException ex)
                    {
                        res = MessageBox.Show(ex.Message, "", MessageBoxButtons.OK);
                        if (res == DialogResult.OK)
                        {
                            SetSetting("ServerName", prev_server);
                            SetSetting("DatabaseName", prev_database);
                            tbServer.Text = prev_server;
                            tbDatabase.Text = prev_database;
                        }
                    }
                }
            }
        }

        private void server_Load(object sender, EventArgs e)
        {
            tbServer.Text = ConfigurationManager.AppSettings["ServerName"];
            tbDatabase.Text = ConfigurationManager.AppSettings["DatabaseName"];
            prev_database = tbDatabase.Text.Trim();
            prev_server = tbServer.Text.Trim();
        }

        private void tbServer_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                tbDatabase.Focus();
            }
        }

        private void tbDatabase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btChange.PerformClick();
            }
        }
    }
}
