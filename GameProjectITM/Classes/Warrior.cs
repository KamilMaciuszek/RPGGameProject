using System;
using System.Collections.Generic;
using System.Text;
using GameProjectITM.Skills;

namespace GameProjectITM.Classes
{
    class Warrior : Champions
    {
      
        public Warrior()
        {
            Name = "Warrior";
            Health = 150;
            RemainingHealth = Health;
            Strength = 4;
            DodgeChance = 2;
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
