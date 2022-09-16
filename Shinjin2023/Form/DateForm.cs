using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Shinjin2023.Util;
using Oracle.ManagedDataAccess.Client;

namespace Shinjin2023
{
    public partial class DateForm : Form
    {
        private object Data = new object();

        /// <summary>
        /// ログイン情報
        /// </summary>
        private User LoginInfo = new User();

        public DateForm(DataGridViewRowCollection dgvrows, User userInfo)
        {
            InitializeComponent();
            //Data = booklendData;
            LoginInfo = userInfo;
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            //foreach (DataGridViewRow r in dgvrows)
            //{
            //    rows.Add(r);
            //}
            //rows.Add((DataGridViewRow)dgvrows[0]);
            for (int i = 0; i < dgvrows.Count; i++)
            {

                DataGridViewRow r = new DataGridViewRow();
                DataGridViewTextBoxCell c1 = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell c2 = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell c3 = new DataGridViewTextBoxCell();

                c1.Value = ((DataGridViewRow)dgvrows[i]).Cells[1].Value;
                c2.Value = ((DataGridViewRow)dgvrows[i]).Cells[2].Value;

                r.Cells.Add(c1);
                r.Cells.Add(c2);
                r.Cells.Add(c3);

                dgv貸出.Rows.Add(r);
            }

        }

        /// <summary>
        /// セルクリック時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DateForm_Load(object sender, EventArgs e)
        {
            //ログインユーザ情報表示用に設定
            this.lbl社員名.Text = LoginInfo.User_Name;
            //dgv貸出.DataSource = Data;
        }

        private void btn確定_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("貸出を確定しますか？",
    "確認",
    MessageBoxButtons.YesNoCancel,
    MessageBoxIcon.Exclamation,
    MessageBoxDefaultButton.Button2);

            //何が選択されたか調べる
            if (result == DialogResult.Yes)
            {

                //「はい」が選択された時
                using (var context = new Shinjin_DbContext())
                {

                    using (DbContextTransaction tra = context.Database.BeginTransaction())
                    {
                        bool statusSuccess = true;
                        bool lendSuccess = true;
                        int statussuccessCnt = 0;
                        int lendsuccessCnt = 0;
                        List<OracleParameter> parameters = new List<OracleParameter>();

                        for (int i = 0; i < dgv貸出.Rows.Count; i++)
                        {

                            parameters.Add(new OracleParameter("BOOK_ID", this.dgv貸出.Rows[i].Cells[0].Value));
                            string status = context.Database.SqlQuery<string>(CreateSqlCheckBookStatus(), parameters.ToArray()).FirstOrDefault();
                            if(status != "0")
                            {
                                break;
                            }
                            statusSuccess =(context.Database.ExecuteSqlCommand(CreateSqlUpdateStatus(), parameters.ToArray()) > 0);
                            if (statusSuccess)
                            {
                                statussuccessCnt++;
                            }

                            parameters.Clear();


                            //parameters.Add(new OracleParameter("userId", "00001"));

                            //string status = ((ComboItem)this.cmbステータス.SelectedItem).ItemValue;
                            parameters.Add(new OracleParameter("USER_ID", LoginInfo.User_ID));
                            parameters.Add(new OracleParameter("BOOK_ID", this.dgv貸出.Rows[i].Cells[0].Value));
                            //parameters.Add(new OracleParameter("LEND_DATE", this.pnl登録者.Text));
                            parameters.Add(new OracleParameter("RETURN_DATE", this.dgv貸出.Rows[i].Cells[2].Value));
                            /*parameters.Add(new OracleParameter("Date", "2022/09/15 10:19:15"));*/
                            int Cnt = context.Database.SqlQuery<int>(CreateSqlBookCount()).FirstOrDefault();
                            parameters.Add(new OracleParameter("SEQUENCE_NO", (Cnt + 1).ToString()));

                            lendSuccess = (context.Database.ExecuteSqlCommand(CreateSqlInsertBookLend(), parameters.ToArray()) > 0);
                            if (lendSuccess)
                            {
                                lendsuccessCnt++;
                            }
                            parameters.Clear();

                        }
                        if (lendsuccessCnt == dgv貸出.Rows.Count && statussuccessCnt == dgv貸出.Rows.Count)
                        {
                            tra.Commit();
                            MessageBox.Show("登録成功！");
                            this.DialogResult = DialogResult.Yes;
                            this.Close();
                        }
                        else
                        {
                            tra.Rollback();
                            MessageBox.Show("登録失敗！");

                        }
                    }
                }

            }

        }

        private string CreateSqlBookCount()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select count(*) from T_LEND_BOOK ");
            return sql.ToString();

        }

        private string CreateSqlInsertBookLend()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("insert ");
            sql.AppendLine("into T_LEND_BOOK( ");
            sql.AppendLine("    USER_ID ");
            sql.AppendLine("    , BOOK_ID ");
            sql.AppendLine("    , LEND_DATE ");
            sql.AppendLine("    , RETURN_DATE ");
            sql.AppendLine("    , SEQUENCE_NO ");
            sql.AppendLine("    , ISRETURN ");
            sql.AppendLine(") ");
            sql.AppendLine("values ( ");
            sql.AppendLine("    :USER_ID ");
            sql.AppendLine("    , :BOOK_ID ");
            sql.AppendLine("    , SYSDATE ");
            sql.AppendLine("    , :RETURN_DATE ");
            sql.AppendLine("    , :SEQUENCE_NO ");
            sql.AppendLine("    , 0 ");
            sql.AppendLine(") ");
            return sql.ToString();

        }

        private string CreateSqlCheckBookStatus()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select STATUS_CD from T_BOOK where ID=:BOOK_ID ");
            return sql.ToString();

        }

        private string CreateSqlUpdateStatus()
        {
            StringBuilder sql = new StringBuilder();

            sql.Append("update  T_BOOK set  STATUS_CD='1' where ID=:BOOK_ID ");
            return sql.ToString();

        }

        private void btn一括_Click(object sender, EventArgs e)
        {
            string lendDate = dgv貸出.Rows[0].Cells[2].Value.ToString();
            for (int i = 1; i < dgv貸出.Rows.Count; i++)
            {
                dgv貸出.Rows[i].Cells[2].Value = lendDate;
            }
        }

        private void btn閉じる_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnl社員名_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
