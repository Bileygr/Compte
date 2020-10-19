using System;
using System.Collections.Generic;
using System.Text;

namespace Compte
{
    class Client
    {
        private string nom;
        private string prenom;
        private string telephone;

        public Client(string nom, string prenom, string telephone)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.telephone = telephone;
        }

        public string Nom
        {
            get { return this.nom; }
            set { this.nom = value; }
        }

        public string Prenom
        {
            get { return this.prenom; }
            set { this.prenom = value; }
        }

        public string Telephone
        {
            get { return this.telephone; }
            set { this.telephone = value; }
        }
    }
}
