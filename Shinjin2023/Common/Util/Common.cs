using System;
using System.Security.Cryptography;
using System.Text;

namespace Shinjin2023.Util
{
    /// <summary>
    /// 共通クラス
    /// </summary>
    static class Common
    {
        /// <summary>
        /// 一般ユーザー
        /// </summary>
        public const string NONE_CODE = "0";
        /// <summary>
        /// 管理者
        /// </summary>
        public const string ADMIN_CODE = "1";
        /// <summary>
        /// 管理部コード
        /// </summary>
        public const string ADMIN_DEPARTMENT_CODE = "007";

        /// <summary>
        /// ハッシュ化処理
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string Hashed(string str)
        {
            //受け取った値ををバイト型に変換
            byte[] bytePass = Encoding.UTF8.GetBytes(str);
            //バイト型に変換した値をハッシュ化
            MD5 md5 = MD5.Create();
            //ハッシュ値を計算
            byte[] bs = md5.ComputeHash(bytePass);
            md5.Clear();
            //計算したハッシュ値を16進数に変換
            return BitConverter.ToString(bs).ToLower().Replace("-", "");
        }

    }
}
