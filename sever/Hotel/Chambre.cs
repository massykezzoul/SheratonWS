using System;
using System.Collections.Generic;

namespace Hotel {
	public class Chambre
	{
		static int counterChambres = 100;
		public string identifiant { get; }
		public int lits { get; }
		public double prix { get; }
		private List<Reservation> reservations;

		public Chambre()
		{
			this.lits = 0;
			this.prix = 0;
			this.identifiant = "CH" + this.lits + "L" + counterChambres++;
			this.reservations = new List<Reservation>();
		}

		public Chambre(string id, int lits, double prix)
		{
			this.identifiant = id;
			this.lits = lits;
			this.prix = prix;

			this.reservations = new List<Reservation>();
		}

		public bool isDisponible(DateTime debut, DateTime fin, int nbPersonnes)
		{
			if (nbPersonnes > this.lits) return false;
			foreach (Reservation r in this.reservations)
			{
				if ((debut <= r.dateDepart) && (debut >= r.dateArrivee) ||
						(fin <= r.dateDepart) && (fin >= r.dateArrivee)||
						(debut <= r.dateArrivee) && (fin >= r.dateDepart) )
                {
					return false;
                }

			}
			return true;
		}

		public bool isDisponible(Reservation r) { return this.isDisponible(r.dateArrivee, r.dateDepart, r.nbPersonnes); }

		public void reserver(Reservation r)
		{
			if (this.isDisponible(r))
				this.reservations.Add(r);
			else
				throw new Exception("Date non disponible, impossible de reserver à cette date.");
		}

		public override string ToString()
		{
			return "Chambre " + this.identifiant + " avec " + this.lits + " lits à " + this.prix + "€ la nuit.";
		}
	}

	public class Adresse
	{
		string pays { get; }
		string ville { get; }
		string rue { get; }
		int numero { get; }

		public Adresse(string pays, string ville, string rue, int numero)
		{
			this.pays = pays;
			this.ville = ville;
			this.rue = rue;
			this.numero = numero;
		}

		public override string ToString()
		{
			return this.numero + " " + this.rue + ", " + this.ville + " " + this.pays;
		}
	}

	[Serializable()]
	public class Offre
	{
		public string hotel;
		public string nomOffre;
		public int lits;
		public double prix;

		public Offre()
		{
			this.hotel = "";
			this.nomOffre = "";
			this.lits = 0;
			this.prix = 0.0;
		}

		public Offre(string hotel, string nomOffre, int lits, double prix)
		{
			this.hotel = hotel;
			this.nomOffre = nomOffre;
			this.lits = lits;
			this.prix = prix;
		}

		public override string ToString()
		{
			return this.hotel + " " + this.nomOffre + " " + this.lits + " " + this.prix + "€";
		}
	}

}