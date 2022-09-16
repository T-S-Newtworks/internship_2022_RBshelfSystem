using System;
using System.IO;
using log4net;
using log4net.Appender;
using log4net.Repository.Hierarchy;

namespace Shinjin2023.Util
{
    /// <summary>
    /// ロガー
    /// </summary>
    public class Logger
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// ログのタイプ
        /// </summary>
        public enum Type
        {
            /// <summary>
            /// 情報
            /// </summary>
            Info,
            /// <summary>
            /// エラー
            /// </summary>
            Err,
            /// <summary>
            /// デバッグ
            /// </summary>
            Debug
        }

        /// <summary>
        /// ファイル名称のサフィックス（語尾）を設定
        /// </summary>
        /// <param name="safixName"></param>
        public static void SetFileNameSafix(String safixName)
        {
            log4net.Repository.Hierarchy.Logger root = ((Hierarchy)log.Logger.Repository).Root;
            FileAppender appender = (FileAppender)root.GetAppender("SystemLog");

            String safix = safixName;
            if (safix.Length == 0) return;
            if (safix.Substring(0, 1) != "_")
            {
                safix = "_" + safix;
            }
            String fileName = Path.GetFileName(appender.File);
            String rootPath = Path.GetDirectoryName(appender.File);
            String[] names = fileName.Split('_');
            if (names.Length >= 2)
            {
                // _(アンダースコア)で区切られている場合は、最初のアンダースコアの直後に挿入する
                // DatePatternや拡張子の部分は appender.ActivateOptions() で再挿入される
                fileName = names[0];
                fileName += safix;
            }
            else
            {
                // _(アンダースコア)がない場合は、拡張子の直前に挿入する
                // 拡張子部分は appender.ActivateOptions() で再挿入されるハズ
                fileName = Path.GetFileNameWithoutExtension(fileName) + safix;
            }
            appender.File = rootPath + "\\" + fileName;
            appender.ActivateOptions();
        }

        /// <summary>
        /// ログ書き出し
        /// </summary>
        /// <param name="message"></param>
        /// <param name="type"></param>
        public static void Write(string message, Type type = Type.Info)
        {
            switch (type)
            {
                case Type.Info:
                    log.Info(message);
                    break;
                case Type.Err:
                    log.Error(message);
                    break;
                case Type.Debug:
                    log.Debug(message);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// エラーログ書き出し
        /// </summary>
        /// <param name="message"></param>
        public static void WriteError(string message)
        {
            Write(message, Type.Err);
        }

        /// <summary>
        /// エラーログ書き出し
        /// </summary>
        /// <param name="message"></param>
        public static void WriteInfo(string message)
        {
            Write(message, Type.Info);
        }

        /// <summary>
        /// ログ書き出し（例外オブジェクト）
        /// </summary>
        /// <param name="ex"></param>
        public static void Write(Exception ex)
        {
            log.Error(ex.Message, ex);
        }

        /// <summary>
        /// エラーログ書き出し（例外オブジェクト）
        /// </summary>
        /// <param name="ex"></param>
        public static void WriteError(Exception ex)
        {
            Write(ex);
        }
    }
}
