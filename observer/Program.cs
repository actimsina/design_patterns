using System;
using System.Collections.Generic;

namespace observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ISubject s = new MyTopic();
            s.setMessage("Hello, Observers");

            s.register(new MyTopicObserver(s));
            s.register(new MyTopicObserver(s));
            s.notifyObservers();
            s.setMessage("Somethings Changed!");
            // s.notifyObservers();            
        }
    }
}
