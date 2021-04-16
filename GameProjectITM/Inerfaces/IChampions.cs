using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectITM.Inerfaces
{
    interface IChampions
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public int Health { get; set; }
        public int RemainingHealth { get; set; }
        public int Strength { get; set; }
        public int DodgeChance { get; set; }

    }
}
