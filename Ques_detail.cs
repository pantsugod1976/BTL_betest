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
using BTL_update;

namespace WindowsFormsApp2
{
    public partial class Ques_detail : Form
    {
        private string ID;
        string Lua_chon;
        Connection sql = new Connection();
        string new_choice;
        private readonly QuestionManage form;
        public Ques_detail(string id, string t, QuestionManage frm)
        {
            InitializeComponent();
            ID = id;
            tbType.Text = t;
            form = frm;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            form.RefreshData();
            Application.OpenForms["HomePage"].Enabled = true;
        }

        private void getDetail()
        {
            string query;
            if (tbType.Text == "Trắc nghiệm")
            {
                query = "SELECT question.Noi_dung, question.Hoc_phan, question.Kieu_cau_hoi, " +
                    "trac_nghiem.A, trac_nghiem.B, trac_nghiem.C, trac_nghiem.D, trac_nghiem.Lua_chon, trac_nghiem.Diem " +
                    "FROM question INNER JOIN trac_nghiem " +
                    "ON trac_nghiem.ID_question = question.ID WHERE trac_nghiem.ID_question = " + ID
                   ;
            }
            else
            {
                query = "SELECT question.Noi_dung, question.Hoc_phan, question.Kieu_cau_hoi, " +
                   "tu_luan.Diem " +
                   "FROM question LEFT JOIN tu_luan" +
                   " ON question.ID = tu_luan.ID_question WHERE tu_luan.ID_question = " + ID
                  ;           
            }
            using (SqlConnection conn = sql.connectSQL())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                   using (SqlDataReader reader = cmd.ExecuteReader())
                   {
                        while (reader.Read())
                        {
                            tbDescription.Text = reader["Noi_dung"].ToString();
                            tbSubject.Text = reader["Hoc_phan"].ToString();
                            tbType.Text = reader["Kieu_cau_hoi"].ToString();
                            tbPoint.Text = reader["Diem"].ToString();
                            if (tbType.Text == "Trắc nghiệm")
                            {
                                tbA.Text = reader["A"].ToString();
                                tbB.Text = reader["B"].ToString();
                                tbC.Text = reader["C"].ToString();
                                tbD.Text = reader["D"].ToString();
                                Lua_chon = reader["Lua_chon"].ToString();
                            }
                        }
                   }
                }
            }
        }
        private void Ques_detail_Load(object sender, EventArgs e)
        {
            getDetail();
            if(tbType.Text.Equals("tự luận",StringComparison.OrdinalIgnoreCase))
                gbChoice.Hide();
            else 
            {
                gbChoice.Show();
                switch (Lua_chon)
                {
                    case "A":
                        rbA.Checked = true;
                        break;
                    case "B":
                        rbB.Checked = true;
                        break;
                    case "C":
                        rbC.Checked = true;
                        break;
                    case "D":
                        rbD.Checked = true;
                        break;
                }
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn thay đổi nội dung câu hỏi?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(res == DialogResult.OK)
            {
                using (SqlConnection con = sql.connectSQL())
                {
                    con.Open();
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        if (tbType.Text.Equals("trắc nghiệm", StringComparison.OrdinalIgnoreCase))
                        {
                            cmd.CommandText = "BEGIN TRANSACTION;\n" +
                            "UPDATE question " +
                            "SET question.Noi_dung = N\'@description\', question.Hoc_phan = N\'@subject\' FROM question, trac_nghiem " +
                            "WHERE question.ID = trac_nghiem.ID_question AND question.ID = @ID;\n\n" +

                            "UPDATE trac_nghiem " +
                            "SET trac_nghiem.A = N\'@A\', trac_nghiem.B = N\'@B\', trac_nghiem.C = N\'@C\', trac_nghiem.D = N\'@D\', trac_nghiem.Lua_chon = N\'@choice\', trac_nghiem.Diem = @point " +
                            "FROM question, trac_nghiem " +
                            "WHERE question.ID = trac_nghiem.ID_question AND question.ID = @ID;\n" +
                            "COMMIT;";
                            cmd.Parameters.AddWithValue("@A", tbA.Text);
                            cmd.Parameters.AddWithValue("@B", tbB.Text);
                            cmd.Parameters.AddWithValue("@C", tbC.Text);
                            cmd.Parameters.AddWithValue("@D", tbD.Text);
                            cmd.Parameters.AddWithValue("@choice", new_choice);

                        }
                        else
                        {
                            cmd.CommandText = "BEGIN TRANSACTION;\n" +
                            "UPDATE question " +
                            "SET question.Noi_dung = N\'@description\', question.Hoc_phan = N\'@subject\' FROM question, tu_luan " +
                            "WHERE question.ID = tu_luan.ID_question AND question.ID = @ID;\n\n" +

                            "UPDATE tu_luan " +
                            "SET tu_luan.Diem = @point FROM question, tu_luan " +
                            "WHERE question.ID = tu_luan.ID_question AND question.ID = @ID;\n" +
                            " COMMIT;";
                        }
                        cmd.Parameters.AddWithValue("@ID", ID);
                        cmd.Parameters.AddWithValue("@description", tbDescription.Text);
                        cmd.Parameters.AddWithValue("@point", tbPoint.Text);
                        cmd.Parameters.AddWithValue("@subject", tbSubject.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thay đổi thông tin thành công\n", "", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                getDetail();
            }
        }

        private void rbA_CheckedChanged(object sender, EventArgs e)
        {
            new_choice = "A";
        }

        private void rbB_CheckedChanged(object sender, EventArgs e)
        {
            new_choice = "B";
        }

        private void rbC_CheckedChanged(object sender, EventArgs e)
        {
            new_choice = "C";
        }

        private void rbD_CheckedChanged(object sender, EventArgs e)
        {
            new_choice = "D";
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn xóa câu hỏi?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(res == DialogResult.OK)
            {
                int prev_ID = int.Parse(ID) - 1;
                string query = string.Format("begin transaction;\ndelete from question where ID = {0}\nDBCC CHECKIDENT(question, reseed, {1})\ncommit;", ID, prev_ID.ToString());
                using (SqlConnection conn = sql.connectSQL())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Xóa thành công");
                this.Close();
                Application.OpenForms["HomePage"].Enabled = true;
            }
        }
    }
}
