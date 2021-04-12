using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AganceDeVoyage
{
    class Client
    {
        string nom { get; }
        string prenom { get; }
        string creditCard { get; }

        public Client(string nom, string prenom , string creditCard)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.creditCard = creditCard;
        }
    }
}
