using Patterns.Samples.CreationalPatterns;
using System;
namespace Patterns.Samples.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //ShowSingletonWork();
            //ShowAbstractFactoryWork();
        }

        private static void ShowSingletonWork()
        {
            Singleton.Instance.DoWork();

            Console.ReadKey();
        }

        private static void ShowAbstractFactoryWork()
        {
            // Abstract factory #1

            AbstractFactory factory1 = new ConcreteFactory1();
            Client client1 = new Client(factory1);
            client1.Run();

            // Abstract factory #2

            AbstractFactory factory2 = new ConcreteFactory2();
            Client client2 = new Client(factory2);
            client2.Run();

            Console.ReadKey();
        }
    }
}
