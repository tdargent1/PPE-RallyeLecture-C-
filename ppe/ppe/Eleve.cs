using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ppe
{
    class Eleve
    {
        private string nom;
        private string prenom;
        private string login;
        private string passWord;
       static Random random = new Random();
        public Eleve(string nom, string prenom, string login,PassWordType type)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.login = login;
            this.passWord = GetNewPassWord(type);
        }
        static private string GetPassWordAleatoire()
        {
            string minuscule = "abcdefghijklmnopqrstuvwxyz";
            string majuscule = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string caractèreSpécial = "&@#";
            string chiffre = "123456789";
            string mdpAleatorie ="";
            
            int positionMajuscule;
            int positionChiffre;
            int positionCaractèreSpécial;
            positionMajuscule = random.Next(0, 8);
            positionChiffre = positionMajuscule;
            positionCaractèreSpécial = positionMajuscule;
            while (positionChiffre == positionMajuscule) 
            {
                positionChiffre = random.Next(0, 8);
            }
            while (positionCaractèreSpécial == positionMajuscule)
            {
                positionCaractèreSpécial = random.Next(0, 8);
            }
            for (int i = 0; i < 9; i++)
            {
                if (i == positionMajuscule || i == positionChiffre || i==positionCaractèreSpécial)
                {
                    if (i == positionChiffre|| i==positionCaractèreSpécial)
                    {
                        if (i == positionChiffre)
                        {
                            mdpAleatorie += chiffre[random.Next(0, chiffre.Count())];
                        }
                        else
                        {
                            mdpAleatorie+=caractèreSpécial[random.Next(0,caractèreSpécial.Count())];
                        }
                    }
                    else
                    {
                        mdpAleatorie += majuscule[random.Next(0,majuscule.Count())];
                    }
                }
                else
                {
                    mdpAleatorie += minuscule[random.Next(0,minuscule.Count())];
                }
                
            }
            return mdpAleatorie;
        }
        private string GetPassWordConstruit()
        {
            string mdp;
            mdp = Convert.ToString(this.prenom[0])+this.nom;
            return mdp;
        }
        public string GetNewPassWord( PassWordType type)
        {
            string mdp;
            switch (type)
            {
                case PassWordType.Aléatoire :
                    mdp = GetPassWordAleatoire();
                    return mdp;
                case PassWordType.Construit:
                    mdp = this.GetPassWordConstruit();
                    return mdp;
                default :
                    mdp = GetPassWordAleatoire();
                    return mdp;

            }
        }
        public string ToString()
        {
            return string.Format("nom : {0} prenom : {1} login : {2} mdp : {3}", this.nom, this.prenom, this.login, this.passWord);
        }
        public string PassWord { get { return passWord; } }
        public string Login { get { return login; } }
        public string Prenom { get { return prenom; } }
        public string Nom { get { return nom; } }

    }
}
