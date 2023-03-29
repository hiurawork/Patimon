using System.Collections.Generic;

namespace PatimonProject9 {
    /// <summary>
    /// プログラムクラス(ListとForeach)
    /// </summary>
    class Program {
        /// <summary>
        /// Mainメソッド(CLRが始めに呼ぶメソッド)
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args) {
            Game.ShowGameInfo();

            System.Console.WriteLine();

            // 主人公は無限にポケモンを持ち歩けるので、沢山ゲットしましょう。
            List<Patimon> hands = new List<Patimon>();

            // 1匹目のペカチュウをゲットして手持ちに追加
            hands.Add(new Pekatyu("田中一郎"));

            // 2匹目のペカチュウをゲットして手持ちに追加
            hands.Add(new Pekatyu("山田一郎"));

            // 3匹目のペカチュウをゲットして手持ちに追加
            hands.Add(new Pekatyu("鈴木一郎"));

            // 4匹目のペカチュウをゲットして手持ちに追加
            hands.Add(new Pekatyu("田中二郎"));

            // 5匹目のペカチュウをゲットして手持ちに追加
            hands.Add(new Pekatyu("あああああ"));

            // 6匹目のペカチュウをゲットして手持ちに追加
            hands.Add(new Pekatyu("ボブ"));

            //手持ちのパチモンをすべて表示
            foreach (Patimon patimon in hands) {
                patimon.ShowInfo();
                System.Console.WriteLine();
            }
        }
    }
}
