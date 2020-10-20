using System;

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
            Compte compte3 = new Compte(client3);

            Console.WriteLine(compte1.Client.Prenom + " " + compte1.Client.Nom + " " + compte1.Numero);
            Console.WriteLine(compte2.Client.Prenom + " " + compte2.Client.Nom + " " + compte2.Numero);
            Console.WriteLine(compte3.Client.Prenom + " " + compte3.Client.Nom + " " + compte3.Numero);
        }
    }
}
