using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ambrogiani.filippo._4i.stampante.Models
{
    internal class Pagina
    {
        // - 4 serbatoi di colore: CMYB
        public int C { get; set; }
        public int M { get; set; }
        public int Y { get; set; }
        public int B { get; set; }

        public Pagina()
        {
            //costruttore che crea pagina con colori random e un costruttore che accetta colori specfici al massimo valore di 3
        }
    }
}
