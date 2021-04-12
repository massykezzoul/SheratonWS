using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenceVoyage
{
	public class AgenceDeVoyage
	{
		string nom { get; }
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

		public void printDisponibilites(DateTime deb, DateTime fin, int nbPersonne)
        {

        }

		public void reserver(string idChambre,DateTime deb,DateTime fin, Client client)
        {
			if (this.facturerClient(client, )
        }

	}
}

