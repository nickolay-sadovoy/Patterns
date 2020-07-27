namespace PatternsApp.Creational.Prototype
{
    using System;

    public class Warrior : IClonable<Warrior>, IPrintable
    {
        public readonly Guid Id;
        public readonly Weapon WarriorWeapon;

        public Warrior(Weapon weapon = null) : base()
        {

            Id = Guid.NewGuid();
            if(weapon != null)
                WarriorWeapon = weapon.Clone();
            else
                WarriorWeapon = new Weapon();
            
        }

        public Warrior (Warrior warrior) : this(warrior.WarriorWeapon)
        {

        }

        public virtual Warrior Clone()
        {
            return new Warrior(this);
        }

        public override string ToString() 
        {
            return $"Warrior: \nID: {Id}\n{WarriorWeapon.ToString()}";
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}