using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public interface IState
    {
        void EnterState(Player player);
        IState HandleInput(Player player, Input input);
        void Update(Player player);
    }

    //This is just for demonstration.
    public enum Input
    {
        PressUp,
        ReleaseUp,
        PressDown,
        ReleaseDown,
    }
}
