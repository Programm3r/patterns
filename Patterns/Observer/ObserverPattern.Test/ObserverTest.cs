using NUnit.Framework;
using ObserverPattern;

namespace ObserverPattern.Test
{
    [TestFixture]
    public class ObserverTest
    {
        [TestCase]
        public void Test1(int killCount)
        {
            Achievement achievement1Observer = new Achievement();
            Achievement achievement2Observer = new Achievement();
            Player player1 = new Player();
            Player player2 = new Player();

            player1.Register(achievement1Observer);
            player2.Register(achievement2Observer);

            string achivementKey = "Achievement-" + "5 Spiders Killed";

            for (int i = 0; i < 5; i++)
            {
                player1.KillSpider();
            }

            for(int i = 0; i < 3; i++)
            {
                player2.KillSpider();
            }

            Assert.IsTrue(achievement1Observer.achievementList.Contains(achivementKey));
            Assert.IsFalse(achievement2Observer.achievementList.Contains(achivementKey));
        }
    }
}
