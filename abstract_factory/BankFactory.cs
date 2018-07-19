namespace abstract_factory
{
    public class BankFactory
    {
        public static Bank getBank(string type) 
        {
            if(type.Equals("investment")){
                return new InvestmentBank();
            }
            else if (type.Equals("development")){
                return new DevelopmentBank();
            }
            else if(type.Equals("commercial")) {
                return new CommercialBank();
            }
            return null;
        }
    }
}