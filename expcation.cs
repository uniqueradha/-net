using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 0;
            try
            {
                int result = a / b;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error:Division by zero is not allowed.");
            }
            finally
            {
                Console.WriteLine("Exception of try-catch block finished");
                Console.ReadKey();
            }
        }
    }
}
