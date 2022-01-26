using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store(10);
            store[0] = new Article("Apple", "Silpo", 20);
            store[1] = new Article("Pineaplle", "Silpo", 50);
            store[2] = new Article("Water", "Silpo", 10);
            store.ShowByNumber(0);
            store.ShowByName("Water");
            store.ShowByName("Car");
            Console.ReadKey();
        }
    }
}
