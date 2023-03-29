namespace PatimonProject5 {
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

        //鳴き声を取得するメソッドのオーバーライドがないため、鳴き声なしになってしまう
    }
}
