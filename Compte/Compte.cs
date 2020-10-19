using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compte
{
    class Compte
    {
        private int numero;
        private double solde;
        private Client client;
        private [] mouvement;

        public Compte()
        {

        }
     
        public int Numero
        {
            get { return this.numero; }
            set { this.numero = value:}
        }

        public Client Client
        {
            get { return this.client; }
            set { this.client = value; }
        }

        public Array Mouvement
        {
            get { return this.mouvement; }
            set { }
        }
    }
}
