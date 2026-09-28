using System;

namespace GameInheritanceDemo
{
    public class Warrior : Character
    {
        public int bonus;

        public Warrior() : base()
        {

            Console.WriteLine("Konstruktor default warrior");

        }

        public Warrior(int bonus, string id, string name, int basePower, string address)
            : base(id, name, basePower, address)

        {
            
            Console.WriteLine("Konstruktor berparameter Warrior");
            this.bonus = bonus;

        }

        public void DisplayData()
        {

            base.DisplayBaseData();
            Console.WriteLine("Bonus          = " + bonus);
            Console.WriteLine("TOTAL POWER = " + (GetBasePower () + bonus));
            Console.WriteLine("===");

        }
    }
}
