namespace ppe
{
    partial class AlimentationBddRalyeLecture
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
			this.lbRepertoireFichier = new System.Windows.Forms.Label();
			this.lbFichierInteger = new System.Windows.Forms.Label();
			this.lbAnneeScolaire = new System.Windows.Forms.Label();
			this.lbNiveau = new System.Windows.Forms.Label();
			this.lbMDP = new System.Windows.Forms.Label();
			this.tbAnneeScolaire = new System.Windows.Forms.TextBox();
			this.cbAleatoire = new System.Windows.Forms.CheckBox();
			this.cbConstruit = new System.Windows.Forms.CheckBox();
			this.btnLancerIntegration = new System.Windows.Forms.Button();
			this.cmbNiveau = new System.Windows.Forms.ComboBox();
			this.cmbRepertoireFichier = new System.Windows.Forms.ComboBox();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.clbFichierIntegrer = new System.Windows.Forms.CheckedListBox();
			this.SuspendLayout();
			// 
			// lbRepertoireFichier
			// 
			this.lbRepertoireFichier.AutoSize = true;
			this.lbRepertoireFichier.Location = new System.Drawing.Point(13, 29);
			this.lbRepertoireFichier.Name = "lbRepertoireFichier";
			this.lbRepertoireFichier.Size = new System.Drawing.Size(116, 13);
			this.lbRepertoireFichier.TabIndex = 0;
			this.lbRepertoireFichier.Text = "répertoire des fichiers : ";
			// 
			// lbFichierInteger
			// 
			this.lbFichierInteger.AutoSize = true;
			this.lbFichierInteger.Location = new System.Drawing.Point(18, 102);
			this.lbFichierInteger.Name = "lbFichierInteger";
			this.lbFichierInteger.Size = new System.Drawing.Size(111, 13);
			this.lbFichierInteger.TabIndex = 1;
			this.lbFichierInteger.Text = "fichier csv à intégrer : ";
			// 
			// lbAnneeScolaire
			// 
			this.lbAnneeScolaire.AutoSize = true;
			this.lbAnneeScolaire.Location = new System.Drawing.Point(18, 206);
			this.lbAnneeScolaire.Name = "lbAnneeScolaire";
			this.lbAnneeScolaire.Size = new System.Drawing.Size(85, 13);
			this.lbAnneeScolaire.TabIndex = 2;
			this.lbAnneeScolaire.Text = "année scolaire : ";
			// 
			// lbNiveau
			// 
			this.lbNiveau.AutoSize = true;
			this.lbNiveau.Location = new System.Drawing.Point(16, 257);
			this.lbNiveau.Name = "lbNiveau";
			this.lbNiveau.Size = new System.Drawing.Size(48, 13);
			this.lbNiveau.TabIndex = 3;
			this.lbNiveau.Text = "niveau : ";
			// 
			// lbMDP
			// 
			this.lbMDP.AutoSize = true;
			this.lbMDP.Location = new System.Drawing.Point(20, 305);
			this.lbMDP.Name = "lbMDP";
			this.lbMDP.Size = new System.Drawing.Size(79, 13);
			this.lbMDP.TabIndex = 4;
			this.lbMDP.Text = "mot de passe : ";
			// 
			// tbAnneeScolaire
			// 
			this.tbAnneeScolaire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbAnneeScolaire.Location = new System.Drawing.Point(150, 203);
			this.tbAnneeScolaire.Name = "tbAnneeScolaire";
			this.tbAnneeScolaire.Size = new System.Drawing.Size(127, 20);
			this.tbAnneeScolaire.TabIndex = 5;
			this.tbAnneeScolaire.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// cbAleatoire
			// 
			this.cbAleatoire.AutoSize = true;
			this.cbAleatoire.Location = new System.Drawing.Point(150, 305);
			this.cbAleatoire.Name = "cbAleatoire";
			this.cbAleatoire.Size = new System.Drawing.Size(66, 17);
			this.cbAleatoire.TabIndex = 6;
			this.cbAleatoire.Text = "aléatoire";
			this.cbAleatoire.UseVisualStyleBackColor = true;
			// 
			// cbConstruit
			// 
			this.cbConstruit.AutoSize = true;
			this.cbConstruit.Location = new System.Drawing.Point(236, 304);
			this.cbConstruit.Name = "cbConstruit";
			this.cbConstruit.Size = new System.Drawing.Size(66, 17);
			this.cbConstruit.TabIndex = 7;
			this.cbConstruit.Text = "construit";
			this.cbConstruit.UseVisualStyleBackColor = true;
			// 
			// btnLancerIntegration
			// 
			this.btnLancerIntegration.Location = new System.Drawing.Point(150, 351);
			this.btnLancerIntegration.Name = "btnLancerIntegration";
			this.btnLancerIntegration.Size = new System.Drawing.Size(136, 23);
			this.btnLancerIntegration.TabIndex = 8;
			this.btnLancerIntegration.Text = "Lancer l\'intégration ";
			this.btnLancerIntegration.UseVisualStyleBackColor = true;
			// 
			// cmbNiveau
			// 
			this.cmbNiveau.FormattingEnabled = true;
			this.cmbNiveau.Location = new System.Drawing.Point(150, 256);
			this.cmbNiveau.Name = "cmbNiveau";
			this.cmbNiveau.Size = new System.Drawing.Size(135, 21);
			this.cmbNiveau.TabIndex = 10;
			// 
			// cmbRepertoireFichier
			// 
			this.cmbRepertoireFichier.FormattingEnabled = true;
			this.cmbRepertoireFichier.Location = new System.Drawing.Point(150, 21);
			this.cmbRepertoireFichier.Name = "cmbRepertoireFichier";
			this.cmbRepertoireFichier.Size = new System.Drawing.Size(303, 21);
			this.cmbRepertoireFichier.TabIndex = 11;
			// 
			// clbFichierIntegrer
			// 
			this.clbFichierIntegrer.FormattingEnabled = true;
			this.clbFichierIntegrer.Location = new System.Drawing.Point(150, 102);
			this.clbFichierIntegrer.Name = "clbFichierIntegrer";
			this.clbFichierIntegrer.Size = new System.Drawing.Size(475, 64);
			this.clbFichierIntegrer.TabIndex = 12;
			// 
			// AlimentationBddRalyeLecture
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ClientSize = new System.Drawing.Size(637, 415);
			this.Controls.Add(this.clbFichierIntegrer);
			this.Controls.Add(this.cmbRepertoireFichier);
			this.Controls.Add(this.cmbNiveau);
			this.Controls.Add(this.btnLancerIntegration);
			this.Controls.Add(this.cbConstruit);
			this.Controls.Add(this.cbAleatoire);
			this.Controls.Add(this.tbAnneeScolaire);
			this.Controls.Add(this.lbMDP);
			this.Controls.Add(this.lbNiveau);
			this.Controls.Add(this.lbAnneeScolaire);
			this.Controls.Add(this.lbFichierInteger);
			this.Controls.Add(this.lbRepertoireFichier);
			this.Name = "AlimentationBddRalyeLecture";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRepertoireFichier;
        private System.Windows.Forms.Label lbFichierInteger;
        private System.Windows.Forms.Label lbAnneeScolaire;
        private System.Windows.Forms.Label lbNiveau;
        private System.Windows.Forms.Label lbMDP;
        private System.Windows.Forms.TextBox tbAnneeScolaire;
        private System.Windows.Forms.CheckBox cbAleatoire;
        private System.Windows.Forms.CheckBox cbConstruit;
        private System.Windows.Forms.Button btnLancerIntegration;
        private System.Windows.Forms.ComboBox cmbNiveau;
        private System.Windows.Forms.ComboBox cmbRepertoireFichier;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckedListBox clbFichierIntegrer;
    }
}

