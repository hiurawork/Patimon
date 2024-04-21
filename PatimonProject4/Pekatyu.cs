namespace PatimonProject4 {
    /// <summary>
    /// ペカチュウのクラス
    /// </summary>
    class Pekatyu : Patimon {

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Pekatyu(string originalName) : base("ペカチュウ", "10ボルト", 100) {
            base.originalName = originalName;
        }

        /// <summary>
        /// 鳴き声を取得します。
        /// </summary>
        /// <returns>鳴き声を返します。</returns>
        public string GetCry() {
            return "ペカチュー";
        }
    }
}
