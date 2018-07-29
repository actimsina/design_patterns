using System;

namespace hfweapons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Character c = new King();
            c.display();
            c.setWeapon(new SwordBehavior());
            c.fight();
            c.setWeapon(new AxeBehavior());
            c.fight();

        }
    }
}
