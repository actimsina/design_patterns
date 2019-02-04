using System;

namespace facade
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");

      Facade f = new Facade();
      f.MethodA();
      f.MethodB();
    }
  }
}
