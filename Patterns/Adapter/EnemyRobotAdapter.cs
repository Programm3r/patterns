using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class EnemyRobotAdapter : IEnemy
    {
        RobotEnemy robot;

        public EnemyRobotAdapter(RobotEnemy Robot)
        {
            this.robot = Robot;
        }

        public void doDamage()
        {
            robot.HitOpponent();
        }

        public void interactWith(string Name)
        {
            robot.ReactToHuman(Name);
        }

        public void moveForward()
        {
            robot.walkForward();
        }
    }
}
