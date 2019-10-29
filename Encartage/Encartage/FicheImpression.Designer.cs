namespace Encartage
{
    partial class FicheImpression
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FicheImpression));
            this.pnlTopUC = new System.Windows.Forms.Panel();
            this.lblFicheSaisie = new System.Windows.Forms.Label();
            this.txtDateFin = new System.Windows.Forms.TextBox();
            this.lblAu = new System.Windows.Forms.Label();
            this.txtDateDebut = new System.Windows.Forms.TextBox();
            this.lblEncartageNuit = new System.Windows.Forms.Label();
            this.rdbAls = new System.Windows.Forms.RadioButton();
            this.rdbDna = new System.Windows.Forms.RadioButton();
            this.lblChoixTitre = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.cboPrinters = new System.Windows.Forms.ComboBox();
            this.pcbPrinter = new System.Windows.Forms.PictureBox();
            this.pcbAttDate = new System.Windows.Forms.PictureBox();
            this.pcbAttTitre = new System.Windows.Forms.PictureBox();
            this.lblNbCopiePlan = new System.Windows.Forms.Label();
            this.lblNbCopieNotes = new System.Windows.Forms.Label();
            this.lblNbCopiesListe = new System.Windows.Forms.Label();
            this.btnOpenDirectory = new System.Windows.Forms.Button();
            this.ucNombreCopieListe = new Encartage.UCNombreCopie();
            this.ucNombreCopieNotes = new Encartage.UCNombreCopie();
            this.ucNombreCopiePlan = new Encartage.UCNombreCopie();
            this.btnMoins = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.pnlTopUC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPrinter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAttDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAttTitre)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopUC
            // 
            this.pnlTopUC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlTopUC.Controls.Add(this.lblFicheSaisie);
            this.pnlTopUC.Location = new System.Drawing.Point(0, 0);
            this.pnlTopUC.Name = "pnlTopUC";
            this.pnlTopUC.Size = new System.Drawing.Size(766, 60);
            this.pnlTopUC.TabIndex = 17;
            // 
            // lblFicheSaisie
            // 
            this.lblFicheSaisie.AutoSize = true;
            this.lblFicheSaisie.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFicheSaisie.ForeColor = System.Drawing.Color.White;
            this.lblFicheSaisie.Location = new System.Drawing.Point(313, 15);
            this.lblFicheSaisie.Name = "lblFicheSaisie";
            this.lblFicheSaisie.Size = new System.Drawing.Size(141, 29);
            this.lblFicheSaisie.TabIndex = 0;
            this.lblFicheSaisie.Text = "Impression";
            // 
            // txtDateFin
            // 
            this.txtDateFin.Location = new System.Drawing.Point(479, 172);
            this.txtDateFin.Name = "txtDateFin";
            this.txtDateFin.Size = new System.Drawing.Size(105, 29);
            this.txtDateFin.TabIndex = 33;
            // 
            // lblAu
            // 
            this.lblAu.AutoSize = true;
            this.lblAu.Location = new System.Drawing.Point(444, 175);
            this.lblAu.Name = "lblAu";
            this.lblAu.Size = new System.Drawing.Size(30, 22);
            this.lblAu.TabIndex = 32;
            this.lblAu.Text = "au";
            // 
            // txtDateDebut
            // 
            this.txtDateDebut.Location = new System.Drawing.Point(334, 172);
            this.txtDateDebut.Name = "txtDateDebut";
            this.txtDateDebut.Size = new System.Drawing.Size(105, 29);
            this.txtDateDebut.TabIndex = 31;
            // 
            // lblEncartageNuit
            // 
            this.lblEncartageNuit.AutoSize = true;
            this.lblEncartageNuit.Location = new System.Drawing.Point(104, 175);
            this.lblEncartageNuit.Name = "lblEncartageNuit";
            this.lblEncartageNuit.Size = new System.Drawing.Size(221, 22);
            this.lblEncartageNuit.TabIndex = 30;
            this.lblEncartageNuit.Text = "Encartage dans la nuit du";
            // 
            // rdbAls
            // 
            this.rdbAls.AutoSize = true;
            this.rdbAls.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbAls.Location = new System.Drawing.Point(510, 103);
            this.rdbAls.Name = "rdbAls";
            this.rdbAls.Size = new System.Drawing.Size(65, 26);
            this.rdbAls.TabIndex = 28;
            this.rdbAls.TabStop = true;
            this.rdbAls.Text = "ALS";
            this.rdbAls.UseVisualStyleBackColor = true;
            // 
            // rdbDna
            // 
            this.rdbDna.AutoSize = true;
            this.rdbDna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbDna.Location = new System.Drawing.Point(415, 103);
            this.rdbDna.Name = "rdbDna";
            this.rdbDna.Size = new System.Drawing.Size(68, 26);
            this.rdbDna.TabIndex = 27;
            this.rdbDna.TabStop = true;
            this.rdbDna.Text = "DNA";
            this.rdbDna.UseVisualStyleBackColor = true;
            // 
            // lblChoixTitre
            // 
            this.lblChoixTitre.AutoSize = true;
            this.lblChoixTitre.Location = new System.Drawing.Point(165, 105);
            this.lblChoixTitre.Name = "lblChoixTitre";
            this.lblChoixTitre.Size = new System.Drawing.Size(219, 22);
            this.lblChoixTitre.TabIndex = 26;
            this.lblChoixTitre.Text = "Choisir le titre concerné :";
            // 
            // btnPrint
            // 
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Location = new System.Drawing.Point(515, 470);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(120, 35);
            this.btnPrint.TabIndex = 35;
            this.btnPrint.Text = "Imprimer";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // cboPrinters
            // 
            this.cboPrinters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPrinters.FormattingEnabled = true;
            this.cboPrinters.Location = new System.Drawing.Point(185, 410);
            this.cboPrinters.Name = "cboPrinters";
            this.cboPrinters.Size = new System.Drawing.Size(450, 30);
            this.cboPrinters.TabIndex = 36;
            // 
            // pcbPrinter
            // 
            this.pcbPrinter.Image = global::Encartage.Properties.Resources.Imprimante;
            this.pcbPrinter.Location = new System.Drawing.Point(125, 400);
            this.pcbPrinter.Name = "pcbPrinter";
            this.pcbPrinter.Size = new System.Drawing.Size(50, 50);
            this.pcbPrinter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPrinter.TabIndex = 38;
            this.pcbPrinter.TabStop = false;
            // 
            // pcbAttDate
            // 
            this.pcbAttDate.Image = ((System.Drawing.Image)(resources.GetObject("pcbAttDate.Image")));
            this.pcbAttDate.Location = new System.Drawing.Point(48, 160);
            this.pcbAttDate.Name = "pcbAttDate";
            this.pcbAttDate.Size = new System.Drawing.Size(50, 50);
            this.pcbAttDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAttDate.TabIndex = 34;
            this.pcbAttDate.TabStop = false;
            // 
            // pcbAttTitre
            // 
            this.pcbAttTitre.Image = ((System.Drawing.Image)(resources.GetObject("pcbAttTitre.Image")));
            this.pcbAttTitre.Location = new System.Drawing.Point(110, 90);
            this.pcbAttTitre.Name = "pcbAttTitre";
            this.pcbAttTitre.Size = new System.Drawing.Size(50, 50);
            this.pcbAttTitre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAttTitre.TabIndex = 29;
            this.pcbAttTitre.TabStop = false;
            // 
            // lblNbCopiePlan
            // 
            this.lblNbCopiePlan.AutoSize = true;
            this.lblNbCopiePlan.Location = new System.Drawing.Point(185, 245);
            this.lblNbCopiePlan.Name = "lblNbCopiePlan";
            this.lblNbCopiePlan.Size = new System.Drawing.Size(255, 22);
            this.lblNbCopiePlan.TabIndex = 40;
            this.lblNbCopiePlan.Text = "Nombre de copie(s) du plan :";
            // 
            // lblNbCopieNotes
            // 
            this.lblNbCopieNotes.AutoSize = true;
            this.lblNbCopieNotes.Location = new System.Drawing.Point(162, 295);
            this.lblNbCopieNotes.Name = "lblNbCopieNotes";
            this.lblNbCopieNotes.Size = new System.Drawing.Size(278, 22);
            this.lblNbCopieNotes.TabIndex = 42;
            this.lblNbCopieNotes.Text = "Nombre de copie(s) des notes :";
            // 
            // lblNbCopiesListe
            // 
            this.lblNbCopiesListe.AutoSize = true;
            this.lblNbCopiesListe.Location = new System.Drawing.Point(166, 345);
            this.lblNbCopiesListe.Name = "lblNbCopiesListe";
            this.lblNbCopiesListe.Size = new System.Drawing.Size(274, 22);
            this.lblNbCopiesListe.TabIndex = 44;
            this.lblNbCopiesListe.Text = "Nombre de copie(s) de la liste :";
            // 
            // btnOpenDirectory
            // 
            this.btnOpenDirectory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenDirectory.Location = new System.Drawing.Point(90, 470);
            this.btnOpenDirectory.Name = "btnOpenDirectory";
            this.btnOpenDirectory.Size = new System.Drawing.Size(180, 35);
            this.btnOpenDirectory.TabIndex = 45;
            this.btnOpenDirectory.Text = "Ouvrir le repertoire";
            this.btnOpenDirectory.UseVisualStyleBackColor = true;
            this.btnOpenDirectory.Click += new System.EventHandler(this.btnOpenDirectory_Click);
            // 
            // ucNombreCopieListe
            // 
            this.ucNombreCopieListe.BackColor = System.Drawing.Color.White;
            this.ucNombreCopieListe.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucNombreCopieListe.Location = new System.Drawing.Point(445, 335);
            this.ucNombreCopieListe.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ucNombreCopieListe.Name = "ucNombreCopieListe";
            this.ucNombreCopieListe.nbCopie = 1;
            this.ucNombreCopieListe.Size = new System.Drawing.Size(135, 40);
            this.ucNombreCopieListe.TabIndex = 43;
            // 
            // ucNombreCopieNotes
            // 
            this.ucNombreCopieNotes.BackColor = System.Drawing.Color.White;
            this.ucNombreCopieNotes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucNombreCopieNotes.Location = new System.Drawing.Point(445, 285);
            this.ucNombreCopieNotes.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ucNombreCopieNotes.Name = "ucNombreCopieNotes";
            this.ucNombreCopieNotes.nbCopie = 1;
            this.ucNombreCopieNotes.Size = new System.Drawing.Size(135, 40);
            this.ucNombreCopieNotes.TabIndex = 41;
            // 
            // ucNombreCopiePlan
            // 
            this.ucNombreCopiePlan.BackColor = System.Drawing.Color.White;
            this.ucNombreCopiePlan.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucNombreCopiePlan.Location = new System.Drawing.Point(445, 235);
            this.ucNombreCopiePlan.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ucNombreCopiePlan.Name = "ucNombreCopiePlan";
            this.ucNombreCopiePlan.nbCopie = 1;
            this.ucNombreCopiePlan.Size = new System.Drawing.Size(135, 40);
            this.ucNombreCopiePlan.TabIndex = 39;
            // 
            // btnMoins
            // 
            this.btnMoins.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoins.Location = new System.Drawing.Point(590, 170);
            this.btnMoins.Name = "btnMoins";
            this.btnMoins.Size = new System.Drawing.Size(33, 33);
            this.btnMoins.TabIndex = 47;
            this.btnMoins.Text = "-";
            this.btnMoins.UseVisualStyleBackColor = true;
            this.btnMoins.Click += new System.EventHandler(this.btnMoins_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlus.Location = new System.Drawing.Point(629, 170);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(33, 33);
            this.btnPlus.TabIndex = 46;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // FicheImpression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnMoins);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnOpenDirectory);
            this.Controls.Add(this.lblNbCopiesListe);
            this.Controls.Add(this.ucNombreCopieListe);
            this.Controls.Add(this.lblNbCopieNotes);
            this.Controls.Add(this.ucNombreCopieNotes);
            this.Controls.Add(this.lblNbCopiePlan);
            this.Controls.Add(this.ucNombreCopiePlan);
            this.Controls.Add(this.pcbPrinter);
            this.Controls.Add(this.cboPrinters);
            this.Controls.Add(this.btnPrint);
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
            this.Name = "FicheImpression";
            this.Size = new System.Drawing.Size(766, 525);
            this.Load += new System.EventHandler(this.ImpressionNotesPlans_Load);
            this.pnlTopUC.ResumeLayout(false);
            this.pnlTopUC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPrinter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAttDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAttTitre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopUC;
        private System.Windows.Forms.Label lblFicheSaisie;
        private System.Windows.Forms.PictureBox pcbAttDate;
        private System.Windows.Forms.TextBox txtDateFin;
        private System.Windows.Forms.Label lblAu;
        private System.Windows.Forms.TextBox txtDateDebut;
        private System.Windows.Forms.Label lblEncartageNuit;
        private System.Windows.Forms.PictureBox pcbAttTitre;
        private System.Windows.Forms.RadioButton rdbAls;
        private System.Windows.Forms.RadioButton rdbDna;
        private System.Windows.Forms.Label lblChoixTitre;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ComboBox cboPrinters;
        private System.Windows.Forms.PictureBox pcbPrinter;
        private UCNombreCopie ucNombreCopiePlan;
        private System.Windows.Forms.Label lblNbCopiePlan;
        private System.Windows.Forms.Label lblNbCopieNotes;
        private UCNombreCopie ucNombreCopieNotes;
        private System.Windows.Forms.Label lblNbCopiesListe;
        private UCNombreCopie ucNombreCopieListe;
        private System.Windows.Forms.Button btnOpenDirectory;
        private System.Windows.Forms.Button btnMoins;
        private System.Windows.Forms.Button btnPlus;
    }
}
