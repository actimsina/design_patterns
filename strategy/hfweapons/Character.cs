using System;

namespace hfweapons
{
    public abstract class Character 
    {
        private IWeaponBehavior weapon;

        public void fight()
        {
            weapon.useWeapon();
        }

        public void setWeapon(IWeaponBehavior w)
        {
            this.weapon = w;
        }

        public abstract void display();
    }
    
    public class King : Character
    {
        public override void display()
        {
            Console.WriteLine("King: ");
        }
    }

    public class Queen: Character
    {
        public override void display()
        {
            Console.WriteLine("Queen: ");
        }
    }

    public class Knight : Character
    {
        public override void display()
        {
            Console.WriteLine("Knight: ");
        }
    }

    public class Troll : Character
    {
        public override void display()
        {
            Console.WriteLine("Troll: ");
        }
    }
}