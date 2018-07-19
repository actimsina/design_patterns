using System;

namespace abstract_factory
{
    class Program
    {
        static void Main(string[] args)
        {

            Bank b2 = BankFactory.getBank("investment");
            IAccount a2 = b2.openAccount("fixed");

            Console.WriteLine(a2.getRate());
        
        }
    }
}
