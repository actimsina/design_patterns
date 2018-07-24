using System;
namespace slides
{
    public interface ISpellAction
    {
        void castSpell();        
    }

    public class DefendSpell : ISpellAction
    {
        public void castSpell()
        {
            Console.WriteLine("Defend Spell");
        }
    }

    public class AttackSpell : ISpellAction
    {
        public void castSpell()
        {
            Console.WriteLine("Attack Spell");
        }
    }
}