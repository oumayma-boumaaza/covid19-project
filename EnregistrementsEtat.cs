using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EtatCovid
{
   public class EnregistrementsEtat
    {
        public DateTime DateEtat;
        public string CinCitoyen;
    public EnregistrementsEtat(DateTime date,string cin)
        {
            DateEtat = date;
            CinCitoyen = cin;
        }
    }
}
