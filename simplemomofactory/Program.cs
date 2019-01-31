using System;

namespace simplemomofactory
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");

      Momo momo = MomoFactory.GetMomo("veg");
      momo.prepare();
      momo.serve();

    }
  }
}
