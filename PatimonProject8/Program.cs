namespace PatimonProject8 {
    /// <summary>
    /// プログラムクラス(例外)
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
            tanaka.ShowInfo();
            string tanakaCry = tanaka.GetCry();
            System.Console.WriteLine("鳴き声：" + tanakaCry);

            System.Console.Write("パチモンセンターで体力を回復。どれだけ回復する？：");
            string recoveryHp = System.Console.ReadLine();
            int hp = tanaka.GetHp();

            // もし文字列が入力されたら、変換エラーになるので下の2行をコメントアウトして、①を使う
            int newHp = hp + int.Parse(recoveryHp);
            System.Console.WriteLine("回復後のHP：" + newHp);

            // ① 例外の処理(下の行のコメントアウトを外す)
            //try {
            //    int newHp = hp + int.Parse(recoveryHp);
            //    System.Console.WriteLine("回復後のHP：" + newHp);
            //}
            //catch (System.Exception) {
            //    System.Console.WriteLine("整数を入力してください。");
            //}
        }
    }
}
