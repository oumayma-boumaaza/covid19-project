/***********************************************************************
 * Module:  Citoyen.cs
 * Author:  Boumaaza Oumayma
 * Purpose: Definition of the Class Citoyen
 ***********************************************************************/
using System;
using System.Collections.Generic;

namespace EtatCovid
{
    public enum Etat
    {
        Symptomatique,
        PorteurDeVirus,
        Inexplore,
        Sain,
        Vaccine,
    }
    
        
    public class Citoyen
    {
        private string last;
        private string first;
        public string cin;
        public DateTime dateDeNaissaance { get; set;}
        public List<Rencontre> rencontres;
        public Etat etat{get;   set;}
        
        public Citoyen(string lastName, string firstName, string Cin, DateTime DateDeNaissance)
        {
            last = lastName;
            first = firstName;
            cin = Cin;
            dateDeNaissaance = DateDeNaissance;
            etat = Etat.Inexplore;
            rencontres = new List<Rencontre>();
        }

        public void Contacter(Citoyen citoyen)
        {
            Rencontre rencontre = new Rencontre(DateTime.Now, this.cin, citoyen.cin);
            this.rencontres.Add(rencontre);
            citoyen.rencontres.Add(rencontre);
        }
        public void SeConfiner(DateTime debut, DateTime fin)
        {
            
        }
    }
}   