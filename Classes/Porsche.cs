using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
   // [Serializable]

    public class Porsche
    {
        public DateTime DatumIzmene { get; set; }
        public string Porse_Modeli { get; set; }
        public String Podnaslov { get; set; }
        public string Tekst { get; set; }
        public String Kategorija { get; set; }
        public String Slika { get; set; }


        public Porsche() { }
        public Porsche(string porse_Modeli, string podnaslov, string tekst, string kategorija,string slika)
        {
            DatumIzmene = DateTime.Now;
            Porse_Modeli = porse_Modeli;
            Podnaslov = podnaslov;
            Tekst = tekst;
            Kategorija = kategorija;
            Slika = slika;
        }
    }
}
