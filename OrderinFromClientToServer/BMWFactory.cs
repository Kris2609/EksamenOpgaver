using System;
using System.Collections.Generic;
using System.Text;

namespace OrderinFromClientToServer
{
    class BMWFactory : CarFactory
    {
        public override Car Make()
        {
            return new BMW();
        }
    }
}
