namespace simple_factory
{
    public abstract class Account
    {
        public abstract float getRate();
    }

    public class SavingAccount : Account
    {
        private float rate = 4.0f;
        public override float getRate()
        {
            return this.rate;
        }
    }

    public class CurrentAccount: Account
    {
        private float rate = 1.0f;

        public override float getRate()
        {
            return this.rate;
        }
    }

    public class FixedAccount: Account
    {
        private float rate = 10.0f;

        public override float getRate()
        {
            return this.rate;
        }
    }
}