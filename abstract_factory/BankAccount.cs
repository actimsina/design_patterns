namespace abstract_factory
{
    public interface IBankAccount
    {
       float getRate(); 
    }

    public class SavingAccount : IBankAccount
    {
        private float rate = 4.5f;

        public float getRate()
        {
            return this.rate;
        }
    }

    public class CurrentAccount : IBankAccount
    {
        private float rate = 1.0f;

        public float getRate()
        {
            return this.rate;
        }
    }

    public class FixedAccount : IBankAccount
    {
        private float rate = 10.5f;

        public float getRate()
        {
            return this.rate;
        }
    }
}