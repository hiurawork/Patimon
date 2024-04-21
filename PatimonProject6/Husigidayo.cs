namespace PatimonProject6 {
    /// <summary>
    /// フシギダヨのクラス
    /// </summary>
    class Husigidayo : Patimon {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Husigidayo(string originalName) : base("フシギダヨ", "葉っぱあったー", 120) {
            base.originalName = originalName;
        }

        /// <summary>
        /// 鳴き声を取得します。
        /// </summary>
        /// <returns>鳴き声を返します。</returns>
        public override string GetCry() {
            return "ダヨダヨー";
        }
    }
}
