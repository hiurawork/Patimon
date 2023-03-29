namespace PatimonProject7 {
    /// <summary>
    /// プログラムクラス(インタフェース)
    /// </summary>
    class Program {
        /// <summary>
        /// Mainメソッド(CLRが始めに呼ぶメソッド)
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args) {
            Game.ShowGameInfo();

            System.Console.WriteLine();

            // 主人公をインスタンス化
            Hero hero = new Hero("サトス");
            // インスタンスのメソッドを呼び出し
            hero.ShowInfo();

            System.Console.WriteLine();

            // ペカチュウをインスタンス化
            Pekatyu tanaka = new Pekatyu("田中一郎");
            // インスタンスのメソッドを呼び出し
            tanaka.ShowInfo();
            string tanakaCry = tanaka.GetCry();
            System.Console.WriteLine("鳴き声：" + tanakaCry);
        }
    }
}
