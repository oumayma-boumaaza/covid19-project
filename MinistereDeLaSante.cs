/***********************************************************************
 * Module:  MinistereDeLaSante.cs
 * Author:  Oumayma Boumaaza
 * Purpose: Definition of the Class MinistereDeLaSante
 ***********************************************************************/

using System;
namespace EtatCovid

{
    public static class MinistereDeLaSante
    {
        public static void ModifierL_etat(Citoyen citoyen, Etat etat)
        {
            citoyen.etat = etat;
            EnregistrementsEtat.EnregistrerLesEtats(DateTime.Now, citoyen.cin, etat);
        }
    }
}