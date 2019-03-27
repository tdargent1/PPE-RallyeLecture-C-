using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace ppe
{
    class TableNiveau
    {
        private MySqlConnection connection;

        public List<Niveau> GetAll()
        {
            this.connection = ConnexionMySql.GetConnexion;
            List<Niveau> niveau = new List<Niveau>();
            connection.Open();
            MySqlCommand cmdSql = new MySqlCommand();

            cmdSql.Connection = this.connection;
            cmdSql.CommandText = "niveau";
            cmdSql.CommandType = CommandType.TableDirect;

            MySqlDataReader reader = cmdSql.ExecuteReader();
            while (reader.Read())
            {
                Niveau n = new Niveau((int)reader[0], (string)reader[1]);
                niveau.Add(n);
            }
            this.connection.Close();
            return niveau;
        }
    }
}
