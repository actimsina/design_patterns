namespace observer
{
    public interface ISubject
    {
        void register(IObserver obs);
        void unregister(IObserver obs);
        void notifyObservers();
        string getMessage();
        void setMessage(string msg);
        // void getUpdate(IObserver obj);
    }
}