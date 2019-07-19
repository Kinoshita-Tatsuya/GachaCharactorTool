using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GachaTool.Models.ValueObjects
{
    class CharactorParameter
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public float Probability { get; set; }

        public int Rarity { get; set; }

        public string Image { get; set; }
    }
}
