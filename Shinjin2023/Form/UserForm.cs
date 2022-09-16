using Oracle.ManagedDataAccess.Client;
using Shinjin2023.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Shinjin2023
{
    /// <summary>
    /// ユーザ管理画面
    /// </summary>
    public partial class UserForm : Form
    {
        /// <summary>
        /// ログイン情報
        /// </summary>
        private User LoginInfo = new User();

        public UserForm(User userInfo)
        {
            InitializeComponent();
            LoginInfo = userInfo;
        }

        /// <summary>
        /// 画面読込時処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserForm_Load(object sender, EventArgs e)
        {
            //ユーザーID,名前テキストボックスに空白を設定
            this.TxtUserId.Text = string.Empty;
            this.TxtUserName.Text = string.Empty;
            //T_SYOZOKUテーブルから一覧を取得して設定する。
            CreateSyozokuList(this.CmbSyozoku);
        }

        # region ボタンクリック、グリッドビュー表示処理
        /// <summary>
        /// 検索ボタン押下時処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Logger.WriteInfo("検索処理開始");

            //エラーメッセージを初期化
            this.LblErrorMessage.Text = string.Empty;

            //検索処理実行
            ExcuteSearch();

            //検索結果が存在するかチェック
            // 一番下の行を表示にすると結果が0件の場合1件プラスになるので1より多きいかで判定
            if (this.DgvUsers.Rows.Count > 1)
            {
                //ヘッダーを中央揃えに設定
                this.DgvUsers.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //列幅設定
                this.DgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                //ユーザID、所属、権限は読み取り専用に設定
                this.DgvUsers.Columns["User_ID"].ReadOnly = true;
                this.DgvUsers.Columns["Syozoku_Name"].ReadOnly = true;
                this.DgvUsers.Columns["Kengen"].ReadOnly = true;
                //所属、権限コードを非表示に設定
                this.DgvUsers.Columns["Syozoku_Cd"].Visible = false;
                this.DgvUsers.Columns["Kengen_Cd"].Visible = false;

                //ログに検索結果の件数書き込み
                Logger.WriteInfo("検索件数: " + this.DgvUsers.RowCount.ToString() + "件");
            }
            else
            {
                this.LblErrorMessage.Text = "検索条件に紐づくユーザ情報が存在しません。";
                Logger.WriteInfo(this.LblErrorMessage.Text);
            }

            Logger.WriteInfo("検索処理終了");
        }

        /// <summary>
        /// ダブルクリック時処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //ヘッダーダブルクリックの際の対策
            if (e.RowIndex != -1)
            {
                EditForm editForm = new EditForm(LoginInfo);
                using (var context = new Shinjin_DbContext())
                {
                    int maxUserID = int.Parse(context.Database.SqlQuery<string>(CreateSqFetchMaxUserID()).FirstOrDefault());
                    int selectedUserID = 0;
                    if (this.DgvUsers.Rows[e.RowIndex].Cells["User_ID"].Value != null)
                    {
                        selectedUserID = int.Parse(this.DgvUsers.Rows[e.RowIndex].Cells["User_ID"].Value.ToString());
                    }
                    //ユーザIDの現在の最大値よりクリック行のユーザIDの方が大きい場合又は、クリック行のが新規追加行は登録処理設定を行う
                    if (maxUserID < selectedUserID || selectedUserID == 0)
                    {
                        editForm.BtnEdit.Text = "登録";
                        CreateSyozokuList(editForm.CmbSyozoku);
                        CreateKengenList(editForm.CmbKengen);
                        //ユーザIDの最大値の次の値になるように加算する
                        maxUserID++;
                        //0埋めして編集画面のユーザIDに設定
                        editForm.TxtUserId.Text = String.Format("{0:00000}", maxUserID);
                    }
                    //更新処理設定
                    else
                    {
                        CreateSyozokuList(editForm.CmbSyozoku, this.DgvUsers.Rows[e.RowIndex].Cells["Syozoku_Name"].Value.ToString());
                        CreateKengenList(editForm.CmbKengen, this.DgvUsers.Rows[e.RowIndex].Cells["Kengen"].Value.ToString());
                        editForm.TxtUserId.Text = this.DgvUsers.Rows[e.RowIndex].Cells["User_ID"].Value.ToString();
                        editForm.TxtUserName.Text = this.DgvUsers.Rows[e.RowIndex].Cells["User_Name"].Value.ToString();
                        editForm.LblRequiredPass.Visible = false;
                    }
                }

                //所属が管理部以外の場合または処理状態が登録の場合は、削除ボタンを非表示に設定
                if (LoginInfo.Syozoku_Cd != Common.ADMIN_DEPARTMENT_CODE || editForm.BtnEdit.Text == "登録")
                {
                    editForm.BtnDelete.Hide();
                    //表示位置を変更
                    editForm.BtnEdit.Location = new Point(178, 12);
                }

                //編集画面で処理終了後のダイアログでOKが押された場合は再検索
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    ExcuteSearch();
                }
            }
        }

        /// <summary>
        /// クリアボタン押下時処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClear_Click(object sender, EventArgs e)
        {
            //ユーザーID,名前テキストボックスに空白を設定
            this.TxtUserId.Text = string.Empty;
            this.TxtUserName.Text = string.Empty;
            if (0 < this.CmbSyozoku.Items.Count)
            {
                //選択値を0に設定
                this.CmbSyozoku.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// 閉じるボタン押下時処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Click(object sender, EventArgs e)
        {
            //画面を閉じる
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        #endregion

        #region コンボボックス設定、検索処理
        /// <summary>
        /// 所属コンボボックス設定処理
        /// </summary>
        /// <param name="cmbSyozoku"></param>
        /// <param name="selectSyozoku"></param>
        private void CreateSyozokuList(ComboBox cmbSyozoku, string selectSyozoku = null)
        {
            if (LoginInfo.Syozoku_Cd == Common.ADMIN_DEPARTMENT_CODE)
            {
                //コンボボックスの先頭一列目に空白を設定
                //ログインユーザの所属が管理部の場合は全件検索が可能なため
                cmbSyozoku.Items.Add(new ComboItem(string.Empty, string.Empty));
            }

            using (var context = new Shinjin_DbContext())
            {
                List<OracleParameter> parameters = new List<OracleParameter>();
                //ログインユーザの所属が管理部以外の場合は所属をログイン情報で固定
                if (LoginInfo.Syozoku_Cd != Common.ADMIN_DEPARTMENT_CODE)
                {
                    parameters.Add(new OracleParameter("syozoku", LoginInfo.Syozoku_Name));
                }

                //所属情報一覧取得
                List<Syozoku> syosokuList = context.Database.SqlQuery<Syozoku>(CreateSqlFetchSyozokuList(), parameters.ToArray()).ToList();
                //コンボボックスに取得した所属情報を設定
                foreach (var item in syosokuList)
                {
                    cmbSyozoku.Items.Add(new ComboItem(item.Syozoku_Name, item.Syozoku_Cd));
                }
                cmbSyozoku.DisplayMember = "ItemText";
                cmbSyozoku.ValueMember = "ItemValue";
                //初期選択値を設定
                cmbSyozoku.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// 権限コンボボックス設定処理
        /// </summary>
        /// <param name="cmbKengen"></param>
        /// <param name="selectKengen"></param>
        private void CreateKengenList(ComboBox cmbKengen, string selectKengen = null)
        {
            cmbKengen.Items.Add(new ComboItem("一般", Common.NONE_CODE));
            cmbKengen.Items.Add(new ComboItem("管理者", Common.ADMIN_CODE));

            if (selectKengen == Common.NONE_CODE)
            {
                cmbKengen.SelectedIndex = 0;
            }
            else if (selectKengen == Common.ADMIN_CODE)
            {
                cmbKengen.SelectedIndex = 1;
            }
        }

        /// <summary>
        /// 検索処理実行
        /// </summary>
        /// <returns></returns>
        private void ExcuteSearch()
        {
            //入力されたユーザIDを設定
            string userId = this.TxtUserId.Text;
            //入力された氏名を設定
            string userName = this.TxtUserName.Text;
            //選択された所属コードを設定
            string syozoku = ((ComboItem)this.CmbSyozoku.SelectedItem).ItemValue;

            using (var context = new Shinjin_DbContext())
            {
                List<OracleParameter> parameters = new List<OracleParameter>();
                if (!string.IsNullOrEmpty(userId))
                {
                    parameters.Add(new OracleParameter("userId", userId));
                }

                if (!string.IsNullOrEmpty(userName))
                {
                    parameters.Add(new OracleParameter("userName", userName));
                }

                if (!string.IsNullOrEmpty(syozoku))
                {
                    parameters.Add(new OracleParameter("syozoku", syozoku));
                }

                //ユーザ情報を検索
                List<User> users = context.Database.SqlQuery<User>(CreateSqlFetchUserInfo(userId, userName, syozoku), parameters.ToArray()).ToList();
                //新規追加用用に追加
                users.Add(new User());
                //DataGridViewに検索結果を設定
                this.DgvUsers.DataSource = users;
            }
        }
        #endregion 

        #region SQL
        private string CreateSqlFetchSyozokuList()
        {
            StringBuilder sql = new StringBuilder();

            sql.AppendLine("SELECT ");
            sql.AppendLine("    SYOZOKU_CD ");
            sql.AppendLine("    , SYOZOKU_NAME ");
            sql.AppendLine("FROM ");
            sql.AppendLine("    T_SYOZOKU ");

            //ログインユーザの所属が管理部以外の場合は所属をログイン情報で固定
            if (LoginInfo.Syozoku_Cd != "007")
            {
                sql.AppendLine("WHERE ");
                sql.AppendLine("    SYOZOKU_NAME = :syozoku ");
            }

            sql.AppendLine("ORDER BY ");
            sql.AppendLine("    SYOZOKU_CD ");

            return sql.ToString();
        }

        private string CreateSqlFetchUserInfo(string userId, string userName, string syozoku)
        {
            StringBuilder sql = new StringBuilder();

            sql.AppendLine("SELECT ");
            sql.AppendLine("    users.USER_ID");
            sql.AppendLine("    , users.USER_NAME");
            sql.AppendLine("    , syozoku.SYOZOKU_NAME");
            sql.AppendLine("    , users.KENGEN AS");
            sql.AppendLine("FROM ");
            sql.AppendLine("    T_USER users ");
            sql.AppendLine("    LEFT JOIN T_SYOZOKU syozoku ");
            sql.AppendLine("        ON users.SYOZOKU_CD = syozoku.SYOZOKU_CD ");
            //ANDを追加しやするする為に記述
            sql.AppendLine("WHERE ");
            sql.AppendLine("    '1' = '1' ");

            if (!string.IsNullOrEmpty(userId))
            {
                sql.AppendLine("AND users.USER_ID LIKE '%' || :userId || '%' ");
            }

            if (!string.IsNullOrEmpty(userName))
            {
                sql.AppendLine("AND users.USER_NAME LIKE '%' || :userName || '%' ");
            }

            if (!string.IsNullOrEmpty(syozoku))
            {
                sql.AppendLine("AND users.SYOZOKU_CD = :syozoku ");
            }

            sql.AppendLine("    AND users.DELETE_YMD IS NULL ");
            sql.AppendLine("ORDER BY ");
            sql.AppendLine("    users.USER_ID ");

            return sql.ToString();
        }

        private string CreateSqFetchMaxUserID()
        {
            StringBuilder sql = new StringBuilder();

            sql.AppendLine("SELECT ");
            sql.AppendLine("    MAX(USER_ID) ");
            sql.AppendLine("FROM ");
            sql.AppendLine("    T_USER ");

            return sql.ToString();
        }
        #endregion

        private void CmbSyozoku_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
