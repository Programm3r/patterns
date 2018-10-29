using System;

namespace StatePattern
{
    public class CrouchingState : IState
    {
        public void EnterState(Player player)
        {
            Console.WriteLine("{0} is now crouching.", player.name);
        }

        public IState HandleInput(Player player, Input input)
        {
            if (input == Input.ReleaseDown)
            {
                return new StandingState();
            }
            else
            {
                return this;
            }
        }

        public void Update(Player player)
        {
            Console.WriteLine("{0} is crouching...", player.name);
        }
    }

    public class StandingState : IState
    {
        public void EnterState(Player player)
        {
            Console.WriteLine("{0} is now standing.", player.name);
        }

        public IState HandleInput(Player player, Input input)
        {
            if (input == Input.PressDown)
            {
                return new CrouchingState();
            }
            else if (input == Input.PressUp)
            {
                return new JumpingState();
            }
            else
            {
                return this;
            }
        }

        public void Update(Player player)
        {
            Console.WriteLine("{0} is standing.", player.name);
        }
    }

    public class JumpingState : IState
    {
        private int counter = 3;

        public void EnterState(Player player)
        {
            Console.WriteLine("{0} is now jumping.", player.name);
        }

        public IState HandleInput(Player player, Input input)
        {
            return this;
        }

        public void Update(Player player)
        {
            Console.WriteLine("{0} is jumping.", player.name);

            counter--;
            if (counter == 0)
            {
                player.playerState = new StandingState();
            }
        }
    }
}
