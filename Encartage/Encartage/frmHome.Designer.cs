namespace Encartage
{
    partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.btnMinim = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlModifEncart = new System.Windows.Forms.Panel();
            this.lblModifEncart = new System.Windows.Forms.Label();
            this.pnlSaisieEncart = new System.Windows.Forms.Panel();
            this.lblSaisieEncart = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.pnlImpression = new System.Windows.Forms.Panel();
            this.lblImpression = new System.Windows.Forms.Label();
            this.pnlLine2 = new System.Windows.Forms.Panel();
            this.pcbLogoAls = new System.Windows.Forms.PictureBox();
            this.pcbLogoDna = new System.Windows.Forms.PictureBox();
            this.pnlLine1 = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlTopBar.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlModifEncart.SuspendLayout();
            this.pnlSaisieEncart.SuspendLayout();
            this.pnlImpression.SuspendLayout();
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
            resources.ApplyResources(this.pnlTopBar, "pnlTopBar");
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitre_MouseDown);
            this.pnlTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTitre_MouseMove);
            this.pnlTopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblTitre_MouseUp);
            // 
            // btnMinim
            // 
            this.btnMinim.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnMinim, "btnMinim");
            this.btnMinim.Name = "btnMinim";
            this.btnMinim.UseVisualStyleBackColor = true;
            this.btnMinim.Click += new System.EventHandler(this.btnMinim_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitre
            // 
            resources.ApplyResources(this.lblTitre, "lblTitre");
            this.lblTitre.ForeColor = System.Drawing.Color.White;
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitre_MouseDown);
            this.lblTitre.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTitre_MouseMove);
            this.lblTitre.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblTitre_MouseUp);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.pnlMenu.Controls.Add(this.pnlModifEncart);
            this.pnlMenu.Controls.Add(this.pnlSaisieEncart);
            this.pnlMenu.Controls.Add(this.btnQuit);
            this.pnlMenu.Controls.Add(this.pnlImpression);
            this.pnlMenu.Controls.Add(this.pnlLine2);
            this.pnlMenu.Controls.Add(this.pcbLogoAls);
            this.pnlMenu.Controls.Add(this.pcbLogoDna);
            this.pnlMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.pnlMenu, "pnlMenu");
            this.pnlMenu.Name = "pnlMenu";
            // 
            // pnlModifEncart
            // 
            this.pnlModifEncart.BackColor = System.Drawing.Color.White;
            this.pnlModifEncart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlModifEncart.Controls.Add(this.lblModifEncart);
            this.pnlModifEncart.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.pnlModifEncart, "pnlModifEncart");
            this.pnlModifEncart.Name = "pnlModifEncart";
            this.pnlModifEncart.Click += new System.EventHandler(this.lblModifEncart_Click);
            this.pnlModifEncart.MouseEnter += new System.EventHandler(this.lblImpression_MouseEnter);
            this.pnlModifEncart.MouseLeave += new System.EventHandler(this.lblImpression_MouseLeave);
            // 
            // lblModifEncart
            // 
            resources.ApplyResources(this.lblModifEncart, "lblModifEncart");
            this.lblModifEncart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblModifEncart.Name = "lblModifEncart";
            this.lblModifEncart.Click += new System.EventHandler(this.lblModifEncart_Click);
            this.lblModifEncart.MouseEnter += new System.EventHandler(this.lblImpression_MouseEnter);
            this.lblModifEncart.MouseLeave += new System.EventHandler(this.lblImpression_MouseLeave);
            // 
            // pnlSaisieEncart
            // 
            this.pnlSaisieEncart.BackColor = System.Drawing.Color.White;
            this.pnlSaisieEncart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSaisieEncart.Controls.Add(this.lblSaisieEncart);
            this.pnlSaisieEncart.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.pnlSaisieEncart, "pnlSaisieEncart");
            this.pnlSaisieEncart.Name = "pnlSaisieEncart";
            this.pnlSaisieEncart.Click += new System.EventHandler(this.lblSaisieEncart_Click);
            this.pnlSaisieEncart.MouseEnter += new System.EventHandler(this.lblImpression_MouseEnter);
            this.pnlSaisieEncart.MouseLeave += new System.EventHandler(this.lblImpression_MouseLeave);
            // 
            // lblSaisieEncart
            // 
            resources.ApplyResources(this.lblSaisieEncart, "lblSaisieEncart");
            this.lblSaisieEncart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSaisieEncart.Name = "lblSaisieEncart";
            this.lblSaisieEncart.Click += new System.EventHandler(this.lblSaisieEncart_Click);
            this.lblSaisieEncart.MouseEnter += new System.EventHandler(this.lblImpression_MouseEnter);
            this.lblSaisieEncart.MouseLeave += new System.EventHandler(this.lblImpression_MouseLeave);
            // 
            // btnQuit
            // 
            this.btnQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnQuit, "btnQuit");
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlImpression
            // 
            this.pnlImpression.BackColor = System.Drawing.Color.White;
            this.pnlImpression.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlImpression.Controls.Add(this.lblImpression);
            this.pnlImpression.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.pnlImpression, "pnlImpression");
            this.pnlImpression.Name = "pnlImpression";
            this.pnlImpression.Click += new System.EventHandler(this.lblImpression_Click);
            this.pnlImpression.MouseEnter += new System.EventHandler(this.lblImpression_MouseEnter);
            this.pnlImpression.MouseLeave += new System.EventHandler(this.lblImpression_MouseLeave);
            // 
            // lblImpression
            // 
            resources.ApplyResources(this.lblImpression, "lblImpression");
            this.lblImpression.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblImpression.Name = "lblImpression";
            this.lblImpression.Click += new System.EventHandler(this.lblImpression_Click);
            this.lblImpression.MouseEnter += new System.EventHandler(this.lblImpression_MouseEnter);
            this.lblImpression.MouseLeave += new System.EventHandler(this.lblImpression_MouseLeave);
            // 
            // pnlLine2
            // 
            this.pnlLine2.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.pnlLine2, "pnlLine2");
            this.pnlLine2.Name = "pnlLine2";
            // 
            // pcbLogoAls
            // 
            this.pcbLogoAls.Image = global::Encartage.Properties.Resources.Logo_ALS_Gris;
            resources.ApplyResources(this.pcbLogoAls, "pcbLogoAls");
            this.pcbLogoAls.Name = "pcbLogoAls";
            this.pcbLogoAls.TabStop = false;
            // 
            // pcbLogoDna
            // 
            this.pcbLogoDna.Image = global::Encartage.Properties.Resources.Logo_DNA_Gris;
            resources.ApplyResources(this.pcbLogoDna, "pcbLogoDna");
            this.pcbLogoDna.Name = "pcbLogoDna";
            this.pcbLogoDna.TabStop = false;
            // 
            // pnlLine1
            // 
            this.pnlLine1.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.pnlLine1, "pnlLine1");
            this.pnlLine1.Name = "pnlLine1";
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.pnlContent.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.pnlContent, "pnlContent");
            this.pnlContent.Name = "pnlContent";
            // 
            // FrmHome
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.pnlLine1);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.pnlContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmHome";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlModifEncart.ResumeLayout(false);
            this.pnlModifEncart.PerformLayout();
            this.pnlSaisieEncart.ResumeLayout(false);
            this.pnlSaisieEncart.PerformLayout();
            this.pnlImpression.ResumeLayout(false);
            this.pnlImpression.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoAls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoDna)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Button btnMinim;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Panel pnlImpression;
        private System.Windows.Forms.Label lblImpression;
        private System.Windows.Forms.Panel pnlLine2;
        private System.Windows.Forms.PictureBox pcbLogoAls;
        private System.Windows.Forms.PictureBox pcbLogoDna;
        private System.Windows.Forms.Panel pnlLine1;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlSaisieEncart;
        private System.Windows.Forms.Label lblSaisieEncart;
        private System.Windows.Forms.Panel pnlModifEncart;
        private System.Windows.Forms.Label lblModifEncart;
    }
}

