namespace singleton
{
    public class EagerSingleton
    {
        private static EagerSingleton instance = new EagerSingleton();
        private EagerSingleton(){}
        public static EagerSingleton Instance
        {
            get{
                return instance;
            }
        }
    }
}