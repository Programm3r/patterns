using System;
using System.Collections.Generic;

namespace StatePattern
{
    public class Player
    {
        public string name;
        public IState playerState;

        public Player(string _name)
        {
            name = _name;
            playerState = new StandingState();
        }

        public void HandleInput(Input input)
        {
            playerState.HandleInput(this, input);
        }

        public void Update()
        {
            playerState.Update(this);
        }
    }
}
