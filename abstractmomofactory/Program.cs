using System;

namespace abstractmomofactory
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");

      MomoFactory mf = new DillibazarMomoFactory();
      Momo m1 = mf.CreateMomo("veg");
      m1.prepare();
      m1.serve();
    }
  }
}
