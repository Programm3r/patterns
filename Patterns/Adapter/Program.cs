using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            InfantryEnemy soldier = new InfantryEnemy();
            RobotEnemy r2d2 = new RobotEnemy();
            EnemyRobotAdapter adaptedRobot = new EnemyRobotAdapter(r2d2);


            Console.WriteLine("The game is afoot!");
            Console.WriteLine();

            Console.WriteLine("R2D2 without an adapter");
            r2d2.HitOpponent();
            r2d2.walkForward();
            r2d2.ReactToHuman("Ryan");

            Console.WriteLine();
            Console.WriteLine("Infantry Enemy");
            soldier.doDamage();
            soldier.moveForward();
            soldier.interactWith("Ryan");

            Console.WriteLine();
            Console.WriteLine("Robot Enemy with adapter");
            adaptedRobot.doDamage();
            adaptedRobot.moveForward();
            adaptedRobot.interactWith("Ryan");

            Console.ReadLine();
        }
    }
}
