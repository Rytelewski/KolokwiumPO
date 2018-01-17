using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateuszRytelewskiZestawH3
{
    class Serwis : ISerwis
    {
        
        private HashSet<Elektronika> doNaprawy = new HashSet<Elektronika>();

        
        private HashSet<Komputer> komputery = new HashSet<Komputer>();

        public Serwis()
        {
            
       }

        public void DodajTelewizor(string marka, int numerSeryjny, string usterka)
        {
           /*/ foreach (string s in a)
            {
                doNaprawy.Add(Telewizor);
                h.Contains(s);
            } /*/
           
        }

        public void DodajKomputer(string marka, int numerSeryjny, string usterka)
        {

        }

        public override string ToString()
        {
            return "Zawartosc zbioru: " ;
        }

        public void Polacz()
        {

        }

        public void Podziel()
        {
            
        }

        public void Napraw()
        {

        }

        public void Napraw(int numerSeryjny)
        {

        }
    }
}
