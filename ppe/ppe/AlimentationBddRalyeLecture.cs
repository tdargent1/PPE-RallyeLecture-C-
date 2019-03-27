using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;

namespace ppe
{
    public partial class AlimentationBddRalyeLecture : Form
    {
        private Enseignant enseignant;

        public AlimentationBddRalyeLecture(int id, string nom, string prenom, string login, string hashPassWord)
        {
            InitializeComponent();

            this.enseignant = new Enseignant(id, nom, prenom, login, hashPassWord);
            
            
            ConnexionMySql.Connexion("root", "siojjr", "rallyeLecture", "172.16.0.173");
            MySqlConnection cnx = ConnexionMySql.GetConnexion;

			TableNiveau n = new TableNiveau();
            List<Niveau> niveau = n.GetAll();
            foreach (Niveau liste in niveau)
            {
                cmbNiveau.Items.Add(liste.NiveauScolaire);
            }
            cmbRepertoireFichier.Click += new EventHandler(cmbRepertoireFichier_Click);
            cmbNiveau.Text = "choisir Le niveau";
            cbAleatoire.Click += new EventHandler(cbAléatoire_Click);
            cbConstruit.Click += new EventHandler(cbConstruit_Click);
            btnLancerIntegration.Click += new EventHandler(btnLancerIntegration_Click);
            
        }

        void btnLancerIntegration_Click(object sender, EventArgs e)
        {
            if (clbFichierIntegrer.SelectedItem != null)
            {
                string nomFichierCharger = folderBrowserDialog1.SelectedPath + "/" + Convert.ToString(clbFichierIntegrer.SelectedItem);
                string nomFichierCreer = folderBrowserDialog1.SelectedPath ;
                LesEleves leseleves = new LesEleves();
                
                PassWordType type;
                if (tbAnneeScolaire.Text != "")
                {
                    if (cmbNiveau.Text != "choisir Le niveau")
                    {
                        if (cbAleatoire.Checked == true || cbConstruit.Checked == true)
                        {
                            if (cbAleatoire.Checked == true)
                            {
                                type = PassWordType.Aléatoire;
                            }
                            else
                            {
                                type = PassWordType.Construit;
                            }
                            cbAleatoire.BackColor = System.Drawing.Color.White;
                            cbConstruit.BackColor = System.Drawing.Color.White;
                            tbAnneeScolaire.BackColor = System.Drawing.Color.White;
                            clbFichierIntegrer.BackColor = System.Drawing.Color.White;
                            cmbNiveau.BackColor = System.Drawing.Color.White;
                            List<Eleve> listnom = leseleves.LoadCsv(type, nomFichierCharger);
                            TableEnseignant tEnseignant = new TableEnseignant();
                            //Enseignant enseignant = new Enseignant();
                            //enseignant = tEnseignant.GetByLogin("enseignant@sio.jjr.fr");
                            Classe laClasse = new Classe(this.enseignant.Id, tbAnneeScolaire.Text, cmbNiveau.SelectedIndex);
                            TableClasse tClasse = new TableClasse();
                            tClasse.Insert(laClasse);
                            TableEleve tEleve = new TableEleve();
                            foreach (Eleve eleve in listnom)
                            {
                                tEleve.Insert(eleve);
                            }
                            leseleves.CreateCsvPasswordFile(nomFichierCreer + "/" + tbAnneeScolaire.Text + cmbNiveau.Text);

                            MessageBox.Show("Integration fini");
                        }
                        else
                        {
                            MessageBox.Show("Vous n'avez pas selectionner le type de mot de passe");
                            cbAleatoire.BackColor = System.Drawing.Color.Red;
                            cbConstruit.BackColor = System.Drawing.Color.Red;
                            tbAnneeScolaire.BackColor = System.Drawing.Color.White;
                            cmbNiveau.BackColor = System.Drawing.Color.White;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vous n'avez pas selectionner le niveau de la classe");
                        cmbNiveau.BackColor = System.Drawing.Color.Red;
                    }
                }
                else
                {
                    MessageBox.Show("Vous n'avez pas donner une année scolaire");
                    tbAnneeScolaire.BackColor = System.Drawing.Color.Red;
                    clbFichierIntegrer.BackColor = System.Drawing.Color.White;
                    cmbRepertoireFichier.BackColor = System.Drawing.Color.White;
                }
            }
            else
            {
                MessageBox.Show("Vous n'avez pas choisi de fichier");
                clbFichierIntegrer.BackColor = System.Drawing.Color.Red;
                cmbRepertoireFichier.BackColor = System.Drawing.Color.Red;
            }
        }
        void cbConstruit_Click(object sender, EventArgs e)
        {
            cbAleatoire.Checked = false;
        }
        void cbAléatoire_Click(object sender, EventArgs e)
        {
            cbConstruit.Checked = false;
        }
        void cmbRepertoireFichier_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            cmbRepertoireFichier.Text = folderBrowserDialog1.SelectedPath;
			if (cmbRepertoireFichier.Text != "")
			{
				DirectoryInfo direction = new DirectoryInfo(@cmbRepertoireFichier.Text);
				FileInfo[] fichiers = direction.GetFiles("*.csv");

				foreach (FileInfo fichier in fichiers)
				{
					clbFichierIntegrer.Items.Add(fichier.Name);
				}
			}
        }

    }
}
