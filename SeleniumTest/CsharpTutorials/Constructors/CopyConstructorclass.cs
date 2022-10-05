using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorials.Constructors
{
    internal class CopyConstructorclass
    {
        int x;

        CopyConstructorclass(int y)
        {
            this.x = y;
        }

        public CopyConstructorclass(CopyConstructorclass objj)
        {
            x = objj.x;
        }
        void display()
        {
            Console.WriteLine($"value of x is {x}");
        }

        public static void Main(string[] args)
        {
            CopyConstructorclass c = new CopyConstructorclass(15);
            c.display();
            CopyConstructorclass c1 = new CopyConstructorclass(c);
            c1.display();
        }
    }
}
