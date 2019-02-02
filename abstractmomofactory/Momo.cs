using System;

namespace abstractmomofactory
{
  public abstract class Momo
  {
    public abstract void prepare();
    public abstract void serve();
  }

  public abstract class DillibazarMomo : Momo
  {
    public override void serve()
    {
      Console.WriteLine("Serving momos with Dillibazar pickel");
    }
  }

  public abstract class GwarkoMomo : Momo
  {
    public override void serve()
    {
      Console.WriteLine("Serving momos with Gwarko pickel");
    }
  }

  public class DillibazarVegMomo : DillibazarMomo
  {
    public override void prepare()
    {
      Console.WriteLine("Preparing Dillibzar Style Veg Momo");
    }
  }
  public class DillibazarChickenMomo : DillibazarMomo
  {
    public override void prepare()
    {
      Console.WriteLine("Preparing Dillibazar Style Chicken Momo");
    }
  }

  public class GwarkoVegMomo : GwarkoMomo
  {
    public override void prepare()
    {
      Console.WriteLine("Preparing Gwarko Style Veg Momo");
    }
  }


  public class GwarkoChickenMomo : GwarkoMomo
  {
    public override void prepare()
    {
      Console.WriteLine("Preparing Gwarko Style Chicken Momo");
    }
  }

}