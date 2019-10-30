using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class Fan : IOperation
    {
        public string On()
        {
            return "Fan On !!!";
        }

        public string Off()
        {
            return "Fan Off !!!";
        }
    }
}
