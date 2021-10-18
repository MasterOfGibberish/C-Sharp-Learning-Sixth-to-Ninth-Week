using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamuDarbai
{
    class Zaidimas
    {

        

        private List<Kortos> kortuKalade = new List<Kortos>();
        private int kortuSk = 52;
        private string[] kortuZenklai = new string[] { "Kryzius", "Vynas", "Bugnas", "Sirdis" };
        private List<Zaidejas> zaidejuSarasas = new List<Zaidejas>();


        public Zaidimas(int zaidejuSkaicius)
        {
            ZaidejuSkaicius = zaidejuSkaicius;
            UzpildytiZenklais(kortuSk, kortuZenklai, kortuKalade);
        }

        public void Isspausdinti()
        {
            var r = new Random();

            foreach (Kortos korta in kortuKalade)
            {
                Console.WriteLine($"{korta.Zenklas} {korta.Verte} {korta.Indeksas}");
                Console.WriteLine($"RANDOM: {r.Next(0, 2)}");
            }

            Console.WriteLine(kortuKalade.Count);
        }
        public int ZaidejuSkaicius { get; }

        public void Zaisti()
        {
            foreach (Kortos korta in kortuKalade)
            {

            }
        }

        private void UzpildytiZenklais(int kortuSkaicius, string[] kortuZenklai, List<Kortos> kortuKalade)
        {
            foreach (string zenklas in kortuZenklai)
            {
                int vienoZenkloKiekis = kortuSkaicius / kortuZenklai.Length;

                for (int i = 2; i < vienoZenkloKiekis - 2; i++)
                {
                    kortuKalade.Add(new SkaitineKorta(zenklas, i));
                }

                kortuKalade.Add(new Galva(zenklas, "B"));
                kortuKalade.Add(new Galva(zenklas, "Q"));
                kortuKalade.Add(new Galva(zenklas, "K"));
                kortuKalade.Add(new Galva(zenklas, "A"));
            }
        }
        private void UzpildytiZaidejuSarasa()
        {

            for (int i = 1; i <= ZaidejuSkaicius; i++)
            {
                Console.WriteLine("Iveskite Varda:");
                string Vardas = Console.ReadLine();
                Zaidejas zaidejasA = new Zaidejas(Vardas);
                zaidejuSarasas.Add(zaidejasA);

            }
        }
        private KortuIsdalinimas()
        {
            foreach (Kortos korta in kortuKalade)
            {
               
            }
        }

    }
}

