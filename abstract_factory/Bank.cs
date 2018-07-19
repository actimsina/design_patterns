namespace abstract_factory
{
    public abstract class Bank
    {
       public abstract IAccount openAccount(string type); 
    }

    public class InvestmentBank : Bank
    {
        public override IAccount openAccount(string type)
        {
            return AccountFactory.createAccount(type);
        }
    }

    public class CommercialBank: Bank
    {
        public override IAccount openAccount(string type) {
            return AccountFactory.createAccount(type);
        }
    } 

    public class DevelopmentBank: Bank
    {
        public override IAccount openAccount(string type)
        {
            return AccountFactory.createAccount(type);
        }
    }
}