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
        public int Id { get; set; }
        //プレイヤー名
        public string Name { get; set; }
        //パスワード
        public string Pass { get; set; }
        //選択言語
        static public string Lang { get; set; }
        //選択難易度
        static public Level level { get; set; }

        //コンストラクター
        public PlayerDTO(string name,string pass)
        {
            Name = name;
            Pass = pass;
        }
    }

    public enum Level : int
    {
        初級=1,
        中級=2,
        上級=3,
    }
}



