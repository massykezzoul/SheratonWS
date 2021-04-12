# SheratonWS

L’objectif de ce projet est de développer en C# une application de réservation d’hôtels en ligne. Cette application propose une interface permettant à un utilisateur de saisir les informations suivantes: Une ville de séjour, une date d’arrivée, une date de départ, un intervalle de prix souhaité, une catégorie d’hôtel: nombre d’étoiles, le nombre de personnes à héberger. En réponse, l’application lui retourne une liste d’hôtels quirépondent à ses critères et où pour chaque hôtelles informations suivantes sont affichées: nom de l’hôtel, adresse de l’hôtel (pays, ville, rue, numéro, lieu-dit, position GPS), le prix à payer, nombre d’étoile, nombre de lits proposés. L’utilisateur  choisira  un  hôtel  dans  la  liste  proposée  et  l’application  lui  demandera  les informations  suivantes: le  nom  et  prénom  de  la  personne  principale à  héberger,  les informations de la carte de crédit de paiement. L’application utilisera ces informations pour réaliser la réservation de l’hôtel en question.

## Implémentation

L'implémentation s'est faite en C# via [Visual Studio](https://fr.wikipedia.org/wiki/Microsoft_Visual_Studio). La base de données est définie dans le répertoire `db` via [Microsoft SQL Server](https://fr.wikipedia.org/wiki/Microsoft_SQL_Server). Le web service est dans le répertoire `server/Hotel/` et l'application de l'agence `client/AgenceDeVoyage/`

## Auteurs

- Kezzoul Massili -> `massy.kezzoul@gmail.com`
- Elhouiti Chakib -> `celhouiti@gmail.com`
