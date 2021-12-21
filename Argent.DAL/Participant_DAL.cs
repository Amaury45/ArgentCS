using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Argent.DAL
{
    public class Personne_DAL
    {
        public int ID { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        SqlConnection connexion = new SqlConnection();
        public Participant_DAL(string nom, string prenom) => (Nom, Prenom) = (nom, prenom);
        public Participant_DAL(int id, string nom, string prenom)
            => (ID, Nom, Prenom, IDSoiree) = (id, nom, prenom);

        public void Insert(SqlConnection connexion)
        {

            using (var commande = new SqlCommand())
            {
                commande.Connection = connexion;
                commande.CommandText = "insert into Personne(nom, prenom, idSoiree)" + " values(@Nom,@Prenom); SELECT SCOPE_IDENTITY()";

                commande.Parameters.Add(new SqlParameter("@Nom", Nom));
                commande.Parameters.Add(new SqlParameter("@Prenom", Prenom));

                ID = Convert.ToInt32((decimal)commande.ExecuteScalar());




            }
            connexion.Close();
        }
    }

}