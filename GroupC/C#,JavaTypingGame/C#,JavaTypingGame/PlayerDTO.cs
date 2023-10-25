using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__JavaTypingGame
{
    internal class PlayerDTO
    {
        //プレイヤーID
       static public int Id { get; set; }
        //プレイヤー名
       static public string Name { get; set; }
        //パスワード
       static public string Pass { get; set; }
        //選択言語
        static public string Lang { get; set; }
        //選択難易度
        static public Level level { get; set; }
        //得点
        static public int score { set; get; }

        //ログイン状態のフラグ
        static public bool Login { get; set; } =false;

        //ゲスト保存用スコア
        static public Guest guest { get; set; } = null;

        //コンストラクター
        public PlayerDTO(string name,string pass)
        {
            Name = name;
            Pass = pass;
            Login = true;
        }
    }

    public enum Level
    {
        初級,
        中級,
        上級,
    }
}



