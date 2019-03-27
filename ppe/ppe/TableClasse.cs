using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace ppe
{
    class TableClasse
    {
        private MySqlConnection connection;
        public void Insert(Classe classe)
        {
            this.connection = ConnexionMySql.GetConnexion;
            connection.Open();
            MySqlCommand cmdSql = new MySqlCommand();
            cmdSql.Connection = this.connection;
            cmdSql.CommandText = "insert into classe(anneeScolaire,idEnseignant,idNiveau) values(@annee,@idEnseignant,@idNiveau)";
            cmdSql.CommandType = CommandType.Text;
            cmdSql.Parameters.Add("@annee", MySqlDbType.String);
            cmdSql.Parameters["@annee"].Value = classe.AnneeScolaire;
            cmdSql.Parameters.Add("@idEnseignant", MySqlDbType.String);
            cmdSql.Parameters["@idEnseignant"].Value = classe.IdEnseignant;
            cmdSql.Parameters.Add("@idNiveau", MySqlDbType.String);
            cmdSql.Parameters["@idNiveau"].Value = classe.IdNiveau+1;
            cmdSql.ExecuteNonQuery();
            this.connection.Close();

        }
    }
}
