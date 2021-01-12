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
            if (!LiasonDB.LaboExist(this.nom))
                LiasonDB.InsertLabo(this);
        }
        public string getInfoLabo()
        {
            return $"=> Le Laboratoire : {this.nom}.";
            
        }
        //donne une resultat aletoire entre 0 et 1 en supposant superieur que 0,5 .
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