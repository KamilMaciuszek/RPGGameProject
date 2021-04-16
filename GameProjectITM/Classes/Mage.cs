using System;
using System.Collections.Generic;
using System.Text;
using GameProjectITM.Skills;

namespace GameProjectITM.Classes
{
    class Mage : Champions
    {
        public Mage()
        {
            Name = "Mage";
            Health = 100;
            RemainingHealth = Health;
            Strength = 3;
            DodgeChance = 4;
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
