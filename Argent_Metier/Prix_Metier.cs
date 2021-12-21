using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetSymfoCS.DAL;

namespace Argent.Metier
{
    public class Prix_Metier
    {
        public float Montant { get; set; }
        public int IDSoiree { get; set; }
        public int IDParticipant { get; set; }

        public Prix_Metier(float montant, int idSoiree, int idParticipant)
            => (Montant, IDParticipant) = (montant, idParticipant);

        public void InsertIntoBDD()
        {
            Prix_DAL prix = new Prix_DAL(Montant, IDParticipant, IDSoiree);
            PrixDepot_DAL prixD = new DAL.PrixDepot_DAL();
            prixD.Insert(prix);
        }
        public double AfficherPrix(int idSoiree)
        {
            List<Prix_DAL> listP = new List<Prix_DAL>();
            PrixDepot_DAL prixD = new DAL.PrixDepot_DAL();
            listP = prixD.GetAllByIDSoiree(idSoiree);

            double prixTotal = 0;
            foreach (var item in listP)
            {
                prixTotal = prixTotal + item.Montant;
            }
            return prixTotal;
        }
        public List<double> AfficherPrixByParticipant(int idSoiree)
        {
            List<Prix_DAL> listP = new List<Prix_DAL>();
            PrixDepot_DAL prixD = new DAL.PrixDepot_DAL();
            listP = prixD.GetAllByIDSoiree(idSoiree);

            ParticipantDepot_DAL participant = new PartcipantDepot_DAL();
            var listePartcicipant = new List<Participant_DAL>();
            List<double> Depense = new List<double>();
            listeParticipant = participant.GetAllByIDSoiree(idSoiree);
            int nb = 0;
            foreach (var item in listeParticipant)
            {
                nb++;
            }
            for (int i = 0; i < nb; i++)
            {
                int nbDepense = 0;
                Depense.Add(nbDepense);
            }

            foreach (var item in listP)
            {
                for (int i = 0; i < listeParticipantCount; i++)
                {
                    if (item.IDParticipant == listeParticipant[i].ID)
                    {
                        Depense[i] += item.Montant;
                    }
                }
            }
            return Depense;
        }
    }
}