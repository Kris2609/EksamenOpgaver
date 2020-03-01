using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lazy_Loading
{
    class Lazy
    {
        private string _mac;
        public string Mac 
        {
            get
            {
                if (string.IsNullOrEmpty(_mac))
                {
                    _mac = "[MacAdress]";
                    
                }
                return _mac;
            }
        } 
    }
}
