namespace Encartage
{
    partial class FicheDistribution
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FicheDistribution));
            this.pnlTopUC = new System.Windows.Forms.Panel();
            this.lblTitre = new System.Windows.Forms.Label();
            this.grpEditions = new System.Windows.Forms.GroupBox();
            this.cbx68 = new System.Windows.Forms.CheckBox();
            this.cbx67 = new System.Windows.Forms.CheckBox();
            this.grpDistribution = new System.Windows.Forms.GroupBox();
            this.pcbAttNbExemp = new System.Windows.Forms.PictureBox();
            this.pcbAttDistrib = new System.Windows.Forms.PictureBox();
            this.txtNbExemp = new System.Windows.Forms.TextBox();
            this.lblNbExemp = new System.Windows.Forms.Label();
            this.cbxSB = new System.Windows.Forms.CheckBox();
            this.cbxVno = new System.Windows.Forms.CheckBox();
            this.cbxPorteur = new System.Windows.Forms.CheckBox();
            this.btnResetDistrib = new System.Windows.Forms.Button();
            this.btnResetEdit = new System.Windows.Forms.Button();
            this.pcbAttEditions = new System.Windows.Forms.PictureBox();
            this.lblEdition = new System.Windows.Forms.Label();
            this.pnlTopUC.SuspendLayout();
            this.grpEditions.SuspendLayout();
            this.grpDistribution.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAttNbExemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAttDistrib)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAttEditions)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopUC
            // 
            this.pnlTopUC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlTopUC.Controls.Add(this.lblTitre);
            this.pnlTopUC.Location = new System.Drawing.Point(0, 0);
            this.pnlTopUC.Name = "pnlTopUC";
            this.pnlTopUC.Size = new System.Drawing.Size(966, 60);
            this.pnlTopUC.TabIndex = 13;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.White;
            this.lblTitre.Location = new System.Drawing.Point(375, 15);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(217, 29);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Fiche distribution";
            // 
            // grpEditions
            // 
            this.grpEditions.Controls.Add(this.cbx68);
            this.grpEditions.Controls.Add(this.cbx67);
            this.grpEditions.Location = new System.Drawing.Point(83, 100);
            this.grpEditions.Name = "grpEditions";
            this.grpEditions.Size = new System.Drawing.Size(800, 270);
            this.grpEditions.TabIndex = 14;
            this.grpEditions.TabStop = false;
            this.grpEditions.Text = "Choisir les éditions concernées";
            // 
            // cbx68
            // 
            this.cbx68.AutoSize = true;
            this.cbx68.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx68.Location = new System.Drawing.Point(743, 238);
            this.cbx68.Name = "cbx68";
            this.cbx68.Size = new System.Drawing.Size(51, 26);
            this.cbx68.TabIndex = 1;
            this.cbx68.Text = "68";
            this.cbx68.UseVisualStyleBackColor = true;
            this.cbx68.Click += new System.EventHandler(this.cbx68_Click);
            // 
            // cbx67
            // 
            this.cbx67.AutoSize = true;
            this.cbx67.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx67.Location = new System.Drawing.Point(686, 238);
            this.cbx67.Name = "cbx67";
            this.cbx67.Size = new System.Drawing.Size(51, 26);
            this.cbx67.TabIndex = 0;
            this.cbx67.Text = "67";
            this.cbx67.UseVisualStyleBackColor = true;
            this.cbx67.Click += new System.EventHandler(this.cbx67_Click);
            // 
            // grpDistribution
            // 
            this.grpDistribution.Controls.Add(this.pcbAttNbExemp);
            this.grpDistribution.Controls.Add(this.pcbAttDistrib);
            this.grpDistribution.Controls.Add(this.txtNbExemp);
            this.grpDistribution.Controls.Add(this.lblNbExemp);
            this.grpDistribution.Controls.Add(this.cbxSB);
            this.grpDistribution.Controls.Add(this.cbxVno);
            this.grpDistribution.Controls.Add(this.cbxPorteur);
            this.grpDistribution.Location = new System.Drawing.Point(83, 420);
            this.grpDistribution.Name = "grpDistribution";
            this.grpDistribution.Size = new System.Drawing.Size(800, 135);
            this.grpDistribution.TabIndex = 15;
            this.grpDistribution.TabStop = false;
            this.grpDistribution.Text = "Distribution";
            // 
            // pcbAttNbExemp
            // 
            this.pcbAttNbExemp.Image = ((System.Drawing.Image)(resources.GetObject("pcbAttNbExemp.Image")));
            this.pcbAttNbExemp.Location = new System.Drawing.Point(720, 46);
            this.pcbAttNbExemp.Name = "pcbAttNbExemp";
            this.pcbAttNbExemp.Size = new System.Drawing.Size(50, 50);
            this.pcbAttNbExemp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAttNbExemp.TabIndex = 14;
            this.pcbAttNbExemp.TabStop = false;
            // 
            // pcbAttDistrib
            // 
            this.pcbAttDistrib.Image = ((System.Drawing.Image)(resources.GetObject("pcbAttDistrib.Image")));
            this.pcbAttDistrib.Location = new System.Drawing.Point(25, 46);
            this.pcbAttDistrib.Name = "pcbAttDistrib";
            this.pcbAttDistrib.Size = new System.Drawing.Size(50, 50);
            this.pcbAttDistrib.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAttDistrib.TabIndex = 13;
            this.pcbAttDistrib.TabStop = false;
            // 
            // txtNbExemp
            // 
            this.txtNbExemp.Location = new System.Drawing.Point(594, 57);
            this.txtNbExemp.Name = "txtNbExemp";
            this.txtNbExemp.Size = new System.Drawing.Size(120, 29);
            this.txtNbExemp.TabIndex = 4;
            // 
            // lblNbExemp
            // 
            this.lblNbExemp.AutoSize = true;
            this.lblNbExemp.Location = new System.Drawing.Point(377, 60);
            this.lblNbExemp.Name = "lblNbExemp";
            this.lblNbExemp.Size = new System.Drawing.Size(211, 22);
            this.lblNbExemp.TabIndex = 3;
            this.lblNbExemp.Text = "Nombre d\'exemplaires :";
            // 
            // cbxSB
            // 
            this.cbxSB.AutoSize = true;
            this.cbxSB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxSB.Location = new System.Drawing.Point(106, 92);
            this.cbxSB.Name = "cbxSB";
            this.cbxSB.Size = new System.Drawing.Size(60, 26);
            this.cbxSB.TabIndex = 2;
            this.cbxSB.Text = "S/B";
            this.cbxSB.UseVisualStyleBackColor = true;
            // 
            // cbxVno
            // 
            this.cbxVno.AutoSize = true;
            this.cbxVno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxVno.Location = new System.Drawing.Point(106, 60);
            this.cbxVno.Name = "cbxVno";
            this.cbxVno.Size = new System.Drawing.Size(172, 26);
            this.cbxVno.TabIndex = 1;
            this.cbxVno.Text = "Vente au numéro";
            this.cbxVno.UseVisualStyleBackColor = true;
            // 
            // cbxPorteur
            // 
            this.cbxPorteur.AutoSize = true;
            this.cbxPorteur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxPorteur.Location = new System.Drawing.Point(106, 28);
            this.cbxPorteur.Name = "cbxPorteur";
            this.cbxPorteur.Size = new System.Drawing.Size(91, 26);
            this.cbxPorteur.TabIndex = 0;
            this.cbxPorteur.Text = "Porteur";
            this.cbxPorteur.UseVisualStyleBackColor = true;
            // 
            // btnResetDistrib
            // 
            this.btnResetDistrib.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetDistrib.Location = new System.Drawing.Point(794, 390);
            this.btnResetDistrib.Name = "btnResetDistrib";
            this.btnResetDistrib.Size = new System.Drawing.Size(89, 30);
            this.btnResetDistrib.TabIndex = 17;
            this.btnResetDistrib.Text = "Reset";
            this.btnResetDistrib.UseVisualStyleBackColor = true;
            this.btnResetDistrib.Click += new System.EventHandler(this.btnResetDistrib_Click);
            // 
            // btnResetEdit
            // 
            this.btnResetEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetEdit.Location = new System.Drawing.Point(794, 70);
            this.btnResetEdit.Name = "btnResetEdit";
            this.btnResetEdit.Size = new System.Drawing.Size(89, 30);
            this.btnResetEdit.TabIndex = 16;
            this.btnResetEdit.Text = "Reset";
            this.btnResetEdit.UseVisualStyleBackColor = true;
            this.btnResetEdit.Click += new System.EventHandler(this.btnResetEdit_Click);
            // 
            // pcbAttEditions
            // 
            this.pcbAttEditions.Image = ((System.Drawing.Image)(resources.GetObject("pcbAttEditions.Image")));
            this.pcbAttEditions.Location = new System.Drawing.Point(17, 192);
            this.pcbAttEditions.Name = "pcbAttEditions";
            this.pcbAttEditions.Size = new System.Drawing.Size(50, 50);
            this.pcbAttEditions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAttEditions.TabIndex = 18;
            this.pcbAttEditions.TabStop = false;
            // 
            // lblEdition
            // 
            this.lblEdition.AutoSize = true;
            this.lblEdition.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdition.Location = new System.Drawing.Point(79, 70);
            this.lblEdition.Name = "lblEdition";
            this.lblEdition.Size = new System.Drawing.Size(165, 22);
            this.lblEdition.TabIndex = 19;
            this.lblEdition.Text = "Édition complète";
            // 
            // FicheDistribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblEdition);
            this.Controls.Add(this.pnlTopUC);
            this.Controls.Add(this.grpEditions);
            this.Controls.Add(this.grpDistribution);
            this.Controls.Add(this.pcbAttEditions);
            this.Controls.Add(this.btnResetDistrib);
            this.Controls.Add(this.btnResetEdit);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FicheDistribution";
            this.Size = new System.Drawing.Size(966, 565);
            this.Load += new System.EventHandler(this.FicheDistribution_Load);
            this.pnlTopUC.ResumeLayout(false);
            this.pnlTopUC.PerformLayout();
            this.grpEditions.ResumeLayout(false);
            this.grpEditions.PerformLayout();
            this.grpDistribution.ResumeLayout(false);
            this.grpDistribution.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAttNbExemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAttDistrib)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAttEditions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopUC;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.GroupBox grpEditions;
        private System.Windows.Forms.CheckBox cbx68;
        private System.Windows.Forms.CheckBox cbx67;
        private System.Windows.Forms.GroupBox grpDistribution;
        private System.Windows.Forms.PictureBox pcbAttNbExemp;
        private System.Windows.Forms.PictureBox pcbAttDistrib;
        private System.Windows.Forms.TextBox txtNbExemp;
        private System.Windows.Forms.Label lblNbExemp;
        private System.Windows.Forms.CheckBox cbxSB;
        private System.Windows.Forms.CheckBox cbxVno;
        private System.Windows.Forms.CheckBox cbxPorteur;
        private System.Windows.Forms.PictureBox pcbAttEditions;
        private System.Windows.Forms.Button btnResetDistrib;
        private System.Windows.Forms.Button btnResetEdit;
        private System.Windows.Forms.Label lblEdition;
    }
}
