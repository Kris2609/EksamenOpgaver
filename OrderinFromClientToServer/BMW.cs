using System;
using System.Collections.Generic;
using System.Text;

namespace OrderinFromClientToServer
{
    [Serializable]
    class BMW : Car
    {
        public override string Color => "Red";

        public override string Engine => "4,5";

        public override string Brand => "BMW";

        public override string HorsePower => "45";
    }
}
