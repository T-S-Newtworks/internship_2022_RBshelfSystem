using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Shinjin2023
{
    /// <summary>
    /// ユーザー情報
    /// </summary>
    public class User
    {
        /// <summary>
        /// ユーザーID
        /// </summary>
        [Key]
        [DisplayName("ユーザID")]
        public string User_ID { get; set; }

        /// <summary>
        /// ユーザー名
        /// </summary>
        [DisplayName("ユーザ名")]
        public string User_Name { get; set; }

        /// <summary>
        /// 所属名
        /// </summary>
        [DisplayName("所属")]
        public string Syozoku_Name { get; set; }

        /// <summary>
        /// 所属コード
        /// </summary>
        public string Syozoku_Cd { get; set; }

        /// <summary>
        /// 権限コード
        /// </summary>
        [DisplayName("権限コード")]
        public string Kengen_Cd { get; set; }

        /// <summary>
        /// 権限
        /// </summary>
        [DisplayName("権限")]
        public string Kengen { get; set; }


    }
}
