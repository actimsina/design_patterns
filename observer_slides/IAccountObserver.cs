namespace observer_slides
{
    public interface IAccountObserver
    {
         void stateChanged(int current, int change);
    }
}