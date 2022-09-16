namespace Shinjin2023.Util
{
    /// <summary>
    /// コンボボックスアイテム用クラス
    /// </summary>
    class ComboItem
    {
        /// <summary>
        /// //表示する値
        /// </summary>
        public string ItemText { get; set; }

        /// <summary>
        /// 処理で使用する値
        /// </summary>
        public string ItemValue { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="text"></param>
        /// <param name="value"></param>
        public ComboItem(string text, string value)
        {
            ItemText = text;
            ItemValue = value;
        }

        /// <summary>
        /// 表示値文字列取得
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return ItemText;
        }

    }
}
