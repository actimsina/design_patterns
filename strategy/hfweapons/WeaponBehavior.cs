using System;

namespace hfweapons
{
    public interface IWeaponBehavior
    {
        void useWeapon();
    }

    public class SwordBehavior : IWeaponBehavior
    {
        public void useWeapon()
        {
            Console.WriteLine("I am swinging sword!");
        }
    }
    
    public class KnifeBehavior : IWeaponBehavior
    {
        public void useWeapon()
        {
            Console.WriteLine("I am cutting with knife!");
        }
    }

    public class BowAndArrowBehavior : IWeaponBehavior
    {
        public void useWeapon()
        {
            Console.WriteLine("I am shooting with bow and arrow!");
        }
    }

    public class AxeBehavior : IWeaponBehavior
    {
        public void useWeapon()
        {
            Console.WriteLine("I am chopping with an axe");
        }
    }
}