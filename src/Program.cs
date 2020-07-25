using System;
using PatternsApp.Creational.Singleton;


namespace PatternsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.Instance.Info("What is your name? ");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            Logger.Instance.Info($"Hello, {name}, on {date:d} at {date:t}!");
            Console.ReadKey(true);
        }
    }
}
