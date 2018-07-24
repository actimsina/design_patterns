using System;

namespace slides
{
    public class Rogue : CharacterType
    {
        public Rogue()
        {
            myAttack = new StealthAttack();
            myDefence = new DodgeDefence();
        }

        public override void display()
        {
            Console.WriteLine("I am Rogue: ");
        }
    }

    public class Wizard : CharacterType
    {
        public Wizard()
        {
            myAttack = new StaffAttack();
            mySpell = new DefendSpell();
        }

        public override void display()
        {
            Console.WriteLine("I am Wizard: ");
        }
    }

    public class Assassin : CharacterType
    {
        public Assassin()
        {
            myAttack = new DaggerAttack();
            myDefence = new DodgeDefence();
        }

        public override void display()
        {
            Console.WriteLine("I'm Assassin: ");
        }
    }

    public class Witch : CharacterType
    {
        public Witch()
        {
            myDefence = new ParryDefence();
            mySpell = new AttackSpell();
        }

        public override void display()
        {
            Console.WriteLine("I am Witch: ");
        }
    }
}