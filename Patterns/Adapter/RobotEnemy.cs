using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class RobotEnemy
    {

        private Random generator = new Random();

        public void HitOpponent()
        {
            int damage = generator.Next(10) + 1;

            Console.WriteLine("Enemy robot causes " + damage.ToString() + " to opponent.");
        }

        public void walkForward()
        {
            int walk = generator.Next(10) + 1;

            Console.WriteLine("Enemy robot walks " + walk.ToString() + " spaces.");
        }

        public void ReactToHuman(string Name)
        {
            Console.WriteLine("Robot Enemy Tromples " + Name);
        }

    }
}