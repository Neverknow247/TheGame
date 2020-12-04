using System;

namespace TheGame.Models
{
    public abstract class Enemies
    {
        public string Name;

        public int Strength;

        public int Dexterity;

        public int Health;

        public Enemies(string name, int strength, int dexterity, int health)
        {
            Name = name;
            Strength = strength;
            Dexterity = dexterity;
            Health = health;
            Console.WriteLine($"We made Name: {Name} Strength: {Strength} Dexterity: {Dexterity} Health: {Health}");

        }

        public void Stats()
        {
            Console.WriteLine($"Name: {Name} Strength: {Strength} Dexterity: {Dexterity} Health: {Health}");
        }
    }
}

