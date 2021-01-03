/***********************************************************************
 * Module:  Confinement.cs
 * Author:  dell
 * Purpose: Definition of the Class Confinement
 ***********************************************************************/

using System;
namespace EtatCovid
{
    public class Confinement
    {
        public DateTime DateDebut;
        public DateTime DateFin;

    public Confinement(DateTime debut,DateTime fin)
        {
            DateDebut = debut;
            DateFin = fin;
        }

    }

}