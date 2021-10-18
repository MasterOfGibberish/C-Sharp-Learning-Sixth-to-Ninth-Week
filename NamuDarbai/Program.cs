using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamuDarbai
{
    class Program
    {
        static void Main(string[] args)
        {
            Zaidimas kortuZaidimas = new Zaidimas(2);
            kortuZaidimas.Isspausdinti();
            Console.Read();

        }
    }
}
