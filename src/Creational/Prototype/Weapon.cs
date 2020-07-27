namespace PatternsApp.Creational.Prototype
{
    using System;
    using PatternsApp.Creational.Singleton;

    public class Weapon : IClonable<Weapon>, IPrintable
    {
        public const string DefaultName = "Default weapon";
        const int MinDamage = 1;
        const int MaxDamage = 5;
        public readonly Guid Id;
        public readonly string Name;
        public readonly int Damage;
        public Weapon() : this(DefaultName)
        {
        }
        public Weapon(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
            Damage = Randomizer.Instance.GetNext(MinDamage, MaxDamage);
        }
        public Weapon(Weapon weapon)
        {
            Id = Guid.NewGuid();
            Name = weapon.Name;
            Damage = weapon.Damage;
        }

        public Weapon Clone()
        {
            return new Weapon(this);
        }
        public override string ToString()
        {
            return $"Weapon: \nID: {Id}\nName: {Name}\nDamage: {Damage}";
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}