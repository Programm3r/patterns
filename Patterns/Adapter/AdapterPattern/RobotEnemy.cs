using System;

namespace AdapterPattern
{
    public class RobotEnemy
    {
        private readonly Random _generator = new Random();

        public virtual void HitOpponent()
        {
            var damage = _generator.Next(10) + 1;

            Console.WriteLine("Enemy robot causes " + damage + " to opponent.");
        }

        public virtual void WalkForward()
        {
            var walk = _generator.Next(10) + 1;

            Console.WriteLine("Enemy robot walks " + walk + " spaces.");
        }

        public virtual void ReactToHuman(string name)
        {
            Console.WriteLine("Robot Enemy Tromples " + name);
        }
    }
}