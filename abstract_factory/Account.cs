namespace abstract_factory
{
    public interface IAccount
    {
       float getRate(); 
    }

    public class SavingAccount : IAccount
    {
        private float rate = 4.5f;

        public float getRate()
        {
            return this.rate;
        }
    }

    public class CurrentAccount : IAccount
    {
        private float rate = 1.0f;

        public float getRate()
        {
            return this.rate;
        }
    }

    public class FixedAccount : IAccount
    {
        private float rate = 10.5f;

        public float getRate()
        {
            return this.rate;
        }
    }
}