/***********************************************************************
 * Module:  Citoyen.cs
 * Author:  Boumaaza Oumayma
 * Purpose: Definition of the Class Citoyen
 ***********************************************************************/
using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
        public DateTime dateDeNaissaance { get; set; }
        public Etat etat { get; set; }

        public Citoyen(string lastName, string firstName, string Cin, DateTime DateDeNaissance, Etat state)
        {
            last = lastName;
            first = firstName;
            cin = Cin;
            dateDeNaissaance = DateDeNaissance;
            etat = state;
            
        }

        public void Contacter(Citoyen citoyen)
        {
            EnregistrementsRencontres.EnregistrerRncontres(DateTime.Now, this.cin, citoyen.cin);
        }


        public void SeConfiner(DateTime debut, DateTime fin)
        {
            Timer timer1 = new Timer();

            timer1.Interval = 1000 * 60 * 60 * 24 * 14;

            timer1.Enabled = true;

            timer1.Tick += new System.EventHandler(EnregistrerConfinement);

            void EnregistrerConfinement(object sender, EventArgs e)
            {
                timer1.Stop();
                Confinement.EnregistrerConfinements(debut, fin,cin);

            }
        }


    }
}