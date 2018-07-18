namespace abstract_factory
{
    public abstract class AccountFactory
    {
        public abstract IAccount createAccount();
    }

    public class SavingAccountFactory : AccountFactory
    {
        public override IAccount createAccount() {
            return new SavingAccount();
        }
    }

    public class CurrentAccountFactory: AccountFactory
    {
        public override IAccount createAccount(){
            return new CurrentAccount();
        }
    }

    public class FixedAccountFactory: AccountFactory
    {
        public override IAccount createAccount(){
            return new FixedAccount();
        }
    }
}