namespace PatternsApp.Creational.Singleton
{

    using System;
    public class Randomizer
    {
        private static object lockObject = new object();
        private static Randomizer instance;

        private readonly Random randomInstance;

        public static Randomizer Instance
        {
            get
            { 
                if (instance == null)
                {
                    lock(lockObject)
                    {
                        if(instance == null)
                        {
                            instance = new Randomizer();
                        }

                    }

                }

                return instance;
            }
        }

        public Randomizer()
        {
           randomInstance = new Random();
        }

        public int GetNext()
        {
            return randomInstance.Next();
        }
        public int GetNext(int max)
        {
            return randomInstance.Next(max);
        }public int GetNext(int min, int max)
        {
            return randomInstance.Next(min, max);
        }

    }
}