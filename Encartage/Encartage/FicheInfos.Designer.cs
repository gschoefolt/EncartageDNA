namespace Encartage
{
    partial class FicheInfos
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FicheInfos));
            this.btnResetInfos = new System.Windows.Forms.Button();
            this.btnResetTitre = new System.Windows.Forms.Button();
            this.pnlTopUC = new System.Windows.Forms.Panel();
            this.lblFicheSaisie = new System.Windows.Forms.Label();
            this.rdbEditPart = new System.Windows.Forms.RadioButton();
            this.rdbEditComplet = new System.Windows.Forms.RadioButton();
            this.grpSaisieEncart = new System.Windows.Forms.GroupBox();
            this.pcbAttPoids = new System.Windows.Forms.PictureBox();
            this.pcbAttInit = new System.Windows.Forms.PictureBox();
            this.pcbAttType = new System.Windows.Forms.PictureBox();
            this.pcbAttTitle = new System.Windows.Forms.PictureBox();
            this.pcbAttDate = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPoids = new System.Windows.Forms.TextBox();
            this.txtNomEncart = new System.Windows.Forms.TextBox();
            this.lblTitreEncart = new System.Windows.Forms.Label();
            this.lblPoids = new System.Windows.Forms.Label();
            this.txtDateFin = new System.Windows.Forms.TextBox();
            this.lblAu = new System.Windows.Forms.Label();
            this.txtDateDebut = new System.Windows.Forms.TextBox();
            this.lblEncartageNuit = new System.Windows.Forms.Label();
            this.txtInitiales = new System.Windows.Forms.TextBox();
            this.lblInitiales = new System.Windows.Forms.Label();
            this.grpChoixTitre = new System.Windows.Forms.GroupBox();
            this.pcbAttTitre = new System.Windows.Forms.PictureBox();
            this.rdbAls = new System.Windows.Forms.RadioButton();
            this.rdbDna = new System.Windows.Forms.RadioButton();
            this.lblChoixTitre = new System.Windows.Forms.Label();
            this.btnMoins = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.pnlTopUC.SuspendLayout();
            this.grpSaisieEncart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAttPoids)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAttInit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAttType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAttTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAttDate)).BeginInit();
            this.grpChoixTitre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAttTitre)).BeginInit();
            this.SuspendLayout();
            // 
            // btnResetInfos
            // 
            this.btnResetInfos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetInfos.Location = new System.Drawing.Point(794, 198);
            this.btnResetInfos.Name = "btnResetInfos";
            this.btnResetInfos.Size = new System.Drawing.Size(89, 30);
            this.btnResetInfos.TabIndex = 17;
            this.btnResetInfos.Text = "Reset";
            this.btnResetInfos.UseVisualStyleBackColor = true;
            this.btnResetInfos.Click += new System.EventHandler(this.btnResetInfos_Click);
            // 
            // btnResetTitre
            // 
            this.btnResetTitre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetTitre.Location = new System.Drawing.Point(794, 64);
            this.btnResetTitre.Name = "btnResetTitre";
            this.btnResetTitre.Size = new System.Drawing.Size(89, 30);
            this.btnResetTitre.TabIndex = 16;
            this.btnResetTitre.Text = "Reset";
            this.btnResetTitre.UseVisualStyleBackColor = true;
            this.btnResetTitre.Click += new System.EventHandler(this.btnResetTitre_Click);
            // 
            // pnlTopUC
            // 
            this.pnlTopUC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlTopUC.Controls.Add(this.lblFicheSaisie);
            this.pnlTopUC.Location = new System.Drawing.Point(0, 0);
            this.pnlTopUC.Name = "pnlTopUC";
            this.pnlTopUC.Size = new System.Drawing.Size(966, 60);
            this.pnlTopUC.TabIndex = 15;
            // 
            // lblFicheSaisie
            // 
            this.lblFicheSaisie.AutoSize = true;
            this.lblFicheSaisie.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFicheSaisie.ForeColor = System.Drawing.Color.White;
            this.lblFicheSaisie.Location = new System.Drawing.Point(375, 15);
            this.lblFicheSaisie.Name = "lblFicheSaisie";
            this.lblFicheSaisie.Size = new System.Drawing.Size(216, 29);
            this.lblFicheSaisie.TabIndex = 0;
            this.lblFicheSaisie.Text = "Fiche information";
            // 
            // rdbEditPart
            // 
            this.rdbEditPart.AutoSize = true;
            this.rdbEditPart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbEditPart.Location = new System.Drawing.Point(425, 283);
            this.rdbEditPart.Name = "rdbEditPart";
            this.rdbEditPart.Size = new System.Drawing.Size(157, 26);
            this.rdbEditPart.TabIndex = 12;
            this.rdbEditPart.TabStop = true;
            this.rdbEditPart.Text = "Édition partielle";
            this.rdbEditPart.UseVisualStyleBackColor = true;
            // 
            // rdbEditComplet
            // 
            this.rdbEditComplet.AutoSize = true;
            this.rdbEditComplet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbEditComplet.Location = new System.Drawing.Point(225, 283);
            this.rdbEditComplet.Name = "rdbEditComplet";
            this.rdbEditComplet.Size = new System.Drawing.Size(170, 26);
            this.rdbEditComplet.TabIndex = 11;
            this.rdbEditComplet.TabStop = true;
            this.rdbEditComplet.Text = "Édition complète";
            this.rdbEditComplet.UseVisualStyleBackColor = true;
            // 
            // grpSaisieEncart
            // 
            this.grpSaisieEncart.Controls.Add(this.btnMoins);
            this.grpSaisieEncart.Controls.Add(this.btnPlus);
            this.grpSaisieEncart.Controls.Add(this.pcbAttPoids);
            this.grpSaisieEncart.Controls.Add(this.pcbAttInit);
            this.grpSaisieEncart.Controls.Add(this.pcbAttType);
            this.grpSaisieEncart.Controls.Add(this.pcbAttTitle);
            this.grpSaisieEncart.Controls.Add(this.pcbAttDate);
            this.grpSaisieEncart.Controls.Add(this.rdbEditPart);
            this.grpSaisieEncart.Controls.Add(this.rdbEditComplet);
            this.grpSaisieEncart.Controls.Add(this.label1);
            this.grpSaisieEncart.Controls.Add(this.txtPoids);
            this.grpSaisieEncart.Controls.Add(this.txtNomEncart);
            this.grpSaisieEncart.Controls.Add(this.lblTitreEncart);
            this.grpSaisieEncart.Controls.Add(this.lblPoids);
            this.grpSaisieEncart.Controls.Add(this.txtDateFin);
            this.grpSaisieEncart.Controls.Add(this.lblAu);
            this.grpSaisieEncart.Controls.Add(this.txtDateDebut);
            this.grpSaisieEncart.Controls.Add(this.lblEncartageNuit);
            this.grpSaisieEncart.Controls.Add(this.txtInitiales);
            this.grpSaisieEncart.Controls.Add(this.lblInitiales);
            this.grpSaisieEncart.Location = new System.Drawing.Point(83, 220);
            this.grpSaisieEncart.Name = "grpSaisieEncart";
            this.grpSaisieEncart.Size = new System.Drawing.Size(800, 330);
            this.grpSaisieEncart.TabIndex = 14;
            this.grpSaisieEncart.TabStop = false;
            this.grpSaisieEncart.Text = "Fiche saisie encart";
            // 
            // pcbAttPoids
            // 
            this.pcbAttPoids.Image = ((System.Drawing.Image)(resources.GetObject("pcbAttPoids.Image")));
            this.pcbAttPoids.Location = new System.Drawing.Point(15, 210);
            this.pcbAttPoids.Name = "pcbAttPoids";
            this.pcbAttPoids.Size = new System.Drawing.Size(50, 50);
            this.pcbAttPoids.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAttPoids.TabIndex = 18;
            this.pcbAttPoids.TabStop = false;
            // 
            // pcbAttInit
            // 
            this.pcbAttInit.Image = ((System.Drawing.Image)(resources.GetObject("pcbAttInit.Image")));
            this.pcbAttInit.Location = new System.Drawing.Point(15, 30);
            this.pcbAttInit.Name = "pcbAttInit";
            this.pcbAttInit.Size = new System.Drawing.Size(50, 50);
            this.pcbAttInit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAttInit.TabIndex = 17;
            this.pcbAttInit.TabStop = false;
            // 
            // pcbAttType
            // 
            this.pcbAttType.Image = ((System.Drawing.Image)(resources.GetObject("pcbAttType.Image")));
            this.pcbAttType.Location = new System.Drawing.Point(15, 270);
            this.pcbAttType.Name = "pcbAttType";
            this.pcbAttType.Size = new System.Drawing.Size(50, 50);
            this.pcbAttType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAttType.TabIndex = 16;
            this.pcbAttType.TabStop = false;
            // 
            // pcbAttTitle
            // 
            this.pcbAttTitle.Image = ((System.Drawing.Image)(resources.GetObject("pcbAttTitle.Image")));
            this.pcbAttTitle.Location = new System.Drawing.Point(15, 150);
            this.pcbAttTitle.Name = "pcbAttTitle";
            this.pcbAttTitle.Size = new System.Drawing.Size(50, 50);
            this.pcbAttTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAttTitle.TabIndex = 14;
            this.pcbAttTitle.TabStop = false;
            // 
            // pcbAttDate
            // 
            this.pcbAttDate.Image = ((System.Drawing.Image)(resources.GetObject("pcbAttDate.Image")));
            this.pcbAttDate.Location = new System.Drawing.Point(15, 90);
            this.pcbAttDate.Name = "pcbAttDate";
            this.pcbAttDate.Size = new System.Drawing.Size(50, 50);
            this.pcbAttDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAttDate.TabIndex = 13;
            this.pcbAttDate.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Type d\'édition :";
            // 
            // txtPoids
            // 
            this.txtPoids.Location = new System.Drawing.Point(200, 222);
            this.txtPoids.Name = "txtPoids";
            this.txtPoids.Size = new System.Drawing.Size(75, 29);
            this.txtPoids.TabIndex = 9;
            // 
            // txtNomEncart
            // 
            this.txtNomEncart.Location = new System.Drawing.Point(230, 159);
            this.txtNomEncart.Name = "txtNomEncart";
            this.txtNomEncart.Size = new System.Drawing.Size(326, 29);
            this.txtNomEncart.TabIndex = 8;
            // 
            // lblTitreEncart
            // 
            this.lblTitreEncart.AutoSize = true;
            this.lblTitreEncart.Location = new System.Drawing.Point(70, 164);
            this.lblTitreEncart.Name = "lblTitreEncart";
            this.lblTitreEncart.Size = new System.Drawing.Size(152, 22);
            this.lblTitreEncart.TabIndex = 7;
            this.lblTitreEncart.Text = "Nom de l\'encart :";
            // 
            // lblPoids
            // 
            this.lblPoids.AutoSize = true;
            this.lblPoids.Location = new System.Drawing.Point(71, 225);
            this.lblPoids.Name = "lblPoids";
            this.lblPoids.Size = new System.Drawing.Size(123, 22);
            this.lblPoids.TabIndex = 6;
            this.lblPoids.Text = "Poids (en g) :";
            // 
            // txtDateFin
            // 
            this.txtDateFin.Location = new System.Drawing.Point(440, 101);
            this.txtDateFin.Name = "txtDateFin";
            this.txtDateFin.Size = new System.Drawing.Size(105, 29);
            this.txtDateFin.TabIndex = 5;
            // 
            // lblAu
            // 
            this.lblAu.AutoSize = true;
            this.lblAu.Location = new System.Drawing.Point(405, 104);
            this.lblAu.Name = "lblAu";
            this.lblAu.Size = new System.Drawing.Size(30, 22);
            this.lblAu.TabIndex = 4;
            this.lblAu.Text = "au";
            // 
            // txtDateDebut
            // 
            this.txtDateDebut.Location = new System.Drawing.Point(295, 101);
            this.txtDateDebut.Name = "txtDateDebut";
            this.txtDateDebut.Size = new System.Drawing.Size(105, 29);
            this.txtDateDebut.TabIndex = 3;
            // 
            // lblEncartageNuit
            // 
            this.lblEncartageNuit.AutoSize = true;
            this.lblEncartageNuit.Location = new System.Drawing.Point(70, 104);
            this.lblEncartageNuit.Name = "lblEncartageNuit";
            this.lblEncartageNuit.Size = new System.Drawing.Size(221, 22);
            this.lblEncartageNuit.TabIndex = 2;
            this.lblEncartageNuit.Text = "Encartage dans la nuit du";
            // 
            // txtInitiales
            // 
            this.txtInitiales.Location = new System.Drawing.Point(240, 41);
            this.txtInitiales.Name = "txtInitiales";
            this.txtInitiales.Size = new System.Drawing.Size(80, 29);
            this.txtInitiales.TabIndex = 1;
            // 
            // lblInitiales
            // 
            this.lblInitiales.AutoSize = true;
            this.lblInitiales.Location = new System.Drawing.Point(70, 44);
            this.lblInitiales.Name = "lblInitiales";
            this.lblInitiales.Size = new System.Drawing.Size(163, 22);
            this.lblInitiales.TabIndex = 0;
            this.lblInitiales.Text = "Initiales utilisées : ";
            // 
            // grpChoixTitre
            // 
            this.grpChoixTitre.Controls.Add(this.pcbAttTitre);
            this.grpChoixTitre.Controls.Add(this.rdbAls);
            this.grpChoixTitre.Controls.Add(this.rdbDna);
            this.grpChoixTitre.Controls.Add(this.lblChoixTitre);
            this.grpChoixTitre.Location = new System.Drawing.Point(83, 85);
            this.grpChoixTitre.Name = "grpChoixTitre";
            this.grpChoixTitre.Size = new System.Drawing.Size(800, 100);
            this.grpChoixTitre.TabIndex = 13;
            this.grpChoixTitre.TabStop = false;
            this.grpChoixTitre.Text = "Choix du titre";
            // 
            // pcbAttTitre
            // 
            this.pcbAttTitre.Image = ((System.Drawing.Image)(resources.GetObject("pcbAttTitre.Image")));
            this.pcbAttTitre.Location = new System.Drawing.Point(105, 30);
            this.pcbAttTitre.Name = "pcbAttTitre";
            this.pcbAttTitre.Size = new System.Drawing.Size(50, 50);
            this.pcbAttTitre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAttTitre.TabIndex = 3;
            this.pcbAttTitre.TabStop = false;
            // 
            // rdbAls
            // 
            this.rdbAls.AutoSize = true;
            this.rdbAls.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbAls.Location = new System.Drawing.Point(535, 43);
            this.rdbAls.Name = "rdbAls";
            this.rdbAls.Size = new System.Drawing.Size(65, 26);
            this.rdbAls.TabIndex = 2;
            this.rdbAls.TabStop = true;
            this.rdbAls.Text = "ALS";
            this.rdbAls.UseVisualStyleBackColor = true;
            // 
            // rdbDna
            // 
            this.rdbDna.AutoSize = true;
            this.rdbDna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbDna.Location = new System.Drawing.Point(425, 43);
            this.rdbDna.Name = "rdbDna";
            this.rdbDna.Size = new System.Drawing.Size(68, 26);
            this.rdbDna.TabIndex = 1;
            this.rdbDna.TabStop = true;
            this.rdbDna.Text = "DNA";
            this.rdbDna.UseVisualStyleBackColor = true;
            // 
            // lblChoixTitre
            // 
            this.lblChoixTitre.AutoSize = true;
            this.lblChoixTitre.Location = new System.Drawing.Point(160, 45);
            this.lblChoixTitre.Name = "lblChoixTitre";
            this.lblChoixTitre.Size = new System.Drawing.Size(219, 22);
            this.lblChoixTitre.TabIndex = 0;
            this.lblChoixTitre.Text = "Choisir le titre concerné :";
            // 
            // btnMoins
            // 
            this.btnMoins.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoins.Location = new System.Drawing.Point(567, 99);
            this.btnMoins.Name = "btnMoins";
            this.btnMoins.Size = new System.Drawing.Size(33, 33);
            this.btnMoins.TabIndex = 45;
            this.btnMoins.Text = "-";
            this.btnMoins.UseVisualStyleBackColor = true;
            this.btnMoins.Click += new System.EventHandler(this.btnMoins_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlus.Location = new System.Drawing.Point(606, 99);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(33, 33);
            this.btnPlus.TabIndex = 44;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // FicheInfos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnResetInfos);
            this.Controls.Add(this.btnResetTitre);
            this.Controls.Add(this.pnlTopUC);
            this.Controls.Add(this.grpSaisieEncart);
            this.Controls.Add(this.grpChoixTitre);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FicheInfos";
            this.Size = new System.Drawing.Size(966, 565);
            this.Load += new System.EventHandler(this.FicheInfos_Load);
            this.pnlTopUC.ResumeLayout(false);
            this.pnlTopUC.PerformLayout();
            this.grpSaisieEncart.ResumeLayout(false);
            this.grpSaisieEncart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAttPoids)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAttInit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAttType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAttTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAttDate)).EndInit();
            this.grpChoixTitre.ResumeLayout(false);
            this.grpChoixTitre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAttTitre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnResetInfos;
        private System.Windows.Forms.Button btnResetTitre;
        private System.Windows.Forms.Panel pnlTopUC;
        private System.Windows.Forms.Label lblFicheSaisie;
        private System.Windows.Forms.PictureBox pcbAttPoids;
        private System.Windows.Forms.PictureBox pcbAttInit;
        private System.Windows.Forms.PictureBox pcbAttType;
        private System.Windows.Forms.PictureBox pcbAttTitle;
        private System.Windows.Forms.PictureBox pcbAttDate;
        private System.Windows.Forms.RadioButton rdbEditPart;
        private System.Windows.Forms.RadioButton rdbEditComplet;
        private System.Windows.Forms.GroupBox grpSaisieEncart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPoids;
        private System.Windows.Forms.TextBox txtNomEncart;
        private System.Windows.Forms.Label lblTitreEncart;
        private System.Windows.Forms.Label lblPoids;
        private System.Windows.Forms.TextBox txtDateFin;
        private System.Windows.Forms.Label lblAu;
        private System.Windows.Forms.TextBox txtDateDebut;
        private System.Windows.Forms.Label lblEncartageNuit;
        private System.Windows.Forms.TextBox txtInitiales;
        private System.Windows.Forms.Label lblInitiales;
        private System.Windows.Forms.GroupBox grpChoixTitre;
        private System.Windows.Forms.PictureBox pcbAttTitre;
        private System.Windows.Forms.RadioButton rdbAls;
        private System.Windows.Forms.RadioButton rdbDna;
        private System.Windows.Forms.Label lblChoixTitre;
        private System.Windows.Forms.Button btnMoins;
        private System.Windows.Forms.Button btnPlus;
    }
}
