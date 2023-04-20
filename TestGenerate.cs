using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_update
{
    public partial class TestGenerate : Form
    {
        public TestGenerate()
        {
            InitializeComponent();
        }
        private DataTable dt = new DataTable();
        Connection sql = new Connection();
        List<string> list = new List<string>();
        private void GetCBtype()
        {
            string query = "select distinct Kieu_cau_hoi from question";
            using (SqlConnection conn = sql.connectSQL())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            cbType.Items.Add(r.GetString(0));
                        }
                    }
                }
            }
        }
        private void GetSubject()
        {
            string query = "select distinct Hoc_phan from question";
            using (SqlConnection conn = sql.connectSQL())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            cbSubject.Items.Add(r.GetString(0));
                        }
                    }
                }
            }
        }
        private void TestGenerate_Load(object sender, EventArgs e)
        {
            GetCBtype();
            GetSubject();
            dgvList.AllowUserToAddRows = false;
        }
        private void GetQuestion()
        {
            string query = "SELECT * FROM question WHERE Hoc_phan = N\'" + cbSubject.Text + "\' AND Kieu_cau_hoi = N\'" + cbType.Text + "\'";
            using (SqlConnection conn = sql.connectSQL())
            {
                conn.Open();
                using (SqlDataAdapter ad = new SqlDataAdapter(query, conn))
                {
                    dt.Clear();
                    ad.Fill(dt);
                }
            }
            dgvList.DataSource = dt;
        }
        private void btGenerate_Click(object sender, EventArgs e)
        {
            if (cbSubject.SelectedItem == null || cbType.SelectedItem == null)
            {
                MessageBox.Show("Null value", "", MessageBoxButtons.OK);
                return;
            }
            GetQuestion();
            if (!dgvList.Columns.Contains("Check"))
            {
                DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
                dataGridViewCheckBoxColumn.ValueType = typeof(bool);
                dataGridViewCheckBoxColumn.Name = "Check";
                dataGridViewCheckBoxColumn.HeaderText = "Add";
                dgvList.Columns.Add(dataGridViewCheckBoxColumn);
            }
        }
        private void WriteTxt(DataTable dt, string FolderPath, string FolderName)
        {
            int i = 1;
            using (StreamWriter sw = new StreamWriter(FolderPath + "\\" + FolderName, false, Encoding.UTF8))
            {
                foreach (DataRow r in dt.Rows)
                {
                    sw.WriteLine("Câu " + i + "(" + r["Diem"] + "): " + r["Noi_dung"]);
                    if (cbType.Text.Equals("trắc nghiệm", StringComparison.OrdinalIgnoreCase))
                    {
                        sw.WriteLine("A." + r["A"] + "\t\t" + "B." + r["B"]);
                        sw.WriteLine("C." + r["C"] + "\t\t" + "D." + r["D"]);
                    }
                    i++;
                }
            }
            MessageBox.Show("Create test.txt successful", "", MessageBoxButtons.OK);
        }
        private DataTable CreateTable(string query, SqlConnection conn)
        {
            DataTable dt = new DataTable();
            using (SqlDataAdapter adt = new SqlDataAdapter(query, conn))
            {
                adt.Fill(dt);
            }
            return dt;
        }
        private void btPreview_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.ShowDialog();
            string FolderPath = folderBrowser.SelectedPath;
            if (!Directory.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
            }
            string fileName = "test.txt";
            string query;
            if (cbType.Text.Equals("trắc nghiệm", StringComparison.OrdinalIgnoreCase))
            {
                query = "SELECT question.Noi_dung, trac_nghiem.A, trac_nghiem.B, trac_nghiem.C, trac_nghiem.D, trac_nghiem.Diem FROM question, trac_nghiem WHERE question.ID = trac_nghiem.ID_question AND question.ID IN (";
            }
            else
            {
                query = "SELECT question.Noi_dung, tu_luan.Diem FROM question, tu_luan WHERE question.ID = tu_luan.ID_question AND question.ID IN (";
            }
            foreach (string id in list)
            {
                if (id.Equals(list.Last()))
                {
                    query += id + ")";
                }
                else query += id + ", ";
            }
            MessageBox.Show(query);
            using (SqlConnection conn = sql.connectSQL())
            {
                WriteTxt(CreateTable(query, conn), FolderPath, fileName);
            }
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == dgvList.Columns["Check"].Index)
            {
                if (Convert.ToBoolean(dgvList.Rows[e.RowIndex].Cells["Check"].EditedFormattedValue))
                    list.Add(dgvList.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                else
                {
                    list.Remove(dgvList.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                }
            }
        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (tbSearch.Text == null || tbSearch.Text == "")
                {
                    return;
                }
                int Row_Search = -1;
                DataGridViewRow row = dgvList.Rows.Cast<DataGridViewRow>().Where(r => r.Cells["Noi_dung"].Value.ToString().Equals(tbSearch.Text)).First();
                Row_Search = row.Index;
                if (Row_Search == -1)
                {
                    MessageBox.Show("Không có kết quả phù hợp", "", MessageBoxButtons.OK);
                    tbSearch.Focus();
                }
                else
                {
                    dgvList.ClearSelection();
                    dgvList.Rows[Row_Search].Selected = true;
                }
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearch.Text))
            {
                dgvList.ClearSelection();
            }
        }
    }
}
