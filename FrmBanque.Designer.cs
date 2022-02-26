using libBanque;

namespace AppWindoBanque
{
    partial class FrmBanque
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label25;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBanque));
            System.Windows.Forms.Label label24;
            System.Windows.Forms.Label label22;
            System.Windows.Forms.Label label27;
            System.Windows.Forms.Label label20;
            System.Windows.Forms.Label label19;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label label15;
            System.Windows.Forms.Label label14;
            System.Windows.Forms.Label label16;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label34;
            System.Windows.Forms.Label label33;
            System.Windows.Forms.Label label32;
            System.Windows.Forms.Label label31;
            System.Windows.Forms.Label label30;
            System.Windows.Forms.Label label29;
            System.Windows.Forms.Label label28;
            System.Windows.Forms.Label label23;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabVirement = new System.Windows.Forms.TabPage();
            this.cbx_vi_ChoixCompte_Debiteur = new System.Windows.Forms.ComboBox();
            this.cbx_vi_ChoixCompte_Crediteur = new System.Windows.Forms.ComboBox();
            this.btn_vi_Annuler = new System.Windows.Forms.Button();
            this.btn_vi_Enregistrer = new System.Windows.Forms.Button();
            this.lbl_vi_Message = new System.Windows.Forms.Label();
            this.tbx_vi_Montant_A_Virer = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.tabRetrait = new System.Windows.Forms.TabPage();
            this.cbx_re_ChoixCompte = new System.Windows.Forms.ComboBox();
            this.btn_re_Annuler = new System.Windows.Forms.Button();
            this.btn_re_Enregistrer = new System.Windows.Forms.Button();
            this.lbl_re_Message = new System.Windows.Forms.Label();
            this.tbx_re_Montant_A_Debiter = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tabVersement = new System.Windows.Forms.TabPage();
            this.cbx_ve_ChoixCompte = new System.Windows.Forms.ComboBox();
            this.btn_ve_Annuler = new System.Windows.Forms.Button();
            this.btn_ve_Enregistrer = new System.Windows.Forms.Button();
            this.lbl_ve_Message = new System.Windows.Forms.Label();
            this.tbx_ve_Montant_A_Crediter = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tabCreation = new System.Windows.Forms.TabPage();
            this.btn_cr_Annuler = new System.Windows.Forms.Button();
            this.btn_cr_Creer = new System.Windows.Forms.Button();
            this.lbl_cr_Message = new System.Windows.Forms.Label();
            this.tbx_cr_SoldeInitial = new System.Windows.Forms.TextBox();
            this.tbx_cr_Titulaire = new System.Windows.Forms.TextBox();
            this.tbx_cr_Numero = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabConsultation = new System.Windows.Forms.TabPage();
            this.tbx_co_SoldeActuel = new System.Windows.Forms.TextBox();
            this.tbx_co_Titulaire = new System.Windows.Forms.TextBox();
            this.tbx_co_Numero = new System.Windows.Forms.TextBox();
            this.cbb_co_ChoixCompte = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabAccueil = new System.Windows.Forms.TabPage();
            this.dgv_ListeComptes = new System.Windows.Forms.DataGridView();
            this.lbl_ac_Titre = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            label25 = new System.Windows.Forms.Label();
            label24 = new System.Windows.Forms.Label();
            label22 = new System.Windows.Forms.Label();
            label27 = new System.Windows.Forms.Label();
            label20 = new System.Windows.Forms.Label();
            label19 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label34 = new System.Windows.Forms.Label();
            label33 = new System.Windows.Forms.Label();
            label32 = new System.Windows.Forms.Label();
            label31 = new System.Windows.Forms.Label();
            label30 = new System.Windows.Forms.Label();
            label29 = new System.Windows.Forms.Label();
            label28 = new System.Windows.Forms.Label();
            label23 = new System.Windows.Forms.Label();
            this.tabVirement.SuspendLayout();
            this.tabRetrait.SuspendLayout();
            this.tabVersement.SuspendLayout();
            this.tabCreation.SuspendLayout();
            this.tabConsultation.SuspendLayout();
            this.tabAccueil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListeComptes)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // label25
            // 
            label25.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(label25, "label25");
            label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(131)))));
            label25.Name = "label25";
            // 
            // label24
            // 
            label24.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(label24, "label24");
            label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(131)))));
            label24.Name = "label24";
            // 
            // label22
            // 
            label22.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(label22, "label22");
            label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(131)))));
            label22.Name = "label22";
            // 
            // label27
            // 
            label27.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(label27, "label27");
            label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(131)))));
            label27.Name = "label27";
            // 
            // label20
            // 
            label20.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(label20, "label20");
            label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(131)))));
            label20.Name = "label20";
            // 
            // label19
            // 
            label19.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(label19, "label19");
            label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(131)))));
            label19.Name = "label19";
            // 
            // label13
            // 
            label13.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(label13, "label13");
            label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(131)))));
            label13.Name = "label13";
            // 
            // label15
            // 
            label15.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(label15, "label15");
            label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(131)))));
            label15.Name = "label15";
            // 
            // label14
            // 
            label14.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(label14, "label14");
            label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(131)))));
            label14.Name = "label14";
            // 
            // label16
            // 
            label16.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(label16, "label16");
            label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(131)))));
            label16.Name = "label16";
            // 
            // label10
            // 
            label10.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(label10, "label10");
            label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(131)))));
            label10.Name = "label10";
            // 
            // label9
            // 
            label9.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(label9, "label9");
            label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(131)))));
            label9.Name = "label9";
            // 
            // label8
            // 
            label8.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(label8, "label8");
            label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(131)))));
            label8.Name = "label8";
            // 
            // label11
            // 
            label11.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(label11, "label11");
            label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(131)))));
            label11.Name = "label11";
            // 
            // label3
            // 
            label3.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(131)))));
            label3.Name = "label3";
            // 
            // label4
            // 
            label4.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(label4, "label4");
            label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(131)))));
            label4.Name = "label4";
            // 
            // label5
            // 
            label5.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(label5, "label5");
            label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(131)))));
            label5.Name = "label5";
            // 
            // label6
            // 
            label6.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(label6, "label6");
            label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(131)))));
            label6.Name = "label6";
            // 
            // label7
            // 
            label7.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(label7, "label7");
            label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(131)))));
            label7.Name = "label7";
            // 
            // label2
            // 
            label2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(131)))));
            label2.Name = "label2";
            // 
            // label34
            // 
            label34.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(label34, "label34");
            label34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            label34.Name = "label34";
            // 
            // label33
            // 
            label33.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(label33, "label33");
            label33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(131)))));
            label33.Name = "label33";
            // 
            // label32
            // 
            label32.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(label32, "label32");
            label32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            label32.Name = "label32";
            // 
            // label31
            // 
            label31.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(label31, "label31");
            label31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            label31.Name = "label31";
            // 
            // label30
            // 
            label30.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(label30, "label30");
            label30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            label30.Name = "label30";
            // 
            // label29
            // 
            label29.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(label29, "label29");
            label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(131)))));
            label29.Name = "label29";
            // 
            // label28
            // 
            label28.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(label28, "label28");
            label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(131)))));
            label28.Name = "label28";
            // 
            // label23
            // 
            label23.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(label23, "label23");
            label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(131)))));
            label23.Name = "label23";
            // 
            // tabVirement
            // 
            this.tabVirement.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabVirement.Controls.Add(this.cbx_vi_ChoixCompte_Debiteur);
            this.tabVirement.Controls.Add(label27);
            this.tabVirement.Controls.Add(this.cbx_vi_ChoixCompte_Crediteur);
            this.tabVirement.Controls.Add(label22);
            this.tabVirement.Controls.Add(this.btn_vi_Annuler);
            this.tabVirement.Controls.Add(this.btn_vi_Enregistrer);
            this.tabVirement.Controls.Add(this.lbl_vi_Message);
            this.tabVirement.Controls.Add(label24);
            this.tabVirement.Controls.Add(this.tbx_vi_Montant_A_Virer);
            this.tabVirement.Controls.Add(label25);
            this.tabVirement.Controls.Add(this.label26);
            resources.ApplyResources(this.tabVirement, "tabVirement");
            this.tabVirement.Name = "tabVirement";
            this.tabVirement.Enter += new System.EventHandler(this.tabVirement_Enter);
            // 
            // cbx_vi_ChoixCompte_Debiteur
            // 
            resources.ApplyResources(this.cbx_vi_ChoixCompte_Debiteur, "cbx_vi_ChoixCompte_Debiteur");
            this.cbx_vi_ChoixCompte_Debiteur.FormattingEnabled = true;
            this.cbx_vi_ChoixCompte_Debiteur.Name = "cbx_vi_ChoixCompte_Debiteur";
            // 
            // cbx_vi_ChoixCompte_Crediteur
            // 
            resources.ApplyResources(this.cbx_vi_ChoixCompte_Crediteur, "cbx_vi_ChoixCompte_Crediteur");
            this.cbx_vi_ChoixCompte_Crediteur.FormattingEnabled = true;
            this.cbx_vi_ChoixCompte_Crediteur.Name = "cbx_vi_ChoixCompte_Crediteur";
            // 
            // btn_vi_Annuler
            // 
            this.btn_vi_Annuler.BackColor = System.Drawing.Color.Gray;
            this.btn_vi_Annuler.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_vi_Annuler, "btn_vi_Annuler");
            this.btn_vi_Annuler.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_vi_Annuler.Name = "btn_vi_Annuler";
            this.btn_vi_Annuler.UseVisualStyleBackColor = false;
            this.btn_vi_Annuler.Click += new System.EventHandler(this.btn_vi_Annuler_Click);
            // 
            // btn_vi_Enregistrer
            // 
            this.btn_vi_Enregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(131)))));
            this.btn_vi_Enregistrer.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_vi_Enregistrer, "btn_vi_Enregistrer");
            this.btn_vi_Enregistrer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_vi_Enregistrer.Name = "btn_vi_Enregistrer";
            this.btn_vi_Enregistrer.UseVisualStyleBackColor = false;
            this.btn_vi_Enregistrer.Click += new System.EventHandler(this.btn_vi_Enregistrer_Click);
            // 
            // lbl_vi_Message
            // 
            this.lbl_vi_Message.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lbl_vi_Message, "lbl_vi_Message");
            this.lbl_vi_Message.ForeColor = System.Drawing.Color.Red;
            this.lbl_vi_Message.Name = "lbl_vi_Message";
            // 
            // tbx_vi_Montant_A_Virer
            // 
            resources.ApplyResources(this.tbx_vi_Montant_A_Virer, "tbx_vi_Montant_A_Virer");
            this.tbx_vi_Montant_A_Virer.Name = "tbx_vi_Montant_A_Virer";
            // 
            // label26
            // 
            this.label26.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label26, "label26");
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(131)))));
            this.label26.Name = "label26";
            // 
            // tabRetrait
            // 
            this.tabRetrait.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabRetrait.Controls.Add(this.cbx_re_ChoixCompte);
            this.tabRetrait.Controls.Add(label13);
            this.tabRetrait.Controls.Add(this.btn_re_Annuler);
            this.tabRetrait.Controls.Add(this.btn_re_Enregistrer);
            this.tabRetrait.Controls.Add(this.lbl_re_Message);
            this.tabRetrait.Controls.Add(label19);
            this.tabRetrait.Controls.Add(this.tbx_re_Montant_A_Debiter);
            this.tabRetrait.Controls.Add(label20);
            this.tabRetrait.Controls.Add(this.label21);
            resources.ApplyResources(this.tabRetrait, "tabRetrait");
            this.tabRetrait.Name = "tabRetrait";
            this.tabRetrait.Enter += new System.EventHandler(this.tabRetrait_Enter);
            // 
            // cbx_re_ChoixCompte
            // 
            resources.ApplyResources(this.cbx_re_ChoixCompte, "cbx_re_ChoixCompte");
            this.cbx_re_ChoixCompte.FormattingEnabled = true;
            this.cbx_re_ChoixCompte.Name = "cbx_re_ChoixCompte";
            // 
            // btn_re_Annuler
            // 
            this.btn_re_Annuler.BackColor = System.Drawing.Color.Gray;
            this.btn_re_Annuler.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_re_Annuler, "btn_re_Annuler");
            this.btn_re_Annuler.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_re_Annuler.Name = "btn_re_Annuler";
            this.btn_re_Annuler.UseVisualStyleBackColor = false;
            this.btn_re_Annuler.Click += new System.EventHandler(this.btn_re_Annuler_Click);
            // 
            // btn_re_Enregistrer
            // 
            this.btn_re_Enregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(131)))));
            this.btn_re_Enregistrer.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_re_Enregistrer, "btn_re_Enregistrer");
            this.btn_re_Enregistrer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_re_Enregistrer.Name = "btn_re_Enregistrer";
            this.btn_re_Enregistrer.UseVisualStyleBackColor = false;
            this.btn_re_Enregistrer.Click += new System.EventHandler(this.btn_re_Enregistrer_Click);
            // 
            // lbl_re_Message
            // 
            this.lbl_re_Message.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lbl_re_Message, "lbl_re_Message");
            this.lbl_re_Message.ForeColor = System.Drawing.Color.Red;
            this.lbl_re_Message.Name = "lbl_re_Message";
            // 
            // tbx_re_Montant_A_Debiter
            // 
            resources.ApplyResources(this.tbx_re_Montant_A_Debiter, "tbx_re_Montant_A_Debiter");
            this.tbx_re_Montant_A_Debiter.Name = "tbx_re_Montant_A_Debiter";
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label21, "label21");
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(131)))));
            this.label21.Name = "label21";
            // 
            // tabVersement
            // 
            this.tabVersement.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabVersement.Controls.Add(this.cbx_ve_ChoixCompte);
            this.tabVersement.Controls.Add(label16);
            this.tabVersement.Controls.Add(this.btn_ve_Annuler);
            this.tabVersement.Controls.Add(this.btn_ve_Enregistrer);
            this.tabVersement.Controls.Add(this.lbl_ve_Message);
            this.tabVersement.Controls.Add(label14);
            this.tabVersement.Controls.Add(this.tbx_ve_Montant_A_Crediter);
            this.tabVersement.Controls.Add(label15);
            this.tabVersement.Controls.Add(this.label18);
            resources.ApplyResources(this.tabVersement, "tabVersement");
            this.tabVersement.Name = "tabVersement";
            this.tabVersement.Enter += new System.EventHandler(this.tabVersement_Enter);
            // 
            // cbx_ve_ChoixCompte
            // 
            resources.ApplyResources(this.cbx_ve_ChoixCompte, "cbx_ve_ChoixCompte");
            this.cbx_ve_ChoixCompte.FormattingEnabled = true;
            this.cbx_ve_ChoixCompte.Name = "cbx_ve_ChoixCompte";
            // 
            // btn_ve_Annuler
            // 
            this.btn_ve_Annuler.BackColor = System.Drawing.Color.Gray;
            this.btn_ve_Annuler.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_ve_Annuler, "btn_ve_Annuler");
            this.btn_ve_Annuler.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ve_Annuler.Name = "btn_ve_Annuler";
            this.btn_ve_Annuler.UseVisualStyleBackColor = false;
            this.btn_ve_Annuler.Click += new System.EventHandler(this.btn_ve_Annuler_Click);
            // 
            // btn_ve_Enregistrer
            // 
            this.btn_ve_Enregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(131)))));
            this.btn_ve_Enregistrer.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_ve_Enregistrer, "btn_ve_Enregistrer");
            this.btn_ve_Enregistrer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ve_Enregistrer.Name = "btn_ve_Enregistrer";
            this.btn_ve_Enregistrer.UseVisualStyleBackColor = false;
            this.btn_ve_Enregistrer.Click += new System.EventHandler(this.btn_ve_Enregistrer_Click);
            // 
            // lbl_ve_Message
            // 
            this.lbl_ve_Message.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lbl_ve_Message, "lbl_ve_Message");
            this.lbl_ve_Message.ForeColor = System.Drawing.Color.Red;
            this.lbl_ve_Message.Name = "lbl_ve_Message";
            // 
            // tbx_ve_Montant_A_Crediter
            // 
            resources.ApplyResources(this.tbx_ve_Montant_A_Crediter, "tbx_ve_Montant_A_Crediter");
            this.tbx_ve_Montant_A_Crediter.Name = "tbx_ve_Montant_A_Crediter";
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label18, "label18");
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(131)))));
            this.label18.Name = "label18";
            // 
            // tabCreation
            // 
            this.tabCreation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabCreation.Controls.Add(this.btn_cr_Annuler);
            this.tabCreation.Controls.Add(this.btn_cr_Creer);
            this.tabCreation.Controls.Add(this.lbl_cr_Message);
            this.tabCreation.Controls.Add(label11);
            this.tabCreation.Controls.Add(this.tbx_cr_SoldeInitial);
            this.tabCreation.Controls.Add(this.tbx_cr_Titulaire);
            this.tabCreation.Controls.Add(this.tbx_cr_Numero);
            this.tabCreation.Controls.Add(label8);
            this.tabCreation.Controls.Add(label9);
            this.tabCreation.Controls.Add(label10);
            this.tabCreation.Controls.Add(this.label12);
            resources.ApplyResources(this.tabCreation, "tabCreation");
            this.tabCreation.Name = "tabCreation";
            this.tabCreation.Enter += new System.EventHandler(this.tabCreation_Enter);
            // 
            // btn_cr_Annuler
            // 
            this.btn_cr_Annuler.BackColor = System.Drawing.Color.Gray;
            this.btn_cr_Annuler.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_cr_Annuler, "btn_cr_Annuler");
            this.btn_cr_Annuler.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_cr_Annuler.Name = "btn_cr_Annuler";
            this.btn_cr_Annuler.UseVisualStyleBackColor = false;
            this.btn_cr_Annuler.Click += new System.EventHandler(this.btn_cr_Annuler_Click);
            // 
            // btn_cr_Creer
            // 
            this.btn_cr_Creer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(131)))));
            this.btn_cr_Creer.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_cr_Creer, "btn_cr_Creer");
            this.btn_cr_Creer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_cr_Creer.Name = "btn_cr_Creer";
            this.btn_cr_Creer.UseVisualStyleBackColor = false;
            this.btn_cr_Creer.Click += new System.EventHandler(this.btn_cr_Creer_Click);
            // 
            // lbl_cr_Message
            // 
            this.lbl_cr_Message.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lbl_cr_Message, "lbl_cr_Message");
            this.lbl_cr_Message.ForeColor = System.Drawing.Color.Red;
            this.lbl_cr_Message.Name = "lbl_cr_Message";
            this.lbl_cr_Message.Enter += new System.EventHandler(this.tabCreation_Enter);
            // 
            // tbx_cr_SoldeInitial
            // 
            resources.ApplyResources(this.tbx_cr_SoldeInitial, "tbx_cr_SoldeInitial");
            this.tbx_cr_SoldeInitial.Name = "tbx_cr_SoldeInitial";
            // 
            // tbx_cr_Titulaire
            // 
            resources.ApplyResources(this.tbx_cr_Titulaire, "tbx_cr_Titulaire");
            this.tbx_cr_Titulaire.Name = "tbx_cr_Titulaire";
            // 
            // tbx_cr_Numero
            // 
            resources.ApplyResources(this.tbx_cr_Numero, "tbx_cr_Numero");
            this.tbx_cr_Numero.Name = "tbx_cr_Numero";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label12, "label12");
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(131)))));
            this.label12.Name = "label12";
            // 
            // tabConsultation
            // 
            this.tabConsultation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabConsultation.Controls.Add(label7);
            this.tabConsultation.Controls.Add(this.tbx_co_SoldeActuel);
            this.tabConsultation.Controls.Add(this.tbx_co_Titulaire);
            this.tabConsultation.Controls.Add(this.tbx_co_Numero);
            this.tabConsultation.Controls.Add(this.cbb_co_ChoixCompte);
            this.tabConsultation.Controls.Add(label6);
            this.tabConsultation.Controls.Add(label5);
            this.tabConsultation.Controls.Add(label4);
            this.tabConsultation.Controls.Add(label3);
            this.tabConsultation.Controls.Add(this.label1);
            resources.ApplyResources(this.tabConsultation, "tabConsultation");
            this.tabConsultation.Name = "tabConsultation";
            this.tabConsultation.Enter += new System.EventHandler(this.tabConsultation_Enter);
            // 
            // tbx_co_SoldeActuel
            // 
            resources.ApplyResources(this.tbx_co_SoldeActuel, "tbx_co_SoldeActuel");
            this.tbx_co_SoldeActuel.Name = "tbx_co_SoldeActuel";
            this.tbx_co_SoldeActuel.ReadOnly = true;
            // 
            // tbx_co_Titulaire
            // 
            resources.ApplyResources(this.tbx_co_Titulaire, "tbx_co_Titulaire");
            this.tbx_co_Titulaire.Name = "tbx_co_Titulaire";
            this.tbx_co_Titulaire.ReadOnly = true;
            // 
            // tbx_co_Numero
            // 
            resources.ApplyResources(this.tbx_co_Numero, "tbx_co_Numero");
            this.tbx_co_Numero.Name = "tbx_co_Numero";
            this.tbx_co_Numero.ReadOnly = true;
            // 
            // cbb_co_ChoixCompte
            // 
            resources.ApplyResources(this.cbb_co_ChoixCompte, "cbb_co_ChoixCompte");
            this.cbb_co_ChoixCompte.FormattingEnabled = true;
            this.cbb_co_ChoixCompte.Name = "cbb_co_ChoixCompte";
            this.cbb_co_ChoixCompte.SelectedIndexChanged += new System.EventHandler(this.cbb_co_ChoixCompte_SelectedIndexChanged);
            this.cbb_co_ChoixCompte.Enter += new System.EventHandler(this.tabConsultation_Enter);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(131)))));
            this.label1.Name = "label1";
            // 
            // tabAccueil
            // 
            this.tabAccueil.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabAccueil.Controls.Add(this.dgv_ListeComptes);
            this.tabAccueil.Controls.Add(label2);
            this.tabAccueil.Controls.Add(this.lbl_ac_Titre);
            resources.ApplyResources(this.tabAccueil, "tabAccueil");
            this.tabAccueil.Name = "tabAccueil";
            this.tabAccueil.Enter += new System.EventHandler(this.tabAccueil_Enter);
            // 
            // dgv_ListeComptes
            // 
            this.dgv_ListeComptes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(131)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(131)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(131)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ListeComptes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ListeComptes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgv_ListeComptes, "dgv_ListeComptes");
            this.dgv_ListeComptes.Name = "dgv_ListeComptes";
            this.dgv_ListeComptes.ReadOnly = true;
            this.dgv_ListeComptes.RowTemplate.Height = 25;
            // 
            // lbl_ac_Titre
            // 
            this.lbl_ac_Titre.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lbl_ac_Titre, "lbl_ac_Titre");
            this.lbl_ac_Titre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(131)))));
            this.lbl_ac_Titre.Name = "lbl_ac_Titre";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAccueil);
            this.tabControl1.Controls.Add(this.tabConsultation);
            this.tabControl1.Controls.Add(this.tabCreation);
            this.tabControl1.Controls.Add(this.tabVersement);
            this.tabControl1.Controls.Add(this.tabRetrait);
            this.tabControl1.Controls.Add(this.tabVirement);
            this.tabControl1.Controls.Add(this.tabAbout);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabAbout
            // 
            this.tabAbout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabAbout.Controls.Add(label34);
            this.tabAbout.Controls.Add(label33);
            this.tabAbout.Controls.Add(label32);
            this.tabAbout.Controls.Add(label31);
            this.tabAbout.Controls.Add(label30);
            this.tabAbout.Controls.Add(label29);
            this.tabAbout.Controls.Add(label28);
            this.tabAbout.Controls.Add(label23);
            this.tabAbout.Controls.Add(this.label17);
            resources.ApplyResources(this.tabAbout, "tabAbout");
            this.tabAbout.Name = "tabAbout";
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label17, "label17");
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(131)))));
            this.label17.Name = "label17";
            // 
            // FrmBanque
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(131)))));
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBanque";
            this.tabVirement.ResumeLayout(false);
            this.tabVirement.PerformLayout();
            this.tabRetrait.ResumeLayout(false);
            this.tabRetrait.PerformLayout();
            this.tabVersement.ResumeLayout(false);
            this.tabVersement.PerformLayout();
            this.tabCreation.ResumeLayout(false);
            this.tabCreation.PerformLayout();
            this.tabConsultation.ResumeLayout(false);
            this.tabConsultation.PerformLayout();
            this.tabAccueil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListeComptes)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabAbout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabVirement;
        private System.Windows.Forms.ComboBox cbx_vi_ChoixCompte_Debiteur;
        private System.Windows.Forms.ComboBox cbx_vi_ChoixCompte_Crediteur;
        private System.Windows.Forms.Button btn_vi_Annuler;
        private System.Windows.Forms.Button btn_vi_Enregistrer;
        private System.Windows.Forms.Label lbl_vi_Message;
        private System.Windows.Forms.TextBox tbx_vi_Montant_A_Virer;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TabPage tabRetrait;
        private System.Windows.Forms.ComboBox cbx_re_ChoixCompte;
        private System.Windows.Forms.Button btn_re_Annuler;
        private System.Windows.Forms.Button btn_re_Enregistrer;
        private System.Windows.Forms.Label lbl_re_Message;
        private System.Windows.Forms.TextBox tbx_re_Montant_A_Debiter;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TabPage tabVersement;
        private System.Windows.Forms.ComboBox cbx_ve_ChoixCompte;
        private System.Windows.Forms.Button btn_ve_Annuler;
        private System.Windows.Forms.Button btn_ve_Enregistrer;
        private System.Windows.Forms.Label lbl_ve_Message;
        private System.Windows.Forms.TextBox tbx_ve_Montant_A_Crediter;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TabPage tabCreation;
        private System.Windows.Forms.Button btn_cr_Annuler;
        private System.Windows.Forms.Button btn_cr_Creer;
        private System.Windows.Forms.Label lbl_cr_Message;
        private System.Windows.Forms.TextBox tbx_cr_SoldeInitial;
        private System.Windows.Forms.TextBox tbx_cr_Titulaire;
        private System.Windows.Forms.TextBox tbx_cr_Numero;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabConsultation;
        private System.Windows.Forms.TextBox tbx_co_SoldeActuel;
        private System.Windows.Forms.TextBox tbx_co_Titulaire;
        private System.Windows.Forms.TextBox tbx_co_Numero;
        private System.Windows.Forms.ComboBox cbb_co_ChoixCompte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabAccueil;
        private System.Windows.Forms.DataGridView dgv_ListeComptes;
        private System.Windows.Forms.Label lbl_ac_Titre;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.Label label17;
    }
}