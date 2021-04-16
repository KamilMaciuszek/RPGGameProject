using System;
using System.Collections.Generic;
using GameProjectITM.Classes;

namespace GameProjectITM.Generators
{
    class ChampionsGenerator
    {
        public int NumberOfPlayers = 8;
        public Random Random = new Random();

        private static List<Champions> ChampionsAvailableList()
        {
            return new List<Champions>
            {
                new Assasin(),
                new Mage(),
                new Warrior()
            };
        }

        public List<Champions> ChampionsInCompetition()
        {
            List<Champions> listOfChampions = new List<Champions>();
            for (int i = 0; i < NumberOfPlayers; i++)
            {
                int index = Random.Next(ChampionsAvailableList().Count);
                listOfChampions.Add(ChampionsAvailableList()[index]);
                listOfChampions[i].ID = i+1;
            }
            return listOfChampions;
        }

        public void DescribeChampions(List<Champions> listOfChampions)
        {
            Console.WriteLine("Today's competitors are:");
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine($"{i + 1}.{listOfChampions[i].Name}");
            }
            Console.WriteLine();
        }

        
    }
}
