using System;
using System.Collections.Generic;
using System.Text;

namespace OrderinFromClientToServer
{
    class TeslaFactory : CarFactory
    {
        public override Car Make()
        {
            return new Tesla();
        }
    }
}
