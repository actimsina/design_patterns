using System;
using System.Collections.Generic;

namespace observer
{
    public class MyTopic : ISubject
    {
        private List<IObserver> observers;
        private string message;

        public MyTopic()
        {
            this.observers = new List<IObserver>();
        }

        public string getMessage()
        {
            return this.message;
        }

        public void notifyObservers()
        {
            foreach(var observer in observers){
                observer.update();
            }
        }

        public void register(IObserver obs)
        {
            if(!observers.Contains(obs)) observers.Add(obs);
        }

        public void unregister(IObserver obs)
        {
            if(observers.Contains(obs)) observers.Remove(obs);
        }

        public void setMessage(string msg){
            this.message = msg;
            notifyObservers();
        }
    }
}