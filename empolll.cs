using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace emplpoyee_e
{
    class Program
    {
        static void Main(string[] args)
        {
            String NAME;
            string DEPT;
            int salary;
            Console.WriteLine("Name:");
            NAME = Console.ReadLine();
            Console.WriteLine("DEPT:");
            DEPT = Console.ReadLine();
            Console.WriteLine("salary:");
            salary = int.Parse(Console.ReadLine());
            Console.WriteLine("employee deatils " + NAME + salary + DEPT);
            Console.ReadLine();

        }
    }
}
