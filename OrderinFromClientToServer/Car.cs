using System;
using System.Collections.Generic;
using System.Text;

namespace OrderinFromClientToServer
{
    [Serializable]
    abstract class Car
    {
        public abstract string Color { get; }
        public abstract string Engine { get; }
        public abstract string Brand { get; }
        public abstract string HorsePower { get; }

        public override string ToString()
        {
            string Return = "";
            Return += $"-Color: {Color}{Environment.NewLine}";
            Return += $"-Engine: {Engine}{Environment.NewLine}";
            Return += $"-Brand: {Brand}{Environment.NewLine}";
            Return += $"-HorsePower: {HorsePower}{Environment.NewLine}";
            return Return;
        }
    }
}
