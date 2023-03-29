namespace PatimonProject4 {
    /// <summary>
    /// プログラムクラス(継承)
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
            Pekatyu pekatyu1 = new Pekatyu("あああ");
            // インスタンスのメソッドを呼び出し
            pekatyu1.ShowInfo(1);
            string pekatyu1Cry = pekatyu1.GetCry();
            System.Console.WriteLine("鳴き声：" + pekatyu1Cry);

            System.Console.WriteLine();

            // パチモンをインスタンス化
            Pekatyu pekatyu2 = new Pekatyu("ペカチュウ2号");
            // インスタンスのメソッドを呼び出し
            pekatyu2.ShowInfo(1);
            string pekatyu2Cry = pekatyu2.GetCry();
            System.Console.WriteLine("鳴き声：" + pekatyu2Cry);
        }
    }
}
