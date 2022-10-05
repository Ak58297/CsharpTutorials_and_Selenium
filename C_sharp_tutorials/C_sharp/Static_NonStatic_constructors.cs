using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
     class Static_NonStatic_constructors
    {
        static int x;
        int y;

        static Static_NonStatic_constructors()
        {
            //This will get executed without creatin an instance of the class
            //Will be executed as soon as main method is triggered
            //cannot be parameterized because it is implicitly called
            //can not be overloaded
            //non static block can not be accessed inside static block
            


            Console.WriteLine("iNSIDE static constructor");
            Console.WriteLine(x);
            
        }

        Static_NonStatic_constructors()
        {
            Console.WriteLine("Inside NON-static constructor");
        }

        public static void Main(string[] args)
        {
            Static_NonStatic_constructors s=new Static_NonStatic_constructors();
            //Console.WriteLine(y); a object ref is reqiired for non static field
            Console.WriteLine(s.y);// non static/Instant variables can only be called by using object reference


        }

    }
}
