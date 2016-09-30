using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4_1
{
    class Program
    {
        static double Safe(double x)
        {
            if (x < 0)
                throw new NegativeNumber();
            return (Math.Pow(x, 1 / 2) + (2 / x) - 3);
        }
        static void Main()
        {

            try
            {
                double a;
                a = Convert.ToDouble(Console.ReadLine());
                double result = 0;

                result = Safe(a);
                Console.WriteLine("{0} divided by = {1}", a, result);
            }
            catch (FormatException)
            {
                Console.WriteLine("It is NOT the number !!!\n");
            }
            catch (NegativeNumber)
            {
                Console.WriteLine("A negative number.");
            }
        }

        class NegativeNumber : SystemException
        {

        }
    }
}
