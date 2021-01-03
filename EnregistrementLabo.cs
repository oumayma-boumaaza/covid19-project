/***********************************************************************
 * Module:  EnregistrementLabo.cs
 * Author:  dell
 * Purpose: Definition of the Class EnregistrementLabo
 ***********************************************************************/

using System;
namespace EtatCovid
{
    public class EnregistrementLabo
    {
        public DateTime DateTest;
        public string CinCitoyen;
        public bool Resultat;
    public EnregistrementLabo(DateTime date,string cin,bool result)
        {
            DateTest = date;
            CinCitoyen = cin;
            Resultat = result;
        }
    }
}