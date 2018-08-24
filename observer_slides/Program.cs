using System;

namespace observer_slides
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a = new Account();
            a.addListener(new InterestedParty());
            a.adjustBalance(100);
            a.adjustBalance(100);
        }
    }
}
