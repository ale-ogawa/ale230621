using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GachaSimulator
{
    class GachaSimulator
    {
        public int Id { get; set; }
        public string Rarity { get; set; }
        public string Name { get; set; }

        public int Gacha(int id,string rarity,string name)
        {
            Id = id;
            Rarity = rarity;
            Name = name;

            return Id;
        }
    }
}
