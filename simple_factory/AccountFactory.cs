namespace simple_factory
{
    public class AccountFactory
    {
        public static BankAccount createAccount(string type) 
        {
            BankAccount account;
            switch(type){
                case "saving":
                    account = new SavingAccount();
                    break;
                case "current":
                    account = new CurrentAccount();
                    break;
                case "fixed":
                    account =  new FixedAccount();
                    break;
                default:
                    account = null;
                    break;
            }
            return account;
        }
    }
}