namespace PatimonProject1 {
    /// <summary>
    /// プログラムクラス(クラスとインスタンスの基本)
    /// </summary>
    class Program {
        /// <summary>
        /// Mainメソッド(CLRが始めに呼ぶメソッド)
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args) {
            Game.ShowGameInfo();

            System.Console.WriteLine();

            // パチモンをインスタンス化
            Patimon pekatyu = new Patimon();
            // インスタンスのプロパティを設定
            pekatyu.Name = "ペカチュウ";
            pekatyu.Skill = "10ボルト";
            pekatyu.Hp = 100;
            // インスタンスのメソッドを呼び出し
            pekatyu.ShowInfo();

            System.Console.WriteLine();

            // パチモンをインスタンス化
            Patimon hitokyage = new Patimon();
            // インスタンスのプロパティを設定
            hitokyage.Name = "ヒトキャゲ";
            hitokyage.Skill = "火をふく";
            hitokyage.Hp = 100;
            // インスタンスのメソッドを呼び出し
            hitokyage.ShowInfo();
        }
    }
}
