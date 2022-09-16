using Oracle.ManagedDataAccess.Client;
using Shinjin2023.Util;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using System.Windows.Forms;

namespace Shinjin2023
{
    /// <summary>
    /// ユーザ情報編集画面
    /// </summary>
    public partial class EditForm : Form
    {
        /// <summary>
        /// ログイン情報
        /// </summary>
        private User LoginInfo = new User();

        public EditForm(User userInfo)
        {
            InitializeComponent();
            LoginInfo = userInfo;
        }

        #region ボタンクリック処理
        /// <summary>
        /// 登録、更新ボタン押下時処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            //ユーザー名が入力されていない場合はエラーメッセージを表示
            if (string.IsNullOrEmpty(this.TxtUserName.Text))
            {
                MessageBox.Show("名前が未入力です。", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (MessageBox.Show("入力した情報で" + this.BtnEdit.Text + "します。\r\nよろしいですか?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Logger.WriteInfo(this.BtnEdit.Text + "処理開始");
                //登録、更新処理実行
                if (Execute())
                {
                    this.DialogResult = MessageBox.Show(this.BtnEdit.Text + "処理に成功しました。", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    this.DialogResult = MessageBox.Show(this.BtnEdit.Text + "処理に失敗しました。\r\n開発元にお知らせください。", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Logger.WriteInfo(this.BtnEdit.Text + "処理修了");
                this.Close();
            }
        }

        /// <summary>
        /// 削除ボタン押下時処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("選択した情報を削除します。\r\nよろしいですか?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Logger.WriteInfo("削除処理開始");
                if (ExecuteDelete())
                {
                    this.DialogResult = MessageBox.Show("削除処理に成功しました。", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    this.DialogResult = MessageBox.Show("削除処理に失敗しました。\r\n開発元にお知らせください。", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Logger.WriteInfo("削除処理修了");
                this.Close();
            }
        }
        #endregion

        #region 登録、更新、削除処理
        /// <summary>
        /// 登録、更新処理実行
        /// </summary>
        /// <returns></returns>
        private bool Execute()
        {
            using (var context = new Shinjin_DbContext())
            {
                using (DbContextTransaction tra = context.Database.BeginTransaction())
                {
                    List<OracleParameter> parameters = new List<OracleParameter>();
                    bool isSuccess = true;

                    //選択された所属コードを設定
                    string syozoku = ((ComboItem)this.CmbSyozoku.SelectedItem).ItemValue;
                    //選択された権限を設定
                    string kengenCd = ((ComboItem)this.CmbKengen.SelectedItem).ItemValue;
                    string kengen = ((ComboItem)this.CmbKengen.SelectedItem).ItemText;

                    //入力されたパスワードをハッシュ化
                    string convertedPass = Common.Hashed(this.TxtPass.Text);

                    //登録処理
                    if (this.BtnEdit.Text == "登録")
                    {
                        parameters.Add(new OracleParameter("userId", this.TxtUserId.Text));
                        parameters.Add(new OracleParameter("userName", this.TxtUserName.Text));
                        parameters.Add(new OracleParameter("syozoku", syozoku));
                        parameters.Add(new OracleParameter("kengenCd", kengenCd));
                        parameters.Add(new OracleParameter("kengen", kengen));
                        //入力されたパスワードをハッシュ化して設定
                        parameters.Add(new OracleParameter("pass", convertedPass));
                        parameters.Add(new OracleParameter("loginUserId", LoginInfo.User_ID));

                        isSuccess = (context.Database.ExecuteSqlCommand(CreateSqlInsertUserInfo(), parameters.ToArray()) > 0);

                        if (isSuccess)
                        {
                            tra.Commit();
                        }
                        else
                        {
                            tra.Rollback();
                        }

                    }
                    //更新処理
                    else if (this.BtnEdit.Text == "更新")
                    {
                        parameters.Add(new OracleParameter("userName", this.TxtUserName.Text));
                        parameters.Add(new OracleParameter("syozoku", syozoku));
                        parameters.Add(new OracleParameter("kengenCd", kengenCd));
                        parameters.Add(new OracleParameter("kengen", kengen));
                        //入力されたパスワードをハッシュ化して設定
                        parameters.Add(new OracleParameter("pass", convertedPass));
                        parameters.Add(new OracleParameter("loginUserId", LoginInfo.User_ID));
                        parameters.Add(new OracleParameter("userId", this.TxtUserId.Text));

                        isSuccess = (context.Database.ExecuteSqlCommand(CreateSqlUpdateUserInfo(), parameters.ToArray()) > 0);

                        if (isSuccess)
                        {
                            tra.Commit();
                        }
                        else
                        {
                            tra.Rollback();
                        }

                    }

                    return isSuccess;
                }
            }
        }

        /// <summary>
        /// 削除処理実行
        /// </summary>
        /// <returns></returns>
        private bool ExecuteDelete()
        {
            using (var context = new Shinjin_DbContext())
            {
                using (DbContextTransaction tra = context.Database.BeginTransaction())
                {
                    bool isSuccess = true;
                    List<OracleParameter> parameters = new List<OracleParameter>();
                    parameters.Add(new OracleParameter("loginUserId", LoginInfo.User_ID));
                    parameters.Add(new OracleParameter("userId", this.TxtUserId.Text));

                    isSuccess = (context.Database.ExecuteSqlCommand(CreateSqlLogicalDeleteUserInfo(), parameters.ToArray()) > 0);

                    if (isSuccess)
                    {
                        tra.Commit();
                    }
                    else
                    {
                        tra.Rollback();
                    }

                    return isSuccess;
                }
            }
        }
        #endregion

        #region SQL
        private string CreateSqlInsertUserInfo()
        {
            StringBuilder sql = new StringBuilder();

            sql.AppendLine("INSERT ");
            sql.AppendLine("INTO T_USER( ");
            sql.AppendLine("    USER_ID ");
            sql.AppendLine("    , USER_NAME ");
            sql.AppendLine("    , SYOZOKU_CD ");
            sql.AppendLine("    , KENGEN_CD ");
            sql.AppendLine("    , KENGEN ");
            sql.AppendLine("    , USER_PASS ");
            sql.AppendLine("    , SUBMIT_USER_ID ");
            sql.AppendLine("    , SUBMIT_YMD ");
            sql.AppendLine(") ");
            sql.AppendLine("VALUES ( ");
            sql.AppendLine("    :userId ");
            sql.AppendLine("    , :userName ");
            sql.AppendLine("    , :syozoku ");
            sql.AppendLine("    , :kengenCd ");
            sql.AppendLine("    , :kengen ");
            sql.AppendLine("    , :pass ");
            sql.AppendLine("    , :loginUserId ");
            sql.AppendLine("    , CURRENT_DATE ");
            sql.AppendLine(") ");

            return sql.ToString();
        }

        private string CreateSqlUpdateUserInfo()
        {
            StringBuilder sql = new StringBuilder();

            sql.AppendLine("UPDATE T_USER ");
            sql.AppendLine("SET ");
            sql.AppendLine("    USER_NAME = :userName ");
            sql.AppendLine("    , SYOZOKU_CD = :syozoku ");
            sql.AppendLine("    , KENGEN_CD = :kengenCd ");
            sql.AppendLine("    , KENGEN = :kengen ");
            sql.AppendLine("    , USER_PASS = :pass ");
            sql.AppendLine("    , SUBMIT_USER_ID = :loginUserId ");
            sql.AppendLine("    , UPDATE_YMD = CURRENT_DATE ");
            sql.AppendLine("WHERE ");
            sql.AppendLine("    USER_ID = :userId ");

            return sql.ToString();
        }

        private string CreateSqlLogicalDeleteUserInfo()
        {
            StringBuilder sql = new StringBuilder();

            sql.AppendLine("UPDATE T_USER ");
            sql.AppendLine("SET ");
            sql.AppendLine("    SUBMIT_USER_ID = :loginUserId ");
            sql.AppendLine("    , DELETE_YMD = CURRENT_DATE ");
            sql.AppendLine("WHERE ");
            sql.AppendLine("    USER_ID = :userId ");

            return sql.ToString();
        }
        #endregion

        private void TxtUserId_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmbSyozoku_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CmbKengen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
