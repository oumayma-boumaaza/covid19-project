﻿using EtatCovid;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        private static List<Citoyen> citoyens = new List<Citoyen>();
        private static List<Labo> labos = new List<Labo>();
        private static List<CentreDeVaccination> centreDeVaccinations = new List<CentreDeVaccination>();

        static void Main(string[] args)
        {

            do
            {
                int choix = menu();

                switch (choix)
                {
                    case 0:
                        //Ajouter un citoyen
                        Console.Write("Donner le cin du citoyen:");
                        string cin = Console.ReadLine().Trim().ToUpper();
                        bool exist0 = false;
                        for (int i = 0; i < citoyens.Count(); i++)
                        {
                            if (citoyens[i].cin.Equals(cin))
                            {
                                Console.WriteLine("le cin existe deja!");
                                exist0 = true;
                                break;
                            }
                        }
                        if (!exist0)
                        {
                            getCitoyenInfo(cin);
                            Console.Write("le citoyen a été bien ajouté \n");
                            
                        }
                        break;
                    case 1:
                        //Ajouter un laboratoire
                        Console.Write("Donner le nom du loboratoire: ");
                        string nomLabo = Console.ReadLine().Trim().ToUpper();
                        bool exist1 = false;
                        for (int i = 0; i < labos.Count(); i++)
                        {
                            if (labos[i].nom.Equals(nomLabo))
                            {
                                Console.WriteLine("le nom du labo existe deja!");
                                exist1 = true;
                                break;
                            }

                        }
                        if (!exist1)
                        {
                            labos.Add(new Labo(nomLabo));
                            Console.Write("le laboratoire a été bien ajouté \n");
                        }
                        break;

                    case 2:
                        //Ajouter un centre de vaccination
                        Console.Write("Donner le nom du centre de vaccination: ");
                        string nomCentre = Console.ReadLine().Trim().ToUpper();
                        bool exist2 = false;
                        for (int i = 0; i < centreDeVaccinations.Count(); i++)
                        {
                            if (centreDeVaccinations[i].nomCentre.Equals(nomCentre))
                            {
                                Console.WriteLine("le nom du centre existe deja!");
                                exist2 = true;
                                break;

                            }
                        }
                        if (!exist2)
                        {
                            centreDeVaccinations.Add(new CentreDeVaccination(nomCentre));
                            Console.Write("le centre de vaccination a été bien ajouté \n");
                        }

                        break;
                    case 3:
                        //Afficher la liste des citoyens
                        ListerCitoyens();
                        break;
                    case 4:
                        //Consulter l'etat d'un citoyen
                        ChercherCitoyen();
                        break;
                    case 5:
                        //tester un citoyen
                        TesterCit();
                        
                        break;
                    case 6:
                        ;
                        break;
                    case 7:
                        ;
                        break;
                    case 8:
                        Console.WriteLine("VOUS AVEZ QUITTÉ");
                        return;
                    default:
                        Console.WriteLine("Il n'existe aucune operation portant le numero : " + " ' " + choix + " ' ");
                        break;
                }
            }
            while (true);
        }

        public static int menu()
        {
            bool choixvalid;
            int choix;
            do
            {

                Console.WriteLine(" >>>App Covid19\n");
                Console.WriteLine("0 : Ajouter un citoyen");
                Console.WriteLine("1 : Ajouter un laboratoire");
                Console.WriteLine("2 : Ajouter un centre de vaccination");
                Console.WriteLine("3 : Afficher la liste des citoyens");
                Console.WriteLine("4 : Consulter l'état d'un citoyen");
                Console.WriteLine("5 : Tester un Citoyen");
                Console.WriteLine("6 : Vacciner un citoyen");
                Console.WriteLine("7 : Contacter deux citoyens");
                Console.WriteLine("8 : Quitter");
                Console.Write("\n>>> Veuillez Choisir!! : ");


                string c = Console.ReadLine();
             choixvalid = int.TryParse(c,out choix);
                if (!choixvalid)
                {
                    Console.WriteLine("choix non valid");
                }
            } while (((choix > 8) && (choix < 0)) ||( !choixvalid));
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
                    citoyens.Add(new Citoyen(nom, prenom, cin, dateDeNaissaance, Etat.Symptomatique));
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
        public static void ListerCitoyens()
        {
            if (citoyens.Count==0)
            {
                Console.WriteLine("Il y a aucun citoyen!");
            }
            else
            {
                for (int i = 0; i < citoyens.Count; i++)
                {
                    Console.WriteLine( citoyens[i].GetInformation() ); 
                }
            }
        }
        public static void ChercherCitoyen()
        {
            Console.Write("Entrez le CIN: ");
            string cin = Console.ReadLine().Trim().ToUpper();
            for (int i = 0; i < citoyens.Count; i++)
            {
                if (citoyens[i].cin.Equals(cin))
                {
                    Console.WriteLine(citoyens[i].GetInformation());
                    return;
                }
            }
            Console.WriteLine("Il n'existe aucun citoyen avec ce CIN");
        }
        public static void TesterCit()
        {
            Console.Write("Citez Le nom du Laboratoire: ");
            string nomlab = Console.ReadLine().Trim().ToUpper();
            for (int i = 0; i < labos.Count; i++)
            {
                if (labos[i].nom.Equals(nomlab))
                {
                    Console.Write("Entrez le CIN: ");
                    string cin = Console.ReadLine().Trim().ToUpper();
                    for (int index = 0; index < citoyens.Count; index++)
                    {
                        if (citoyens[index].cin.Equals(cin))
                        {
                        bool testresult=labos[i].TesterLeCitoyen(citoyens[index]);
                            if (testresult)
                            {
                                Console.WriteLine("Le Test est Positif");
                            }
                            else
                            {
                                Console.WriteLine("Le Test est Négatif");
                                
                            }
                            return;
                        }
                    }
                    Console.WriteLine("Il n'existe aucun citoyen avec ce CIN");
                    return;
                }
                
            }
            
            Console.WriteLine("Il n'existe aucun laboratoire avec ce nom");
        }
    }
}