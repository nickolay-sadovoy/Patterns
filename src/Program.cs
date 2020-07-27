using System;
using PatternsApp.Creational.Singleton;
using PatternsApp.Creational.Prototype;


namespace PatternsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var Warrior1 = new Warrior(new Weapon("Super knife 1"));
            var Warrior3 = new Warrior(new Weapon("Bowl"));
            var Warrior4 = new Warrior(new Weapon("Magic staff"));
            Logger.Instance.Info("----------------------------Warrior 1----------------------------");
            Warrior1.Print();
            var Warrior2 = Warrior1.Clone();
            Logger.Instance.Info("----------------------------Warrior 2 cloned from Warrior 1------");
            Warrior2.Print();
            Logger.Instance.Info("----------------------------Warrior 3----------------------------");
            Warrior3.Print();
            Logger.Instance.Info("----------------------------Warrior 4----------------------------");
            Warrior4.Print();
        }
    }
}
