using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using ProjetSymfoCS.DAL;

namespace Argent.Metier
{
    public class Personne_Metier
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public Personne_Metier(string nom, string prenom) => (Nom, Prenom) = (nom, prenom);


        public void GetAll(int id)
        {
            ParticipantDepot_DAL participant = new ParticipantDepot_DAL();
            var listePersonne = new List<Personne_DAL>();

            listeParticipant = participant.GetAllByIDSoiree(id);
            foreach (var item in listePersonne)
            {
                Console.WriteLine(item.ID + (", ") + item.Nom + (", ") + item.Prenom);
            }
        }
        public int GetNbParticipant(int id)
        {
            ParcipantDepot_DAL personne = new ParticipantDepot_DAL();
            var listeParticipant = new List<Participant_DAL>();

            listeParticipant = participant.GetAllByIDSoiree(id);
            int nb = 0;
            foreach (var item in listeParticipant)
            {
                nb++;
            }
            return nb;
        }
        public List<string> GetNom(int id)
        {
            ParticipantDepot_DAL participant = new ParticipantDepot_DAL();
            var listeParttcipant = new List<Participant_DAL>();
            List<string> noms = new List<string>();

            listeParticipant = personne.GetAllByIDSoiree(id);
            foreach (var item in listeParticipant)
            {
                string nom = item.Nom + (" ") + item.Prenom;
                noms.Add(nom);
            }
            return noms;
        }
    }

}
