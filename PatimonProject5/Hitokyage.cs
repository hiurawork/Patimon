namespace PatimonProject5 {
    /// <summary>
    /// ヒトキャゲのクラス
    /// </summary>
    class Hitokyage : Patimon {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Hitokyage(string originalName) : base("ヒトキャゲ", "ひをふく", 150) {
            base.originalName = originalName;
        }

        /// <summary>
        /// 鳴き声を取得します。
        /// </summary>
        /// <returns>鳴き声を返します。</returns>
        public override string GetCry() {
            return "キャゲー";
        }
    }
}
