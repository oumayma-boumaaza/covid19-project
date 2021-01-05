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
      private static  List<Labo> labos = new List<Labo>();
      private static List<CentreDeVaccination> centreDeVaccinations = new List<CentreDeVaccination>();

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
                        Console.Write("le citoyen a été bien ajouté \n");
                        break;

                    case 1:
                        //Ajouter un laboratoire
                        Console.Write("Donner le nom du loboratoire: ");
                        string nomLabo = Console.ReadLine();
                        for (int i = 0; i < labos.Count(); i++)
                        {
                            if (labos[i].nom.Equals(nomLabo))
                            {
                                Console.WriteLine("le nom du labo existe deja!");
                                continue;
                            }

                        }
                        labos.Add(new Labo(nomLabo));
                        Console.Write("le laboratoire a été bien ajouté \n");
                        break;
                    case 2:
                        //Ajouter un centre de vaccination
                        Console.Write("Donner le nom du centre de vaccination: ");
                        string nomCentre = Console.ReadLine();
                        for (int i = 0; i < centreDeVaccinations.Count(); i++)
                        {
                            if (centreDeVaccinations[i].nomCentre.Equals(nomCentre))
                            {
                                Console.WriteLine("le nom du centre existe deja!");
                                continue;
                            }

                        }
                        centreDeVaccinations.Add(new CentreDeVaccination(nomCentre));
                        Console.Write("le centre de vaccination a été bien ajouté \n");

                        break;
                    case 3:
                        //Afficher la liste des citoyens

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
                    default:
                        Console.WriteLine("Il n'existe aucune operation portant le numero : " + " ' "+ choix + " ' ");
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
                Console.WriteLine("1 : Ajouter un laboratoire");
                Console.WriteLine("2 : Ajouter un centre de vaccination");
                Console.WriteLine("3 : Afficher la liste des citoyens");
                Console.WriteLine("4 : Selectionner un citoyen");
                Console.WriteLine("5 : Tester un Citoyen");
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
        public static void addLabo()
        {

        }

    }
}