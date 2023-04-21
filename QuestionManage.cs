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
            dt.Clear();
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
            using(SqlConnection conn = connect.connectSQL())
            {
                try
                {
                    
                    conn.Open();
                }
                catch(Exception ex) 
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
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
            dataGridView1.CurrentCell = null;

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Form frm = new AddQuestion(this);
            frm.Show();
            Application.OpenForms["HomePage"].Enabled = false;
        }
        public void RefreshData()
        {
            Generate_TB();
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
        private void Search() 
        {
            string description = tbDescription.Text.Trim();
            string subject = cbSubject.Text.ToUpper();
            string type = cbType.Text;
            string query = string.Format("SELECT ID, Noi_dung as 'Nội dung', Hoc_phan as 'Học phần', Kieu_cau_hoi as 'Kiểu câu hỏi' FROM question WHERE Noi_dung LIKE COALESCE(NULLIF(N\'{0}%\', ''), Noi_dung)\n" +
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
        private void btSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new AddQuestion(this);
            frm.Show();
            Application.OpenForms["HomePage"].Enabled = false;
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.OpenForms["HomePage"].Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(dataGridView1.SelectedColumns[0].Index, dataGridView1.SelectedRows[0].Index);
            this.dataGridView1_CellContentClick(sender, ex);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn xóa câu hỏi?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                int cell_index = dataGridView1.SelectedCells[0].RowIndex;
                string id = dataGridView1.Rows[cell_index].Cells[dataGridView1.Columns["ID"].Index].Value.ToString();
                int ID = int.Parse(id);
                int prev_ID = ID - 1;
                string query = string.Format("delete from question where ID = {0}", ID, prev_ID.ToString());
                using (SqlConnection conn = connect.connectSQL())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Xóa thành công");
                RefreshData();
            }
        }

        private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                DataGridView.HitTestInfo hit = dataGridView1.HitTest(e.X, e.Y);
                if (hit.Type == DataGridViewHitTestType.None)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.CurrentCell = null;
                    toolStripMenuItem1.Visible = true;
                    refreshToolStripMenuItem.Visible = true;
                    thoátToolStripMenuItem.Visible = true;
                    editToolStripMenuItem.Visible = false;
                    deleteToolStripMenuItem.Visible = false;
                }
                else
                {
                    if(dataGridView1.SelectedCells.Count > 0)
                    {
                        toolStripMenuItem1.Visible = false;
                        refreshToolStripMenuItem.Visible = false;
                        thoátToolStripMenuItem.Visible = false;
                        editToolStripMenuItem.Visible = true;
                        deleteToolStripMenuItem.Visible = true;
                    }
                }
            }
        }

        private void tbDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter){
                cbSubject.Focus();
                cbSubject.DroppedDown = true;
            }
        }

        private void cbSubject_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter){
                cbType.Focus();
                cbType.DroppedDown = true;
            }
        }

        private void cbType_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btSearch.PerformClick();
            }
        }

        private void cbSubject_TextChanged(object sender, EventArgs e)
        {
            if(cbSubject.Text.Length == 0)
            {
                Search();
            }
        }

        private void cbType_TextChanged(object sender, EventArgs e)
        {
            if (cbType.Text.Length == 0)
            {
                Search();
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            tbDescription.Clear();
            cbSubject.SelectedItem = null;
            cbType.SelectedItem = null;
            Search();
        }
    }
}
