using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorials.variables
{
    internal class Second
    {

        static int x =10; //static variable
        int y=20; // non static variable
        const float pi = 3.14f; // const msut be declared at the time of initialization and cannot be modified
        //constant variable will behave same as static variable ie initialize only one time and does not require instance od class to call
        //only difference is static variable can be modified but const variable cannot be modified

        readonly int q = 89;// cannot be modified as constant after initialization and it not compulsory to initialize readonly variable
        //but behaviour will be same as non static variable ie need to create instant of class
        readonly int w;

        Second()
        {
            this.w =900 ;
        }
        static void Main(String[] args)
        {
            int z; //static variable as it is decalared inside the stati block
            x = 30;
            Console.WriteLine(x); // static member does not require instance for class for initialization
            //Console.WriteLine(y); object reference is required so need to create a object a class

           
            Second s = new Second();
            Console.WriteLine(s.y);
            Console.WriteLine(pi);
            Console.WriteLine(s.q);
            Console.WriteLine(s.w);
           // s.y= 34; This is allowed for non static variable
           // s.w=44; This is not allowed and can only be initialized using constructor

            

        }
    }
}
