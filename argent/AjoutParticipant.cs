using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Argent.Metier;

namespace Argent
{
    internal static class AjoutParticipant
    {
        public static void AjouterParticipant()
        {
            Console.WriteLine("Entrez votre nom: ");
            string nom = Console.ReadLine();
            Console.WriteLine("Entrez votre prenom: ");
            string prenom = Console.ReadLine();

            Participant_Metier personne = new Participant_Metier(nom, prenom);


            Console.ReadLine();
        }

    }
}