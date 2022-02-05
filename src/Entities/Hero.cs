using System;
using RpgAbstration.src.Interfaces;

namespace RpgAbstration.src.Entities
{
    public abstract class Hero : IHero
    {
        public Hero(
            string name,
            int level,
            int hp = 100,
            int power = 10,
            Genre genre = Genre.Male,
            TypeOfPower typeOfPower = TypeOfPower.Attack
            )
        {
            Name = name;
            Level = level;
            Hp = hp;
            Power = power;
            Genre = genre;
            HeroTypeOfPower = typeOfPower;
        }

        public string Name { get; set; }
        public int Level { get; set; }
        public int Hp { get; set; }
        public int Power { get; set; }
        public Genre Genre { get; set; }
        public TypeOfPower HeroTypeOfPower { get; set; }

        public void Attack()
        {
            Console.WriteLine($"{Name} attacking with power: {Power}.");
        }

        public void Cure()
        {
            Hp += 10;
            Console.WriteLine($"{Name} increasing {Hp} + 10. New HP: {Hp}");
        }

        public override string ToString()
        {
            string mainMessage = "";
            mainMessage += "\n------------------------";
            mainMessage += "\n--------HERO------------";
            mainMessage += $"\nName: {Name}";
            mainMessage += $"\nLevel: {Level}";
            mainMessage += $"\nLife: {Hp}";
            mainMessage += $"\nPower: {Power}";
            mainMessage += $"\nGenre: {Genre}";
            mainMessage += $"\nType Of Hero: {HeroTypeOfPower}";

            return mainMessage;
        }
    }
}