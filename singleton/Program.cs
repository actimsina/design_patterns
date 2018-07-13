using System;

namespace singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LazySingleton.Instance.GetHashCode());
            Console.WriteLine(LazySingleton.Instance.GetHashCode());
            Console.WriteLine(EagerSingleton.Instance.GetHashCode());
            Console.WriteLine(EagerSingleton.Instance.GetHashCode());
        }
    }
}
