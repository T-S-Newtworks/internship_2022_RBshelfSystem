using Shinjin2023.Util;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Shinjin2023.Filter
{
    class ErrorFilter
    {
        public ErrorFilter()
        {
            // ThreadExceptionイベント・ハンドラを登録する
            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);

            // UnhandledExceptionイベント・ハンドラを登録する
            Thread.GetDomain().UnhandledException += new UnhandledExceptionEventHandler(Application_UnhandledException);
        }

        public static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            ShowErrorMessage(e.Exception, "Application_ThreadExceptionによる例外通知です。");
        }

        /// <summary>
        ///  未処理例外をキャッチするイベント・ハンドラ
        // （主にコンソール・アプリケーション用）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void Application_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = e.ExceptionObject as Exception;
            if (ex != null)
            {
                ShowErrorMessage(ex, "Application_UnhandledExceptionによる例外通知です。");
            }
        }

        /// <summary>
        ///  ユーザー・フレンドリなダイアログを表示するメソッド
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="extraMessage"></param>
        public static void ShowErrorMessage(Exception ex, string extraMessage)
        {
            MessageBox.Show(extraMessage + " \n――――――――\n\n" +
              "エラーが発生しました。開発元にお知らせください。\n\n" +
              "【エラー内容】\n" + ex.Message + "\n\n" +
              "【スタックトレース】\n" + ex.StackTrace);

            //ログ書き込み
            Logger.WriteError(ex.ToString() + extraMessage);
        }

    }
}
