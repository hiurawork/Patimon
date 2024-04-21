namespace PatimonProject8 {
    /// <summary>
    /// パチモンクラス
    /// </summary>
    abstract class Patimon : Character {
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
        protected int hp;

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
        public void ShowInfo() {
            System.Console.WriteLine("■■■パチモンの情報■■■");
            System.Console.WriteLine("名前：" + this.name);
            System.Console.WriteLine("オリジナルの名前：" + this.originalName);
            System.Console.WriteLine("技：" + this.skill);
            System.Console.WriteLine("体力：" + this.hp);
        }

        /// <summary>
        /// 鳴き声を取得します。
        /// </summary>
        /// <returns>鳴き声を返します。</returns>
        public abstract string GetCry();
    }
}
