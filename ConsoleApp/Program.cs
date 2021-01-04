using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EtatCovid;

namespace ConsoleApp
{
    class Program
    {
        private static List<Citoyen> citoyens = new List<Citoyen>();
        static void Main(string[] args)
        {
              int menu()
            {
                int choix = 0;
                Console.WriteLine(" >>>App Covid19");
                Console.WriteLine();
                Console.WriteLine("1 : Afficher la liste des citoyens");
                Console.WriteLine("2 : Selectionner un citoyen");
                Console.WriteLine("4 : Tester un Citoyen");
                Console.WriteLine("6 : Se faire vacciner un citoyen");
                Console.WriteLine("7 : Contacter deux citoyen");
                Console.WriteLine("8 : Quitter");
                Console.WriteLine();
                Console.Write(">>> Veuillez Choisir!! : ");

                while ((choix <= 8) && (choix >= 1))
                {
                    choix = Console.Read();
                }
                return choix;

                int choix;

                do
                {
                    choix = menu();

                    switch (choix)
                    {
                        case 1:
                            //Afficher la liste des citoyens
                            Console.Write("");
                          
                            }
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
                            ;
                            break;
                    }
                }
                while (choix < 11);
            }



        }
    }
}