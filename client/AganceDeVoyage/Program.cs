using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AganceDeVoyage.Hotel;
using System.ComponentModel;

namespace AganceDeVoyage
{
    class Program
    {
        static void Main(string[] args)
        {
            WebService1 hotel = new WebService1();

            string nom = "k", prenom = "m";
            DateTime deb = new DateTime(2021, 04, 1), fin = new DateTime(2021, 05, 01);
            int nbP = 1;

            Hotel.Offre[] l = hotel.getDisponible(deb,fin , nbP);

            Console.WriteLine("Les offre disponible pour "+ nbP + " personne(s) du "+ deb+ " au "+ fin+ ":");
            foreach (Hotel.Offre e in l)
            {
                Console.WriteLine("Chambre "+ e.nomOffre+ " avec "+ e.lits+ " lits, "+ e.prix+"€ la nuit");
            }

            Console.Write("Donnnez la chambre de votre choix : ");
            string choix = Console.ReadLine();

            Console.WriteLine("Réservation en cours...");
            bool result = hotel.reserver(choix, deb, fin, nbP, nom, prenom);
            Console.WriteLine(result ? "OK":"Refusé");


            l = hotel.getDisponible(deb, fin, nbP);
            Console.WriteLine("Les offre disponible pour " + nbP + " personne(s) du " + deb + " au " + fin + ":");
            foreach (Hotel.Offre e in l)
            {
                Console.WriteLine("Chambre " + e.nomOffre + " avec " + e.lits + " lits, " + e.prix + "€ la nuit");
            }
            Console.ReadLine();
        }
    }
}
