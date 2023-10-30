using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__JavaTypingGame
{
    internal class Guest
    {
        static public string GuestLang { get; set; }
        static public int GuestScore { get; set; }
        public Guest(String lang,int score)
        {
            GuestLang = lang;
            GuestScore = score;
        }
    }
}
