using System;
using System.Reflection.Metadata.Ecma335;

namespace Compte
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client("Keita", "Cheik-Siramakan", "0605557802");
            Client client2 = new Client("Alassan", "Abou", "0605557803");
            Client client3 = new Client("Boullioud", "Corentin", "0605557804");


            Compte compte1 = new Compte(client1);
            Compte compte2 = new Compte(client2);
            Epargne compte3 = new Epargne(client3);

            compte1.AddMouvement(new Mouvement("Versement initial", 20));
            compte2.AddMouvement(new Mouvement("Versement initial", 50000));
            compte3.AddMouvement(new Mouvement("Versement initial", 25000));

            Console.WriteLine(compte1.Client.Prenom + " " + compte1.Client.Nom + " " + compte1.Numero + " Versement : " + compte1.Mouvements[0].Libelle + " " + compte1.Mouvements[0].Montant) ;
            Console.WriteLine(compte2.Client.Prenom + " " + compte2.Client.Nom + " " + compte2.Numero + " Versement : " + compte2.Mouvements[0].Libelle + " " + compte2.Mouvements[0].Montant);
            Console.WriteLine(compte3.Client.Prenom + " " + compte3.Client.Nom + " " + compte3.Numero + " Versement : " + compte3.Mouvements[0].Libelle + " " + compte3.Mouvements[0].Montant);
        }
    }
}
