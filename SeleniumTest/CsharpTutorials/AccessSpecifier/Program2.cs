using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorials.AccessSpecifier
{

    /*Five types of access modifiers
    public, internal, private, protected, protected internal

    Member defined as private will only be accessible within the class
    Every member of the class is by default private
    cannot apply "private,protected, protected internal" in a class
    we can only have public classes
     */

    public class Program2 : Program1
    {

       
        public static void Main(String[] args)
        {
            Program2 p=new Program2();
            p.publicmethod();
           // p.privatmethod(); method will only be accessible inside the class it is defined
            p.internalmethod(); ;
            p.protectedInternalmethod();
            p.protectedmethod();

        }



    }
}
