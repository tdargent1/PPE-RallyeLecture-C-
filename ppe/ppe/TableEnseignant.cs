using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace ppe
{
    class TableEnseignant
    {
        private MySqlConnection connection;
		public Enseignant ChargerUnEnseignant(string login,string mdp)
		{
			//charge l'enseignant
			Enseignant e = GetByLogin(login);
			if (e != null)
			{
                string idAauth="";
                // je récupére l'id aauth de l'enseignant
                this.connection.Open();
                MySqlCommand cmdSql = new MySqlCommand();
                cmdSql.Connection = this.connection;
                cmdSql.CommandText = "select id from aauth_users where email=@email";
                cmdSql.CommandType = CommandType.Text;
                cmdSql.Parameters.Add("@email", MySqlDbType.String);
                cmdSql.Parameters["@email"].Value = login;
                MySqlDataReader reader = cmdSql.ExecuteReader();
                while (reader.Read())
                {
                    idAauth = Convert.ToString(reader[0]);
                }
                this.connection.Close();
				// hash le mot de passe rentré en paramétre
				Hash hash = new Hash();
                string mdpHash = hash.Salt(mdp, idAauth);
				// compare les mot de passe
				if (e.HashPassWord == mdpHash)
				{
					return e;
				}
			}
			return null;
		}
        public Enseignant GetByLogin(string login)
        {
            this.connection = ConnexionMySql.GetConnexion;
            List<string> utilisateur = new List<string>();
            Enseignant enseignant = new Enseignant();
            List<Enseignant> lesEnseignant = new List<Enseignant>();
            List<int> id = new List<int>();
            List<string> nom = new List<string>();
            List<string> prenom = new List<string>();
            List<string> loginE = new List<string>();
            List<int> idAuth = new List<int>();
            connection.Open();
            // charge tout les enseignant
            MySqlCommand cmdSql = new MySqlCommand();
            cmdSql.Connection = this.connection;
            cmdSql.CommandText = "enseignant";
            cmdSql.CommandType = CommandType.TableDirect;
            MySqlDataReader reader = cmdSql.ExecuteReader();
            while (reader.Read())
            {
                id.Add((int)reader[0]);
                nom.Add((string)reader[1]);
                prenom.Add((string)reader[2]);
                loginE.Add((string)reader[3]);
                idAuth.Add((int)reader[4]);
            }
            this.connection.Close();
            for (int i = 0; i < id.Count; i++)
            {
                connection.Open();
                // charge le mot de passe de l'enseignant
                MySqlCommand cmdSql1 = new MySqlCommand();
                cmdSql1.Connection = this.connection;
                cmdSql1.CommandText = "select pass, username from aauth_users where id=@id";
                cmdSql1.CommandType = CommandType.Text;
                cmdSql1.Parameters.Add("@id", MySqlDbType.Int32);
                cmdSql1.Parameters["@id"].Value = idAuth[i];
                MySqlDataReader reader1 = cmdSql1.ExecuteReader();
                while (reader1.Read())
                {
                    Enseignant e = new Enseignant(id[i], nom[i], prenom[i], loginE[i], (string)reader1[0]);
                    lesEnseignant.Add(e);
                }
                this.connection.Close();
            }
            foreach (Enseignant e in lesEnseignant)
            {
                // conpare les login de tout les enseignant au login donnée en paramétre
                if (e.Login == login)
                {
                    return e;
                }
            }
            return null;
        }
    }
}
