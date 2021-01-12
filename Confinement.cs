/***********************************************************************
 * Module:  Confinement.cs
 * Author:  dell
 * Purpose: Definition of the Class Confinement
 ***********************************************************************/

using System;
using System.Collections.Generic;

namespace EtatCovid
{
    
    public class Confinement
    {
        public static List<Confinement> Confinements = new List<Confinement>();
        public DateTime DateDebut;
        public DateTime DateFin;
        public string CinCitoyen;

    public Confinement(DateTime debut,DateTime fin,string cin)
        {
            DateDebut = debut;
            DateFin = fin;
        }
    public static void EnregistrerConfinements(DateTime debut,DateTime fin,string cin)
        {
            Confinements.Add(new Confinement(debut, fin,cin));
            try
            {
                LiasonDB.InsertConfinement(debut, fin, cin);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

}