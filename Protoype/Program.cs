using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protoype
{
    class Program
    {
        static void Main(string[] args)
        {
            ColorManager colorManager = new ColorManager();
            colorManager.Colors["red"] = new Color(255, 0, 0);
            colorManager.Colors["green"] = new Color(0, 255, 0);
            colorManager.Colors["blue"] = new Color(0, 0, 255);

            Color clone = colorManager.Colors["red"].Clone() as Color;

            Console.WriteLine($"Prototype: : {colorManager.Colors["red"].ToString()}");
            Console.WriteLine($"Clone: : {clone.ToString()}");
            Console.WriteLine("--------");
            clone.Red = 150;
            Console.WriteLine($"Prototype: : {colorManager.Colors["red"].ToString()}");
            Console.WriteLine($"Clone: : {clone.ToString()}");

            Console.ReadLine();
        }
    }
}
