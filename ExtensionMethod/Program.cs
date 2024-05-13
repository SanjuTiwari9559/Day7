using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "This is Sanjay Tiwari you are so Talented ";
            //string str = " ";
            //string str = "This is Sanjay Tiwari";
         var sorterString= stringExtension.sorten(str, 5);
            Console.WriteLine(sorterString);
        }
    }
}
