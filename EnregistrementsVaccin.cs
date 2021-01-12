/***********************************************************************
 * Module:  EnregistrementsVaccin.cs
 * Author:  dell
 * Purpose: Definition of the Class EnregistrementsVaccin
 ***********************************************************************/

using System;
using System.Collections.Generic;

namespace EtatCovid
{
    public class EnregistrementsVaccin
    {
        public static List<EnregistrementsVaccin> Vaccins = new List<EnregistrementsVaccin>();
        public DateTime DateVacc;
        public string CinCitoyen;
        public string CentreDeVaccination;
        public EnregistrementsVaccin(DateTime date,string cin,string centreDeVaccination)
        {
            DateVacc = date;
            CinCitoyen = cin;
            CentreDeVaccination = centreDeVaccination;
        }
        public static void EnregistrerVaccin(DateTime date,string cin,string centreDeVaccination)
        {
            Vaccins.Add(new EnregistrementsVaccin(date,cin, centreDeVaccination));
            try
            {
                LiasonDB.InsertEnregistrementVaccins(date, cin, centreDeVaccination);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}