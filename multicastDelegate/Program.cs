using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace multicastDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SomeClass someClass = new SomeClass();
         
            //someClass.someDelegate=callValue;
            someClass.someDelegate = null;
            //someClass.someDelegate += classValue2;
            //someClass.someDelegate += classValue3;
            Thread thread=new Thread(new ThreadStart(someClass.hugeProcess));
            thread.Start();
           // someClass.hugeProcess();
            Console.WriteLine("Program.cs");


        }
        public static void callValue(int i)
        {
            Console.WriteLine(i);
        }
        public static void classValue2(int j)
        {
            Console.WriteLine("This is 2 nd function");
        }
        public static void classValue3(int k)
        {
            Console.WriteLine("This is the 3 rd function");
        }
    }
    public class SomeClass
    {
        public delegate void SomeDelegate(int i);
        public event SomeDelegate someDelegate = null;
        public void hugeProcess()
        {
            for(int i=0;i<10; i++)
            {
                Thread.Sleep(1000);
                someDelegate(i);
            }
        }
    }
}
