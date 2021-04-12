using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using AganceDeVoyage.Hotel;
namespace AgenceDeVoyage
{
    class Program
    {
        static void Main(string[] args)
        {
            AgenceDeVoyage agence = new AgenceDeVoyage();

            Console.WriteLine("Bienvenu à l'agence " + agence.nom);
            Console.Write("Veuillez saisir votre nom : ");
            string nom = Console.ReadLine();
            Console.Write("Veuillez saisir votre prenom : ");
            string prenom = Console.ReadLine();
            Console.Write("Veuillez saisir les numéro de votre carte de crédit: ");
            string creditCard = Console.ReadLine();

            Client client = new Client(nom, prenom, creditCard);

            Console.WriteLine("Format de la date : (jj/mm/aaaa)");
            Console.Write("Veuillez saisir la date de début de votre séjour: ");
            DateTime deb = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Veuillez saisir la date de fin de votre séjour: ");
            DateTime fin = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Nombre de personnes : ");
            int nbP = Convert.ToInt32(Console.ReadLine());

            Offre[] offres = agence.printDisponibilites(deb, fin, nbP);

            if (offres == null || (offres.Length == 0))
                return;

            Console.Write("Donnnez la chambre de votre choix : ");
            string choix = Console.ReadLine();

            Console.WriteLine("Réservation en cours...");
            agence.reserver(offres, choix, deb, fin, nbP, client);


            Console.WriteLine("--------------------------------------------");
            agence.printDisponibilites(deb, fin, nbP);
            Console.ReadLine();
            return;
        }
    }
}
