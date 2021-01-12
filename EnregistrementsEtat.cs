using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EtatCovid
{
   public class EnregistrementsEtat
    {
        public static List<EnregistrementsEtat> Etats = new List<EnregistrementsEtat>();
        public DateTime DateEtat;
        public string CinCitoyen;
        public  Etat etat;
    public EnregistrementsEtat(DateTime date,string cin,Etat Etat)
        {
            DateEtat = date;
            CinCitoyen = cin;
            etat = Etat;
        }
    public static void EnregistrerLesEtats(DateTime date, string cin,Etat Etat)
        {
           Etats.Add(new EnregistrementsEtat(DateTime.Now, cin, Etat));
            try
            {
                LiasonDB.InsertEnregistrementEtat(date, cin, Etat);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
