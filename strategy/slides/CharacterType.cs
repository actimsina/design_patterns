namespace slides
{
    public abstract class CharacterType
    {
        protected IAttackAction myAttack;
        protected IDefendAction myDefence;
        protected ISpellAction mySpell;
        public void performAttack()
        {
            myAttack.doAttack();
        }

        public void performDefence()
        {
            myDefence.doDefence();
        }
        public void performSpell()
        {
            mySpell.castSpell();
        }

        public abstract void display();

    }
}