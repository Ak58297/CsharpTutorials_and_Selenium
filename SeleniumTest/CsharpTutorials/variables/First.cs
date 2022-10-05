
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorials.variables
{
    internal class First
    {
        int i = 100;
        static int b = 8;

        static void Main()
        {
            //non static fields cannot be directly accessed in static block   Console.WriteLine("value of x is" + i);   hvae to create instace of class
            First f=new First(); // instace of a class
            First f1 = f;// f2 is reference of the class OR pointer of f

            Console.WriteLine(f.i);
            Console.WriteLine("value of b is" + b);
        }
    }
}
