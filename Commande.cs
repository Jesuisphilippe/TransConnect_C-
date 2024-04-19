using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace TransConnect
{
    internal class Commande
    {
        public Client Client { get; private set; }
        public Vehicule Vehicule { get; private set; }
        public Chauffeur Chauffeur { get; private set; }
        public string PointDepart { get; private set; }
        public string PointArrivee { get; private set; }
        public DateTime DateLivraison { get; private set; }
        public double Prix { get; private set; }
        public bool EstPayee { get; private set; }

        public Commande(Client client, Vehicule vehicule, Chauffeur chauffeur, string pointDepart, string pointArrivee, DateTime dateLivraison)
        {
            if (!chauffeur.Libre || chauffeur.DateDerniereLivraison.Date == dateLivraison.Date)
            {
                throw new InvalidOperationException("Le chauffeur n'est pas disponible pour cette date.");
            }

            Client = client;
            Vehicule = vehicule;
            Chauffeur = chauffeur;
            PointDepart = pointDepart;
            PointArrivee = pointArrivee;
            DateLivraison = dateLivraison;
            EstPayee = false;

            chauffeur.MettreAJourDisponibilite(dateLivraison, false); // Mettre à jour la disponibilité du chauffeur
        }

        public void CalculerPrix(double kilometres)
        {
           
        }

        public void ConfirmerPaiement()
        {
            EstPayee = true;
            Chauffeur.Libre = true; 
        }
    }
}
