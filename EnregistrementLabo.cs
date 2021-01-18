/***********************************************************************
 * Module:  EnregistrementLabo.cs
 * Author:  dell
 * Purpose: Definition of the Class EnregistrementLabo
 ***********************************************************************/

using System;
using System.Collections.Generic;

namespace EtatCovid
{

    public class EnregistrementLabo
    {
        public static List<EnregistrementLabo> Testes = LiasonDB.ListerTests();
        public DateTime DateTest;
        public string CinCitoyen;
        public bool Resultat;
        public string NomLabo;
        public EnregistrementLabo(DateTime date, string cin, bool result, string nomLabo)
        {
            DateTest = date;
            CinCitoyen = cin;
            Resultat = result;
            NomLabo = nomLabo;
        }

        public static void EnregistrerTest(DateTime date, string cin, bool result, string nomLabo)
        {
            Testes.Add(new EnregistrementLabo(date, cin, result, nomLabo));
            try
            {
                LiasonDB.InsertEnregistrementTest(date, cin, result, nomLabo);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}