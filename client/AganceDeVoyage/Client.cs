using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenceDeVoyage
{
    public class Client
    {
        public string nom { get; }
        public string prenom { get; }
        public string creditCard { get; }

        public Client(string nom, string prenom , string creditCard)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.creditCard = creditCard;
        }
    }
}
