using System;
using System.Collections.Generic;
using System.Text;
using GameProjectITM.Skills;

namespace GameProjectITM.Classes
{
    class Assasin : Champions
    {
        public Assasin()
        {
            Name = "Assasin";
            Health = 100;
            RemainingHealth = Health;
            Strength = 2;
            DodgeChance = 8;
        }

        public override List<Skills.Skills> SkillsList()
        {
            return new List<Skills.Skills>
            {
                new SneakAttack(),
                new WeakAttack()
            };
        }
    }
}
