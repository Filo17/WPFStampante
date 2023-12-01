using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ambrogiani.filippo._4i.stampante.Models
{
    /* TODO LIST

      Classe "Pagina" 
      - 4 attributi CMYB che, se usata per stampare, consuma i serbatoi della stampante.
      - un costruttore che accetta colori specifici al massimo di valore 3
      - un costruttore che crea una Pagina con colori random*/
    internal class Pagina
    {
        // - 4 serbatoi di colore: CMYB
        public int C { get; set; }
        public int M { get; set; }
        public int Y { get; set; }
        public int B { get; set; }
        Random random = new Random();


        //costruttore che crea pagina con colori random 
        public Pagina()
        {         
            C = random.Next(4);
            M = random.Next(4);
            Y = random.Next(4);
            B = random.Next(4);
        }
        //un costruttore che accetta colori specfici al massimo valore di 3
        public Pagina(int c, int m, int y, int b)
        {
            if (c>3 || m>3 || y>3 || b>3)
            {
                throw new ArgumentException();
            }
        }

    }
}
