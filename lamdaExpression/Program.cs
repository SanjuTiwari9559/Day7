using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lamdaExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Func<int,int,int> fun=delegate(int a,int b)
            //{
            //    return a + b;
            //} ;
            //Lamda Expression
            Func<int, int, int> sum = (a, b) => (a + b);
            Console.WriteLine(sum(5,7));
        }
        //public static int sum(int a,int b)
        //{
        //    return a+b;
        //}
    }
}
