namespace PatternsApp.Creational.Prototype
{
    public interface IClonable<T> where T : class
    {
        T Clone();
    }
}