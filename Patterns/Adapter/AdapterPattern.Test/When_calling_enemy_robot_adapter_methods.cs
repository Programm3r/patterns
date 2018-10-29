using Moq;
using NUnit.Framework;

namespace AdapterPattern.Test
{
    [TestFixture]
    public class When_calling_enemy_robot_adapter_methods
    {
        [Test]
        public void It_should_call_hit_oponent_robot_enemy_for_do_damage_enemy_action()
        {
            // Given
            var robotEnemyMock = new Mock<RobotEnemy>();
            var adapter = new EnemyRobotAdapter(robotEnemyMock.Object);

            // When
            adapter.DoDamage();

            // Then
            robotEnemyMock.Verify(foo => foo.HitOpponent(), Times.Once);
        }

        [Test]
        public void It_should_call_react_to_human_robot_enemy_for_interact_with_enemy_action()
        {
            // Given
            const string interactionObjectName = "InteractionObjectName";
            var robotEnemyMock = new Mock<RobotEnemy>();
            var adapter = new EnemyRobotAdapter(robotEnemyMock.Object);

            // When
            adapter.InteractWith(interactionObjectName);

            // Then
            robotEnemyMock.Verify(foo => foo.ReactToHuman(interactionObjectName), Times.Once);
        }

        [Test]
        public void It_should_call_walk_forward_robot_enemy_for_move_forward_enemy_action()
        {
            // Given
            var robotEnemyMock = new Mock<RobotEnemy>();
            var adapter = new EnemyRobotAdapter(robotEnemyMock.Object);

            // When
            adapter.MoveForward();

            // Then
            robotEnemyMock.Verify(foo => foo.WalkForward(), Times.Once);
        }
    }
}