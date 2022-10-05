using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorials.Constructors
{
    /* Why constructor are needed
     * To create instance of class and for each class we have a implicit constructor if not defined explicitly
     * 




    internal class Class1 
    {
        String name;
        /*
    It's a good practise to declare constructors in the class and if not declared it will be automatically-
        -declared by the program which is called implicit constructor
    Implicit constructor are always public
    Below all are non static constructor and we need to call them explicitly
    */
    

        Class1() { //default constructor if defined explicitly/ Implicit constructor if not defined 
            Console.WriteLine("Inside Default Constructor");
        }

        Class1(string name) // By defaul it will be public and it is called explicit costructors OR Paramaterised constructors
        {
            this.name = name;
            Console.WriteLine($"Inside paramaterised constructor and name is {name}");
            
        }

        public static void Main(String[] args)
        {
            Console.WriteLine("Main method started");
            Class1 c1=new Class1();
            Class1 c2 = new Class1("Abhishek");
        }
    }
}
