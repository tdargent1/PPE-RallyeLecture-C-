using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ppe
{
    class Enseignant
    {
        private int id;
        private string nom;
        private string prenom;
        private string login;
        private string hashPassWord;
        public Enseignant(int id, string nom, string prenom, string login, string hashPassWord)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.login = login;
            this.hashPassWord = hashPassWord;
        }
        public Enseignant()
        {
            this.id = 0;
            this.nom = "";
            this.prenom = "";
            this.login = "";
            this.hashPassWord = "";
        }
        public int Id { get { return id; } }
        public string Login { get { return login; } }
        public string HashPassWord { get { return hashPassWord; } }
		public string Nom { get { return nom; } }
		public string Prenom { get { return prenom; } }
	}
}
