using System;
using System.Collections.Generic;
using System.Text;
using GameProjectITM.Inerfaces;

namespace GameProjectITM.Classes
{
    abstract class Champions : IChampions
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public int Health { get; set; }
        public int RemainingHealth { get; set; }
        public int Strength { get; set; }
        public int DodgeChance { get; set; }
        public abstract List<Skills.Skills> SkillsList();

    }
}
