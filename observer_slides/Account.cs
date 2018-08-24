using System.Collections.Generic;

namespace observer_slides
{
    public class Account
    {
        private int amount;

        List<IAccountObserver> myObservers;

        public Account()
        {
            myObservers = new List<IAccountObserver>();
        }

        public void addListener(IAccountObserver observer)
        {
            if(!myObservers.Contains(observer))
            {
                myObservers.Add(observer);
            }
        }

        public void removeListener(IAccountObserver observer)
        {
            if(myObservers.Contains(observer))
            {
                myObservers.Remove(observer);
            }
        }

        public void notifyListeners(int current, int amount)
        {
            foreach(var observer in myObservers)
            {
                observer.stateChanged(current, amount);
            }
        }

        public void adjustBalance(int val) 
        {
            amount += val;
            notifyListeners(amount, val);
        }
    }
}