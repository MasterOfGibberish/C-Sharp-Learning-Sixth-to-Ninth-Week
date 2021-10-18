using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zodynas
{
    class Program
    {
        static void Main(string[] args)
        {
            Zodynelis();
            Console.ReadLine();
        }
            public static void Zodynelis()
        {
            Dictionary<string, string> Zodynas = new Dictionary<string, string>();
            Zodynas.Add("Kazkas", "Kazkas1 blablabala");
            
            foreach (var item in Zodynas)
            {
                Console.WriteLine($"\n {item.Key} )");
            }
            Zodynas.Add("Kazkas2", "Kazkas3");
            Zodynas.TryGetValue("Kazkas", out string ManoNorimasTekstas);
            Console.WriteLine($"Patikriname: {ManoNorimasTekstas}") ;
            
            foreach (var item in Zodynas)
            {
                Console.WriteLine($"{item.Key}\n Visos reiksmes: {item.Value}");
            }
            Console.WriteLine("Programa nusprende pailseti");
            Console.ReadLine();
        }
            

        
    }
}
