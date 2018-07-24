using System;

namespace slides
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            CharacterType c = new Rogue();
            c.display();
            c.performAttack();
            c.performDefence();
        }
    }
}
