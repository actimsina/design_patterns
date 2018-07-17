namespace simple_factory
{
    public abstract class BankAccount
    {
        public abstract float getRate();
    }

    public class SavingAccount : BankAccount
    {
        private float rate = 4.0f;
        public override float getRate()
        {
            return this.rate;
        }
    }

    public class CurrentAccount: BankAccount
    {
        private float rate = 1.0f;

        public override float getRate()
        {
            return this.rate;
        }
    }

    public class FixedAccount: BankAccount
    {
        private float rate = 10.0f;

        public override float getRate()
        {
            return this.rate;
        }
    }
}