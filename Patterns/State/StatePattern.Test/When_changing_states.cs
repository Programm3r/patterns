using NUnit.Framework;

namespace StatePattern.Test
{
    [TestFixture]
    public class When_changing_states
    {
        [TestCase(Input.PressDown, Input.PressUp)]
        public void It_Should_Not_Jump_While_Crouching(Input[] inputs)
        {
            Player nick = new Player("Nick");

            foreach (Input i in inputs)
            {
                nick.HandleInput(i);
                nick.Update();
            }

            Assert.AreNotEqual(new JumpingState(), nick.playerState);
        }

        [TestCase(Input.PressUp)]
        public void It_Should_Return_To_StandingState_After_3_JumpingState_Updates(Input input)
        {
            Player nick = new Player("Nick");

            nick.HandleInput(input);

            for (int i = 0; i < 3; i++)
            {
                nick.Update();
            }

            Assert.AreEqual(new StandingState(), nick.playerState);
        }
        
    }
}
