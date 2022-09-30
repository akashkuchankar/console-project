using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace console_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 Number");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine(sum);
            int sub = a - b;
            Console.WriteLine(sub);
            int mul = a * b;
            Console.WriteLine(mul);
            int div = a / b;
            Console.WriteLine(div);
            int mode = a% b;
            Console.WriteLine(mode);

        }
    }
}
