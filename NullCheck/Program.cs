using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullCheck
{
    class Program
    {
        static int[] CreateArray()
        {
            return null;
        }
        static void Main(string[] args)
        {
            int[] array = CreateArray();

            Console.WriteLine($"Sum of arrays's elements: {array?.Sum() ?? 0}");
            /* operator of null-coalescion ?? allows to setup the default values for reference types.
             * returns the value of its left-hand operand if it isn't null; 
             * otherwise, it evaluates the right-hand operand and returns its result. */

            /* non-conditional operator for null ?.
             * If the object is not null, then a component of the object is accessed:
             * a field, property, method. If the object represents null, the method component is not invoked. */

            Console.ReadKey();
        }
    }

}
