using System;
using System.Threading.Tasks;

namespace Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers numbers = new Numbers();

            Console.WriteLine("Minimum #1: {0}", numbers.findMinimum(3, 1));
            Console.WriteLine("Minimum #2: {0}", numbers.findMinimum(3, 2, 4));
            Console.WriteLine();
            Console.WriteLine("Maximum #1: {0}", numbers.findMaximum(3, 1));
            Console.WriteLine("Maximum #2: {0}",numbers.findMaximum(3, 2, 4));
            Console.ReadKey();
        }
    }
}
