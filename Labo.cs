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

        public  bool TesterLeCitoyen(Citoyen citoyen)
        {
            Random rand = new Random();
            bool resultat = rand.NextDouble() >= 0.5;
            EnregistrementLabo.EnregistrerTest(DateTime.Now, citoyen.cin, resultat, this.nom);
            DonnerLeResultat(resultat, citoyen);
            return resultat;
        }
        public void DonnerLeResultat(bool Resultat, Citoyen cit)
        {
            if (Resultat)
            {
                MinistereDeLaSante.ModifierL_etat(cit, Etat.PorteurDeVirus);     
            }
            else
            {
                MinistereDeLaSante.ModifierL_etat(cit, Etat.Sain);    
            }

        }
    }
}