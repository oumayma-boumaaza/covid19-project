/***********************************************************************
 * Module:  Citoyen.cs
 * Author:  Boumaaza Oumayma
 * Purpose: Definition of the Class Citoyen
 ***********************************************************************/
using System;
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
        public string last;
        public string first;
        public string cin;
        public DateTime dateDeNaissaance { get; }
        private Etat etat;
        public Etat Etat
        {
            get => etat;
            set
            {
                etat = value;
                LiasonDB.UpdateCitoyen(this);
            }

        }

        public Citoyen(string lastName, string firstName, string Cin, DateTime DateDeNaissance, Etat state)
        {
            last = lastName;
            first = firstName;
            cin = Cin;
            dateDeNaissaance = DateDeNaissance;
            Etat = state;
            try
            {
                if (!LiasonDB.CitoyenExist(this.cin))
                {
                    LiasonDB.InsertCitoyen(this);
                    LiasonDB.InsertEnregistrementEtat(DateTime.Now, this.cin, this.Etat);
                }   
                    
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }



        }

        public void Contacter(Citoyen citoyen)
        {
            EnregistrementsRencontres.EnregistrerRncontres(DateTime.Now, this.cin, citoyen.cin);
        }
        public string GetInformation()
        {
            string etat = string.Empty; // ""
            if (this.etat.Equals(Etat.Sain))
                etat = "sain";
            else if (this.etat.Equals(Etat.PorteurDeVirus))
                etat = "Porteur De Virus";
            else if (this.etat.Equals(Etat.Inexplore))
                etat = "Inéxploré";
            else if (this.etat.Equals(Etat.Symptomatique))
                etat = "Symptomatique";
            else if (this.etat.Equals(Etat.Vaccine))
                etat = "Vacciné";
            return $"=> Le citoyen: {this.first}  {this.last} né le {this.dateDeNaissaance.ToShortDateString()} Comportant le numéro du cin {this.cin} .Il est {etat}.";
        }

        public void SeConfiner(DateTime debut)
        {
            Timer timer1 = new Timer();

            timer1.Interval = 1000 * 60 * 60 * 24 * 14;

            timer1.Enabled = true;

            timer1.Tick += new System.EventHandler(EnregistrerConfinement);

            void EnregistrerConfinement(object sender, EventArgs e)
            {
                timer1.Stop();
                Confinement.EnregistrerConfinements(debut, DateTime.Now, cin);
            }
        }


    }
}