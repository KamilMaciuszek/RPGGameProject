using System;
using GameProjectITM.Generators;

namespace GameProjectITM
{
    class Program
    {
        static void Main(string[] args)
        {
            ChampionsGenerator generator = new ChampionsGenerator();
            fight fight = new fight();
            var list = generator.ChampionsInCompetition();
            generator.DescribeChampions(list);
            fight.Duel(list);

        }
    }
}
