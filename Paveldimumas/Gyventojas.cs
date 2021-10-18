using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paveldimumas
{
    class Gyventojas : Pilietis
    {
        public Gyventojas(string vardas, string pavarde, string asmensKodas, string gyvenamojiVieta) : base(vardas, pavarde, asmensKodas)
        {
            GyvenamojiVieta = gyvenamojiVieta;
        }
        public string  GyvenamojiVieta {get;}

        public override void Info()
          {
            base.Info();
            Console.WriteLine($"Gyvenamoji Vieta: {GyvenamojiVieta}");
          }
  
    }
}
