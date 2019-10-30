using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class Light : IOperation
    {
        public string On()
        {
            return "Light On !!!";
        }

        public string Off()
        {
            return "Light Off !!!";
        }
    }
}
