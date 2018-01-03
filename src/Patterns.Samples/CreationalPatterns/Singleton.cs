using System;

namespace Patterns.Samples.CreationalPatterns
{
    public class Singleton
    {
        // static holder for instance, need to use lambda to construct since constructor private
        private static readonly Lazy<Singleton> _instance = new Lazy<Singleton>(() => new Singleton());

        // private to prevent direct instantiation.
        private Singleton()
        {
        }

        // accessor for instance
        public static Singleton Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        public void DoWork()
        {
            Console.WriteLine(this.GetType().Name + " work");
        }
    }
}
