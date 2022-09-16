using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Oracle.ManagedDataAccess.Client;
using Shinjin2023.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Shinjin2023.Models;

namespace Shinjin2023
{
    
    public partial class BorrowForm : Form
    {
        private User LoginInfo = new User();

        public BorrowForm(User userInfo)
        {
            InitializeComponent();
            LoginInfo= userInfo;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var context = new Shinjin_DbContext())
            {
                
                List<Book> books = context.Database.SqlQuery<Book>(CreateSqlFetchBook() /*parameters.ToArray()*/).ToList();

                dgv本一覧.DataSource = books;
                //DataGridViewに検索結果を設定
                //this.Book_ID. = books;
            }
                
        }

        private string CreateSqlFetchBook()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("select ");
            sql.AppendLine("    Book.ID As Book_ID ");
            sql.AppendLine("    , Book.TITLE ");
            sql.AppendLine("    , Usera.USER_NAME As User_Name ");
            sql.AppendLine("    , lend.RETURN_DATE as RETURN_DATE ");
            sql.AppendLine("    , Book_Status.NAME As Status_Name ");
            sql.AppendLine("from ");
            sql.AppendLine("    T_BOOK Book ");
            sql.AppendLine("    left join T_USER Usera ");
            sql.AppendLine("        on Book.USER_ID = Usera.USER_ID ");
            sql.AppendLine("    left join T_BOOK_STATUS Book_Status ");
            sql.AppendLine("        on Book.STATUS_CD = Book_Status.CODE ");
            sql.AppendLine("        left join (select * from T_LEND_BOOK where ISRETURN = '0') lend ");
            sql.AppendLine("        on Book.ID = lend.BOOK_ID ");

            return sql.ToString();
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            ReturnBookForm ReturnBookForm = new ReturnBookForm(LoginInfo);
            ReturnBookForm.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnUser_Click(object sender, EventArgs e)
        {

            string BookId = "10";
            EditBookForm EditBookForm = new EditBookForm(LoginInfo, "追加", BookId);
            if (EditBookForm.ShowDialog() == DialogResult.Yes)
            {
                RefreshGrid();
            }

            //string BookId = "10";
            //EditBookForm EditBookForm = new EditBookForm(LoginInfo,"追加", BookId);
            //EditBookForm.ShowDialog();
        }

        private void btn編集_Click(object sender, EventArgs e)
        {
            string BookId = "10";
            EditBookForm EditBookForm = new EditBookForm(LoginInfo,"編集", BookId);
            EditBookForm.ShowDialog();
        }

        private void btn貸出_Click(object sender, EventArgs e)
        {
           DateForm DateForm = new DateForm(dgv予定一覧.Rows, LoginInfo);
           if ( DateForm.ShowDialog() == DialogResult.Yes)
            {
                RefreshGrid();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BorrowForm_Load(object sender, EventArgs e)
        {
            using (var context = new Shinjin_DbContext())
            {
                //ログインユーザ情報表示用に設定
                this.lbl社員名.Text = LoginInfo.User_Name;

                if(LoginInfo.Kengen_Cd != "0")
                {
                    groupBox2.Visible = false;
                }
                dgv本一覧.CurrentCell = null;
                List<Book> books = context.Database.SqlQuery<Book>(CreateSqlFetchBook() /*parameters.ToArray()*/).ToList();

                dgv本一覧.DataSource = books;

                dgv本一覧.Columns["User_ID"].Visible = false;
                dgv本一覧.Columns["Touroku_Date"].Visible = false;
                dgv本一覧.Columns["Status_Cd"].Visible = false;
                dgv本一覧.Columns["Delete_Flag"].Visible = false;
                dgv本一覧.Columns["Delete_Flag"].Visible = false;

                //DataGridViewに検索結果を設定
                //this.Book_ID. = books;
            }
        }

        private void btn貸出追加_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < dgv本一覧.RowCount; i++)

            {
                DataGridViewCheckBoxCell chkcell = (DataGridViewCheckBoxCell)dgv本一覧.Rows[i].Cells[0];
                object chk = chkcell.Value;

                if (chk != null && chk.ToString() == "True")
                {
                    bool isExist = true;

                    for (int j = 0; j < dgv予定一覧.RowCount; j++)
                    {
                        if(dgv本一覧.Rows[i].Cells[1].Value == dgv予定一覧.Rows[j].Cells[1].Value)
                        {
                            isExist = false;
                        }
                    }
                    if (isExist) {

                        DataGridViewRow r = new DataGridViewRow();
                        r.Cells.Add(new DataGridViewCheckBoxCell());

                        DataGridViewTextBoxCell cell1 = new DataGridViewTextBoxCell();
                        cell1.Value = dgv本一覧.Rows[i].Cells[1].Value;
                        DataGridViewTextBoxCell cell2 = new DataGridViewTextBoxCell();
                        cell2.Value = dgv本一覧.Rows[i].Cells[2].Value;

                        r.Cells.Add(cell1);
                        r.Cells.Add(cell2);

                        //dgv予定一覧.Rows.Add(r);
                        int idx = dgv予定一覧.Rows.Count;
                        dgv予定一覧.Rows.Add(r);
                        }
                }
            }
        }

        private void pnl件数_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn貸出削除_Click(object sender, EventArgs e)
        {
            int rowCount = dgv予定一覧.RowCount;
            int deleteCnt = 0;
            for (int i = 0; i < rowCount; i++)
            {
                DataGridViewCheckBoxCell chkcell = (DataGridViewCheckBoxCell) dgv予定一覧.Rows[i- deleteCnt].Cells[0];
                object chk = chkcell.Value;

                if (chk != null && chk.ToString() == "True")
                {
                    dgv予定一覧.Rows.RemoveAt(i - deleteCnt);
                    deleteCnt++;
                }
            }
        }

        private void dgv本一覧_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void RefreshGrid()
        {
            using (var context = new Shinjin_DbContext())
            {

                dgv本一覧.CurrentCell = null;
                List<Book> books = context.Database.SqlQuery<Book>(CreateSqlFetchBook() /*parameters.ToArray()*/).ToList();

                dgv本一覧.DataSource = books;

                dgv本一覧.Columns["User_ID"].Visible = false;
                dgv本一覧.Columns["Touroku_Date"].Visible = false;
                dgv本一覧.Columns["Status_Cd"].Visible = false;
                dgv本一覧.Columns["Delete_Flag"].Visible = false;
                dgv本一覧.Columns["Delete_Flag"].Visible = false;
            }

        }

        private void BorrowForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //アプリケーションを終了する
            Application.Exit();
        }
    }
}
