using System;

namespace simple_factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Account b1 = new SavingAccount();
            Console.WriteLine(b1.getRate());

            Account a1;
            try {
               a1 = AccountFactory.createAccount("saving");
               Console.WriteLine(a1.getRate());
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
