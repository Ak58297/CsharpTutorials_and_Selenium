using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    public class Class1
    {
        int x;
        public string name = "abhi";

        public Class1()
        {
            Console.WriteLine("Inside constructor");
            Console.WriteLine("Number is : " + x);
        }
        public Class1(int n)
        {
            this.x = n;
            Console.WriteLine("Inside Paramaterized constructor");
            Console.WriteLine("Number is : "+x);
        }
       /* public static void Main(string[] args)
        {
            Console.WriteLine("Hello pppp");
            Class1 c1 = new Class1(5);
            Class1 c = new Class1();
           
            Console.ReadLine();
        }*/
    }
}
