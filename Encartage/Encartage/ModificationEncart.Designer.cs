namespace Encartage
{
    partial class ModificationEncart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificationEncart));
            this.pnlTopUC = new System.Windows.Forms.Panel();
            this.lblFicheSaisie = new System.Windows.Forms.Label();
            this.rdbAls = new System.Windows.Forms.RadioButton();
            this.rdbDna = new System.Windows.Forms.RadioButton();
            this.lblChoixTitre = new System.Windows.Forms.Label();
            this.pcbAttTitre = new System.Windows.Forms.PictureBox();
            this.pcbAttDate = new System.Windows.Forms.PictureBox();
            this.txtDateFin = new System.Windows.Forms.TextBox();
            this.lblAu = new System.Windows.Forms.Label();
            this.txtDateDebut = new System.Windows.Forms.TextBox();
            this.lblEncartageNuit = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lboEncarts = new System.Windows.Forms.ListBox();
            this.lblResume = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPoids = new System.Windows.Forms.Label();
            this.lblEditions = new System.Windows.Forms.Label();
            this.lblDistrib = new System.Windows.Forms.Label();
            this.lblNbExemp = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTypeEdit = new System.Windows.Forms.TextBox();
            this.txtNbExemp = new System.Windows.Forms.TextBox();
            this.txtDistrib = new System.Windows.Forms.TextBox();
            this.txtEditions = new System.Windows.Forms.TextBox();
            this.txtPoids = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblTypeEdit = new System.Windows.Forms.Label();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMoins = new System.Windows.Forms.Button();
            this.btnOpenDirectory = new System.Windows.Forms.Button();
            this.pnlTopUC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAttTitre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAttDate)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopUC
            // 
            this.pnlTopUC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlTopUC.Controls.Add(this.lblFicheSaisie);
            this.pnlTopUC.Location = new System.Drawing.Point(0, 0);
            this.pnlTopUC.Name = "pnlTopUC";
            this.pnlTopUC.Size = new System.Drawing.Size(966, 60);
            this.pnlTopUC.TabIndex = 16;
            // 
            // lblFicheSaisie
            // 
            this.lblFicheSaisie.AutoSize = true;
            this.lblFicheSaisie.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFicheSaisie.ForeColor = System.Drawing.Color.White;
            this.lblFicheSaisie.Location = new System.Drawing.Point(355, 15);
            this.lblFicheSaisie.Name = "lblFicheSaisie";
            this.lblFicheSaisie.Size = new System.Drawing.Size(256, 29);
            this.lblFicheSaisie.TabIndex = 0;
            this.lblFicheSaisie.Text = "Modification d\'encart";
            // 
            // rdbAls
            // 
            this.rdbAls.AutoSize = true;
            this.rdbAls.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbAls.Location = new System.Drawing.Point(638, 88);
            this.rdbAls.Name = "rdbAls";
            this.rdbAls.Size = new System.Drawing.Size(65, 26);
            this.rdbAls.TabIndex = 19;
            this.rdbAls.TabStop = true;
            this.rdbAls.Text = "ALS";
            this.rdbAls.UseVisualStyleBackColor = true;
            // 
            // rdbDna
            // 
            this.rdbDna.AutoSize = true;
            this.rdbDna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbDna.Location = new System.Drawing.Point(528, 88);
            this.rdbDna.Name = "rdbDna";
            this.rdbDna.Size = new System.Drawing.Size(68, 26);
            this.rdbDna.TabIndex = 18;
            this.rdbDna.TabStop = true;
            this.rdbDna.Text = "DNA";
            this.rdbDna.UseVisualStyleBackColor = true;
            // 
            // lblChoixTitre
            // 
            this.lblChoixTitre.AutoSize = true;
            this.lblChoixTitre.Location = new System.Drawing.Point(263, 90);
            this.lblChoixTitre.Name = "lblChoixTitre";
            this.lblChoixTitre.Size = new System.Drawing.Size(219, 22);
            this.lblChoixTitre.TabIndex = 17;
            this.lblChoixTitre.Text = "Choisir le titre concerné :";
            // 
            // pcbAttTitre
            // 
            this.pcbAttTitre.Image = ((System.Drawing.Image)(resources.GetObject("pcbAttTitre.Image")));
            this.pcbAttTitre.Location = new System.Drawing.Point(207, 75);
            this.pcbAttTitre.Name = "pcbAttTitre";
            this.pcbAttTitre.Size = new System.Drawing.Size(50, 50);
            this.pcbAttTitre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAttTitre.TabIndex = 20;
            this.pcbAttTitre.TabStop = false;
            // 
            // pcbAttDate
            // 
            this.pcbAttDate.Image = ((System.Drawing.Image)(resources.GetObject("pcbAttDate.Image")));
            this.pcbAttDate.Location = new System.Drawing.Point(144, 140);
            this.pcbAttDate.Name = "pcbAttDate";
            this.pcbAttDate.Size = new System.Drawing.Size(50, 50);
            this.pcbAttDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAttDate.TabIndex = 25;
            this.pcbAttDate.TabStop = false;
            // 
            // txtDateFin
            // 
            this.txtDateFin.Location = new System.Drawing.Point(570, 152);
            this.txtDateFin.Name = "txtDateFin";
            this.txtDateFin.Size = new System.Drawing.Size(105, 29);
            this.txtDateFin.TabIndex = 24;
            // 
            // lblAu
            // 
            this.lblAu.AutoSize = true;
            this.lblAu.Location = new System.Drawing.Point(535, 155);
            this.lblAu.Name = "lblAu";
            this.lblAu.Size = new System.Drawing.Size(30, 22);
            this.lblAu.TabIndex = 23;
            this.lblAu.Text = "au";
            // 
            // txtDateDebut
            // 
            this.txtDateDebut.Location = new System.Drawing.Point(425, 152);
            this.txtDateDebut.Name = "txtDateDebut";
            this.txtDateDebut.Size = new System.Drawing.Size(105, 29);
            this.txtDateDebut.TabIndex = 22;
            // 
            // lblEncartageNuit
            // 
            this.lblEncartageNuit.AutoSize = true;
            this.lblEncartageNuit.Location = new System.Drawing.Point(200, 155);
            this.lblEncartageNuit.Name = "lblEncartageNuit";
            this.lblEncartageNuit.Size = new System.Drawing.Size(221, 22);
            this.lblEncartageNuit.TabIndex = 21;
            this.lblEncartageNuit.Text = "Encartage dans la nuit du";
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(418, 210);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(130, 35);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "Rechercher";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lboEncarts
            // 
            this.lboEncarts.FormattingEnabled = true;
            this.lboEncarts.ItemHeight = 22;
            this.lboEncarts.Location = new System.Drawing.Point(20, 275);
            this.lboEncarts.Name = "lboEncarts";
            this.lboEncarts.Size = new System.Drawing.Size(350, 268);
            this.lboEncarts.TabIndex = 27;
            this.lboEncarts.SelectedIndexChanged += new System.EventHandler(this.lboEncarts_SelectedIndexChanged);
            // 
            // lblResume
            // 
            this.lblResume.AutoSize = true;
            this.lblResume.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResume.Location = new System.Drawing.Point(226, 10);
            this.lblResume.Name = "lblResume";
            this.lblResume.Size = new System.Drawing.Size(97, 22);
            this.lblResume.TabIndex = 28;
            this.lblResume.Text = "Résumé :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(122, 54);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(60, 22);
            this.lblNom.TabIndex = 29;
            this.lblNom.Text = "Nom :";
            // 
            // lblPoids
            // 
            this.lblPoids.AutoSize = true;
            this.lblPoids.Location = new System.Drawing.Point(113, 86);
            this.lblPoids.Name = "lblPoids";
            this.lblPoids.Size = new System.Drawing.Size(69, 22);
            this.lblPoids.TabIndex = 30;
            this.lblPoids.Text = "Poids :";
            // 
            // lblEditions
            // 
            this.lblEditions.AutoSize = true;
            this.lblEditions.Location = new System.Drawing.Point(94, 118);
            this.lblEditions.Name = "lblEditions";
            this.lblEditions.Size = new System.Drawing.Size(88, 22);
            this.lblEditions.TabIndex = 31;
            this.lblEditions.Text = "Éditions :";
            // 
            // lblDistrib
            // 
            this.lblDistrib.AutoSize = true;
            this.lblDistrib.Location = new System.Drawing.Point(68, 150);
            this.lblDistrib.Name = "lblDistrib";
            this.lblDistrib.Size = new System.Drawing.Size(114, 22);
            this.lblDistrib.TabIndex = 32;
            this.lblDistrib.Text = "Distribution :";
            // 
            // lblNbExemp
            // 
            this.lblNbExemp.AutoSize = true;
            this.lblNbExemp.Location = new System.Drawing.Point(30, 182);
            this.lblNbExemp.Name = "lblNbExemp";
            this.lblNbExemp.Size = new System.Drawing.Size(152, 22);
            this.lblNbExemp.TabIndex = 33;
            this.lblNbExemp.Text = "Nb exemplaires :";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtTypeEdit);
            this.panel1.Controls.Add(this.txtNbExemp);
            this.panel1.Controls.Add(this.txtDistrib);
            this.panel1.Controls.Add(this.txtEditions);
            this.panel1.Controls.Add(this.txtPoids);
            this.panel1.Controls.Add(this.txtNom);
            this.panel1.Controls.Add(this.lblTypeEdit);
            this.panel1.Controls.Add(this.lblNbExemp);
            this.panel1.Controls.Add(this.lblDistrib);
            this.panel1.Controls.Add(this.lblEditions);
            this.panel1.Controls.Add(this.lblPoids);
            this.panel1.Controls.Add(this.lblNom);
            this.panel1.Controls.Add(this.lblResume);
            this.panel1.Location = new System.Drawing.Point(400, 275);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 268);
            this.panel1.TabIndex = 39;
            // 
            // txtTypeEdit
            // 
            this.txtTypeEdit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeEdit.Location = new System.Drawing.Point(188, 211);
            this.txtTypeEdit.Name = "txtTypeEdit";
            this.txtTypeEdit.ReadOnly = true;
            this.txtTypeEdit.Size = new System.Drawing.Size(330, 29);
            this.txtTypeEdit.TabIndex = 45;
            // 
            // txtNbExemp
            // 
            this.txtNbExemp.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNbExemp.Location = new System.Drawing.Point(188, 179);
            this.txtNbExemp.Name = "txtNbExemp";
            this.txtNbExemp.ReadOnly = true;
            this.txtNbExemp.Size = new System.Drawing.Size(330, 29);
            this.txtNbExemp.TabIndex = 44;
            // 
            // txtDistrib
            // 
            this.txtDistrib.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistrib.Location = new System.Drawing.Point(188, 147);
            this.txtDistrib.Name = "txtDistrib";
            this.txtDistrib.ReadOnly = true;
            this.txtDistrib.Size = new System.Drawing.Size(330, 29);
            this.txtDistrib.TabIndex = 43;
            // 
            // txtEditions
            // 
            this.txtEditions.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditions.Location = new System.Drawing.Point(188, 115);
            this.txtEditions.Name = "txtEditions";
            this.txtEditions.ReadOnly = true;
            this.txtEditions.Size = new System.Drawing.Size(330, 29);
            this.txtEditions.TabIndex = 42;
            // 
            // txtPoids
            // 
            this.txtPoids.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoids.Location = new System.Drawing.Point(188, 83);
            this.txtPoids.Name = "txtPoids";
            this.txtPoids.ReadOnly = true;
            this.txtPoids.Size = new System.Drawing.Size(330, 29);
            this.txtPoids.TabIndex = 41;
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(188, 51);
            this.txtNom.Name = "txtNom";
            this.txtNom.ReadOnly = true;
            this.txtNom.Size = new System.Drawing.Size(330, 29);
            this.txtNom.TabIndex = 40;
            // 
            // lblTypeEdit
            // 
            this.lblTypeEdit.AutoSize = true;
            this.lblTypeEdit.Location = new System.Drawing.Point(44, 214);
            this.lblTypeEdit.Name = "lblTypeEdit";
            this.lblTypeEdit.Size = new System.Drawing.Size(138, 22);
            this.lblTypeEdit.TabIndex = 39;
            this.lblTypeEdit.Text = "Type d\'édition :";
            // 
            // btnModif
            // 
            this.btnModif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModif.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModif.Location = new System.Drawing.Point(516, 561);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(120, 35);
            this.btnModif.TabIndex = 40;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupprimer.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Location = new System.Drawing.Point(330, 561);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(120, 35);
            this.btnSupprimer.TabIndex = 41;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlus.Location = new System.Drawing.Point(733, 150);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(33, 33);
            this.btnPlus.TabIndex = 42;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMoins
            // 
            this.btnMoins.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoins.Location = new System.Drawing.Point(694, 150);
            this.btnMoins.Name = "btnMoins";
            this.btnMoins.Size = new System.Drawing.Size(33, 33);
            this.btnMoins.TabIndex = 43;
            this.btnMoins.Text = "-";
            this.btnMoins.UseVisualStyleBackColor = true;
            this.btnMoins.Click += new System.EventHandler(this.btnMoins_Click);
            // 
            // btnOpenDirectory
            // 
            this.btnOpenDirectory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenDirectory.Location = new System.Drawing.Point(20, 561);
            this.btnOpenDirectory.Name = "btnOpenDirectory";
            this.btnOpenDirectory.Size = new System.Drawing.Size(180, 35);
            this.btnOpenDirectory.TabIndex = 46;
            this.btnOpenDirectory.Text = "Ouvrir le repertoire";
            this.btnOpenDirectory.UseVisualStyleBackColor = true;
            this.btnOpenDirectory.Click += new System.EventHandler(this.btnOpenDirectory_Click);
            // 
            // ModificationEncart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnOpenDirectory);
            this.Controls.Add(this.btnMoins);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lboEncarts);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.pcbAttDate);
            this.Controls.Add(this.txtDateFin);
            this.Controls.Add(this.lblAu);
            this.Controls.Add(this.txtDateDebut);
            this.Controls.Add(this.lblEncartageNuit);
            this.Controls.Add(this.pcbAttTitre);
            this.Controls.Add(this.rdbAls);
            this.Controls.Add(this.rdbDna);
            this.Controls.Add(this.lblChoixTitre);
            this.Controls.Add(this.pnlTopUC);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "ModificationEncart";
            this.Size = new System.Drawing.Size(966, 625);
            this.Load += new System.EventHandler(this.ModificationEncart_Load);
            this.pnlTopUC.ResumeLayout(false);
            this.pnlTopUC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAttTitre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAttDate)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopUC;
        private System.Windows.Forms.Label lblFicheSaisie;
        private System.Windows.Forms.RadioButton rdbAls;
        private System.Windows.Forms.RadioButton rdbDna;
        private System.Windows.Forms.Label lblChoixTitre;
        private System.Windows.Forms.PictureBox pcbAttTitre;
        private System.Windows.Forms.PictureBox pcbAttDate;
        private System.Windows.Forms.TextBox txtDateFin;
        private System.Windows.Forms.Label lblAu;
        private System.Windows.Forms.TextBox txtDateDebut;
        private System.Windows.Forms.Label lblEncartageNuit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lboEncarts;
        private System.Windows.Forms.Label lblResume;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPoids;
        private System.Windows.Forms.Label lblEditions;
        private System.Windows.Forms.Label lblDistrib;
        private System.Windows.Forms.Label lblNbExemp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtNbExemp;
        private System.Windows.Forms.TextBox txtDistrib;
        private System.Windows.Forms.TextBox txtEditions;
        private System.Windows.Forms.TextBox txtPoids;
        private System.Windows.Forms.TextBox txtTypeEdit;
        private System.Windows.Forms.Label lblTypeEdit;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMoins;
        private System.Windows.Forms.Button btnOpenDirectory;
    }
}
