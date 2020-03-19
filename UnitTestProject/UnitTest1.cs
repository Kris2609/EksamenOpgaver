using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            void Test(int a)
            {
                if (a > 0)
                {
                    a++;
                }
                else
                {
                    if (a==5)
                    {
                        a = 6;
                    }
                }
                int b = a;
            }
           
        }
        [TestMethod]
        public void TestWhile()
        {
            void Test(int a)
            {
                bool c = true;
                while (c == true)
                {
                    if (a > 0)
                    {
                        a++;
                    }
                    else
                    {
                        if (a == 6)
                        {
                            a = 7;
                        }
                    }
                    int b = a;
                    c = false;

                }
            }
            
        }
    }
}
