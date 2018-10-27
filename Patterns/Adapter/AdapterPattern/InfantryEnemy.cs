using System;

namespace AdapterPattern
{
    public class InfantryEnemy : IEnemy
    {
        private readonly Random _generator = new Random();

        public void DoDamage()
        {
            var damage = _generator.Next(10) + 1;
            Console.WriteLine("Infantry does " + damage + " damage.");
        }

        public void InteractWith(string name)
        {
            Console.WriteLine("Infantry attacks " + name + ".");
        }

        public void MoveForward()
        {
            var movement = _generator.Next(10) + 1;
            Console.WriteLine("Infantry moves " + movement + " spaces.");
        }
    }
}