using System;
using System.Collections.Generic;
using System.Text;
using GameProjectITM.Classes;

namespace GameProjectITM.Generators
{
    class fight
    {
        public void Duel(List<Champions> list)
        {
            int count = list.Count;
            for (int i = 0; i < count/2; i++)
            {
                var player1 = list[i];
                var player2 = list[i+1];
                
                StartFighting(player1,player2,i,list);
            }
            WinnerBrackets(list);
        }

        public void StartFighting(Champions player1, Champions player2, int i, List<Champions> championsList)
        {
            Random random = new Random();
            int maxDodgeChance = 10;
            
            while (true)
            {
                if (random.Next(maxDodgeChance) > player2.DodgeChance) {
                    var attack1 = random.Next(player1.SkillsList().Count);
                    player2.RemainingHealth -= player1.SkillsList()[attack1].Damage * player1.Strength;
                    if (player2.RemainingHealth <= 0)
                    {
                        Console.WriteLine($"{championsList[i + 1].Name} has 0 hp");
                        championsList.RemoveAt(i + 1);
                        Console.WriteLine($"{championsList[i].Name} has won the fight with {championsList[i].RemainingHealth} hp");
                        Console.WriteLine();
                        break;
                    }
                }
                
                if(random.Next(maxDodgeChance) > player1.DodgeChance) {
                    var attack2 = random.Next(player2.SkillsList().Count);
                    player1.RemainingHealth -= player2.SkillsList()[attack2].Damage * player2.Strength;
                    if (player1.RemainingHealth <= 0)
                    {
                        Console.WriteLine($"{championsList[i].Name} has 0 hp");
                        championsList.RemoveAt(i);
                        Console.WriteLine($"{championsList[i].Name} has won the fight with {championsList[i].RemainingHealth} hp");
                        Console.WriteLine();
                        break;
                    }
                }
            }

            
        }

        public void WinnerBrackets(List<Champions> championsList)
        {
            Console.WriteLine("Players left:");
            Console.WriteLine("");
            for (int i = 0; i < championsList.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{championsList[i].Name}");
            }
            if (championsList.Count>1) Duel(championsList);
            Console.WriteLine($"The winner is: {championsList[0].Name}");

        }
    }
}
