using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EtatCovid
{
   public class EnregistrementsRencontres
    {
        public static List<EnregistrementsRencontres> rencontre = new List<EnregistrementsRencontres>();
        public DateTime DateRoncontre;
        public string CinCitoyen1;
        public string CinCitoyen2;

        public EnregistrementsRencontres(DateTime Date,string Cin1,string Cin2)
        {
            DateRoncontre = Date;
            CinCitoyen1 = Cin1;
            CinCitoyen2 = Cin2;
        }
        public static void EnregistrerRncontres(DateTime date,string cin1,string cin2)
        {
            rencontre.Add(new EnregistrementsRencontres(DateTime.Now, cin1, cin2));
            try
            {
                LiasonDB.InsertEnregistrementRencontre(date, cin1,cin2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
