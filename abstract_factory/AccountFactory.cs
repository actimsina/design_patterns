namespace abstract_factory
{
  public class AccountFactory
  {
    public static IAccount createAccount(string type)
    {
      if (type.Equals("saving"))
      {
        return new SavingAccount();
      }
      else if (type.Equals("fixed"))
      {
        return new FixedAccount();
      }
      else if (type.Equals("current"))
      {
        return new CurrentAccount();
      }
      else
      {
        throw new System.Exception();
      }
    }
  }
}