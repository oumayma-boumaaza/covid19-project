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
        public EnregistrementsVaccin(DateTime date,string cin)
        {
            DateVacc = date;
            CinCitoyen = cin;
        }
        public static void EnregistrerVaccin(DateTime date,string cin)
        {
            Vaccins.Add(new EnregistrementsVaccin(date,cin));
        }

    }
}