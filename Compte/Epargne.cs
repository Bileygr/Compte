using System;
using System.Collections.Generic;
using System.Text;

namespace Compte
{
    class Epargne : Compte
    {
        private double taux { get; set; }

        public Epargne() { }

        public Epargne(Client client) 
        {
            this.numero = prochainNumero();
            this.client = client;
        }

        public double Taux
        {
            get { return this.taux; }
            set { this.taux = value; }
        }
    }
}
