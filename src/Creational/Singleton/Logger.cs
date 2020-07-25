using System;

namespace PatternsApp.Creational.Singleton
{
    public class Logger
    {
        private static object lockObject = new object();
        private static Logger instance;

        public static Logger Instance
        {
            get
            { 
                if (instance == null)
                {
                    lock(lockObject)
                    {
                        if(instance == null)
                        {
                            instance = new Logger();
                        }

                    }

                }

                return instance;
            }
        }

        public void Info(string info)
        {
            Console.WriteLine($"Info : {info}");
        }

    }
}