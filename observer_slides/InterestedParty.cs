using System;

namespace observer_slides
{
    public class InterestedParty : IAccountObserver
    {
        public void stateChanged(int current, int change)
        {
            Console.WriteLine($"Current balance is: {current}, adjusted by: {change}");
        }
    }
}