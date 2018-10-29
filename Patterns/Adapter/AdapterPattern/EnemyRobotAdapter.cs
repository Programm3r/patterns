namespace AdapterPattern
{
    public class EnemyRobotAdapter : IEnemy
    {
        readonly RobotEnemy _robot;

        public EnemyRobotAdapter(RobotEnemy robot)
        {
            _robot = robot;
        }

        public void DoDamage()
        {
            _robot.HitOpponent();
        }

        public void InteractWith(string name)
        {
            _robot.ReactToHuman(name);
        }

        public void MoveForward()
        {
            _robot.WalkForward();
        }
    }
}
