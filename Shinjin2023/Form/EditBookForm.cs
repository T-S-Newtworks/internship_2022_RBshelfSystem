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
using System.Data.Entity;
using Shinjin2023.Models;

namespace Shinjin2023
{
    public partial class EditBookForm : Form
    {
        private User LoginInfo = new User();

        private string Mode = string.Empty;
        public EditBookForm(User userInfo, string mode, String BookId)
        {
            InitializeComponent();
            LoginInfo = userInfo;

            Mode = mode;



            using (var context = new Shinjin_DbContext())
            {
                List<OracleParameter> parameters = new List<OracleParameter>();
                //String newID= context.Database.SqlQuery<string>(MaxBookID(), parameters.ToArray());
                int newIDnewID = context.Database.SqlQuery<int>(MaxBookID()).FirstOrDefault() + 1;

                this.txt本ID.Text = newIDnewID.ToString();
            }

            this.txt登録者.Text = LoginInfo.User_Name;



            //this.pnl本ID.Text = sql.ToString()+1; 
        }

        private void LblUserId_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 追加処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("追加を確定しますか？",
        "確認",
MessageBoxButtons.YesNoCancel,
MessageBoxIcon.Exclamation,
MessageBoxDefaultButton.Button2);

            //何が選択されたか調べる
            if (result == DialogResult.Yes)
            {
                using (var context = new Shinjin_DbContext())
                {
                    using (DbContextTransaction tra = context.Database.BeginTransaction())
                    {

                        List<OracleParameter> parameters = new List<OracleParameter>();


                        //parameters.Add(new OracleParameter("userId", "00001"));

                        //string status = ((ComboItem)this.cmbステータス.SelectedItem).ItemValue;
                        //string status = "0";
                        //string status = ((ComboItem)this.cmbステータス.SelectedItem).ItemValue;


                        parameters.Add(new OracleParameter("BookID", this.txt本ID.Text));
                        parameters.Add(new OracleParameter("Title", this.txtタイトル.Text));
                        parameters.Add(new OracleParameter("UserID", this.txt登録者.Text));
                        parameters.Add(new OracleParameter("TourokuDate", DateTime.Now));
                        /*parameters.Add(new OracleParameter("Date", "2022/09/15 10:19:15"));*/
                        parameters.Add(new OracleParameter("status", ((ComboItem)this.cmbステータス.SelectedItem).ItemValue));

                        bool isSuccess = true;
                        isSuccess = (context.Database.ExecuteSqlCommand(CreateSqlUpdateBookInfo(), parameters.ToArray()) > 0);


                        if (isSuccess)
                        {
                            tra.Commit();
                        }
                        else
                        {
                            tra.Rollback();
                        }
                    }
                }
                MessageBox.Show("登録成功！");
                this.DialogResult = DialogResult.Yes;
                //TODO: TOP画面を表示
                this.Close();
            }
        }

        
        /// <summary>
        /// ステータスコンボボックス設定処理
        /// </summary>
        /// <param name="cmbStatus"></param>
        /// <param name="selectStatus"></param>
        private void CreateStatusList(ComboBox cmbStatus, string selectStatus = null)
        {

            cmbStatus.Items.Add(new ComboItem(string.Empty, string.Empty));
            using (var context = new Shinjin_DbContext())
            {
                List<OracleParameter> parameters = new List<OracleParameter>();
                

                //ステータス情報一覧取得
                List<Bookstatus> statusList = context.Database.SqlQuery<Bookstatus>(CreateSqlFetchStatusList(), parameters.ToArray()).ToList();
                //コンボボックスに取得したステータス情報を設定
                foreach (var item in statusList)
                {
                    cmbStatus.Items.Add(new ComboItem(item.Status_Name, item.Status_Code));
                }
                
            }
        }

        private string MaxBookID()
        {
           
            StringBuilder sql = new StringBuilder(); 

            sql.AppendLine("SELECT ");
            sql.AppendLine("MAX(TO_NUMBER(ID)) ");
            sql.AppendLine("FROM T_BOOK");

            return sql.ToString();
        }
        private string CreateSqlUpdateBookInfo()
        {
            StringBuilder sql = new StringBuilder();

            sql.AppendLine("INSERT ");
            sql.AppendLine("INTO T_BOOK( ");
            sql.AppendLine("    ID ");
            sql.AppendLine("    , TITLE ");
            sql.AppendLine("    , USER_ID ");
            sql.AppendLine("    , TOUROKU_DATE ");
            sql.AppendLine("    , STATUS_CD ");
            sql.AppendLine("    , DELETE_FLAG ");
            sql.AppendLine(") ");
            sql.AppendLine("VALUES ( ");
            sql.AppendLine("    :BookID ");
            sql.AppendLine("    , :Title ");
            sql.AppendLine("    , :UserID ");
            sql.AppendLine("    , :TourokuDate ");
            sql.AppendLine("    , :status");
            sql.AppendLine("    , 0 ");
            sql.AppendLine(") ");

            return sql.ToString();
        }

        private string CreateSqlFetchStatusList()
        {
            StringBuilder sql = new StringBuilder();

          sql.AppendLine("SELECT ");
          sql.AppendLine("  CODE AS Status_Code");
          sql.AppendLine("  ,NAME AS Status_Name");
          sql.AppendLine("FROM  ");
          sql.AppendLine("  T_BOOK_STATUS");
          sql.AppendLine("ORDER BY  ");
          sql.AppendLine("    CODE ASC");


            return sql.ToString();
        }

        private void tableLayoutPanelAdd_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbステータス_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn編集確定_Click(object sender, EventArgs e)
        {

        }

        private void EditBookForm_Load(object sender, EventArgs e)
        {

            CreateStatusList(cmbステータス);

            //モードによってボタンの表示を変える
            switch (Mode)
            {
                case "追加": //変数が値Aのとき実行される
                    tableLayoutPanelEdit.Visible = false;
                    this.Text = "本の追加";
                    break;   

                case "編集": //変数が値Bのとき実
                    tableLayoutPanelAdd.Visible = false;
                    this.Text = "本の編集";
                    break;

                default: //上記の条件に変数がどれも当てはまらない場合に実行される。
                    break;　　// 文Cの実行が終わったらswitchから抜ける
            }
        }

        private void btn編集閉じる_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
