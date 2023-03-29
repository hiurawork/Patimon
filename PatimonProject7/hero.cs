namespace PatimonProject7 {
    /// <summary>
    /// 主人公クラス
    /// </summary>
    class Hero : Character {
        /// <summary>
        /// 主人公の名前(フィールド)
        /// </summary>
        private string name;

        public Hero(string name) {
            this.name = name;
        }

        /// <summary>
        /// 主人公の情報を表示
        /// </summary>
        public void ShowInfo() {
            System.Console.WriteLine("■■■主人公の情報■■■");
            System.Console.WriteLine("主人公の名前：" + this.name);
        }
    }
}
