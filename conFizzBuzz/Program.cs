using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clFizzBuzz;

namespace conFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fb = new FizzBuzz("Fizz","Buzz",3, 5, 1, 100);
            fb.WriteFizzBuzz();

            Console.ReadLine();
        }
    }
}
