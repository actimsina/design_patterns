namespace simplemomofactory
{
  public class MomoFactory
  {
    public static Momo GetMomo(string type)
    {
      if (type == "veg")
      {
        return new VegMomo();
      }
      else if (type == "buff")
      {
        return new BuffMomo();
      }
      else if (type == "chicken")
      {
        return new ChickenMomo();
      }
      return null;
    }
  }
}