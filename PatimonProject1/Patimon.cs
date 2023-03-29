namespace PatimonProject1 {
    /// <summary>
    /// パチモンクラス
    /// </summary>
    class Patimon {
        /// <summary>
        /// パチモンの名前(プロパティ)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// パチモンの技(プロパティ)
        /// </summary>

        public string Skill { get; set; }

        /// <summary>
        /// パチモンの体力(プロパティ)
        /// </summary>
        public int Hp { get; set; }

        /// <summary>
        /// パチモンの情報を表示
        /// </summary>
        public void ShowInfo() {
            System.Console.WriteLine("■■■パチモンの情報■■■");
            System.Console.WriteLine("名前：" + this.Name);
            System.Console.WriteLine("技：" + this.Skill);
            System.Console.WriteLine("体力：" + this.Hp);
        }
    }
}
