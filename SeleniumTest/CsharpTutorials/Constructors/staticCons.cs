using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorials.Constructors
{
    internal class staticCons
    {
        /* static constructor are implicitly declared only if class contain static variable
         * static constructor only initialize static variable
         * static constructor cannot have parameter(as they are implictly called) as so it cannot be overloaded
         * static constructor are implicitly called before every constructor
         * static constructor will be called as soon as main method gets executed
         * static variables can only be called in static methods
         * non static constructors can be overloaded
         * static constructors are implicitly defined only if class contains static varaiables
          */

        static staticCons()
        {
            Console.WriteLine("Inside static constructor");
        }

        static void Main()
        {
            Console.WriteLine("main method gets executed");

        }

    }
}
