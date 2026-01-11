using Raiding;
using System;
using System.Collections.Generic;

public class StartUp
{
    public static void Main()
    {
        int N = int.Parse(Console.ReadLine()); 
        List<BaseHero> raidGroup = new List<BaseHero>();

        int counter = 0; 
        while (counter < N)
        {
            string heroName = Console.ReadLine();
            string heroType = Console.ReadLine();

            try
            {
                BaseHero hero = HeroFactory.CreateHero(heroName, heroType);
                raidGroup.Add(hero);
                counter++; 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); 
            }
        }

        int bossPower = int.Parse(Console.ReadLine()); 

        int totalPower = 0;
        foreach (var hero in raidGroup)
        {
            Console.WriteLine(hero.CastAbility());
            totalPower += hero.Power;
        }

        if (totalPower >= bossPower)
        {
            Console.WriteLine("Victory!");
        }
        else
        {
            Console.WriteLine("Defeat...");
        }
    }
}
