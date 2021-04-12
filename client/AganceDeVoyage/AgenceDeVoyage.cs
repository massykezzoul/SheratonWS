using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AganceDeVoyage.Hotel;

namespace AgenceDeVoyage
{
	public class AgenceDeVoyage
	{
		public string nom { get; }
		string identifiant { get; }
		string password { get; }
		double tarif { get; } // pourcentage de commision de l'agence


		public AgenceDeVoyage()
		{
			this.nom = "DZTravel";
			this.identifiant = "DZTravel";
			this.password = "strongpassword";
			this.tarif = 1.1;
		}

		private bool facturerClient(Client client,double prix)
        {
			// facture le client de la somme indiqué en paramètre
			return true;
        }

		public Offre[] printDisponibilites(DateTime deb, DateTime fin, int nbPersonne)
        {
			Hotel hotel = new Hotel();
			SOAPResponse response = hotel.getDisponible(this.identifiant, this.password, deb, fin, nbPersonne);

			if (!response.success)
            {
				Console.WriteLine("Impossible d'accéder aux offres de l'hotel (" + response.message+")");
				return new Offre[0];
            }

			if (response.result == null || response.result.Length == 0)
            {
				Console.WriteLine("Aucune chambre n'est disponible.");
				return new Offre[0];
            }

			Console.WriteLine("Les offre disponible pour " + nbPersonne + " personne(s) du " + deb + " au " + fin + ":");
			foreach (Offre offre in response.result)
				Console.WriteLine("Chambre " + offre.nomOffre + " avec " + offre.lits + " lits, " + offre.prix*this.tarif + "€ la nuit");

			return response.result;
		}

		public void reserver(Offre[] offres, string idChambre,DateTime deb,DateTime fin,int nbPersonne, Client client)
        {
			double prix = -1;
			foreach (Offre offre in offres)
				if (offre.nomOffre.Equals(idChambre)) prix = offre.prix;

			if (prix == -1)
            {
				Console.WriteLine("Impossible de reserver la chambre " + idChambre);
				return;
            }

			if (!this.facturerClient(client, prix))
            {
				Console.WriteLine("Impossible de proceder au payment");
				return;
            }
			
			Hotel hotel = new Hotel();
			SOAPResponse response = hotel.reserver(this.identifiant, this.password, idChambre, deb, fin, nbPersonne, client.nom, client.prenom);

			if (!response.success)
            {
				// annuler le payment
				Console.WriteLine("Impossible de reserver la chambre (" + response.message + ")");
				return;
            }

			Console.WriteLine("Reservation réaliser avec succès, vous recevrer un e-mail contenant les informations de réservation.");
			return;
        }

	}
}

