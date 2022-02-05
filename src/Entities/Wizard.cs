namespace RpgAbstration.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(
            string name,
            int level,
            int hp = 100,
            int power = 10,
            Genre genre = Genre.Male,
            TypeOfPower typeOfPower = TypeOfPower.Attack
            ) : base(name, level, hp, power, genre, typeOfPower)
        {
        }
    }
}