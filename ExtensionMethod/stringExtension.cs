using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public static class stringExtension
    {
        public static string sorten(this string s,int numberOfWords)
        {
            if(s.Length<=0)
            {

                return "This string is Empty please write one or More Words in string";
            }
            var words=s.Split(' ');
            if (words.Length <= numberOfWords)
                return s;
            else
            //{
            //    string str = "";
            //   for(int i=0;i<numberOfWords; i++)
            //    {
            //        str += words[i]+" ";
            //    }
            //   return str;
            //}
            // other Way to write the code
            return string.Join(" ", words.Take(numberOfWords));
        }

     
    }
}
