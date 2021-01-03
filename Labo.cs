/***********************************************************************
 * Module:  Labo.cs
 * Author:  Oumayma Boumaaza
 * Purpose: Definition of the Class Labo
 ***********************************************************************/

using System;
namespace EtatCovid
{
    public class Labo
    {
        public string nom
        {
            get;
        }
        public Labo(string Nom)
        {
            nom = Nom;
        }

        public void TesterLeCitoyen(Citoyen citoyen)
        {
            Random rand = new Random();
            bool resultat = rand.NextDouble() > 0.5;

            DonnerLeResultat(resultat, citoyen);
        }

        public string DonnerLeResultat(bool Resultat, Citoyen cit)
        {
            if (Resultat)
            {
                MinistereDeLaSante.ModifierL_etat(cit, Etat.PorteurDeVirus);
                return "Le test est positif";
            }
            else
            {
                MinistereDeLaSante.ModifierL_etat(cit, Etat.Sain);
                return "Le test est negatif";
            }

        }
    }
}