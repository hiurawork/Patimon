﻿namespace PatimonProject2 {
    /// <summary>
    /// プログラムクラス(コンストラクタ)
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
            Patimon pekatyu = new Patimon("ペカチュウ", "10ボルト");
            // インスタンスのメソッドを呼び出し
            pekatyu.ShowInfo();

            System.Console.WriteLine();

            // パチモンをインスタンス化
            Patimon hitokyage = new Patimon("ヒトキャゲ", "火をふく");
            // インスタンスのメソッドを呼び出し
            hitokyage.ShowInfo();
        }
    }
}
