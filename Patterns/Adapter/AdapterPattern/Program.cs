using System;

namespace AdapterPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var soldier = new InfantryEnemy();
            var r2d2 = new RobotEnemy();
            var adaptedRobot = new EnemyRobotAdapter(r2d2);

            Console.WriteLine("The game is afoot!");
            Console.WriteLine();

            Console.WriteLine("R2D2 without an adapter");
            r2d2.HitOpponent();
            r2d2.WalkForward();
            r2d2.ReactToHuman("Ryan");

            Console.WriteLine();
            Console.WriteLine("Infantry Enemy");
            soldier.DoDamage();
            soldier.MoveForward();
            soldier.InteractWith("Ryan");

            Console.WriteLine();
            Console.WriteLine("Robot Enemy with adapter");
            adaptedRobot.DoDamage();
            adaptedRobot.MoveForward();
            adaptedRobot.InteractWith("Ryan");

            Console.ReadLine();
        }
    }
}