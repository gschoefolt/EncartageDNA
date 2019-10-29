namespace Encartage
{
    partial class UCNombreCopie
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
            this.txtCompte = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMoins = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCompte
            // 
            this.txtCompte.Location = new System.Drawing.Point(42, 5);
            this.txtCompte.Name = "txtCompte";
            this.txtCompte.ReadOnly = true;
            this.txtCompte.Size = new System.Drawing.Size(50, 29);
            this.txtCompte.TabIndex = 0;
            this.txtCompte.Text = "1";
            this.txtCompte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPlus
            // 
            this.btnPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlus.Location = new System.Drawing.Point(98, 3);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(33, 33);
            this.btnPlus.TabIndex = 1;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMoins
            // 
            this.btnMoins.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoins.Location = new System.Drawing.Point(3, 3);
            this.btnMoins.Name = "btnMoins";
            this.btnMoins.Size = new System.Drawing.Size(33, 33);
            this.btnMoins.TabIndex = 2;
            this.btnMoins.Text = "-";
            this.btnMoins.UseVisualStyleBackColor = true;
            this.btnMoins.Click += new System.EventHandler(this.btnMoins_Click);
            // 
            // UCNombreCopie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnMoins);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.txtCompte);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "UCNombreCopie";
            this.Size = new System.Drawing.Size(135, 40);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCompte;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMoins;
    }
}
