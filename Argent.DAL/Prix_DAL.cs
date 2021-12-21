using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Argent.DAL
{
    public class Prix_DAL
    {
        public int ID { get; set; }
        public double Montant { get; set; }
        public int IDParticipant { get; set; }
        

        SqlConnection connexion = new SqlConnection();
        public Prix_DAL(int id, double montant, int idPersonne) => (ID, Montant, IDParticipant)
            = (id, montant, IDparticipant);

        public void Insert()
        {
            var chaineDeConnexion = "Data Source=localhost;Initial Catalog=Argent;Integrated Security=True";
            using (var connexion = new SqlConnection(chaineDeConnexion))
            {
                connexion.Open();
                using (var commande = new SqlCommand())
                {
                    commande.Connection = connexion;
                    commande.CommandText = "insert into Prix(montant, idPersonne, idSoiree)" + " values(@Montant, @Participant, @idSoiree)";

                    commande.Parameters.Add(new SqlParameter("@Montant", Montant));
                    commande.Parameters.Add(new SqlParameter("@idPersonne", IDParticipant));
                




                }
                connexion.Close();
            }
        }
    }
}