using System;
using System.Windows.Forms;
using Shinjin2023.Util;

namespace Shinjin2023
{
    /// <summary>
    /// TOP画面
    /// </summary>
    public partial class TopForm : Form
    {
        /// <summary>
        /// ログイン情報
        /// </summary>
        private User LoginInfo = new User();

        public TopForm(User userInfo)
        {
            InitializeComponent();
            LoginInfo = userInfo;
        }

        /// <summary>
        /// 画面読込時処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TopForm_Load(object sender, EventArgs e)
        {
            //ログインユーザ情報表示用に設定
            this.LblLoginUserName.Text = LoginInfo.User_Name;
            this.LblLoginUserSyozoku.Text = LoginInfo.Syozoku_Name;

            //ログにログイン情報を書き込み
            Logger.WriteInfo("ログイン成功");
            Logger.WriteInfo("ログインユーザ情報: 名前: " + LoginInfo.User_Name + " 所属:" + LoginInfo.Syozoku_Name + " 権限:" + LoginInfo.Kengen);

            //ログインユーザの権限が管理者の場合
            if (LoginInfo.Kengen_Cd == Common.ADMIN_CODE)
            {
                LblManagerTitle.Show();
                LblManagerBorder.Show();
                BtnUser.Show();
            }
        }

        #region ボタンクリック処理
        /// <summary>
        /// 機能Aボタン押下時処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnA_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("この機能は未実装です。", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //EditBookForm EditBookForm = new EditBookForm(LoginInfo);
            //EditBookForm.ShowDialog();
        }

        /// <summary>
        /// 機能Bボタン押下時処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("この機能は未実装です。", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        ///ユーザ管理ボタン押下時処理 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUser_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm(LoginInfo);
            userForm.ShowDialog();
        }

        /// <summary>
        /// ログアウトボタン押下時処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            //ログイン画面を開く
            loginForm.Show();
            //トップ画面を非表示にする
            this.Hide();
            Logger.WriteInfo("ログアウト");
        }
        #endregion

        private void PnlUserInfo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
