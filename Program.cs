using System;
using System.Collections.Generic;
using RpgAbstration.src.Entities;

namespace RpgAbstration
{
    class Program
    {
        static void Main(string[] args)
        {
            var arus = new Knight("Arus", 10);
            var wedge = new Wizard("Wedge", 15, typeOfPower: TypeOfPower.Agility);
            var jeronica = new Wizard("Jeronica", 20, genre: Genre.Female, typeOfPower: TypeOfPower.Magic);
            var topapa = new Wizard("Wedge", 25, genre: Genre.Female, typeOfPower: TypeOfPower.Cure);
            List<Hero> heros = new List<Hero> { arus, wedge, jeronica, topapa };

            foreach (var hero in heros)
            {
                hero.Attack();
                hero.Cure();
            }

            foreach (var hero in heros)
            {
                Console.WriteLine(hero);
            }
        }
    }
}
