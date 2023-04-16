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
    public partial class data : Form
    {
        public data()
        {
            InitializeComponent();
        }
        Connection connect = new Connection();
        private DataTable table = new DataTable();
        private DataTable GetCsvData(string filePath)
        {
            DataTable dt = new DataTable();
            using (StreamReader reader = new StreamReader(filePath))
            {
                string[] headers = reader.ReadLine().Split(','); //Chia cac gia tri theo dau ','
                foreach (string header in headers)
                {
                    dt.Columns.Add(header);
                }
                while (!reader.EndOfStream)
                {
                    string[] rows = reader.ReadLine().Split(',');
                    DataRow dr = dt.NewRow();
                    for (int i = 0; i < headers.Length; i++) //Chia khoang gia tri theo cot
                    {
                        dr[i] = rows[i];
                    }
                    dt.Rows.Add(dr);
                }
            }
            return dt;
        }
        private void ImportSql(DataTable dt)
        {
            using (SqlConnection conn = connect.connectSQL())
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "delete from question where Kieu_cau_hoi = N\'@type\'";
                    MessageBox.Show(cmd.CommandText);
                    cmd.Parameters.AddWithValue("@type", cbType.Text);
                    cmd.ExecuteNonQuery();
                    if (cbType.Text.Equals("trắc nghiệm", StringComparison.OrdinalIgnoreCase))
                    {
                        cmd.CommandText =
                            "BEGIN TRANSACTION;\n\n" +
                            "DECLARE @output AS TABLE (Question_ID INT)\n" + //Tao bang output vs cot Question_ID
                            "INSERT INTO question (Noi_dung, Hoc_phan, Kieu_cau_hoi)\nOUTPUT inserted.ID INTO @output(Question_ID)\nVALUES (N\'@description\', N\'@subject\', N\'@type\')\n\n" +
                            "DECLARE @Question_ID INT\n SELECT @Question_ID = Question_ID FROM @output\n\n" +
                            "INSERT INTO trac_nghiem(ID_question, A, B, C, D, Lua_chon, Diem) VALUES (@Question_ID, N\'@A\', N\'@B\', N\'@C\', N\'@D\', N\'@answer\', @point)\n" +
                            "COMMIT;"
                            ;
                        foreach (DataRow r in dt.Rows)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@description", r["Noi_dung"].ToString());
                            cmd.Parameters.AddWithValue("@subject", r["Hoc_phan"].ToString());
                            cmd.Parameters.AddWithValue("@A", r["A"].ToString());
                            cmd.Parameters.AddWithValue("@B", r["B"].ToString());
                            cmd.Parameters.AddWithValue("@C", r["C"].ToString());
                            cmd.Parameters.AddWithValue("@D", r["D"].ToString());
                            cmd.Parameters.AddWithValue("@answer", r["Lua_chon"].ToString());
                            cmd.Parameters.AddWithValue("@point", r["Diem"].ToString());
                            cmd.Parameters.AddWithValue("@type", cbType.Text);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        cmd.CommandText =
                            "BEGIN TRANSACTION;\n\n" +
                            "DECLARE @output AS TABLE (Question_ID INT)\n" + //Tao bang output vs cot Question_ID
                            "INSERT INTO question (Noi_dung, Hoc_phan, Kieu_cau_hoi)\n OUTPUT inserted.ID INTO @output(Question_ID)\n VALUES (N\'@description\', N\'@subject\', N\'@type\')\n\n" +
                            "DECLARE @Question_ID INT\n SELECT @Question_ID = Question_ID FROM @output\n\n" +
                            "INSERT INTO tu_luan(ID_question, Diem) VALUES (@Question_ID, @point)\n" +
                            "COMMIT;"
                           ;
                        foreach (DataRow r in dt.Rows)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@description", r["Noi_dung"].ToString());
                            cmd.Parameters.AddWithValue("@subject", r["Hoc_phan"].ToString());
                            cmd.Parameters.AddWithValue("@type", cbType.Text);
                            cmd.Parameters.AddWithValue("@point", r["Diem"].ToString());
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }
        private void btRestore_Click(object sender, EventArgs e)
        {
            gbImport.Show();
        }

        private void data_Load(object sender, EventArgs e)
        {
            cbType.Items.Add("trắc nghiệm");
            cbType.Items.Add("tự luận");
            gbImport.Hide();
        }

        private void btFile_Click(object sender, EventArgs e)
        {
            if (cbType.SelectedItem == null)
            {
                MessageBox.Show("Null type", "", MessageBoxButtons.OK);
                cbType.Focus();
                return;
            }
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.RestoreDirectory = true;
            ofd.Title = "Browser csv file";
            ofd.DefaultExt = "csv";
            ofd.Filter = "csv files(*.csv)|*.csv";
            ofd.CheckFileExists = true;
            ofd.ShowDialog();
            if (cbType.SelectedText.Equals("Trắc nghiệm", StringComparison.OrdinalIgnoreCase))
            {
                if (Path.GetFileNameWithoutExtension(ofd.FileName).Contains("trac_nghiem*"))
                {
                    MessageBox.Show("Sai file cho cau hoi " + cbType.SelectedText);
                    return;
                }
            }
            else
            {
                if (Path.GetFileNameWithoutExtension(ofd.FileName).Contains("tu_luan*"))
                {
                    MessageBox.Show("Sai file cho cau hoi " + cbType.SelectedText);
                    return;
                }
            }
            tbFile.Text = ofd.FileName;
            table = GetCsvData(ofd.FileName);
        }
        private void WriteValue(SqlConnection conn, string FolderPath, string query, string table)
        {
            DataTable dt = new DataTable();
            DateTime today = DateTime.Today;
            string folderName = string.Format("{0}backup{1}_{2}_{3}.csv", table, today.Day.ToString(), today.Month.ToString(), today.Year.ToString());
            string folderPath = FolderPath + "\\" + table;
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (SqlDataAdapter adt = new SqlDataAdapter(query, conn))
            {
                adt.Fill(dt);
            }
            using (StreamWriter sw = new StreamWriter(folderPath + "\\" + folderName, false, Encoding.UTF8))
            {
                for (int i = 0; i < dt.Columns.Count; ++i)
                {
                    if (i < dt.Columns.Count - 1)
                    {
                        sw.Write(dt.Columns[i].ColumnName + ",");
                    }
                    else
                    {
                        sw.Write(dt.Columns[i].ColumnName);
                    }
                }
                sw.Write(sw.NewLine);
                foreach (DataRow row in dt.Rows)
                {
                    for (int i = 0; i < dt.Columns.Count; ++i)
                    {
                        if (!Convert.IsDBNull(row[i]))
                        {
                            string value = row[i].ToString();
                            if (value.Contains(','))
                            {
                                value = String.Format("\"{0}\"", value);
                                sw.Write(value);
                            }
                            else
                            {
                                sw.Write(value);
                            }
                        }
                        if (i < dt.Columns.Count - 1)
                        {
                            sw.Write(',');
                        }
                    }
                    sw.Write('\n');
                }
                return;
            }
        }
        private void btBackUp_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = connect.connectSQL())
            {
                conn.Open();
                string query_TN = "select question.ID, question.Noi_dung, question.Hoc_phan, question.Kieu_cau_hoi, trac_nghiem.A, trac_nghiem.B, trac_nghiem.C, trac_nghiem.D, trac_nghiem.Lua_chon, trac_nghiem.Diem FROM question INNER JOIN trac_nghiem ON question.ID = trac_nghiem.ID_question";
                string query_TL = "select question.ID, question.Noi_dung, question.Hoc_phan, question.Kieu_cau_hoi, tu_luan.Diem FROM question INNER JOIN tu_luan ON question.ID = tu_luan.ID_question";
                FolderBrowserDialog choofdlog = new FolderBrowserDialog();
                choofdlog.ShowDialog();
                string FolderPath = choofdlog.SelectedPath;
                WriteValue(conn, FolderPath, query_TL, "tu_luan");
                WriteValue(conn, FolderPath, query_TN, "trac_nghiem");
                MessageBox.Show("Export successful in " + FolderPath, "Backup database", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cbType.Text == "" || cbType.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn dữ liệu cần khôi phục", "", MessageBoxButtons.OK);
                return;
            }
            if (tbFile.Text == "")
            {
                MessageBox.Show("Vui lòng chọn file khôi phục", "", MessageBoxButtons.OK);
                return;
            }
            ImportSql(table);
            MessageBox.Show("Import complete", "", MessageBoxButtons.OK);
        }
    }
}
