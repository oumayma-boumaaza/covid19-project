using EtatCovid;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        private static List<Citoyen> citoyens = new List<Citoyen>();
        
        static void Main(string[] args)
        {

            int choix;

            do
            {
                choix = menu();

                switch (choix)
                {
                        case 0:
                        //Ajouter un citoyen
                            Console.Write("Donner le cin du citoyen:");
                        string cin = Console.ReadLine();
                        for (int i = 0; i < citoyens.Count(); i++)
                        {
                            if (citoyens[i].cin.Equals(cin))
                            {
                                Console.WriteLine("le cin existe deja!");
                                continue;
                            }

                        }
                        getCitoyenInfo(cin);

                        break;

                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:
                        ;
                        break;
                    case 6:
                        ;
                        break;
                    case 7:
                        ;
                        break;
                    case 8:
                        return
                        ;
                        break;
                }
            }
            while (true);
        }
        
        public static int menu()
        {
            int choix;
            do
            {

                Console.WriteLine(" >>>App Covid19\n");
                Console.WriteLine("0 : Ajouter un citoyen");
                Console.WriteLine("1 : Afficher la liste des citoyens");
                Console.WriteLine("2 : Selectionner un citoyen");
                Console.WriteLine("4 : Tester un Citoyen");
                Console.WriteLine("6 : Se faire vacciner un citoyen");
                Console.WriteLine("7 : Contacter deux citoyen");
                Console.WriteLine("8 : Quitter");
                Console.Write("\n>>> Veuillez Choisir!! : ");


                string c = Console.ReadLine();
                choix = int.Parse(c);

            } while ((choix > 8) && (choix < 0));
            return choix;
        }
        
        public static void getCitoyenInfo(string cin)
        {
            Console.Write("Donner le nom du citoyen:");
            string nom = Console.ReadLine();
            Console.Write("Donner le prenom du citoyen:");
            string prenom = Console.ReadLine();
            Console.Write("Donner la date de naissance du citoyen:");

            string dateStr = Console.ReadLine();
            DateTime dateDeNaissaance = DateTime.ParseExact(dateStr, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine("\n1-Symptomatique,\n2-PorteurDeVirus,\n3-Inexplore,\n4-Sain,\n5-Vacciné");
            Console.Write("Entrer l'etat du Citoyen: ");
            var e = int.Parse(Console.ReadLine().Trim());
            switch (e)
            {
                case 1:
                    citoyens.Add(new Citoyen( nom, prenom,cin, dateDeNaissaance, Etat.Symptomatique));
                    break;
                case 2:
                    citoyens.Add(new Citoyen(nom, prenom, cin, dateDeNaissaance, Etat.PorteurDeVirus));
                    break;
                case 3:
                    citoyens.Add(new Citoyen(nom, prenom, cin, dateDeNaissaance, Etat.Inexplore));
                    break;

                case 4:
                    citoyens.Add(new Citoyen(nom, prenom, cin, dateDeNaissaance, Etat.Sain));
                    break;
                case 5:
                    citoyens.Add(new Citoyen(nom, prenom, cin, dateDeNaissaance, Etat.Vaccine));
                    break;
                default:
                    citoyens.Add(new Citoyen(nom, prenom, cin, dateDeNaissaance, Etat.Inexplore));
                    Console.WriteLine("L'etat est citée commme non reconnue");
                    break;
            }
        }


    }
}