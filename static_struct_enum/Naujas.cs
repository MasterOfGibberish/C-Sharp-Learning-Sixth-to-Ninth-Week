using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_struct_enum
{
    class Naujas
    {
        public static int NustatytiSkaiciu()
        {
            Console.WriteLine("Iveskite skaiciu");
            int sk = Convert.ToInt32(Console.ReadLine());
            return sk;
        }
        public static double NustatytiDouble()
        {
            Console.WriteLine("Parasykite skaiciu su kableliu");
            Double skDouble = Convert.ToDouble(Console.ReadLine());
            return skDouble;
        }
        public static void PrintIntArray(int[] SkMasyvas)
        {
            foreach (int a in SkMasyvas)
            {
                Console.WriteLine($"{a}");
            }
            Console.ReadLine();
        }



    }
}

