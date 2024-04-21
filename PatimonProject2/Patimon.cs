namespace PatimonProject2 {
    /// <summary>
    /// パチモンクラス
    /// </summary>
    class Patimon {
        /// <summary>
        /// パチモンの名前(フィールド)
        /// </summary>
        private string name;

        /// <summary>
        /// パチモンの技(フィールド)
        /// </summary>
        private string skill;

        /// <summary>
        /// パチモンの体力(フィールド)
        /// </summary>
        private int hp;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="name">パチモンの名前を指定</param>
        /// <param name="skill">パチモンのスキルを指定</param>
        public Patimon(string name, string skill) {
            this.name = name;
            this.skill = skill;
            this.hp = 100;
        }

        /// <summary>
        /// パチモンの情報を表示
        /// </summary>
        public void ShowInfo() {
            System.Console.WriteLine("■■■パチモンの情報■■■");
            System.Console.WriteLine("名前：" + this.name);
            System.Console.WriteLine("技：" + this.skill);
            System.Console.WriteLine("体力：" + this.hp);
        }
    }
}
