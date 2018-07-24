using System;

namespace slides
{
    public interface IDefendAction
    {
       void doDefence(); 
    }

    public class DodgeDefence : IDefendAction
    {
        public void doDefence()
        {
            Console.WriteLine("Dodge Defence");
        }
    }

    public class ParryDefence : IDefendAction
    {
        public void doDefence()
        {
            Console.WriteLine("Parry Defence");
        }
    }
}