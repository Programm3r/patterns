using System;

namespace AdapterPattern
{
    public class InfantryEnemy : IEnemy
    {
        private readonly Random generator = new Random();

        public void doDamage()
        {
            var damage = generator.Next(10) + 1;
            Console.WriteLine("Infantry does " + damage + " damage.");
        }

        public void interactWith(string name)
        {
            Console.WriteLine("Infantry attacks " + name + ".");
        }

        public void moveForward()
        {
            var movement = generator.Next(10) + 1;
            Console.WriteLine("Infantry moves " + movement + " spaces.");
        }
    }
}
