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
  public  class CentreDeVaccination
    {
        public string nomCentre
        {
            get;
        }
        public CentreDeVaccination(string NomCentre)
        {
            nomCentre = NomCentre;
        }
        public string getInfoCentre()
        {
            return $"Le centre de vaccination : {this.nomCentre}";
;        }
        public  void Vacciner(Citoyen citoyen)
        {
            EnregistrementsVaccin.EnregistrerVaccin(DateTime.Now, citoyen.cin);
            MinistereDeLaSante.ModifierL_etat(citoyen, Etat.Vaccine);
        }
    }
}