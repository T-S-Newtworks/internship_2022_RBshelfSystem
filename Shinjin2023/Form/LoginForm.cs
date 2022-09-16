using Shinjin2023.Util;
using System;
using System.Windows.Forms;
using Shinjin2023.Filter;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;
using System.Linq;

namespace Shinjin2023
{
    /// <summary>
    /// ログイン画面
    /// </summary>
    public partial class LoginForm : Form
    {
        private readonly ErrorFilter errorFilter = new ErrorFilter();

        public LoginForm()
        {
            InitializeComponent();
        }

        #region ボタンクリック、修了処理
        /// <summary>
        /// ログインボタン押下時処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            //入力チェック処理
            if (CheckInput() == false) return;

            User loginInfo = new User();
            //ログインユーザの情報検索
            using (var context = new Shinjin_DbContext())
            {
                List<OracleParameter> parameters = new List<OracleParameter>();
                parameters.Add(new OracleParameter("userId", this.TxtLoginId.Text));
                loginInfo = context.Database.SqlQuery<User>(CreateSqlFetchLoginInfo(), parameters.ToArray()).FirstOrDefault();
            }
            //トップ画面にログインユーザの情報を設定
            //TopForm topForm = new TopForm(loginInfo);
            BorrowForm borrowForm = new BorrowForm(loginInfo);
            borrowForm.Show();
            //トップ画面を開く
            //topForm.Show();

            //ログイン画面を非表示にする
            this.Hide();
        }

        /// <summary>
        /// 終了処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region チェック処理
        /// <summary>
        /// 入力チェック
        /// </summary>
        /// <returns></returns>
        private bool CheckInput()
        {
            //エラーメッセージを初期化
            this.LblErrorMessage.Text = string.Empty;

            //ログインIDが入力されていなかったらエラー
            if (string.IsNullOrEmpty(this.TxtLoginId.Text))
            {
                this.LblErrorMessage.Text = "ログインIDが未入力です。";
                return false;
            }
            //入力されたログインIDが存在しなかったらエラー
            if (LoginIdNotExists(this.TxtLoginId.Text))
            {
                this.LblErrorMessage.Text = "入力されたログインIDが存在しません。";
                return false;
            }
            //パスワードが入力されていなかったらエラー
            if (string.IsNullOrEmpty(this.TxtPass.Text))
            {
                this.LblErrorMessage.Text = "パスワードが未入力です。";
                return false;
            }
            //入力されたパスワードをハッシュ化
            string convertedPass = Common.Hashed(this.TxtPass.Text);
            //入力されたパスワードがログインIDと紐づいていない場合はエラー
            if (PassCheck(this.TxtLoginId.Text, convertedPass) == false)
            {
                this.LblErrorMessage.Text = "パスワードに誤りがあります。";
                return false;
            }

            return true;
        }

        /// <summary>
        /// 入力されたログインID存在チェック
        /// 存在しない場合にtureを返す
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private bool LoginIdNotExists(string id)
        {
            using (var context = new Shinjin_DbContext())
            {
                List<OracleParameter> parameters = new List<OracleParameter>();
                parameters.Add(new OracleParameter("id", id));

                return context.Database.SqlQuery<int>(CreateSqLoginIdExists(), parameters.ToArray()).FirstOrDefault() <= 0;
            }
        }

        /// <summary>
        /// 入力されたパスワードがのチェック
        /// 正しい場合はtureを返す
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        private bool PassCheck(string id, string pass)
        {
            using (var context = new Shinjin_DbContext())
            {
                List<OracleParameter> parameters = new List<OracleParameter>();
                parameters.Add(new OracleParameter("id", id));
                parameters.Add(new OracleParameter("pass", pass));

                return context.Database.SqlQuery<int>(CreateSqlPassCheck(), parameters.ToArray()).FirstOrDefault() > 0;
            }
        }
        #endregion

        #region SQL
        private string CreateSqLoginIdExists()
        {
            StringBuilder sql = new StringBuilder();

            sql.AppendLine("SELECT ");
            sql.AppendLine("    COUNT(*) COUNT ");
            sql.AppendLine("FROM ");
            sql.AppendLine("    T_USER ");
            sql.AppendLine("WHERE ");
            sql.AppendLine("    USER_ID = :id ");

            return sql.ToString();
        }

        private string CreateSqlPassCheck()
        {
            StringBuilder sql = new StringBuilder();

            sql.AppendLine("SELECT ");
            sql.AppendLine("    COUNT(*) COUNT ");
            sql.AppendLine("FROM ");
            sql.AppendLine("    T_USER ");
            sql.AppendLine("WHERE ");
            sql.AppendLine("    USER_ID = :id ");
            sql.AppendLine("    AND USER_PASS = :pass ");

            return sql.ToString();
        }

        private string CreateSqlFetchLoginInfo()
        {
            StringBuilder sql = new StringBuilder();

            sql.AppendLine("SELECT ");
            sql.AppendLine("    users.USER_ID AS User_ID ");
            sql.AppendLine("    , users.USER_NAME AS User_Name ");
            sql.AppendLine("    , syozoku.SYOZOKU_CD AS Syozoku_Cd ");
            sql.AppendLine("    , syozoku.SYOZOKU_NAME AS Syozoku_Name ");
            sql.AppendLine("    , users.KENGEN_CD AS Kengen_Cd ");
            sql.AppendLine("    , users.KENGEN AS Kengen ");
            sql.AppendLine("FROM ");
            sql.AppendLine("    T_USER users ");
            sql.AppendLine("    LEFT JOIN T_SYOZOKU syozoku ");
            sql.AppendLine("        ON users.SYOZOKU_CD = syozoku.SYOZOKU_CD ");
            sql.AppendLine("WHERE ");
            sql.AppendLine("    users.USER_ID = :userId ");
            sql.AppendLine("ORDER BY ");
            sql.AppendLine("    users.USER_ID ");

            return sql.ToString();
        }
        #endregion
    }
}
