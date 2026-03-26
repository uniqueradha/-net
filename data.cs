using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace data
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string DEPT;
            int java;
            int sharp;
            int python;
            Console.WriteLine("enter the name");
            Console.WriteLine("console.ReadLine()");
            Console.WriteLine("enter the dept");
            DEPT=Console.ReadLine();
            Console.WriteLine("enter java marks");
            java=Int32.Parse(Console.ReadLine());
            Console.WriteLine("enter csharp mark");
            python=Int32.Parse(Console.ReadLine());
            int total = java+python;
            Console.WriteLine("total marks "+total);
            Console.ReadKey();


        }
    }
}