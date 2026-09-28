using System;

namespace GameInheritanceDemo
{
    
    public class ArchMage : Mage
    {
        
        public int ancientKnowledge;

        public ArchMage()
        {
            
            Console.WriteLine("Konstruktor default ArchMage");

        }

        public ArchMage(int ancientKnowledge, int spellPower, string name, string id, int basePower, string address)
            : base(spellPower, name, id, basePower, address)
        {
            
            Console.WriteLine("Konstruktor brparameter ArchMage");
            this.ancientKnowledge = ancientKnowledge;

        }

        public new void DisplayData()
        {
            base.DisplayData();
            Console.WriteLine("ANCIENT KNOWLEDGE = " + ancientKnowledge);
            Console.WriteLine("GRAND TOTAL POWER = " + (GetBasePower() + spellPower + ancientKnowledge));
            Console.WriteLine("===");
        }
    }
}
