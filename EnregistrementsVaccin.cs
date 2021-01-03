/***********************************************************************
 * Module:  EnregistrementsVaccin.cs
 * Author:  dell
 * Purpose: Definition of the Class EnregistrementsVaccin
 ***********************************************************************/

using System;
namespace EtatCovid
{
    public class EnregistrementsVaccin
    {
        public DateTime DateVacc;
        public string CinCitoyen;
        public EnregistrementsVaccin(DateTime date,string cin)
        {
            DateVacc = date;
            CinCitoyen = cin;
        }

    }
}