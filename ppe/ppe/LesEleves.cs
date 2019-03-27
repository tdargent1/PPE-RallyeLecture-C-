using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ppe
{
    class LesEleves
    {
        private List<Eleve> lesEleves;
        public LesEleves()
        {
            lesEleves = new List<Eleve>();
        }
        public List<Eleve> LoadCsv(PassWordType type,string nomfichier)
        {
            StreamReader reader = new StreamReader(nomfichier);
            while (!reader.EndOfStream)
            {
                var ligne = reader.ReadLine();
                var values = ligne.Split(';');
                string login;
                login = values[0] + values[1] + "@sio.jjr.fr";
                Eleve unEleve = new Eleve(values[0], values[1],login, type);
                lesEleves.Add(unEleve);
            }
            return lesEleves;
        }
        public void CreateCsvPasswordFile(string nomfichier)
        {
            StreamWriter file = new StreamWriter(nomfichier+".csv");
            file.WriteLine("login;password");
            for (int i = 0; i < lesEleves.Count; i++)
            {
                file.WriteLine("{0};{1}",lesEleves[i].Login,lesEleves[i].PassWord);
            }
            file.Close();
        }

    }
}
