namespace simple_factory
{
    public class AccountFactory
    {
        public static Account createAccount(string type) 
        {
            switch(type){
                case "saving":
                   return new SavingAccount();
                case "current":
                    return new CurrentAccount();
                case "fixed":
                    return new FixedAccount();
                default:
                    throw new System.Exception();
            }
        }
    }
}