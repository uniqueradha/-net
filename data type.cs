using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace intergerdata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Name: ");
            string name= Console.ReadLine();
            Console.WriteLine("Enter the Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name: "+name);
            Console.WriteLine("Age: "+age);
            Console.ReadKey();
        }
    }
}