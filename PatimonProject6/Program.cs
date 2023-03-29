namespace PatimonProject6 {
    /// <summary>
    /// プログラムクラス(抽象クラス)
    /// </summary>
    class Program {
        /// <summary>
        /// Mainメソッド(CLRが始めに呼ぶメソッド)
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args) {
            Game.ShowGameInfo();

            System.Console.WriteLine();

            // ペカチュウをインスタンス化
            Pekatyu tanaka = new Pekatyu("田中一郎");
            // インスタンスのメソッドを呼び出し
            tanaka.ShowInfo(1);
            string tanakaCry = tanaka.GetCry();
            System.Console.WriteLine("鳴き声：" + tanakaCry);

            System.Console.WriteLine();

            // ヒトキャゲをインスタンス化
            Hitokyage yamada = new Hitokyage("山田太郎");
            // インスタンスのメソッドを呼び出し
            yamada.ShowInfo(1);
            string yamadaCry = yamada.GetCry();
            System.Console.WriteLine("鳴き声：" + yamadaCry);

            System.Console.WriteLine();

            // フシギダヨをインスタンス化
            Husigidayo suzuki = new Husigidayo("鈴木次郎");
            // インスタンスのメソッドを呼び出し
            suzuki.ShowInfo(1);
            string suzukiCry = suzuki.GetCry();
            System.Console.WriteLine("鳴き声：" + suzukiCry);
        }
    }
}
