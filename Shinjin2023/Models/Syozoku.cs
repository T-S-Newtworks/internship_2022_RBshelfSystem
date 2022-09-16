using System.ComponentModel.DataAnnotations;

namespace Shinjin2023
{
    /// <summary>
    /// 所属情報
    /// </summary>
    class Syozoku
    {
        /// <summary>
        /// 所属コード
        /// </summary>
        [Key]
        public string Syozoku_Cd { get; set; }

        /// <summary>
        /// 所属名
        /// </summary>
        public string Syozoku_Name { get; set; }
    }
}
