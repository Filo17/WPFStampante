using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ambrogiani.filippo._4i.stampante.Models
{
    /* TODO LIST */
    internal class Stampante
    {
        // - 4 serbatoi di colore: CMYB
        public int C { get; set; }
        public int M { get; set; }
        public int Y { get; set; }
        public int B { get; set; }
        //...e un cassetto di fogli
        public int Fogli { get; set; }
        public Stampante() //costruttore, indico che una stampante ha queste 2 caratteristiche
        {
            C = M = Y = B = 100;
            Fogli = 200;
        }

        //un metodo bool Stampa(Pagina p) (che torna false, se l'inchiostro non è sufficiente per stampare)
        public bool Stampa(Pagina p)
        {
            if (Fogli>0 && C >= p.C && M >= p.M && Y >= p.Y && B >= p.B)
            {
                C = C - p.C; //tolgo inchiostro cyano in base all'inchiostro che richiede la pagina
                M = M - p.M;
                Y = Y - p.Y;
                B = B - p.B;
                Fogli--;

                return true;
            }
            else { return false; }
        }

        //torna la quantità di inchiostro presente nei 4 serbatoi.
        public int StatoInchiostro(string colore)//colore è un Enum
        {
            if (colore == "C") { return C; }
            else if (colore == "M") { return M; }
            else if (colore == "Y") { return Y; }
            else if (colore == "B") { return B; }
            else return 0;
        }

        //metodo che mi ritorna la quantità di fogli nel cassetto
        public int StatoCarta()
        {
            return Fogli;
        }

        //metodo che rimpiazza un serbatoio di inchiostro e lo riporta a 100
        public void SostituisciColore(int seleziona)
        {
            if (seleziona == 1) {C = 100;}
            else if (seleziona == 2) { M = 100;}
            else if (seleziona == 3) { Y = 100;}
            else if (seleziona == 4) { B = 100;}
            else Console.WriteLine("Inserisci un colore valido!");
        }

        //metodo che aggiunge fogli fino ad un max di 200

        public void AggiungiCarta(int qta)
        {
            Fogli = Fogli + qta;
            if (Fogli >200) {  Fogli = 200; }
        }
    }
}
