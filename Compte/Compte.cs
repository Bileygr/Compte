using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compte
{
    class Compte
    {
        private static int numero_utilise;
        protected int numero;
        protected double solde;
        protected Client client;
        protected Mouvement[] mouvements;

        public Compte(){}

        public Compte(Client client)
        {
            this.numero = prochainNumero();
            this.client = client;
        }

        protected int prochainNumero() => ++numero_utilise;

        public int Numero
        {
            get { return this.numero; }
            set { this.numero = value; }
        }

        public Client Client
        {
            get { return this.client; }
            set { this.client = value; }
        }

        public Array Mouvements
        {
            get { return this.mouvements; }
            set { }
        }

        public void debiter(double s)
        {
            this.solde = this.solde + s;
        }

        public void crediter(double s)
        {
            this.solde = this.solde - s;
        }
    }
}
