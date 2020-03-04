using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protoype
{
    class Color : ColorPrototype
    {
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }

        public Color(int red, int green, int blue)
        {
            this.Red = red;
            this.Green = green;
            this.Blue = blue;
        }
        public override ColorPrototype Clone()
        {
            return MemberwiseClone() as ColorPrototype;
        }

        public override string ToString()
        {
            return $"RGB: {Red}, {Green},{Blue}";  
        }
    }
}
