using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EtatCovid
{
   public class Rencontre
    {
        public DateTime DateRoncontre;
        public string CinCitoyen1;
        public string CinCitoyen2;

        public Rencontre(DateTime Date,string Cin1,string Cin2)
        {
            DateRoncontre = Date;
            CinCitoyen1 = Cin1;
            CinCitoyen2 = Cin2;
        }
    }
}
