using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public interface IEnemy
    {
        void doDamage();
        void moveForward();
        void interactWith(string Name);
    }
}
