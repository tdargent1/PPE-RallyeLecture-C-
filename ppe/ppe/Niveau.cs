using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ppe
{
    class Niveau
    {
        private int id;
        private string niveauScolaire;
        public Niveau(int id, string niveauScolaire)
        {
            this.id = id;
            this.niveauScolaire = niveauScolaire;
        }
        public string NiveauScolaire { get { return niveauScolaire; } }
    }
}
