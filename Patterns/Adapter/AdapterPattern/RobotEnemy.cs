using System;

namespace AdapterPattern
{
    public class RobotEnemy
    {
        private readonly Random _generator = new Random();

        public void HitOpponent()
        {
            var damage = _generator.Next(10) + 1;

            Console.WriteLine("Enemy robot causes " + damage + " to opponent.");
        }

        public void WalkForward()
        {
            var walk = _generator.Next(10) + 1;

            Console.WriteLine("Enemy robot walks " + walk + " spaces.");
        }

        public void ReactToHuman(string name)
        {
            Console.WriteLine("Robot Enemy Tromples " + name);
        }
    }
}