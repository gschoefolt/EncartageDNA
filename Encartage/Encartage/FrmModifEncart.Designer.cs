namespace Encartage
{
    partial class FrmModifEncart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.btnModifNom = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblPoids = new System.Windows.Forms.Label();
            this.txtPoids = new System.Windows.Forms.TextBox();
            this.btnModifPoids = new System.Windows.Forms.Button();
            this.lblInitiales = new System.Windows.Forms.Label();
            this.txtInitiales = new System.Windows.Forms.TextBox();
            this.btnModifInitiales = new System.Windows.Forms.Button();
            this.btnMoins = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.txtDateFin = new System.Windows.Forms.TextBox();
            this.lblAu = new System.Windows.Forms.Label();
            this.txtDateDebut = new System.Windows.Forms.TextBox();
            this.lblEncartageNuit = new System.Windows.Forms.Label();
            this.btnModifDates = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.rdbEditCplete = new System.Windows.Forms.RadioButton();
            this.rdbEditPart = new System.Windows.Forms.RadioButton();
            this.btnModifType = new System.Windows.Forms.Button();
            this.grpInfos = new System.Windows.Forms.GroupBox();
            this.grpDistribution = new System.Windows.Forms.GroupBox();
            this.btnModifNbExempPart = new System.Windows.Forms.Button();
            this.txtNbExempPart = new System.Windows.Forms.TextBox();
            this.lblNbExempPart = new System.Windows.Forms.Label();
            this.btnModifNbExemp = new System.Windows.Forms.Button();
            this.txtNbExemp = new System.Windows.Forms.TextBox();
            this.lblNbExemp = new System.Windows.Forms.Label();
            this.btnModifDistribPart = new System.Windows.Forms.Button();
            this.cbxSBPart = new System.Windows.Forms.CheckBox();
            this.cbxVnoPart = new System.Windows.Forms.CheckBox();
            this.cbxPorteurPart = new System.Windows.Forms.CheckBox();
            this.lblDistribPart = new System.Windows.Forms.Label();
            this.btnModifEditPart = new System.Windows.Forms.Button();
            this.txtEditPart = new System.Windows.Forms.TextBox();
            this.lblEditPart = new System.Windows.Forms.Label();
            this.btnModifDistrib = new System.Windows.Forms.Button();
            this.cbxSB = new System.Windows.Forms.CheckBox();
            this.cbxVno = new System.Windows.Forms.CheckBox();
            this.cbxPorteur = new System.Windows.Forms.CheckBox();
            this.lblDistrib = new System.Windows.Forms.Label();
            this.btnModifEditPorteur = new System.Windows.Forms.Button();
            this.txtEditPorteur = new System.Windows.Forms.TextBox();
            this.lblEditPorteur = new System.Windows.Forms.Label();
            this.btnModifEditions = new System.Windows.Forms.Button();
            this.txtEditions = new System.Windows.Forms.TextBox();
            this.lblEditions = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTextes = new System.Windows.Forms.TextBox();
            this.lblTextes = new System.Windows.Forms.Label();
            this.btnModifTextes = new System.Windows.Forms.Button();
            this.pnlTopBar.SuspendLayout();
            this.grpInfos.SuspendLayout();
            this.grpDistribution.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlTopBar.Controls.Add(this.lblTitre);
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(1080, 40);
            this.pnlTopBar.TabIndex = 0;
            this.pnlTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitre_MouseDown);
            this.pnlTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTitre_MouseMove);
            this.pnlTopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblTitre_MouseUp);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTitre.ForeColor = System.Drawing.Color.White;
            this.lblTitre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTitre.Location = new System.Drawing.Point(353, 5);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(374, 32);
            this.lblTitre.TabIndex = 2;
            this.lblTitre.Text = "Fiche modification d\'encart";
            this.lblTitre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitre_MouseDown);
            this.lblTitre.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTitre_MouseMove);
            this.lblTitre.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblTitre_MouseUp);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(49, 109);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(60, 22);
            this.lblNom.TabIndex = 5;
            this.lblNom.Text = "Nom :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(115, 106);
            this.txtNom.Name = "txtNom";
            this.txtNom.ReadOnly = true;
            this.txtNom.Size = new System.Drawing.Size(400, 29);
            this.txtNom.TabIndex = 6;
            // 
            // btnModifNom
            // 
            this.btnModifNom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifNom.Location = new System.Drawing.Point(521, 105);
            this.btnModifNom.Name = "btnModifNom";
            this.btnModifNom.Size = new System.Drawing.Size(109, 30);
            this.btnModifNom.TabIndex = 7;
            this.btnModifNom.Text = "Modifier";
            this.btnModifNom.UseVisualStyleBackColor = true;
            this.btnModifNom.Click += new System.EventHandler(this.btnModifNom_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(20, 654);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 32);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "ANNULER";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblPoids
            // 
            this.lblPoids.AutoSize = true;
            this.lblPoids.Location = new System.Drawing.Point(197, 151);
            this.lblPoids.Name = "lblPoids";
            this.lblPoids.Size = new System.Drawing.Size(69, 22);
            this.lblPoids.TabIndex = 9;
            this.lblPoids.Text = "Poids :";
            // 
            // txtPoids
            // 
            this.txtPoids.Location = new System.Drawing.Point(266, 148);
            this.txtPoids.Name = "txtPoids";
            this.txtPoids.ReadOnly = true;
            this.txtPoids.Size = new System.Drawing.Size(100, 29);
            this.txtPoids.TabIndex = 10;
            // 
            // btnModifPoids
            // 
            this.btnModifPoids.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifPoids.Location = new System.Drawing.Point(372, 147);
            this.btnModifPoids.Name = "btnModifPoids";
            this.btnModifPoids.Size = new System.Drawing.Size(109, 30);
            this.btnModifPoids.TabIndex = 11;
            this.btnModifPoids.Text = "Modifier";
            this.btnModifPoids.UseVisualStyleBackColor = true;
            this.btnModifPoids.Click += new System.EventHandler(this.btnModifPoids_Click);
            // 
            // lblInitiales
            // 
            this.lblInitiales.AutoSize = true;
            this.lblInitiales.Location = new System.Drawing.Point(178, 25);
            this.lblInitiales.Name = "lblInitiales";
            this.lblInitiales.Size = new System.Drawing.Size(84, 22);
            this.lblInitiales.TabIndex = 12;
            this.lblInitiales.Text = "Initiales :";
            // 
            // txtInitiales
            // 
            this.txtInitiales.Location = new System.Drawing.Point(268, 22);
            this.txtInitiales.Name = "txtInitiales";
            this.txtInitiales.ReadOnly = true;
            this.txtInitiales.Size = new System.Drawing.Size(100, 29);
            this.txtInitiales.TabIndex = 13;
            // 
            // btnModifInitiales
            // 
            this.btnModifInitiales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifInitiales.Location = new System.Drawing.Point(374, 21);
            this.btnModifInitiales.Name = "btnModifInitiales";
            this.btnModifInitiales.Size = new System.Drawing.Size(109, 30);
            this.btnModifInitiales.TabIndex = 14;
            this.btnModifInitiales.Text = "Modifier";
            this.btnModifInitiales.UseVisualStyleBackColor = true;
            this.btnModifInitiales.Click += new System.EventHandler(this.btnModifInitiales_Click);
            // 
            // btnMoins
            // 
            this.btnMoins.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoins.Location = new System.Drawing.Point(679, 62);
            this.btnMoins.Name = "btnMoins";
            this.btnMoins.Size = new System.Drawing.Size(33, 33);
            this.btnMoins.TabIndex = 49;
            this.btnMoins.Text = "-";
            this.btnMoins.UseVisualStyleBackColor = true;
            this.btnMoins.Click += new System.EventHandler(this.btnMoins_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlus.Location = new System.Drawing.Point(713, 62);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(33, 33);
            this.btnPlus.TabIndex = 48;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // txtDateFin
            // 
            this.txtDateFin.Location = new System.Drawing.Point(450, 64);
            this.txtDateFin.Name = "txtDateFin";
            this.txtDateFin.ReadOnly = true;
            this.txtDateFin.Size = new System.Drawing.Size(105, 29);
            this.txtDateFin.TabIndex = 47;
            // 
            // lblAu
            // 
            this.lblAu.AutoSize = true;
            this.lblAu.Location = new System.Drawing.Point(420, 67);
            this.lblAu.Name = "lblAu";
            this.lblAu.Size = new System.Drawing.Size(30, 22);
            this.lblAu.TabIndex = 46;
            this.lblAu.Text = "au";
            // 
            // txtDateDebut
            // 
            this.txtDateDebut.Location = new System.Drawing.Point(310, 64);
            this.txtDateDebut.Name = "txtDateDebut";
            this.txtDateDebut.ReadOnly = true;
            this.txtDateDebut.Size = new System.Drawing.Size(105, 29);
            this.txtDateDebut.TabIndex = 45;
            // 
            // lblEncartageNuit
            // 
            this.lblEncartageNuit.AutoSize = true;
            this.lblEncartageNuit.Location = new System.Drawing.Point(83, 67);
            this.lblEncartageNuit.Name = "lblEncartageNuit";
            this.lblEncartageNuit.Size = new System.Drawing.Size(221, 22);
            this.lblEncartageNuit.TabIndex = 44;
            this.lblEncartageNuit.Text = "Encartage dans la nuit du";
            // 
            // btnModifDates
            // 
            this.btnModifDates.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifDates.Location = new System.Drawing.Point(561, 63);
            this.btnModifDates.Name = "btnModifDates";
            this.btnModifDates.Size = new System.Drawing.Size(109, 30);
            this.btnModifDates.TabIndex = 50;
            this.btnModifDates.Text = "Modifier";
            this.btnModifDates.UseVisualStyleBackColor = true;
            this.btnModifDates.Click += new System.EventHandler(this.btnModifDates_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(81, 193);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(67, 22);
            this.lblType.TabIndex = 51;
            this.lblType.Text = "Type : ";
            // 
            // rdbEditCplete
            // 
            this.rdbEditCplete.AutoSize = true;
            this.rdbEditCplete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbEditCplete.Enabled = false;
            this.rdbEditCplete.Location = new System.Drawing.Point(150, 191);
            this.rdbEditCplete.Name = "rdbEditCplete";
            this.rdbEditCplete.Size = new System.Drawing.Size(170, 26);
            this.rdbEditCplete.TabIndex = 52;
            this.rdbEditCplete.TabStop = true;
            this.rdbEditCplete.Text = "Édition complète";
            this.rdbEditCplete.UseVisualStyleBackColor = true;
            // 
            // rdbEditPart
            // 
            this.rdbEditPart.AutoSize = true;
            this.rdbEditPart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbEditPart.Enabled = false;
            this.rdbEditPart.Location = new System.Drawing.Point(326, 191);
            this.rdbEditPart.Name = "rdbEditPart";
            this.rdbEditPart.Size = new System.Drawing.Size(157, 26);
            this.rdbEditPart.TabIndex = 53;
            this.rdbEditPart.TabStop = true;
            this.rdbEditPart.Text = "Édition partielle";
            this.rdbEditPart.UseVisualStyleBackColor = true;
            // 
            // btnModifType
            // 
            this.btnModifType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifType.Location = new System.Drawing.Point(489, 189);
            this.btnModifType.Name = "btnModifType";
            this.btnModifType.Size = new System.Drawing.Size(109, 30);
            this.btnModifType.TabIndex = 54;
            this.btnModifType.Text = "Modifier";
            this.btnModifType.UseVisualStyleBackColor = true;
            this.btnModifType.Click += new System.EventHandler(this.btnModifType_Click);
            // 
            // grpInfos
            // 
            this.grpInfos.Controls.Add(this.btnModifType);
            this.grpInfos.Controls.Add(this.rdbEditPart);
            this.grpInfos.Controls.Add(this.rdbEditCplete);
            this.grpInfos.Controls.Add(this.lblType);
            this.grpInfos.Controls.Add(this.btnModifDates);
            this.grpInfos.Controls.Add(this.btnMoins);
            this.grpInfos.Controls.Add(this.btnPlus);
            this.grpInfos.Controls.Add(this.txtDateFin);
            this.grpInfos.Controls.Add(this.lblAu);
            this.grpInfos.Controls.Add(this.txtDateDebut);
            this.grpInfos.Controls.Add(this.lblEncartageNuit);
            this.grpInfos.Controls.Add(this.btnModifInitiales);
            this.grpInfos.Controls.Add(this.txtInitiales);
            this.grpInfos.Controls.Add(this.lblInitiales);
            this.grpInfos.Controls.Add(this.btnModifPoids);
            this.grpInfos.Controls.Add(this.txtPoids);
            this.grpInfos.Controls.Add(this.lblPoids);
            this.grpInfos.Controls.Add(this.btnModifNom);
            this.grpInfos.Controls.Add(this.txtNom);
            this.grpInfos.Controls.Add(this.lblNom);
            this.grpInfos.Location = new System.Drawing.Point(163, 46);
            this.grpInfos.Name = "grpInfos";
            this.grpInfos.Size = new System.Drawing.Size(752, 230);
            this.grpInfos.TabIndex = 55;
            this.grpInfos.TabStop = false;
            this.grpInfos.Text = "Informations de l\'encart";
            // 
            // grpDistribution
            // 
            this.grpDistribution.Controls.Add(this.btnModifNbExempPart);
            this.grpDistribution.Controls.Add(this.txtNbExempPart);
            this.grpDistribution.Controls.Add(this.lblNbExempPart);
            this.grpDistribution.Controls.Add(this.btnModifNbExemp);
            this.grpDistribution.Controls.Add(this.txtNbExemp);
            this.grpDistribution.Controls.Add(this.lblNbExemp);
            this.grpDistribution.Controls.Add(this.btnModifDistribPart);
            this.grpDistribution.Controls.Add(this.cbxSBPart);
            this.grpDistribution.Controls.Add(this.cbxVnoPart);
            this.grpDistribution.Controls.Add(this.cbxPorteurPart);
            this.grpDistribution.Controls.Add(this.lblDistribPart);
            this.grpDistribution.Controls.Add(this.btnModifEditPart);
            this.grpDistribution.Controls.Add(this.txtEditPart);
            this.grpDistribution.Controls.Add(this.lblEditPart);
            this.grpDistribution.Controls.Add(this.btnModifDistrib);
            this.grpDistribution.Controls.Add(this.cbxSB);
            this.grpDistribution.Controls.Add(this.cbxVno);
            this.grpDistribution.Controls.Add(this.cbxPorteur);
            this.grpDistribution.Controls.Add(this.lblDistrib);
            this.grpDistribution.Controls.Add(this.btnModifEditPorteur);
            this.grpDistribution.Controls.Add(this.txtEditPorteur);
            this.grpDistribution.Controls.Add(this.lblEditPorteur);
            this.grpDistribution.Controls.Add(this.btnModifEditions);
            this.grpDistribution.Controls.Add(this.txtEditions);
            this.grpDistribution.Controls.Add(this.lblEditions);
            this.grpDistribution.Location = new System.Drawing.Point(163, 282);
            this.grpDistribution.Name = "grpDistribution";
            this.grpDistribution.Size = new System.Drawing.Size(752, 310);
            this.grpDistribution.TabIndex = 57;
            this.grpDistribution.TabStop = false;
            this.grpDistribution.Text = "Distribution";
            // 
            // btnModifNbExempPart
            // 
            this.btnModifNbExempPart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifNbExempPart.Location = new System.Drawing.Point(524, 273);
            this.btnModifNbExempPart.Name = "btnModifNbExempPart";
            this.btnModifNbExempPart.Size = new System.Drawing.Size(109, 30);
            this.btnModifNbExempPart.TabIndex = 77;
            this.btnModifNbExempPart.Text = "Modifier";
            this.btnModifNbExempPart.UseVisualStyleBackColor = true;
            this.btnModifNbExempPart.Click += new System.EventHandler(this.btnModifNbExempPart_Click);
            // 
            // txtNbExempPart
            // 
            this.txtNbExempPart.Location = new System.Drawing.Point(418, 274);
            this.txtNbExempPart.Name = "txtNbExempPart";
            this.txtNbExempPart.ReadOnly = true;
            this.txtNbExempPart.Size = new System.Drawing.Size(100, 29);
            this.txtNbExempPart.TabIndex = 76;
            // 
            // lblNbExempPart
            // 
            this.lblNbExempPart.AutoSize = true;
            this.lblNbExempPart.Location = new System.Drawing.Point(120, 277);
            this.lblNbExempPart.Name = "lblNbExempPart";
            this.lblNbExempPart.Size = new System.Drawing.Size(292, 22);
            this.lblNbExempPart.TabIndex = 75;
            this.lblNbExempPart.Text = "Nombre d\'exemplaires partielles :";
            // 
            // btnModifNbExemp
            // 
            this.btnModifNbExemp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifNbExemp.Location = new System.Drawing.Point(482, 105);
            this.btnModifNbExemp.Name = "btnModifNbExemp";
            this.btnModifNbExemp.Size = new System.Drawing.Size(109, 30);
            this.btnModifNbExemp.TabIndex = 74;
            this.btnModifNbExemp.Text = "Modifier";
            this.btnModifNbExemp.UseVisualStyleBackColor = true;
            this.btnModifNbExemp.Click += new System.EventHandler(this.btnModifNbExemp_Click);
            // 
            // txtNbExemp
            // 
            this.txtNbExemp.Location = new System.Drawing.Point(376, 106);
            this.txtNbExemp.Name = "txtNbExemp";
            this.txtNbExemp.ReadOnly = true;
            this.txtNbExemp.Size = new System.Drawing.Size(100, 29);
            this.txtNbExemp.TabIndex = 73;
            // 
            // lblNbExemp
            // 
            this.lblNbExemp.AutoSize = true;
            this.lblNbExemp.Location = new System.Drawing.Point(162, 109);
            this.lblNbExemp.Name = "lblNbExemp";
            this.lblNbExemp.Size = new System.Drawing.Size(211, 22);
            this.lblNbExemp.TabIndex = 72;
            this.lblNbExemp.Text = "Nombre d\'exemplaires :";
            // 
            // btnModifDistribPart
            // 
            this.btnModifDistribPart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifDistribPart.Location = new System.Drawing.Point(502, 231);
            this.btnModifDistribPart.Name = "btnModifDistribPart";
            this.btnModifDistribPart.Size = new System.Drawing.Size(109, 30);
            this.btnModifDistribPart.TabIndex = 71;
            this.btnModifDistribPart.Text = "Modifier";
            this.btnModifDistribPart.UseVisualStyleBackColor = true;
            this.btnModifDistribPart.Click += new System.EventHandler(this.btnModifDistribPart_Click);
            // 
            // cbxSBPart
            // 
            this.cbxSBPart.AutoSize = true;
            this.cbxSBPart.Enabled = false;
            this.cbxSBPart.Location = new System.Drawing.Point(436, 234);
            this.cbxSBPart.Name = "cbxSBPart";
            this.cbxSBPart.Size = new System.Drawing.Size(60, 26);
            this.cbxSBPart.TabIndex = 70;
            this.cbxSBPart.Text = "S/B";
            this.cbxSBPart.UseVisualStyleBackColor = true;
            // 
            // cbxVnoPart
            // 
            this.cbxVnoPart.AutoSize = true;
            this.cbxVnoPart.Enabled = false;
            this.cbxVnoPart.Location = new System.Drawing.Point(360, 234);
            this.cbxVnoPart.Name = "cbxVnoPart";
            this.cbxVnoPart.Size = new System.Drawing.Size(70, 26);
            this.cbxVnoPart.TabIndex = 69;
            this.cbxVnoPart.Text = "VNO";
            this.cbxVnoPart.UseVisualStyleBackColor = true;
            // 
            // cbxPorteurPart
            // 
            this.cbxPorteurPart.AutoSize = true;
            this.cbxPorteurPart.Enabled = false;
            this.cbxPorteurPart.Location = new System.Drawing.Point(263, 234);
            this.cbxPorteurPart.Name = "cbxPorteurPart";
            this.cbxPorteurPart.Size = new System.Drawing.Size(91, 26);
            this.cbxPorteurPart.TabIndex = 68;
            this.cbxPorteurPart.Text = "Porteur";
            this.cbxPorteurPart.UseVisualStyleBackColor = true;
            // 
            // lblDistribPart
            // 
            this.lblDistribPart.AutoSize = true;
            this.lblDistribPart.Location = new System.Drawing.Point(72, 235);
            this.lblDistribPart.Name = "lblDistribPart";
            this.lblDistribPart.Size = new System.Drawing.Size(185, 22);
            this.lblDistribPart.TabIndex = 67;
            this.lblDistribPart.Text = "Distribution partielle :";
            // 
            // btnModifEditPart
            // 
            this.btnModifEditPart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifEditPart.Location = new System.Drawing.Point(596, 189);
            this.btnModifEditPart.Name = "btnModifEditPart";
            this.btnModifEditPart.Size = new System.Drawing.Size(109, 30);
            this.btnModifEditPart.TabIndex = 66;
            this.btnModifEditPart.Text = "Modifier";
            this.btnModifEditPart.UseVisualStyleBackColor = true;
            this.btnModifEditPart.Click += new System.EventHandler(this.btnModifEditPart_Click);
            // 
            // txtEditPart
            // 
            this.txtEditPart.Location = new System.Drawing.Point(208, 190);
            this.txtEditPart.Name = "txtEditPart";
            this.txtEditPart.ReadOnly = true;
            this.txtEditPart.Size = new System.Drawing.Size(382, 29);
            this.txtEditPart.TabIndex = 65;
            // 
            // lblEditPart
            // 
            this.lblEditPart.AutoSize = true;
            this.lblEditPart.Location = new System.Drawing.Point(33, 193);
            this.lblEditPart.Name = "lblEditPart";
            this.lblEditPart.Size = new System.Drawing.Size(169, 22);
            this.lblEditPart.TabIndex = 64;
            this.lblEditPart.Text = "Éditions partielles :";
            // 
            // btnModifDistrib
            // 
            this.btnModifDistrib.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifDistrib.Location = new System.Drawing.Point(501, 63);
            this.btnModifDistrib.Name = "btnModifDistrib";
            this.btnModifDistrib.Size = new System.Drawing.Size(109, 30);
            this.btnModifDistrib.TabIndex = 63;
            this.btnModifDistrib.Text = "Modifier";
            this.btnModifDistrib.UseVisualStyleBackColor = true;
            this.btnModifDistrib.Click += new System.EventHandler(this.btnModifDistrib_Click);
            // 
            // cbxSB
            // 
            this.cbxSB.AutoSize = true;
            this.cbxSB.Enabled = false;
            this.cbxSB.Location = new System.Drawing.Point(435, 66);
            this.cbxSB.Name = "cbxSB";
            this.cbxSB.Size = new System.Drawing.Size(60, 26);
            this.cbxSB.TabIndex = 62;
            this.cbxSB.Text = "S/B";
            this.cbxSB.UseVisualStyleBackColor = true;
            // 
            // cbxVno
            // 
            this.cbxVno.AutoSize = true;
            this.cbxVno.Enabled = false;
            this.cbxVno.Location = new System.Drawing.Point(359, 66);
            this.cbxVno.Name = "cbxVno";
            this.cbxVno.Size = new System.Drawing.Size(70, 26);
            this.cbxVno.TabIndex = 61;
            this.cbxVno.Text = "VNO";
            this.cbxVno.UseVisualStyleBackColor = true;
            // 
            // cbxPorteur
            // 
            this.cbxPorteur.AutoSize = true;
            this.cbxPorteur.Enabled = false;
            this.cbxPorteur.Location = new System.Drawing.Point(262, 66);
            this.cbxPorteur.Name = "cbxPorteur";
            this.cbxPorteur.Size = new System.Drawing.Size(91, 26);
            this.cbxPorteur.TabIndex = 60;
            this.cbxPorteur.Text = "Porteur";
            this.cbxPorteur.UseVisualStyleBackColor = true;
            // 
            // lblDistrib
            // 
            this.lblDistrib.AutoSize = true;
            this.lblDistrib.Location = new System.Drawing.Point(142, 67);
            this.lblDistrib.Name = "lblDistrib";
            this.lblDistrib.Size = new System.Drawing.Size(114, 22);
            this.lblDistrib.TabIndex = 59;
            this.lblDistrib.Text = "Distribution :";
            // 
            // btnModifEditPorteur
            // 
            this.btnModifEditPorteur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifEditPorteur.Location = new System.Drawing.Point(596, 147);
            this.btnModifEditPorteur.Name = "btnModifEditPorteur";
            this.btnModifEditPorteur.Size = new System.Drawing.Size(109, 30);
            this.btnModifEditPorteur.TabIndex = 58;
            this.btnModifEditPorteur.Text = "Modifier";
            this.btnModifEditPorteur.UseVisualStyleBackColor = true;
            this.btnModifEditPorteur.Click += new System.EventHandler(this.btnModifEditPorteur_Click);
            // 
            // txtEditPorteur
            // 
            this.txtEditPorteur.Location = new System.Drawing.Point(208, 148);
            this.txtEditPorteur.Name = "txtEditPorteur";
            this.txtEditPorteur.ReadOnly = true;
            this.txtEditPorteur.Size = new System.Drawing.Size(382, 29);
            this.txtEditPorteur.TabIndex = 57;
            // 
            // lblEditPorteur
            // 
            this.lblEditPorteur.AutoSize = true;
            this.lblEditPorteur.Location = new System.Drawing.Point(49, 151);
            this.lblEditPorteur.Name = "lblEditPorteur";
            this.lblEditPorteur.Size = new System.Drawing.Size(153, 22);
            this.lblEditPorteur.TabIndex = 56;
            this.lblEditPorteur.Text = "Éditions porteur :";
            // 
            // btnModifEditions
            // 
            this.btnModifEditions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifEditions.Location = new System.Drawing.Point(563, 21);
            this.btnModifEditions.Name = "btnModifEditions";
            this.btnModifEditions.Size = new System.Drawing.Size(109, 30);
            this.btnModifEditions.TabIndex = 55;
            this.btnModifEditions.Text = "Modifier";
            this.btnModifEditions.UseVisualStyleBackColor = true;
            this.btnModifEditions.Click += new System.EventHandler(this.btnModifEditions_Click);
            // 
            // txtEditions
            // 
            this.txtEditions.Location = new System.Drawing.Point(175, 22);
            this.txtEditions.Name = "txtEditions";
            this.txtEditions.ReadOnly = true;
            this.txtEditions.Size = new System.Drawing.Size(382, 29);
            this.txtEditions.TabIndex = 1;
            // 
            // lblEditions
            // 
            this.lblEditions.AutoSize = true;
            this.lblEditions.Location = new System.Drawing.Point(81, 25);
            this.lblEditions.Name = "lblEditions";
            this.lblEditions.Size = new System.Drawing.Size(88, 22);
            this.lblEditions.TabIndex = 0;
            this.lblEditions.Text = "Éditions :";
            // 
            // btnValider
            // 
            this.btnValider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValider.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.Location = new System.Drawing.Point(940, 654);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(120, 32);
            this.btnValider.TabIndex = 58;
            this.btnValider.Text = "VALIDER";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Visible = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnModifTextes);
            this.groupBox1.Controls.Add(this.lblTextes);
            this.groupBox1.Controls.Add(this.txtTextes);
            this.groupBox1.Location = new System.Drawing.Point(163, 598);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(752, 81);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Textes";
            // 
            // txtTextes
            // 
            this.txtTextes.Location = new System.Drawing.Point(87, 36);
            this.txtTextes.Multiline = true;
            this.txtTextes.Name = "txtTextes";
            this.txtTextes.ReadOnly = true;
            this.txtTextes.Size = new System.Drawing.Size(546, 29);
            this.txtTextes.TabIndex = 78;
            // 
            // lblTextes
            // 
            this.lblTextes.AutoSize = true;
            this.lblTextes.Location = new System.Drawing.Point(6, 39);
            this.lblTextes.Name = "lblTextes";
            this.lblTextes.Size = new System.Drawing.Size(76, 22);
            this.lblTextes.TabIndex = 79;
            this.lblTextes.Text = "Textes :";
            // 
            // btnModifTextes
            // 
            this.btnModifTextes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifTextes.Location = new System.Drawing.Point(637, 35);
            this.btnModifTextes.Name = "btnModifTextes";
            this.btnModifTextes.Size = new System.Drawing.Size(109, 30);
            this.btnModifTextes.TabIndex = 78;
            this.btnModifTextes.Text = "Modifier";
            this.btnModifTextes.UseVisualStyleBackColor = true;
            this.btnModifTextes.Click += new System.EventHandler(this.btnModifTextes_Click);
            // 
            // FrmModifEncart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1078, 698);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.grpDistribution);
            this.Controls.Add(this.grpInfos);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pnlTopBar);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmModifEncart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FrmModifEncart_Load);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.grpInfos.ResumeLayout(false);
            this.grpInfos.PerformLayout();
            this.grpDistribution.ResumeLayout(false);
            this.grpDistribution.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Button btnModifNom;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblPoids;
        private System.Windows.Forms.TextBox txtPoids;
        private System.Windows.Forms.Button btnModifPoids;
        private System.Windows.Forms.Label lblInitiales;
        private System.Windows.Forms.TextBox txtInitiales;
        private System.Windows.Forms.Button btnModifInitiales;
        private System.Windows.Forms.Button btnMoins;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.TextBox txtDateFin;
        private System.Windows.Forms.Label lblAu;
        private System.Windows.Forms.TextBox txtDateDebut;
        private System.Windows.Forms.Label lblEncartageNuit;
        private System.Windows.Forms.Button btnModifDates;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.RadioButton rdbEditCplete;
        private System.Windows.Forms.RadioButton rdbEditPart;
        private System.Windows.Forms.Button btnModifType;
        private System.Windows.Forms.GroupBox grpInfos;
        private System.Windows.Forms.GroupBox grpDistribution;
        private System.Windows.Forms.TextBox txtEditions;
        private System.Windows.Forms.Label lblEditions;
        private System.Windows.Forms.Button btnModifEditions;
        private System.Windows.Forms.Button btnModifEditPorteur;
        private System.Windows.Forms.TextBox txtEditPorteur;
        private System.Windows.Forms.Label lblEditPorteur;
        private System.Windows.Forms.CheckBox cbxSB;
        private System.Windows.Forms.CheckBox cbxVno;
        private System.Windows.Forms.CheckBox cbxPorteur;
        private System.Windows.Forms.Label lblDistrib;
        private System.Windows.Forms.Button btnModifDistrib;
        private System.Windows.Forms.Button btnModifEditPart;
        private System.Windows.Forms.TextBox txtEditPart;
        private System.Windows.Forms.Label lblEditPart;
        private System.Windows.Forms.Button btnModifDistribPart;
        private System.Windows.Forms.CheckBox cbxSBPart;
        private System.Windows.Forms.CheckBox cbxVnoPart;
        private System.Windows.Forms.CheckBox cbxPorteurPart;
        private System.Windows.Forms.Label lblDistribPart;
        private System.Windows.Forms.Label lblNbExemp;
        private System.Windows.Forms.Button btnModifNbExemp;
        private System.Windows.Forms.TextBox txtNbExemp;
        private System.Windows.Forms.Label lblNbExempPart;
        private System.Windows.Forms.Button btnModifNbExempPart;
        private System.Windows.Forms.TextBox txtNbExempPart;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnModifTextes;
        private System.Windows.Forms.Label lblTextes;
        private System.Windows.Forms.TextBox txtTextes;
    }
}