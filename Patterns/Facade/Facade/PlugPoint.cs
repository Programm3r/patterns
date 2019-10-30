using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class PlugPoint:IOperation
    {
        public string On()
        {
            return "Plug Point On !!!";
        }

        public string Off()
        {
            return "Plug Point Off !!!";
        }
    }
}
