using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    public class Class2 : Class1
    {
        public Class2(): base(100)
            { 
            Console.WriteLine("constructor of class 2");
        }
        public static void Main(string[] args)
            {

            Class2 c = new Class2();
            Console.WriteLine(c.name);
            Console.ReadLine();
            
        }
    }
}
