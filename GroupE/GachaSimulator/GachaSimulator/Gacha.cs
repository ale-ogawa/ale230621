using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GachaSimulator
{
    class Gacha
    {
        public int Id { get; set; }
        public string Rarity { get; set; }
        public string Name { get; set; }

        public Gacha(int id,string rarity,string name)
        {
            Id = id;
            Rarity = rarity;
            Name = name;
        }
    }
}
