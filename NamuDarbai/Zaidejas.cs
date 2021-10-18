using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamuDarbai
{


    public class Zaidejas
    {
        public List<Kortos> Ranka { get; }
        public Zaidejas(string vardas)
        {
            Vardas = vardas;
            Ranka = new List<Kortos>();
        }

        public string Vardas { get; }

        public void ImtiKorta(Kortos korta)
        {
            Ranka.Add(korta);
        }
    }

}
