using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ambrogiani.filippo._4i.stampante.Models
{
    /* TODO LIST
    
    
    
    - un metodo int StatoCarta() che mi ritorna la quantità di fogli nel cassetto
    - un metodo void SostituisciColore( Colore c ) che rimpiazza un serbatoio di inchiostro e lo riporta a 100
    - un metodo void AggiungiCarta( int qta ) che aggiunge fogli fino ad un max di 200

    Classe "Pagina" 
    - 4 attributi CMYB che, se usata per stampare, consuma i serbatoi della stampante.
    - un costruttore che accetta colori specifici al massimo di valore 3
    - un costruttore che crea una Pagina con colori random*/
    internal class Stampante
    {
        // - 4 serbatoi di colore: CMYB
        public int C { get; set; }
        public int M { get; set; }
        public int Y { get; set; }
        public int B { get; set; }
        //...e un cassetto di fogli
        public int Fogli { get; set; }
        public Stampante() 
        {
            C = M = Y = B = 100;
            Fogli = 200;
        }

        //un metodo bool Stampa(Pagina p) (che torna false, se l'inchiostro non è sufficiente per stampare)
        public bool Stampa(Pagina p)
        {
            if (Fogli>0 && C >= p.C && M >= p.M && Y >= p.Y && B >= p.B)
            {
                C = C - p.C;
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
            //soy arrivato qui
        }
        /*
        public int StatoCarta()
        {
            return 1; //ritorna la quantità di carta presente
        }

        public void SostituisciColore(Colore c) //rimpiazza un serbatoio di inchiostro con uno nuovo
        {

        }
        public void AggiungiCarta(int qta) //aggiunge fogli fino ad un max di 200
        {

        }
        */
    }
}
