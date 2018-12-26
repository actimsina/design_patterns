using System;

namespace abstract_factory
{
  class Program
  {
    static void Main(string[] args)
    {
      try
      {
        Bank b2 = BankFactory.getBank("investment");
        IAccount a2 = b2.openAccount("fixeded");
        Console.WriteLine(a2.getRate());
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }


    }
  }
}
