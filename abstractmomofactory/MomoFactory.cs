namespace abstractmomofactory
{
  public abstract class MomoFactory
  {
    public abstract Momo CreateMomo(string type);
  }


  public class DillibazarMomoFactory : MomoFactory
  {
    public override Momo CreateMomo(string type)
    {
      if (type == "veg")
      {
        return new DillibazarVegMomo();
      }
      else if (type == "chicken")
      {
        return new DillibazarChickenMomo();
      }
      return null;
    }
  }

  public class GwarkoMomoFactory : MomoFactory
  {
    public override Momo CreateMomo(string type)
    {
      if (type == "veg")
      {
        return new GwarkoVegMomo();
      }
      else if (type == "chicken")
      {
        return new GwarkoChickenMomo();
      }
      return null;
    }
  }

}