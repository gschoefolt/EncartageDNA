namespace Encartage
{
    partial class frmStart
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
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.btnMinim = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnQuit = new System.Windows.Forms.Button();
            this.pnlImpression = new System.Windows.Forms.Panel();
            this.pnlPlanEncartage = new System.Windows.Forms.Panel();
            this.lblPlanEncartage = new System.Windows.Forms.Label();
            this.pnlListeEncarts = new System.Windows.Forms.Panel();
            this.lblListeEncarts = new System.Windows.Forms.Label();
            this.pnlNotesPlans = new System.Windows.Forms.Panel();
            this.lblNotesPlans = new System.Windows.Forms.Label();
            this.pnlLine4 = new System.Windows.Forms.Panel();
            this.lblImpression = new System.Windows.Forms.Label();
            this.pnlGestion = new System.Windows.Forms.Panel();
            this.pnlSupprEncart = new System.Windows.Forms.Panel();
            this.lblSupprEncart = new System.Windows.Forms.Label();
            this.pnlSaisieEncart = new System.Windows.Forms.Panel();
            this.lblSaisieEncart = new System.Windows.Forms.Label();
            this.pnlModifEncart = new System.Windows.Forms.Panel();
            this.lblModifEncart = new System.Windows.Forms.Label();
            this.pnlLine3 = new System.Windows.Forms.Panel();
            this.lblGestion = new System.Windows.Forms.Label();
            this.pnlLine2 = new System.Windows.Forms.Panel();
            this.pcbLogoAls = new System.Windows.Forms.PictureBox();
            this.pcbLogoDna = new System.Windows.Forms.PictureBox();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlLine1 = new System.Windows.Forms.Panel();
            this.pnlTopBar.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlImpression.SuspendLayout();
            this.pnlPlanEncartage.SuspendLayout();
            this.pnlListeEncarts.SuspendLayout();
            this.pnlNotesPlans.SuspendLayout();
            this.pnlGestion.SuspendLayout();
            this.pnlSupprEncart.SuspendLayout();
            this.pnlSaisieEncart.SuspendLayout();
            this.pnlModifEncart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoAls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoDna)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlTopBar.Controls.Add(this.btnMinim);
            this.pnlTopBar.Controls.Add(this.btnClose);
            this.pnlTopBar.Controls.Add(this.lblTitre);
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(1280, 40);
            this.pnlTopBar.TabIndex = 0;
            // 
            // btnMinim
            // 
            this.btnMinim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinim.Location = new System.Drawing.Point(1215, 5);
            this.btnMinim.Name = "btnMinim";
            this.btnMinim.Size = new System.Drawing.Size(28, 29);
            this.btnMinim.TabIndex = 3;
            this.btnMinim.Text = "_";
            this.btnMinim.UseVisualStyleBackColor = true;
            this.btnMinim.Click += new System.EventHandler(this.btnMinim_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(1249, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 29);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.White;
            this.lblTitre.Location = new System.Drawing.Point(15, 4);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(290, 32);
            this.lblTitre.TabIndex = 1;
            this.lblTitre.Text = "Encartage DNA / ALS";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.White;
            this.pnlMenu.Controls.Add(this.btnQuit);
            this.pnlMenu.Controls.Add(this.pnlImpression);
            this.pnlMenu.Controls.Add(this.pnlGestion);
            this.pnlMenu.Controls.Add(this.pnlLine2);
            this.pnlMenu.Controls.Add(this.pcbLogoAls);
            this.pnlMenu.Controls.Add(this.pcbLogoDna);
            this.pnlMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlMenu.Location = new System.Drawing.Point(0, 40);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(250, 680);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnQuit
            // 
            this.btnQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuit.Location = new System.Drawing.Point(75, 635);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(100, 35);
            this.btnQuit.TabIndex = 0;
            this.btnQuit.Text = "Quitter";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // pnlImpression
            // 
            this.pnlImpression.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlImpression.Controls.Add(this.pnlPlanEncartage);
            this.pnlImpression.Controls.Add(this.pnlListeEncarts);
            this.pnlImpression.Controls.Add(this.pnlNotesPlans);
            this.pnlImpression.Controls.Add(this.pnlLine4);
            this.pnlImpression.Controls.Add(this.lblImpression);
            this.pnlImpression.Location = new System.Drawing.Point(11, 415);
            this.pnlImpression.Name = "pnlImpression";
            this.pnlImpression.Size = new System.Drawing.Size(230, 197);
            this.pnlImpression.TabIndex = 8;
            // 
            // pnlPlanEncartage
            // 
            this.pnlPlanEncartage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPlanEncartage.Controls.Add(this.lblPlanEncartage);
            this.pnlPlanEncartage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlPlanEncartage.Location = new System.Drawing.Point(-1, 152);
            this.pnlPlanEncartage.Name = "pnlPlanEncartage";
            this.pnlPlanEncartage.Size = new System.Drawing.Size(230, 45);
            this.pnlPlanEncartage.TabIndex = 7;
            this.pnlPlanEncartage.MouseEnter += new System.EventHandler(this.lblSaisieEncart_MouseEnter);
            this.pnlPlanEncartage.MouseLeave += new System.EventHandler(this.lblSaisieEncart_MouseLeave);
            // 
            // lblPlanEncartage
            // 
            this.lblPlanEncartage.AutoSize = true;
            this.lblPlanEncartage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPlanEncartage.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanEncartage.Location = new System.Drawing.Point(2, 11);
            this.lblPlanEncartage.Name = "lblPlanEncartage";
            this.lblPlanEncartage.Size = new System.Drawing.Size(229, 22);
            this.lblPlanEncartage.TabIndex = 2;
            this.lblPlanEncartage.Text = "Plan encartage seulement";
            this.lblPlanEncartage.MouseEnter += new System.EventHandler(this.lblSaisieEncart_MouseEnter);
            this.lblPlanEncartage.MouseLeave += new System.EventHandler(this.lblSaisieEncart_MouseLeave);
            // 
            // pnlListeEncarts
            // 
            this.pnlListeEncarts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlListeEncarts.Controls.Add(this.lblListeEncarts);
            this.pnlListeEncarts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlListeEncarts.Location = new System.Drawing.Point(-1, 42);
            this.pnlListeEncarts.Name = "pnlListeEncarts";
            this.pnlListeEncarts.Size = new System.Drawing.Size(230, 45);
            this.pnlListeEncarts.TabIndex = 6;
            this.pnlListeEncarts.MouseEnter += new System.EventHandler(this.lblSaisieEncart_MouseEnter);
            this.pnlListeEncarts.MouseLeave += new System.EventHandler(this.lblSaisieEncart_MouseLeave);
            // 
            // lblListeEncarts
            // 
            this.lblListeEncarts.AutoSize = true;
            this.lblListeEncarts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblListeEncarts.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListeEncarts.Location = new System.Drawing.Point(40, 11);
            this.lblListeEncarts.Name = "lblListeEncarts";
            this.lblListeEncarts.Size = new System.Drawing.Size(155, 22);
            this.lblListeEncarts.TabIndex = 0;
            this.lblListeEncarts.Text = "Liste des encarts";
            this.lblListeEncarts.MouseEnter += new System.EventHandler(this.lblSaisieEncart_MouseEnter);
            this.lblListeEncarts.MouseLeave += new System.EventHandler(this.lblSaisieEncart_MouseLeave);
            // 
            // pnlNotesPlans
            // 
            this.pnlNotesPlans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNotesPlans.Controls.Add(this.lblNotesPlans);
            this.pnlNotesPlans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlNotesPlans.Location = new System.Drawing.Point(-1, 97);
            this.pnlNotesPlans.Name = "pnlNotesPlans";
            this.pnlNotesPlans.Size = new System.Drawing.Size(230, 45);
            this.pnlNotesPlans.TabIndex = 7;
            this.pnlNotesPlans.MouseEnter += new System.EventHandler(this.lblSaisieEncart_MouseEnter);
            this.pnlNotesPlans.MouseLeave += new System.EventHandler(this.lblSaisieEncart_MouseLeave);
            // 
            // lblNotesPlans
            // 
            this.lblNotesPlans.AutoSize = true;
            this.lblNotesPlans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNotesPlans.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotesPlans.Location = new System.Drawing.Point(5, 11);
            this.lblNotesPlans.Name = "lblNotesPlans";
            this.lblNotesPlans.Size = new System.Drawing.Size(220, 22);
            this.lblNotesPlans.TabIndex = 1;
            this.lblNotesPlans.Text = "Notes et plans encartage";
            this.lblNotesPlans.MouseEnter += new System.EventHandler(this.lblSaisieEncart_MouseEnter);
            this.lblNotesPlans.MouseLeave += new System.EventHandler(this.lblSaisieEncart_MouseLeave);
            // 
            // pnlLine4
            // 
            this.pnlLine4.BackColor = System.Drawing.Color.Black;
            this.pnlLine4.Location = new System.Drawing.Point(0, 40);
            this.pnlLine4.Name = "pnlLine4";
            this.pnlLine4.Size = new System.Drawing.Size(230, 2);
            this.pnlLine4.TabIndex = 5;
            // 
            // lblImpression
            // 
            this.lblImpression.AutoSize = true;
            this.lblImpression.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpression.Location = new System.Drawing.Point(46, 10);
            this.lblImpression.Name = "lblImpression";
            this.lblImpression.Size = new System.Drawing.Size(138, 24);
            this.lblImpression.TabIndex = 0;
            this.lblImpression.Text = "IMPRESSION";
            // 
            // pnlGestion
            // 
            this.pnlGestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGestion.Controls.Add(this.pnlSupprEncart);
            this.pnlGestion.Controls.Add(this.pnlSaisieEncart);
            this.pnlGestion.Controls.Add(this.pnlModifEncart);
            this.pnlGestion.Controls.Add(this.pnlLine3);
            this.pnlGestion.Controls.Add(this.lblGestion);
            this.pnlGestion.Location = new System.Drawing.Point(10, 159);
            this.pnlGestion.Name = "pnlGestion";
            this.pnlGestion.Size = new System.Drawing.Size(230, 197);
            this.pnlGestion.TabIndex = 5;
            // 
            // pnlSupprEncart
            // 
            this.pnlSupprEncart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSupprEncart.Controls.Add(this.lblSupprEncart);
            this.pnlSupprEncart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlSupprEncart.Location = new System.Drawing.Point(-1, 152);
            this.pnlSupprEncart.Name = "pnlSupprEncart";
            this.pnlSupprEncart.Size = new System.Drawing.Size(230, 45);
            this.pnlSupprEncart.TabIndex = 7;
            this.pnlSupprEncart.MouseEnter += new System.EventHandler(this.lblSaisieEncart_MouseEnter);
            this.pnlSupprEncart.MouseLeave += new System.EventHandler(this.lblSaisieEncart_MouseLeave);
            // 
            // lblSupprEncart
            // 
            this.lblSupprEncart.AutoSize = true;
            this.lblSupprEncart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSupprEncart.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupprEncart.Location = new System.Drawing.Point(28, 11);
            this.lblSupprEncart.Name = "lblSupprEncart";
            this.lblSupprEncart.Size = new System.Drawing.Size(174, 22);
            this.lblSupprEncart.TabIndex = 2;
            this.lblSupprEncart.Text = "Suppression encart";
            this.lblSupprEncart.MouseEnter += new System.EventHandler(this.lblSaisieEncart_MouseEnter);
            this.lblSupprEncart.MouseLeave += new System.EventHandler(this.lblSaisieEncart_MouseLeave);
            // 
            // pnlSaisieEncart
            // 
            this.pnlSaisieEncart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSaisieEncart.Controls.Add(this.lblSaisieEncart);
            this.pnlSaisieEncart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlSaisieEncart.Location = new System.Drawing.Point(-1, 42);
            this.pnlSaisieEncart.Name = "pnlSaisieEncart";
            this.pnlSaisieEncart.Size = new System.Drawing.Size(230, 45);
            this.pnlSaisieEncart.TabIndex = 6;
            this.pnlSaisieEncart.Click += new System.EventHandler(this.lblSaisieEncart_Click);
            this.pnlSaisieEncart.MouseEnter += new System.EventHandler(this.lblSaisieEncart_MouseEnter);
            this.pnlSaisieEncart.MouseLeave += new System.EventHandler(this.lblSaisieEncart_MouseLeave);
            // 
            // lblSaisieEncart
            // 
            this.lblSaisieEncart.AutoSize = true;
            this.lblSaisieEncart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSaisieEncart.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaisieEncart.Location = new System.Drawing.Point(55, 11);
            this.lblSaisieEncart.Name = "lblSaisieEncart";
            this.lblSaisieEncart.Size = new System.Drawing.Size(119, 22);
            this.lblSaisieEncart.TabIndex = 0;
            this.lblSaisieEncart.Text = "Saisie encart";
            this.lblSaisieEncart.Click += new System.EventHandler(this.lblSaisieEncart_Click);
            this.lblSaisieEncart.MouseEnter += new System.EventHandler(this.lblSaisieEncart_MouseEnter);
            this.lblSaisieEncart.MouseLeave += new System.EventHandler(this.lblSaisieEncart_MouseLeave);
            // 
            // pnlModifEncart
            // 
            this.pnlModifEncart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlModifEncart.Controls.Add(this.lblModifEncart);
            this.pnlModifEncart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlModifEncart.Location = new System.Drawing.Point(-1, 97);
            this.pnlModifEncart.Name = "pnlModifEncart";
            this.pnlModifEncart.Size = new System.Drawing.Size(230, 45);
            this.pnlModifEncart.TabIndex = 7;
            this.pnlModifEncart.MouseEnter += new System.EventHandler(this.lblSaisieEncart_MouseEnter);
            this.pnlModifEncart.MouseLeave += new System.EventHandler(this.lblSaisieEncart_MouseLeave);
            // 
            // lblModifEncart
            // 
            this.lblModifEncart.AutoSize = true;
            this.lblModifEncart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblModifEncart.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifEncart.Location = new System.Drawing.Point(32, 11);
            this.lblModifEncart.Name = "lblModifEncart";
            this.lblModifEncart.Size = new System.Drawing.Size(168, 22);
            this.lblModifEncart.TabIndex = 1;
            this.lblModifEncart.Text = "Modification encart";
            this.lblModifEncart.MouseEnter += new System.EventHandler(this.lblSaisieEncart_MouseEnter);
            this.lblModifEncart.MouseLeave += new System.EventHandler(this.lblSaisieEncart_MouseLeave);
            // 
            // pnlLine3
            // 
            this.pnlLine3.BackColor = System.Drawing.Color.Black;
            this.pnlLine3.Location = new System.Drawing.Point(0, 40);
            this.pnlLine3.Name = "pnlLine3";
            this.pnlLine3.Size = new System.Drawing.Size(230, 2);
            this.pnlLine3.TabIndex = 5;
            // 
            // lblGestion
            // 
            this.lblGestion.AutoSize = true;
            this.lblGestion.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestion.Location = new System.Drawing.Point(64, 10);
            this.lblGestion.Name = "lblGestion";
            this.lblGestion.Size = new System.Drawing.Size(102, 24);
            this.lblGestion.TabIndex = 0;
            this.lblGestion.Text = "GESTION";
            // 
            // pnlLine2
            // 
            this.pnlLine2.BackColor = System.Drawing.Color.Black;
            this.pnlLine2.Location = new System.Drawing.Point(0, 110);
            this.pnlLine2.Name = "pnlLine2";
            this.pnlLine2.Size = new System.Drawing.Size(250, 2);
            this.pnlLine2.TabIndex = 4;
            // 
            // pcbLogoAls
            // 
            this.pcbLogoAls.Image = global::Encartage.Properties.Resources.logo_Alsace;
            this.pcbLogoAls.Location = new System.Drawing.Point(165, 10);
            this.pcbLogoAls.Name = "pcbLogoAls";
            this.pcbLogoAls.Size = new System.Drawing.Size(82, 87);
            this.pcbLogoAls.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLogoAls.TabIndex = 1;
            this.pcbLogoAls.TabStop = false;
            // 
            // pcbLogoDna
            // 
            this.pcbLogoDna.Image = global::Encartage.Properties.Resources.DNA_Logo;
            this.pcbLogoDna.Location = new System.Drawing.Point(10, 15);
            this.pcbLogoDna.Name = "pcbLogoDna";
            this.pcbLogoDna.Size = new System.Drawing.Size(147, 75);
            this.pcbLogoDna.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLogoDna.TabIndex = 0;
            this.pcbLogoDna.TabStop = false;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlContent.Location = new System.Drawing.Point(254, 40);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1026, 680);
            this.pnlContent.TabIndex = 2;
            // 
            // pnlLine1
            // 
            this.pnlLine1.BackColor = System.Drawing.Color.Black;
            this.pnlLine1.Location = new System.Drawing.Point(251, 40);
            this.pnlLine1.Name = "pnlLine1";
            this.pnlLine1.Size = new System.Drawing.Size(2, 680);
            this.pnlLine1.TabIndex = 0;
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnlLine1);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTopBar);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "frmStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmStart_Load);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlImpression.ResumeLayout(false);
            this.pnlImpression.PerformLayout();
            this.pnlPlanEncartage.ResumeLayout(false);
            this.pnlPlanEncartage.PerformLayout();
            this.pnlListeEncarts.ResumeLayout(false);
            this.pnlListeEncarts.PerformLayout();
            this.pnlNotesPlans.ResumeLayout(false);
            this.pnlNotesPlans.PerformLayout();
            this.pnlGestion.ResumeLayout(false);
            this.pnlGestion.PerformLayout();
            this.pnlSupprEncart.ResumeLayout(false);
            this.pnlSupprEncart.PerformLayout();
            this.pnlSaisieEncart.ResumeLayout(false);
            this.pnlSaisieEncart.PerformLayout();
            this.pnlModifEncart.ResumeLayout(false);
            this.pnlModifEncart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoAls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoDna)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Panel pnlLine1;
        private System.Windows.Forms.PictureBox pcbLogoDna;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.PictureBox pcbLogoAls;
        private System.Windows.Forms.Panel pnlLine2;
        private System.Windows.Forms.Panel pnlGestion;
        private System.Windows.Forms.Label lblGestion;
        private System.Windows.Forms.Panel pnlLine3;
        private System.Windows.Forms.Panel pnlSaisieEncart;
        private System.Windows.Forms.Panel pnlSupprEncart;
        private System.Windows.Forms.Panel pnlModifEncart;
        private System.Windows.Forms.Label lblSaisieEncart;
        private System.Windows.Forms.Label lblModifEncart;
        private System.Windows.Forms.Label lblSupprEncart;
        private System.Windows.Forms.Panel pnlImpression;
        private System.Windows.Forms.Panel pnlPlanEncartage;
        private System.Windows.Forms.Label lblPlanEncartage;
        private System.Windows.Forms.Panel pnlListeEncarts;
        private System.Windows.Forms.Label lblListeEncarts;
        private System.Windows.Forms.Panel pnlNotesPlans;
        private System.Windows.Forms.Label lblNotesPlans;
        private System.Windows.Forms.Panel pnlLine4;
        private System.Windows.Forms.Label lblImpression;
        private System.Windows.Forms.Button btnMinim;
        private System.Windows.Forms.Button btnClose;
    }
}

