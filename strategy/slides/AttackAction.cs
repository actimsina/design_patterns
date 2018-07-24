using System;
namespace slides
{
    public interface IAttackAction
    {
       void doAttack(); 
    }

    public class StealthAttack : IAttackAction
    {
        public void doAttack()
        {
            Console.WriteLine("Stealth Attack");
        }
    }

    public class StaffAttack: IAttackAction
    {
        public void doAttack()
        {
           Console.WriteLine("Staff Attack"); 
        }
    }

    public class DaggerAttack : IAttackAction
    {
        public void doAttack()
        {
            Console.WriteLine("Dagger Attack");
        }
    }
}