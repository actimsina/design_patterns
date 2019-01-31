using System;
namespace simplemomofactory
{
  public abstract class Momo
  {
    public abstract void prepare();
    public void serve()
    {
      Console.WriteLine("Serving Momos");
    }
  }

  public class VegMomo : Momo
  {
    public override void prepare()
    {
      Console.WriteLine("Preparing Veggie Momo");
    }
  }

  public class BuffMomo : Momo
  {
    public override void prepare()
    {
      Console.WriteLine("Preparing Buff Momo");
    }
  }


  public class ChickenMomo : Momo
  {
    public override void prepare()
    {
      Console.WriteLine("Preparing Chicken Momo");
    }
  }
}