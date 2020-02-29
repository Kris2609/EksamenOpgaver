using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    abstract class Builder
    {
            public abstract void SetModel();
            public abstract void SetEngine();
            public abstract void SetBrand();
            public abstract void SetSeat();
            public abstract void SetColor();
            public abstract void SetGps();

            public abstract Product GetProduct();
    }
}
