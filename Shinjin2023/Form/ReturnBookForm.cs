using System;
using System.Windows.Forms;
using Shinjin2023.Util;
using System.Text;
using Shinjin2023.Models;
using System.Collections.Generic;
using System.Linq;
using Oracle.ManagedDataAccess.Client;
using System.Data.Entity;

namespace Shinjin2023
{
    public partial class ReturnBookForm : Form
    {
        private User LoginInfo = new User();
        public ReturnBookForm(User userInfo)
        {
            InitializeComponent();
            LoginInfo = userInfo;
        }

        private void ReturnBookForm_Load(object sender, EventArgs e)
        {
            using (var context = new Shinjin_DbContext())
            {
                List<OracleParameter> parameters = new List<OracleParameter>();

                parameters.Add(new OracleParameter("UserID", LoginInfo.User_ID));

                List<Book> books = context.Database.SqlQuery<Book>(CreateSqlLendUserBook(), parameters.ToArray()).ToList();

                if (books.Count > 0)
                {
                    dgv返却.DataSource = books;
                }
            }
        }


        private string CreateSqlLendUserBook()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select ");
            sql.Append("    LendBook.BOOK_ID As Book_ID ");
            sql.Append("    , Book.TITLE As Title");
            sql.Append("    , LendBook.RETURN_DATE As Return_Date ");
            sql.Append("from ");
            sql.Append("    T_LEND_BOOK LendBook ");
            sql.Append("    LEFT JOIN T_BOOK Book ");
            sql.Append("        ON LendBook.BOOK_ID = Book.ID ");
            sql.Append("WHERE ");
            sql.Append("    LendBook.USER_ID = :UserID ");
            sql.Append("AND ");
            sql.Append("LendBook.ISRETURN = 0 ");

            return sql.ToString();
        }

        private void btn返却確定_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < dgv返却.RowCount; i++)

            {
                DataGridViewCheckBoxCell chkcell = (DataGridViewCheckBoxCell)dgv返却.Rows[i].Cells[0];
                object chk = chkcell.Value;

                if (chk != null && chk.ToString() == "True")
                {
                    using (var context = new Shinjin_DbContext())
                    {
                        using (DbContextTransaction tra = context.Database.BeginTransaction())
                        {
                            List<OracleParameter> parameters = new List<OracleParameter>();
                            parameters.Add(new OracleParameter("BookId", dgv返却.Rows[i].Cells[1].Value));
                            

                            bool isSuccess = true;
                            isSuccess = (context.Database.ExecuteSqlCommand(CreateSqlUpdateT_BOOK(), parameters.ToArray()) > 0);
                            isSuccess = (context.Database.ExecuteSqlCommand(CreateSqlUpdateT_LENDBOOK(), parameters.ToArray()) > 0);

                            if (isSuccess)
                            {
                                tra.Commit();
                            }
                            else
                            {
                                tra.Rollback();
                            }

                        }
                        MessageBox.Show("返却完了！");
                        ReturnBookForm_Load(sender, e);
                    }
                }

                //if ((bool)dgv返却.Rows[i].Cells[0].Selected)
                //{
                //    DataGridViewRow r = new DataGridViewRow();
                //    r.Cells.Add(new DataGridViewCheckBoxCell());


                //    //cell1.Value = dgv返却.Rows[i].Cells[1].Value;


                //    //cell2.Value = dgv返却.Rows[i].Cells[2].Value;

                //    //cell3.Value = dgv返却.Rows[i].Cells[3].Value;
                //}

            }

            //using (var context = new Shinjin_DbContext())
            //{
            //    using (DbContextTransaction tra = context.Database.BeginTransaction())
            //    {
            //        List<OracleParameter> parameters = new List<OracleParameter>();
            //        parameters.Add(new OracleParameter("STATUS_CD", "0"));
            //        parameters.Add(new OracleParameter("UserID", LoginInfo.User_ID));

            //        bool isSuccess = true;
            //        isSuccess = (context.Database.ExecuteSqlCommand(CreateSqlUpdateT_BOOK(), parameters.ToArray()) > 0);

            //        if (isSuccess)
            //        {
            //            tra.Commit();
            //        }
            //        else
            //        {
            //            tra.Rollback();
            //        }
            //    }
            //}
        }

        private string CreateSqlUpdateT_BOOK()
        {
            StringBuilder sql = new StringBuilder();
            //sql.Append("UPDATE T_BOOK ");
            //sql.Append("SET ID = :STATUS_CD ");
            //sql.Append("WHERE USER_ID = :UserID ");

            sql.Append("UPDATE T_BOOK SET STATUS_CD = 0 ");
            sql.Append("WHERE ID = :BookId ");

            return sql.ToString();
        }

        private string CreateSqlUpdateT_LENDBOOK()
        {
            StringBuilder sql = new StringBuilder();

            sql.Append("UPDATE T_LEND_BOOK SET ISRETURN = 1 ");
            sql.Append("WHERE BOOK_ID = :BookId");


            return sql.ToString();
        }

        private void dgv返却_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //for (int i = 0; i < dgv返却.RowCount; i++)

            //{
            //    if ((bool)dgv返却.Rows[i].Cells[0].Selected)
            //    {
            //        DataGridViewRow r = new DataGridViewRow();
            //        r.Cells.Add(new DataGridViewCheckBoxCell());


            //        //cell1.Value = dgv返却.Rows[i].Cells[1].Value;


            //        //cell2.Value = dgv返却.Rows[i].Cells[2].Value;

            //        //cell3.Value = dgv返却.Rows[i].Cells[3].Value;
            //    }

            //}
        }

        private void btn返却閉じる_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //private void btn返却閉じる(object sender, EventArgs e)
        //{
        //    this.Close();
        //}
    }
}
