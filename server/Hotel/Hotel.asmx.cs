using System;
using System.Collections.Generic;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Data;
using System.Data.SqlClient;

namespace Hotel
{
    /// <summary>
    /// Description résumée de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
	public class Hotel : System.Web.Services.WebService
	{
		string nom { get; }
		Adresse adr { get; }
		int etoile { get; }
		List<Chambre> chambres { get; }

		DBAccess db;

		public Hotel()
		{
			this.chambres = new List<Chambre>();
			this.nom = "Sheraton";
			this.adr = new Adresse("Algérie", "Oran", "Route des Falaises", 31);
			this.etoile = 5;

			// add chambres
			this.db = new DBAccess();
			this.db.createConn();

			DataTable sqlChambres = new DataTable();
			string query = "SELECT * FROM Chambre";
			db.readDatathroughAdapter(query, sqlChambres);


			foreach (DataRow chambre in sqlChambres.Rows)
            {
				
				string id = (string)chambre["identifiant"];
				int lits = (int)chambre["lits"];
				double prix = (float)chambre["prix"];

				Chambre c = new Chambre(id, lits, prix);

				DataTable sqlReservations = new DataTable();
				query = "SELECT * FROM Reservation WHERE chambre = '" + id + "'";
				db.readDatathroughAdapter(query, sqlReservations);

				foreach (DataRow reservation in sqlReservations.Rows)
                {
					c.reserver(new Reservation(
						(string)reservation["nom"],
						(string)reservation["prenom"],
						(string)reservation["agence"],
						(DateTime)reservation["dateDebut"],
						(DateTime)reservation["dateFin"],
						(int) reservation["nbPersonnes"]
						));
                }
				this.addChambre(c);
            }
		}

		public void addChambre(Chambre chambre)
		{
			this.chambres.Add(chambre);
		}

		public Chambre getChambre(string id)
		{
			for (int i = 0; i < this.chambres.Count; i++)
				if (this.chambres[i].identifiant.Equals(id))
					return (this.chambres[i]);
			return null;
		}
		private bool checkAgence(string nom, string pwd)
        {
			DataTable sqlAgence = new DataTable();
			string query = "SELECT * FROM Agence where nom = '" + nom + "' and pwd = '" + pwd + "'";
			db.readDatathroughAdapter(query, sqlAgence);

			return (sqlAgence.Rows.Count == 1);

		}

		[SoapDocumentMethod]
		[WebMethod]
		public SOAPResponse getDisponible(string agence, string aPwd, DateTime debut, DateTime fin, int nbPersonnes = 1)
		{
			if (!this.checkAgence(agence, aPwd))
				return SOAPResponse.errorResponse("Agence non recconu", agence);
			List<Offre> dispo = new List<Offre>();
			Reservation r = new Reservation(debut, fin, nbPersonnes);
			foreach (Chambre c in this.chambres)
				if (c.isDisponible(r))
					dispo.Add(new Offre(this.nom, c.identifiant, c.lits, c.prix));

			return SOAPResponse.successResponse(agence, dispo);
		}

		[WebMethod]
		public SOAPResponse reserver(string agence, string aPwd, string idChambre, DateTime debut, DateTime fin, int nbPersonnes, string nom, string prenom)
		{
			if (!this.checkAgence(agence, aPwd))
				return SOAPResponse.errorResponse("Le nom ou le mot de passe de l'agence est erroné", agence);

			Chambre c = this.getChambre(idChambre);
			Reservation r = new Reservation(nom, prenom,agence, debut, fin, nbPersonnes);
			if (c == null) return SOAPResponse.errorResponse("La chambre " + idChambre + " n'éxiste pas", agence);
			try {
				c.reserver(r);
			} catch (Exception e){
				return SOAPResponse.errorResponse(e.Message, agence);
			}
			
			string dateDebut = debut.ToString("yyyy - MM - dd");
			string dateFin = fin.ToString("yyyy - MM - dd");

			SqlCommand sql = new SqlCommand("INSERT Reservation VALUES (" +
				"'" + dateDebut + "'," +
				"'" + dateFin + "'," +
				"'" + idChambre + "'," +
				nbPersonnes + "," +
				"'" + nom + "'," +
				"'" + prenom + "'," +
				"'" + agence + "'" +
				")");

			try {
				this.db.executeQuery(sql);
				return SOAPResponse.successResponse(agence, "Reservation OK");
            } catch (Exception e) {
				return SOAPResponse.errorResponse("Impossible de réserver (" +e.Message+")", agence);
            }
			
		}

		public override string ToString()
		{
			string r = this.nom + " ";

			for (int i = 0; i < this.etoile; i++)
				r += "*";

			if (this.adr != null)
				r += "\n" + this.adr.ToString() + "\n";

			foreach (Chambre c in this.chambres)
				r += "\t" + c.ToString() + "\n";

			return r;
		}
	}

	

}
