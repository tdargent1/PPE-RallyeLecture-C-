using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace ppe
{
    class TableEleve
    {
        private MySqlConnection connection;
        public void Insert(Eleve eleve)
        {
            // récupére l'id de la classe

            this.connection = ConnexionMySql.GetConnexion;
            this.connection.Open();
            MySqlCommand cmdSql4 = new MySqlCommand();
            cmdSql4.Connection = this.connection;
            cmdSql4.CommandText = "select max(id) from classe";
            cmdSql4.CommandType = CommandType.Text;
            int idClasse = (int)cmdSql4.ExecuteScalar();
            this.connection.Close();

            // récupére le dernier l'id de aauth_user

            this.connection.Open();
            MySqlCommand cmdSql9 = new MySqlCommand();
            cmdSql9.Connection = this.connection;
            cmdSql9.CommandText = "select max(id) from aauth_users";
            cmdSql9.CommandType = CommandType.Text;
            int idAuthSalt = Convert.ToInt32(cmdSql9.ExecuteScalar());
            this.connection.Close();

            // hash le mot de passe
            Hash h = new Hash();
            string mdpHash = h.Salt(eleve.PassWord,Convert.ToString(idAuthSalt+1));
            this.connection = ConnexionMySql.GetConnexion;

            // insert dans aauth_user

            string prenomEleve;
            this.connection.Open();
            MySqlCommand cmdSql = new MySqlCommand();
            cmdSql.Connection = this.connection;
            cmdSql.CommandText = "insert into aauth_users(email,pass,username) values(@email,@pass,@username)";
            cmdSql.CommandType = CommandType.Text;
            cmdSql.Parameters.Add("@pass", MySqlDbType.String);
            cmdSql.Parameters["@pass"].Value = mdpHash;
            cmdSql.Parameters.Add("@username", MySqlDbType.String);
            prenomEleve = eleve.Prenom;
            cmdSql.Parameters["@username"].Value = prenomEleve[0]+eleve.Nom;
			cmdSql.Parameters.Add("@email", MySqlDbType.String);
			cmdSql.Parameters["@email"].Value = eleve.Nom+eleve.Prenom+"@sio.jjr.fr";
			cmdSql.ExecuteNonQuery();
            this.connection.Close();
            /*
            // récupére le dernier l'id de aauth_user

            this.connection.Open();
            MySqlCommand cmdSql2 = new MySqlCommand();
            cmdSql2.Connection = this.connection;
            cmdSql2.CommandText = "select max(id) from aauth_users";
            cmdSql2.CommandType = CommandType.Text;
            int idAuth = Convert.ToInt32(cmdSql2.ExecuteScalar());
            this.connection.Close();
            */
            //insert les eleves

            this.connection.Open();
            MySqlCommand cmdSql1 = new MySqlCommand();
            cmdSql1.Connection = this.connection;
            cmdSql1.CommandText = "insert into eleve(idclasse,nom,prenom,login,idAuth) values(@idclasse,@nom,@prenom,@login,@idAuth)";
            cmdSql1.CommandType = CommandType.Text;
            cmdSql1.Parameters.Add("@idclasse", MySqlDbType.Int32);
            cmdSql1.Parameters["@idclasse"].Value = idClasse;
            cmdSql1.Parameters.Add("@nom", MySqlDbType.String);
            cmdSql1.Parameters["@nom"].Value = eleve.Nom;
            cmdSql1.Parameters.Add("@prenom", MySqlDbType.String);
            cmdSql1.Parameters["@prenom"].Value = eleve.Prenom;
            cmdSql1.Parameters.Add("@login", MySqlDbType.String);
            cmdSql1.Parameters["@login"].Value = eleve.Login;
            cmdSql1.Parameters.Add("@idAuth", MySqlDbType.Int32);
            cmdSql1.Parameters["@idAuth"].Value = idAuthSalt+1;
            cmdSql1.ExecuteNonQuery();
            this.connection.Close();
            
            // insert dans aauth_user_to_group

            this.connection.Open();
            MySqlCommand cmdSql3 = new MySqlCommand();
            cmdSql3.Connection = this.connection;
            cmdSql3.CommandText = "insert into aauth_user_to_group(user_id,group_id) values(@user,@group)";
            cmdSql3.CommandType = CommandType.Text;
            cmdSql3.Parameters.Add("@user", MySqlDbType.Int32);
            cmdSql3.Parameters["@user"].Value = idAuthSalt+1;
            cmdSql3.Parameters.Add("@group", MySqlDbType.Int32);
            cmdSql3.Parameters["@group"].Value = 4;
            cmdSql3.ExecuteNonQuery();
            this.connection.Close();
        }
    }
}
