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

namespace BTL_update
{
    public partial class AddQuestion : Form
    {
        private readonly QuestionManage form;
        public AddQuestion(QuestionManage frm)
        {
            InitializeComponent();
            form = frm;
        }
        Connection connect = new Connection();
        private string type;
        private string choice;
        private void InsertQuestion()
        {
            string description = tbDescription.Text.Trim();
            string subject = tbSubject.Text.Trim().ToUpper();
            string point = tbPoint.Text;
            string query = string.Format("BEGIN TRANSACTION;\n" +
                "DECLARE @output AS TABLE (Question_id INT)\n" +
                "INSERT INTO question (Noi_dung, Hoc_phan, Kieu_cau_hoi)\nOUTPUT inserted.ID INTO @output(Question_id)\nVALUES(N\'{0}\',N\'{1}\',N\'{2}\')\n\n" +
                "DECLARE @Question_ID INT\n SELECT @Question_ID = Question_id FROM @output\n", description, subject, type);
            if(type.Equals("tự luận", StringComparison.OrdinalIgnoreCase))
            {
                query += string.Format("INSERT INTO tu_luan(ID_question, Diem) VALUES (@Question_ID, {0})\n COMMIT;", point);
            }
            else
            {
                string A = tbA.Text;
                string B = tbB.Text;
                string C = tbC.Text;
                string D = tbD.Text;
                query += string.Format("INSERT INTO trac_nghiem(ID_question, A, B, C, D, Lua_chon, Diem) VALUES (@Question_ID, N\'{0}\', N\'{1}\', N\'{2}\', N\'{3}\', N\'{4}\', {5})\n COMMIT;", A, B, C, D, choice, point);
            }
            using (SqlConnection conn = connect.connectSQL())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn)) 
                { 
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void btSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbDescription.Text))
            {
                MessageBox.Show("Thiếu nội dung câu hỏi", "Error description", MessageBoxButtons.OK);
                tbDescription.Focus();
                return;
            }
            if (rbChoice.Checked)
            {
                if (tbA.Text == "" || tbB.Text == "" || tbC.Text == "" || tbD.Text == "")
                {
                    MessageBox.Show("Thiếu nội dung lựa chọn", "", MessageBoxButtons.OK);
                    tbA.Focus();
                    return;
                }
            }
            if (string.IsNullOrEmpty(tbSubject.Text))
            {
                MessageBox.Show("Học phần không xác định", "Error subject", MessageBoxButtons.OK);
                tbSubject.Focus();
                return;
            }
            bool successfullyParsed = float.TryParse(tbPoint.Text, out float res);
            if (!successfullyParsed)
            {
                MessageBox.Show("Diem khong hop le", "", MessageBoxButtons.OK);
                tbPoint.Focus();
                return;
            }
            InsertQuestion();
            MessageBox.Show("Thêm câu hỏi thành công", "", MessageBoxButtons.OK);
            form.RefreshData();
            tbDescription.Focus();
        }

        private void rbChoice_CheckedChanged(object sender, EventArgs e)
        {
            type = "trắc nghiệm";
            gbChoice.Show();
        }

        private void rbEssay_CheckedChanged(object sender, EventArgs e)
        {
            type = "tự luận";
            gbChoice.Hide();
        }

        private void AddQuestion_Load(object sender, EventArgs e)
        {
            gbChoice.Hide();
        }

        private void rbA_CheckedChanged(object sender, EventArgs e)
        {
            choice = "A";
        }

        private void rbB_CheckedChanged(object sender, EventArgs e)
        {
            choice = "B";
        }

        private void rbC_CheckedChanged(object sender, EventArgs e)
        {
            choice = "C";
        }

        private void rbD_CheckedChanged(object sender, EventArgs e)
        {
            choice = "D";
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            form.RefreshData();
        }
    }
}
