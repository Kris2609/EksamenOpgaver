using System;
using System.Collections.Generic;
using System.Text;

namespace OrderinFromClientToServer
{
    [Serializable]
    class Tesla : Car
    {
        public override string Color => "Purple";

        public override string Engine => "V40";

        public override string Brand => "Tesla El Car";

        public override string HorsePower => "200";
    }
}
