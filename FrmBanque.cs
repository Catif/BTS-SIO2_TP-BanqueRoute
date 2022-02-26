using libBanque;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppWindoBanque
{
    public partial class FrmBanque : Form
    {
        
        // Variables globales au formulaire = Propriétés du formulaire
        private AgenceBancaire MonAgence;

        public FrmBanque()
        {
            InitializeComponent();
            InitialiserLaBanque();
        }

        private void InitialiserLaBanque()
        {
            // Instanciation de l'objet MonAgence, en passant en paramètre le nom de l'agence
            MonAgence = new AgenceBancaire("Meta");
            // Modifiction du titre de l'onglet
            lbl_ac_Titre.Text = "AGENCE de " + MonAgence.NomAgence;

            // Appel d'un sous-programme généant le jeu d'essai, autrement dit créant les comptes de l'agence
            GenererJeuDessai();

            // Appel d'un sous-programme remplissant le DataGridView avec la liste des comptes de l'agence
            //RemplirListeComptes();
        }

        #region === Entrée sur les différents onglets ===
            private void tabAccueil_Enter(object sender, EventArgs e)
            {
                RemplirListeComptes();
            }

            private void tabConsultation_Enter(object sender, EventArgs e)
            {
                RemplirCombobox(cbb_co_ChoixCompte);
                NettoyerOnglet(tabConsultation);
            }

            private void tabCreation_Enter(object sender, EventArgs e)
            {
                NettoyerOnglet(tabCreation);
            }

            private void tabVersement_Enter(object sender, EventArgs e)
            {
                RemplirCombobox(cbx_ve_ChoixCompte);
                NettoyerOnglet(tabVersement);
            }

            private void tabRetrait_Enter(object sender, EventArgs e)
            {
                RemplirCombobox(cbx_re_ChoixCompte);
                NettoyerOnglet(tabRetrait);
            }

            private void tabVirement_Enter(object sender, EventArgs e)
            {
                RemplirCombobox(cbx_vi_ChoixCompte_Debiteur);
                RemplirCombobox(cbx_vi_ChoixCompte_Crediteur);
                NettoyerOnglet(tabVirement);
            }
        #endregion

        #region === Boutons Enregistrement ===
            private void btn_ve_Enregistrer_Click(object sender, EventArgs e)
        {
            string message = "Le versement a bien été enregistré !"; // On part du principe que c'est ok
            int iCompte = cbx_ve_ChoixCompte.SelectedIndex;
            CompteBancaire leCompte;
            // On récupère le montant en vérifiant qu'il est correct
            decimal montant = RecupererMontant(tbx_ve_Montant_A_Crediter);

            // On verifie d'abord si un compte a bien été sélectionné
            if (iCompte >= 0)
            {
                // Si le montant est positif
                if (montant > 0)
                {
                    // On tente d'effectuer le versement
                    leCompte = MonAgence.LesComptes.ElementAt(iCompte);

                    if (!leCompte.CrediterCompte(montant)) // Si l'opération de crédit s'est mal passée
                                                           // On signale une erreur;
                        message = "Le virement n'a pu s'effectuer pour cause de montant incorrect.";
                    // Rappel : on sait que CrediterCompte renvoie faux si le montant est négatif ce qui ne devrait
                    // pas se produire puisqu'on l'a testé avant. Mieux vaut deux protections qu'une seule 
                }
                else
                {
                    message = "Le montant est trop petit ou est incorrect !";
                }
            }
            else
            {
                message = "Le virement n'a pas pu être effectué parce que vous n'avez pas sélectionné le compte à créditer !";
            }
            // On affiche le résultat
            lbl_ve_Message.Text = message;
            if (message == "Le versement a bien été enregistré !")
                lbl_ve_Message.ForeColor = Color.Green;
            else
                lbl_ve_Message.ForeColor = Color.Red;
        }

            private void btn_re_Enregistrer_Click(object sender, EventArgs e)
            {
                string message = "Le retrait a bien été enregistré !"; // On part du principe que c'est ok
                int iCompte = cbx_re_ChoixCompte.SelectedIndex;
                CompteBancaire leCompte;
                // On récupère le montant en vérifiant qu'il est correct
                decimal montant = RecupererMontant(tbx_re_Montant_A_Debiter);

                // On verifie d'abord si un compte a bien été sélectionné
                if (iCompte >= 0)
                {
                    // Si le montant est positif
                    if (montant > 0)
                    {
                        // On tente d'effectuer le versement
                        leCompte = MonAgence.LesComptes.ElementAt(iCompte);

                        if (leCompte.SoldeCompte < montant)
                        {
                            message = "Le retrait n'a pu s'effectuer pour cause de montant supérieur au solde du compte.";
                        }
                        else
                        {
                            if (!leCompte.DebiterCompte(montant)) // Si l'opération de débit s'est mal passée
                                                                  // On signale une erreur;
                                message = "Le retrait n'a pu s'effectuer pour cause de montant incorrect.";
                            // Rappel : on sait que CrediterCompte renvoie faux si le montant est négatif ce qui ne devrait
                            // pas se produire puisqu'on l'a testé avant. Mieux vaut deux protections qu'une seule
                        }
                    }
                    else
                    {
                        message = "Le montant est trop petit ou est incorrect !";
                    }
                }
                else
                {
                    message = "Le retrait n'a pas pu être effectué parce que vous n'avez pas sélectionné le compte à créditer !";
                }
                // On affiche le résultat
                lbl_re_Message.Text = message;
                if (message == "Le retrait a bien été enregistré !")
                    lbl_re_Message.ForeColor = Color.Green;
                else
                    lbl_re_Message.ForeColor = Color.Red;
            }

            private void btn_vi_Enregistrer_Click(object sender, EventArgs e)
            {
                string message = "Le versement a bien été enregistré !"; // On part du principe que c'est ok
                int iCompteD = cbx_vi_ChoixCompte_Debiteur.SelectedIndex;
                int iCompteC = cbx_vi_ChoixCompte_Crediteur.SelectedIndex;
                CompteBancaire leCompteD;
                CompteBancaire leCompteC;
                // On récupère le montant en vérifiant qu'il est correct
                decimal montant = RecupererMontant(tbx_vi_Montant_A_Virer);

                // On verifie d'abord si un compte a bien été sélectionné
                if (iCompteD >= 0 && iCompteD >= 0)
                {
                    if (iCompteD != iCompteC)
                    {
                        // Si le montant est positif
                        if (montant > 0)
                        {
                            // On tente d'effectuer le versement
                            leCompteD = MonAgence.LesComptes.ElementAt(iCompteD);
                            leCompteC = MonAgence.LesComptes.ElementAt(iCompteC);

                            if (leCompteD.SoldeCompte < montant)
                                message = "Le versement n'a pu s'effectuer pour cause de montant supérieur au solde du compte.";
                            else
                            {
                                if (!leCompteD.DebiterCompte(montant)) // Si l'opération de débit s'est mal passée
                                    message = "Le retrait n'a pu s'effectuer pour cause de montant incorrect.";
                                else
                                {
                                    if (!leCompteC.CrediterCompte(montant))
                                        message = "Le versement n'a pu s'effectuer pour cause de montant incorrect.";
                                }
                            }
                        }
                        else
                        {
                            message = "Le montant est trop petit ou est incorrect !";
                        }
                    }
                    else
                    {
                        message = "Le versement n'a pas pu être effectué pour cause que vous avez sélectionné deux fois la même personne.";
                    }
                }
                else
                {
                    message = "Le retrait n'a pas pu être effectué parce que vous n'avez pas sélectionné le compte à créditer !";
                }
                // On affiche le résultat
                lbl_vi_Message.Text = message;
                if (message == "Le versement a bien été enregistré !")
                    lbl_vi_Message.ForeColor = Color.Green;
                else
                    lbl_vi_Message.ForeColor = Color.Red;
            }
        #endregion

        #region === Bouton Annuler ===
            private void btn_cr_Annuler_Click(object sender, EventArgs e)
            {
                NettoyerOnglet(tabCreation);
            }

            private void btn_ve_Annuler_Click(object sender, EventArgs e)
                {
                    NettoyerOnglet(tabVersement);
                }

                private void btn_re_Annuler_Click(object sender, EventArgs e)
                {
                    NettoyerOnglet(tabRetrait);
                }

            private void btn_vi_Annuler_Click(object sender, EventArgs e)
                {
                    NettoyerOnglet(tabVirement);
                }
        #endregion

        private void RemplirListeComptes()
        {
            // Pour forcer le rafraichissement en cas de retour sur l'onglet d'accueil
            // on change le DataSource du DataGridView en commençant par dire de DataSource
            dgv_ListeComptes.DataSource = null;

            // On indique tout simplement que la source de données de la DataGridView est une collection
            // -> La dataGridView contiendra autant de lignes que la collection conteint d'objets
            // -> La DataGridView conteindra autant de colonnes que le type d'objet contient de property
            dgv_ListeComptes.DataSource = MonAgence.LesComptes;
            // On peut éventuellement adapter la mise en forme, ici en redimentionnant automatiquement
            // la largeur des colonnes
            dgv_ListeComptes.AutoResizeColumns();
        }

        private void GenererJeuDessai()
        {
            CompteBancaire cbPatrick = new CompteBancaire("0211651079JP", "M. JANE Patrick");
            CompteBancaire cbTeresa = new CompteBancaire("1231212312LT", "Mle LISBON Teresa", 1500.00m);
            CompteBancaire cbCho = new CompteBancaire("9173826431KC", "M. KIMBALL Cho", 5050.00m);

            MonAgence.AjouterCompte(cbPatrick);
            MonAgence.AjouterCompte(cbTeresa);
            MonAgence.AjouterCompte(cbCho);
        }

        

        

        // Choix d'un compte dans l'onglet de Consultation
        private void cbb_co_ChoixCompte_SelectedIndexChanged(object sender, EventArgs e)
        {
            // On récupère l'indice (ou index) du compte sélectionné
            int iCompte = cbb_co_ChoixCompte.SelectedIndex;
            CompteBancaire leCompte;    // Déclaration d'un ovjet CompteBancaire

            if (iCompte >= 0)    // Si on a bien sélectionné un compte
            {
                // On récupère dans la collection lesComptes de MonAgence le compte qui nous intéresse,
                // lequel compte est situé dans la collection à l'indice iCompte
                leCompte = MonAgence.LesComptes.ElementAt(iCompte);
                // Une fois l'objet CompteBancairre qui nous intéresse récupéré,
                // on affiche la valeur de ses propriétés dans les TextBox
                tbx_co_Numero.Text = leCompte.NumCompte.ToString();
                tbx_co_Titulaire.Text = leCompte.NomTitulaire;
                tbx_co_SoldeActuel.Text = leCompte.SoldeCompte.ToString();
            }
        }

        private void btn_cr_Creer_Click(object sender, EventArgs e)
        {
            // Récupération des valeurs des textbox
            string numero = tbx_cr_Numero.Text;
            string titulaire = tbx_cr_Titulaire.Text;
            string soldeString = tbx_cr_SoldeInitial.Text;
            decimal soldeDecimal;
            if(soldeString != "" && titulaire != "" && numero != "")
            {
                if (Decimal.TryParse(soldeString, out soldeDecimal)) // Si la conversion est possible...
                {
                    // ... je peux utiliser le paramètre en sortie soldeDecimal qui est un decimal
                    CompteBancaire cb = new CompteBancaire(numero, titulaire, soldeDecimal);
                    // On ajoute ce nouveau compte à l'agence
                    MonAgence.AjouterCompte(cb);

                    NettoyerOnglet(tabCreation);

                    // J'affiche un message de confirmation
                    lbl_cr_Message.Text = "Le compte de " + titulaire + " a bien été créé !";
                    lbl_cr_Message.ForeColor = Color.Green;
                }
                else
                {
                    // J'affiche un message d'erreur
                    lbl_cr_Message.Text = "Valeur incorrecte pour le solde initial !";
                    lbl_cr_Message.ForeColor = Color.Red;
                }
            }
            else
            {
                lbl_cr_Message.Text = "Tous les champs ne sont pas rempli !";
                lbl_cr_Message.ForeColor = Color.Red;
            }
        }









        private decimal RecupererMontant(TextBox leTextBox)
        {
            decimal montant;

            try      // On essaie la conversion ...
            {
                montant = decimal.Parse(leTextBox.Text);
            }
            catch     // ... si elle ne fonctionne pas on affecet -1 comme valeur erronée
            {
                montant = -1.0m;
            }

            // Retour de la valeur
            return (montant);
        }


        /// <summary>
        /// Sous-programme permettant de remplir une combobox avec la liste des comptes
        /// </summary>
        /// <param name="laCombo">La ComboBox à remplir</param>
        private void RemplirCombobox(ComboBox laCombo)
        {
            // Supprimer le contenu actuel éventuel de la combobox
            laCombo.Items.Clear();
            // Remplir la combobox à l'aide de la structure itérative foreach
            // -> cette structure peremt de parcourir facelement une collection
            // -> un foreach suivi d'une double tabulation génère automatique le squelette de la structure
            // POUR CHAQUE objet de type CompteBancaire, que nous appellerons "unCompte"
            // DANS la collection MonAgence.LesComptes ...
            foreach (CompteBancaire unCompte in MonAgence.LesComptes)
            {
                // ... Ajouter le numéro du compte suivi du titulaire dans les items de la combobox
                laCombo.Items.Add(unCompte.NumCompte + " (" + unCompte.NomTitulaire + ")");
                // NB : Items est une propriété de la combobox certes, mais c'est aussi une collection
                //      En faite une collection d'items (ou lignes)
            }
        }

        /// <summary>
        /// Supprime toutes les informations de l'onglet en paramètre
        /// </summary>
        /// <param name="unOnglet"></param>
        private void NettoyerOnglet(TabPage unOnglet)
        {
            switch (unOnglet.Name)
            {
                case "tabCreation":
                    cbb_co_ChoixCompte.Text = "";
                    tbx_cr_Numero.Text = ""; tbx_cr_SoldeInitial.Text = "";
                    tbx_cr_Titulaire.Text = ""; lbl_cr_Message.Text = "";
                    break;
                case "tabConsultation":
                    tbx_co_Numero.Text = ""; tbx_co_SoldeActuel.Text = "";
                    tbx_co_Titulaire.Text = ""; tbx_co_Numero.Text = "";
                    break;
                case "tabVersement":
                    cbx_ve_ChoixCompte.Text = ""; tbx_ve_Montant_A_Crediter.Text = "";
                    lbl_ve_Message.Text = "";
                    break;
                case "tabRetrait":
                    cbx_re_ChoixCompte.Text = ""; tbx_re_Montant_A_Debiter.Text = "";
                    lbl_re_Message.Text = "";
                    break;
                case "tabVirement":
                    cbx_vi_ChoixCompte_Crediteur.Text = ""; cbx_vi_ChoixCompte_Debiteur.Text = "";
                    tbx_vi_Montant_A_Virer.Text = "";
                    lbl_vi_Message.Text = "";
                    break;
            }
        }
    }
}
