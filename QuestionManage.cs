using Microsoft.SqlServer.Server;
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
using System.Xml.Linq;
using WindowsFormsApp2;

namespace BTL_update
{
    public partial class QuestionManage : Form
    {
        public QuestionManage()
        {
            InitializeComponent();
        }
        private DataTable dt = new DataTable();
        Connection connect = new Connection();
        private void CB_subject()
        {
            string query = "select distinct Hoc_phan from question";
            using (SqlConnection conn = connect.connectSQL())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cbSubject.Items.Add(reader.GetSqlString(0));
                        }
                    }
                }
            }
        }
        private void CB_Type()
        {
            cbType.Items.Add("trắc nghiệm");
            cbType.Items.Add("tự luận");
        }
        private void Generate_TB()
        {
            string query = "select ID, Noi_dung as 'Nội dung', Hoc_phan as 'Học phần', Kieu_cau_hoi as 'Kiểu câu hỏi' from question";
            using (SqlConnection conn = connect.connectSQL())
            {
                using (SqlDataAdapter adt = new SqlDataAdapter(query, conn))
                {
                    adt.Fill(dt);
                }
            }
        }
        private void QuestionManage_Load(object sender, EventArgs e)
        {
            Generate_TB();
            dataGridView1.DataSource = dt;
            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.Name = "Information";
            col.HeaderText = "Thông tin";
            col.Text = "Chi tiết";
            col.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(col);
            CB_subject();
            CB_Type();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Form frm = new AddQuestion(this);
            frm.Show();
            Application.OpenForms["HomePage"].Enabled = false;        }

        private void QuestionManage_EnabledChanged(object sender, EventArgs e)
        {
            Generate_TB();
            dataGridView1.Refresh();
        }
        public void RefreshData()
        {
            dataGridView1.Refresh();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)   //header column
            {
                return;
            }
            string id = dataGridView1.Rows[e.RowIndex].Cells[dataGridView1.Columns["ID"].Index].Value.ToString();
            string type = dataGridView1.Rows[e.RowIndex].Cells[dataGridView1.Columns["KIểu câu hỏi"].Index].Value.ToString();
            if (e.ColumnIndex == dataGridView1.Columns["Information"].Index)
            {

                Ques_detail frm = new Ques_detail(id, type, this);
                frm.Show();
                Application.OpenForms["HomePage"].Enabled = false;
            }
        }

        private void QuestionManage_Leave(object sender, EventArgs e)
        {
            
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            string description = tbDescription.Text.Trim();
            string subject = cbSubject.Text.ToUpper();
            string type = cbType.Text;
            string query = string.Format("SELECT * FROM question WHERE Noi_dung LIKE COALESCE(NULLIF(N\'{0}%\', ''), Noi_dung)\n" +
                                        " AND Hoc_phan = COALESCE(NULLIF(N\'{1}\', ''), Hoc_phan)\n" +
                                        " AND Kieu_cau_hoi = COALESCE(NULLIF(N\'{2}\',''), Kieu_cau_hoi)", description, subject, type);
            using (SqlConnection conn = connect.connectSQL())
            {
                conn.Open();
                using (SqlDataAdapter adt = new SqlDataAdapter(query, conn))
                {
                    dt.Clear();
                    adt.Fill(dt);
                }
            }
            dataGridView1.Refresh();
        }
    }
}
