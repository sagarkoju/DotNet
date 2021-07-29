using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class Program
    {
        int result;
        public void division(int num1, int num2)
        {
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }
            finally
            {
                Console.WriteLine("Result :{0}", result);
            }
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.division(20, 0);
            Console.ReadKey();
        }
    }
}
