using System;
using System.Collections.Generic;
using System.Text;

namespace Compte
{
    public class Mouvement
    {
        private string libelle;
        private double montant;

        public Mouvement(string libelle, double montant)
        {
            this.libelle = libelle;
            this.montant = montant;
        }

        public string Libelle
        {
            get{ return this.libelle; }
            set{ this.libelle = value;}
        }

        public double Montant
        {
            get { return this.montant; }
            set { this.montant = value; }
        }
    }
}
