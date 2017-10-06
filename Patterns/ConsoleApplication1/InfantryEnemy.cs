using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class InfantryEnemy : IEnemy
    {
        private Random generator = new Random();

        public void doDamage()
        {
            int damage = generator.Next(10) + 1;
            Console.WriteLine("Infantry does " + damage.ToString() + " damage.");
        }

        public void interactWith(string Name)
        {
            Console.WriteLine("Infantry attacks " + Name + ".");
        }

        public void moveForward()
        {
            int movement = generator.Next(10) + 1;
            Console.WriteLine("Infantry moves " + movement.ToString() + " spaces.");
        }
    }
}
