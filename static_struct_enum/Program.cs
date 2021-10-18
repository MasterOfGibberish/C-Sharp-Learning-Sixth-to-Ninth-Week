using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_struct_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = Naujas.NustatytiSkaiciu();
            Console.WriteLine($"{k}");
            double j = Naujas.NustatytiDouble();
            Console.WriteLine($"{j}");
            int[] SkMasyvas = { 1, 2, 3 };
            Naujas.PrintIntArray(SkMasyvas);
            Console.WriteLine($"{SkMasyvas}");
            Console.ReadLine();

        }
    }
}
