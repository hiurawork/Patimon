namespace PatimonProject4 {
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
        /// パチモンのオリジナルの名前
        /// </summary>
        protected string originalName;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="name">パチモンの名前を指定</param>
        /// <param name="skill">パチモンのスキルを指定</param>
        /// <param name="hp">パチモンの体力を指定</param>
        public Patimon(string name, string skill, int hp) {
            this.name = name;
            this.skill = skill;
            this.hp = hp;
        }

        /// <summary>
        /// パチモンの情報を表示
        /// </summary>
        /// <param name="titleLayout">タイトルレイアウトを0～2の整数で指定</param>
        public void ShowInfo(int titleLayout) {
            if (titleLayout == 0) {
                System.Console.WriteLine("■■■パチモンの情報■■■");
            } else if (titleLayout == 1) {
                System.Console.WriteLine("★★★パチモンの情報★★★");
            } else if (titleLayout == 2) {
                System.Console.WriteLine("◆◆◆パチモンの情報◆◆◆");
            }

            System.Console.WriteLine("名前：" + this.name);
            System.Console.WriteLine("オリジナルの名前：" + this.originalName);
            System.Console.WriteLine("技：" + this.skill);
            System.Console.WriteLine("体力：" + this.hp);
        }
    }
}
