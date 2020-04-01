using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Øvelser
{
    class ThreadCall
    {
        private string data;
        private int number;

        public ThreadCall(string data)
        {
            this.data = data;
        }
        public ThreadCall(string data, int number)
        {
            this.data = data;
            this.number = number;
        }

        public ThreadCall(int number)
        {
            this.number = number;
        }

        public void PrintMessage()
        {
            Console.WriteLine("The thread is somehow wierd and is using following data: {0}", data);
        }

        public void PrintNumber()
        {
            Console.WriteLine("This is a calculator and has reached: {0}", number);
        }

        public void PrintBothNumberAndMessage()
        {
            Console.WriteLine("This is a double and will give you {0}, {1}", data,number);
        }

    }

    


}
