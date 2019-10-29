namespace Encartage
{
    partial class FicheTexteASaisir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FicheTexteASaisir));
            this.lblTitre = new System.Windows.Forms.Label();
            this.pnlTopUC = new System.Windows.Forms.Panel();
            this.txtTexte = new System.Windows.Forms.TextBox();
            this.lblTexte = new System.Windows.Forms.Label();
            this.btnAddPredef = new System.Windows.Forms.Button();
            this.lboTextes = new System.Windows.Forms.ListBox();
            this.lboResume = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblResume = new System.Windows.Forms.Label();
            this.btnAddResume = new System.Windows.Forms.Button();
            this.btnSubResume = new System.Windows.Forms.Button();
            this.lblTextesPredef = new System.Windows.Forms.Label();
            this.pcbAttTexte = new System.Windows.Forms.PictureBox();
            this.pnlTopUC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAttTexte)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.White;
            this.lblTitre.Location = new System.Drawing.Point(370, 15);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(227, 29);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Fiche texte à saisir";
            // 
            // pnlTopUC
            // 
            this.pnlTopUC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlTopUC.Controls.Add(this.lblTitre);
            this.pnlTopUC.Location = new System.Drawing.Point(0, 0);
            this.pnlTopUC.Name = "pnlTopUC";
            this.pnlTopUC.Size = new System.Drawing.Size(966, 60);
            this.pnlTopUC.TabIndex = 20;
            // 
            // txtTexte
            // 
            this.txtTexte.Location = new System.Drawing.Point(108, 90);
            this.txtTexte.Name = "txtTexte";
            this.txtTexte.Size = new System.Drawing.Size(750, 29);
            this.txtTexte.TabIndex = 21;
            // 
            // lblTexte
            // 
            this.lblTexte.AutoSize = true;
            this.lblTexte.Location = new System.Drawing.Point(20, 93);
            this.lblTexte.Name = "lblTexte";
            this.lblTexte.Size = new System.Drawing.Size(66, 22);
            this.lblTexte.TabIndex = 22;
            this.lblTexte.Text = "Texte :";
            // 
            // btnAddPredef
            // 
            this.btnAddPredef.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPredef.Location = new System.Drawing.Point(596, 125);
            this.btnAddPredef.Name = "btnAddPredef";
            this.btnAddPredef.Size = new System.Drawing.Size(262, 31);
            this.btnAddPredef.TabIndex = 23;
            this.btnAddPredef.Text = "Ajouter aux textes prédéfinis";
            this.btnAddPredef.UseVisualStyleBackColor = true;
            this.btnAddPredef.Click += new System.EventHandler(this.btnAddPredef_Click);
            // 
            // lboTextes
            // 
            this.lboTextes.FormattingEnabled = true;
            this.lboTextes.ItemHeight = 22;
            this.lboTextes.Location = new System.Drawing.Point(108, 205);
            this.lboTextes.Name = "lboTextes";
            this.lboTextes.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lboTextes.Size = new System.Drawing.Size(750, 158);
            this.lboTextes.TabIndex = 24;
            // 
            // lboResume
            // 
            this.lboResume.FormattingEnabled = true;
            this.lboResume.ItemHeight = 22;
            this.lboResume.Location = new System.Drawing.Point(108, 410);
            this.lboResume.Name = "lboResume";
            this.lboResume.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lboResume.Size = new System.Drawing.Size(750, 114);
            this.lboResume.TabIndex = 26;
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(108, 125);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 31);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblResume
            // 
            this.lblResume.AutoSize = true;
            this.lblResume.Location = new System.Drawing.Point(10, 450);
            this.lblResume.Name = "lblResume";
            this.lblResume.Size = new System.Drawing.Size(92, 22);
            this.lblResume.TabIndex = 28;
            this.lblResume.Text = "Résumé :";
            // 
            // btnAddResume
            // 
            this.btnAddResume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddResume.Location = new System.Drawing.Point(870, 267);
            this.btnAddResume.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddResume.Name = "btnAddResume";
            this.btnAddResume.Size = new System.Drawing.Size(35, 35);
            this.btnAddResume.TabIndex = 31;
            this.btnAddResume.Text = "+";
            this.btnAddResume.UseVisualStyleBackColor = true;
            this.btnAddResume.Click += new System.EventHandler(this.btnAddResume_Click);
            // 
            // btnSubResume
            // 
            this.btnSubResume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubResume.Location = new System.Drawing.Point(870, 444);
            this.btnSubResume.Name = "btnSubResume";
            this.btnSubResume.Size = new System.Drawing.Size(35, 35);
            this.btnSubResume.TabIndex = 32;
            this.btnSubResume.Text = "-";
            this.btnSubResume.UseVisualStyleBackColor = true;
            this.btnSubResume.Click += new System.EventHandler(this.btnSubResume_Click);
            // 
            // lblTextesPredef
            // 
            this.lblTextesPredef.Location = new System.Drawing.Point(3, 255);
            this.lblTextesPredef.Name = "lblTextesPredef";
            this.lblTextesPredef.Size = new System.Drawing.Size(105, 58);
            this.lblTextesPredef.TabIndex = 33;
            this.lblTextesPredef.Text = "Textes prédéfinis :";
            this.lblTextesPredef.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcbAttTexte
            // 
            this.pcbAttTexte.Image = ((System.Drawing.Image)(resources.GetObject("pcbAttTexte.Image")));
            this.pcbAttTexte.Location = new System.Drawing.Point(870, 79);
            this.pcbAttTexte.Name = "pcbAttTexte";
            this.pcbAttTexte.Size = new System.Drawing.Size(50, 50);
            this.pcbAttTexte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAttTexte.TabIndex = 34;
            this.pcbAttTexte.TabStop = false;
            // 
            // FicheTexteASaisir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pcbAttTexte);
            this.Controls.Add(this.lblTextesPredef);
            this.Controls.Add(this.btnSubResume);
            this.Controls.Add(this.btnAddResume);
            this.Controls.Add(this.lblResume);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lboResume);
            this.Controls.Add(this.lboTextes);
            this.Controls.Add(this.btnAddPredef);
            this.Controls.Add(this.lblTexte);
            this.Controls.Add(this.txtTexte);
            this.Controls.Add(this.pnlTopUC);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FicheTexteASaisir";
            this.Size = new System.Drawing.Size(966, 565);
            this.Load += new System.EventHandler(this.FicheTexteASaisir_Load);
            this.pnlTopUC.ResumeLayout(false);
            this.pnlTopUC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAttTexte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Panel pnlTopUC;
        private System.Windows.Forms.TextBox txtTexte;
        private System.Windows.Forms.Label lblTexte;
        private System.Windows.Forms.Button btnAddPredef;
        private System.Windows.Forms.ListBox lboTextes;
        private System.Windows.Forms.ListBox lboResume;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblResume;
        private System.Windows.Forms.Button btnAddResume;
        private System.Windows.Forms.Button btnSubResume;
        private System.Windows.Forms.Label lblTextesPredef;
        private System.Windows.Forms.PictureBox pcbAttTexte;
    }
}
