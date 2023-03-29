namespace PatimonProject9 {
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
        /// <returns></returns>
        public override string GetCry() {
            return "ペカチュー";
        }
    }
}
