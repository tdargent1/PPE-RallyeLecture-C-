using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ppe
{
	public partial class pageConnection : Form
	{
		private AlimentationBddRalyeLecture page2;
		public pageConnection()
		{
			InitializeComponent();
			ConnexionMySql.Connexion("root", "siojjr", "rallyeLecture", "172.16.0.173");
			MySqlConnection cnx = ConnexionMySql.GetConnexion;
			btnConnection.Click += new EventHandler(BtnConnection_Click);
		}

		private void BtnConnection_Click(object sender, EventArgs e)
		{
			TableEnseignant tEnseignant = new TableEnseignant();
			Enseignant enseignant = tEnseignant.ChargerUnEnseignant(tbLogin.Text, tbPassWord.Text);
			if (enseignant != null)
			{
				MessageBox.Show("connection réussi");
				// je donne en paramétre l'enseignant connecté
				page2 = new AlimentationBddRalyeLecture(enseignant.Id,enseignant.Nom,enseignant.Prenom,enseignant.Login,enseignant.HashPassWord);
				page2.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("connection impossible");
			}
		}
	}
}
