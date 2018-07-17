using System;

namespace simple_factory
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount b1 = new SavingAccount();
            Console.WriteLine(b1.getRate());

            BankAccount b2 = AccountFactory.createAccount("fixed");
            Console.WriteLine(b2.getRate());

            BankAccount b3  = AccountFactory.createAccount("saving");
        }
    }
}
