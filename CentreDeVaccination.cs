/***********************************************************************
 * Module:  CentreDeVaccination.cs
 * Author:  dell
 * Purpose: Definition of the Class CentreDeVaccination
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EtatCovid
{
    class CentreDeVaccination
    {
        public string nomCentre
        {
            get;
        }
        public CentreDeVaccination(string NomCentre)
        {
            nomCentre = NomCentre;
        }
        public void SeFaireVacciner(Citoyen citoyen)
        {
            MinistereDeLaSante.ModifierL_etat(citoyen, Etat.Vaccine);
        }
    }
}