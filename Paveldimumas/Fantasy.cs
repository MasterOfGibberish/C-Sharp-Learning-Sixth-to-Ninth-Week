using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paveldimumas
{
    class Fantasy
    {
        private readonly string Uzsakovas;
        public string Adresas { get; set; }
        public string PastoKodas { get; set; }

        public string Numeris { get; set; }
        public string Maistas { get; set; }
        public Fantasy(string adresas, string pastoKodas, string numeris, string maistas)
        {
            Uzsakovas = new Random();
            Adresas = adresas;
            PastoKodas = pastoKodas;
            Numeris = numeris;
            Maistas = maistas;
        }
    }
}
