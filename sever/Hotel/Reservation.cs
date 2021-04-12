using System;

namespace Hotel {
	public class Reservation
	{
		public string nom;
		public string prenom;
		public string agence;
		public DateTime dateArrivee { get;  }
		public DateTime dateDepart { get; }
		public int nbPersonnes { get; }

		public Reservation(DateTime dateA, DateTime dateD, int nbPersonnes) {
			if (dateD < dateA)
				throw new Exception("Date de départ et avant la date d'arrivée");
			this.dateArrivee = dateA;
			this.dateDepart = dateD;
			this.nbPersonnes = nbPersonnes;
		}

		public Reservation(string nom, string prenom,string agence, DateTime dateA, DateTime dateD, int nbPersonnes)
		{
			this.nom = nom;
			this.prenom = prenom;
			this.agence = agence;
			if (dateD < dateA)
				throw new Exception("Date de départ est avant la date d'arrivée");
			this.dateArrivee = dateA;
			this.dateDepart = dateD;
			this.nbPersonnes = nbPersonnes;
		}

		public override string ToString()
        {
			return "Reservation du " + this.dateArrivee.ToString("d") + " au " + this.dateDepart.ToString("d");
        }
    }
}
