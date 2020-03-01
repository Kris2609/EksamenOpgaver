using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lazy_Loading
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                List<Normal> normal = new List<Normal>();
                for (int i = 0; i < 20; i++)
                {
                    normal.Add(new Normal());
                }
                foreach (var item in normal)
                {
                    Console.WriteLine(item.mac);
                }

                List<Lazy> lazy = new List<Lazy>();
                for (int i = 0; i < 20; i++)
                {
                    lazy.Add(new Lazy());
                }
                foreach (var item in lazy)
                {
                    Console.WriteLine(item.Mac);
                }
                Console.ReadLine();
            }
        }
    }
}
