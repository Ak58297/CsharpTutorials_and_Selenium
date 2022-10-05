using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorials.AccessSpecifier
{

    /*Five types of access modifiers
    public, internal, private, protected, protected internal
     */

    public class Program1
    {

        private void privatmethod()
        {
            Console.WriteLine("Inside private method");
        }

        protected void protectedmethod()
        {
            Console.WriteLine("Inside protected method");
        }

        protected internal void protectedInternalmethod()
        {
            Console.WriteLine("Inside protected Internal method");
        }

        public void publicmethod()
        {
            Console.WriteLine("Inside public method");
        }

        internal void internalmethod()
        {
            Console.WriteLine("Inside internal method");  
        }

        static void Main(String[] args)
        {
            Program1 p=new Program1();
            p.publicmethod();
            p.privatmethod();
            p.internalmethod(); ;
            p.protectedInternalmethod(); 
            p.protectedmethod();


        }



    }
}
