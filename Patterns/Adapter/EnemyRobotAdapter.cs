namespace AdapterPattern
{
    public class EnemyRobotAdapter : IEnemy
    {
        readonly RobotEnemy robot;

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
            robot.WalkForward();
        }
    }
}
