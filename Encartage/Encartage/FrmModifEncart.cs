using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encartage
{
    public partial class FrmModifEncart : Form
    {
        /* @Variables : Pour le mouvement du formulaire */
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);


        /* @Variables */
        private Dictionary<string, string> dicoActuel;
        private DateTime dtDebut;
        private DateTime dtFin;


        /* Constructor : Constructeur du formulaire de modification d'encart */
        public FrmModifEncart(Dictionary<string, string> dico)
        {
            dicoActuel = new Dictionary<string, string>(dico);
            InitializeComponent();
        }



        /* @Event (Form) : Load du formulaire */
        private void FrmModifEncart_Load(object sender, EventArgs e)
        {
            this.ActiveControl = lblTitre;
            buildForm();
        }


        #region Click sur les boutons pour modifier
        /* @Event (Bouton) : Click sur le bouton pour modifier les initiales */
        private void btnModifInitiales_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if(b.Text == "Modifier")
            {
                txtInitiales.ReadOnly = false;
                b.Text = "Valider";
                this.ActiveControl = txtInitiales;
            }
            else if(b.Text == "Valider")
            {
                txtInitiales.ReadOnly = true;
                if(dicoActuel["initiales"] != txtInitiales.Text)
                {
                    btnValider.Visible = true;
                    dicoActuel["initiales"] = txtInitiales.Text;
                }
                b.Text = "Modifier";
            }
        }

        /* @Event (Bouton) : Click sur le bouton pour modifer les dates */
        private void btnModifDates_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if(b.Text == "Modifier")
            {
                txtDateDebut.ReadOnly = false;
                txtDateFin.ReadOnly = false;
                b.Text = "Valider";
                btnMoins.Visible = true;
                btnPlus.Visible = true;
            }
            else if(b.Text == "Valider")
            {
                if (verifDates())
                {
                    txtDateDebut.ReadOnly = true;
                    txtDateFin.ReadOnly = true;
                    btnMoins.Visible = false;
                    btnPlus.Visible = false;
                    if (dicoActuel["dateDebut"] != txtDateDebut.Text || dicoActuel["dateFin"] != txtDateFin.Text)
                    {
                        btnValider.Visible = true;
                        dicoActuel["dateDebut"] = txtDateDebut.Text.Replace('/', '.');
                        dicoActuel["dateFin"] = txtDateFin.Text.Replace('/', '.');
                    }
                    b.Text = "Modifier";
                }
            }
        }

        /* @Event (Bouton) : Click sur le bouton pour modifier le nom */
        private void btnModifNom_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if(b.Text == "Modifier")
            {
                txtNom.ReadOnly = false;
                b.Text = "Valider";
                this.ActiveControl = txtNom;
            }
            else if(b.Text == "Valider")
            {
                txtNom.ReadOnly = true;
                if(dicoActuel["nom"] != txtNom.Text)
                {
                    btnValider.Visible = true;
                    dicoActuel["nom"] = txtNom.Text;
                }
                b.Text = "Modifier";
            }
        }

        /* @Event (Bouton) : Click sur le bouton pour modifier le poids */
        private void btnModifPoids_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Modifier")
            {
                txtPoids.ReadOnly = false;
                b.Text = "Valider";
                this.ActiveControl = txtPoids;
            }
            else if (b.Text == "Valider")
            {
                txtPoids.ReadOnly = true;
                if(dicoActuel["poids"] != txtPoids.Text)
                {
                    btnValider.Visible = true;
                    dicoActuel["poids"] = txtPoids.Text;
                }
                b.Text = "Modifier";
            }
        }

        /* @Event (Bouton) : Click sur le bouton pour modifier le type */
        private void btnModifType_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Modifier")
            {
                rdbEditCplete.Enabled = true;
                rdbEditPart.Enabled = true;
                b.Text = "Valider";
            }
            else if (b.Text == "Valider")
            {
                rdbEditCplete.Enabled = false;
                rdbEditPart.Enabled = false;
                if(dicoActuel["type"] == "P" && rdbEditCplete.Checked)
                {
                    btnValider.Visible = true;
                    dicoActuel["type"] = "C";
                }
                else if(dicoActuel["type"] == "C" && rdbEditPart.Checked)
                {
                    btnValider.Visible = true;
                    dicoActuel["type"] = "P";
                }
                b.Text = "Modifier";
            }
        }

        /* @Event (Bouton) : Click sur le bouton pour modifier les éditions */
        private void btnModifEditions_Click(object sender, EventArgs e)
        {
            FrmModifEditions frmEdit = new FrmModifEditions(dicoActuel, -1);
            if(frmEdit.ShowDialog() == DialogResult.Yes)
            {
                //Il y a eu un changement
                dicoActuel = new Dictionary<string, string>(frmEdit.dictInfos);
                buildForm();
                btnValider.Visible = true;
            }
        }

        /* @Event (Bouton) : Click sur le bouton pour modifier la distribution */
        private void btnModifDistrib_Click(object sender, EventArgs e)
        {

        }

        /*@Event (Bouton) : Click sur le bouton pour modifier le nombre d'exemplaires partielles */
        private void btnModifNbExemp_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Modifier")
            {
                txtNbExemp.ReadOnly = false;
                b.Text = "Valider";
                this.ActiveControl = txtNbExemp;
            }
            else if (b.Text == "Valider")
            {
                txtNbExemp.ReadOnly = true;
                if (dicoActuel["nbExemp"] != txtNbExemp.Text)
                {
                    btnValider.Visible = true;
                    dicoActuel["nbExemp"] = txtNbExemp.Text;
                }
                b.Text = "Modifier";
            }
        }

        /* @Event (Bouton) : Click sur le bouton pour modifier les éditions porteurs */
        private void btnModifEditPorteur_Click(object sender, EventArgs e)
        {
            FrmModifEditions frmEdit = new FrmModifEditions(dicoActuel, 0);
            if (frmEdit.ShowDialog() == DialogResult.Yes)
            {
                //Il y a eu un changement
                dicoActuel = new Dictionary<string, string>(frmEdit.dictInfos);
                buildForm();
                btnValider.Visible = true;
            }
        }

        /* @Event (Bouton) : Click sur le bouton pour modifier les éditions partielles */
        private void btnModifEditPart_Click(object sender, EventArgs e)
        {
            FrmModifEditions frmEdit = new FrmModifEditions(dicoActuel, 1);
            if (frmEdit.ShowDialog() == DialogResult.Yes)
            {
                //Il y a eu un changement
                dicoActuel = new Dictionary<string, string>(frmEdit.dictInfos);
                buildForm();
                btnValider.Visible = true;
            }
        }

        /* @Event (Bouton) : Click sur le bouton pour modifier la distribution partielle */
        private void btnModifDistribPart_Click(object sender, EventArgs e)
        {

        }

        /* @Event (Bouton) : Click sur le bouton pour modifier le nombre d'exemplaires */
        private void btnModifNbExempPart_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Modifier")
            {
                txtNbExempPart.ReadOnly = false;
                b.Text = "Valider";
                this.ActiveControl = txtNbExempPart;
            }
            else if (b.Text == "Valider")
            {
                txtNbExempPart.ReadOnly = true;
                if (dicoActuel["nbExempPartielle"] != txtNbExempPart.Text)
                {
                    btnValider.Visible = true;
                    dicoActuel["nbExempPartielle"] = txtNbExempPart.Text;
                }
                b.Text = "Modifier";
            }
        }

        /* @Event (Bouton) : Click sur le bouton pour modifier les textes */
        private void btnModifTextes_Click(object sender, EventArgs e)
        {
            
        }
        #endregion


        /* @Event (Bouton) : Click sur le bouton pour enlever un jour aux dates */
        private void btnMoins_Click(object sender, EventArgs e)
        {
            if (verifDates())
            {
                txtDateDebut.Text = dtDebut.AddDays(-1).ToShortDateString();
                txtDateFin.Text = dtFin.AddDays(-1).ToShortDateString();
            }
        }

        /* @Event (Bouton) : Click sur le bouton pour ajouter un jour aux dates */
        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (verifDates())
            {
                txtDateDebut.Text = dtDebut.AddDays(1).ToShortDateString();
                txtDateFin.Text = dtFin.AddDays(1).ToShortDateString();
            }
        }


        /* @Event (Bouton) : Click sur le bouton pour annuler les modifications */
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /* @Event (Bouton) : Click sur le bouton pour valider les changements */
        private void btnValider_Click(object sender, EventArgs e)
        {

        }

        #region Mouvement du formulaire avec la souris
        /* @Event (Panel) : MouseDown de la barre du haut */
        private void lblTitre_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        /* @Event (Panel) : MouseMove de la barre du haut */
        private void lblTitre_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        /* @Event (Panel) : MouseUp de la barre du haut */
        private void lblTitre_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion


        /* @Method : Construit le formulaire avec le dictionnaire donné */
        private void buildForm()
        {
            btnMoins.Visible = false;
            btnPlus.Visible = false;

            txtNom.Text = dicoActuel["nom"];

            txtPoids.Text = dicoActuel["poids"];

            txtInitiales.Text = dicoActuel["initiales"];

            txtDateDebut.Text = dicoActuel["dateDebut"].Replace('.', '/');
            txtDateFin.Text = dicoActuel["dateFin"].Replace('.', '/');

            if(dicoActuel["type"] == "C") { rdbEditCplete.Checked = true; rdbEditPart.Checked = false; }
            else if(dicoActuel["type"] == "P") { rdbEditPart.Checked = true; rdbEditCplete.Checked = false; }

            txtEditions.Text = dicoActuel["editions"];

            if (dicoActuel["distrib"].Contains("P")) { cbxPorteur.Checked = true; }
            if (dicoActuel["distrib"].Contains("VNO")) { cbxVno.Checked = true; }
            if (dicoActuel["distrib"].Contains("SB")) { cbxSB.Checked = true; }

            txtNbExemp.Text = dicoActuel["nbExemp"];

            txtEditPorteur.Text = dicoActuel["editionsPorteur"];

            txtEditPart.Text = dicoActuel["editionsPartielle"];

            if(dicoActuel["distribPartielle"].Contains("P")) { cbxPorteurPart.Checked = true; }
            if(dicoActuel["distribPartielle"].Contains("VNO")) { cbxVnoPart.Checked = true; }
            if(dicoActuel["distribPartielle"].Contains("SB")) { cbxSBPart.Checked = true; }

            txtNbExempPart.Text = dicoActuel["nbExempPartielle"];

            string[] tabSplit = dicoActuel["textes"].Split(new string[] { ";;;" }, StringSplitOptions.None);
            txtTextes.Text = "";
            for (int i = 0; i < tabSplit.Length; i++)
            {
                if(i == 0)
                {
                    txtTextes.Text = tabSplit[i];
                }
                else
                {
                    txtTextes.Text += Environment.NewLine + tabSplit[i];
                }
            }
        }


        /* @Method : Vérifie les dates */
        private bool verifDates()
        {
            string[] tabDebut = txtDateDebut.Text.Split('/');
            string[] tabFin = txtDateFin.Text.Split('/');
            if (!txtDateDebut.Text.Contains('/') || txtDateDebut.Text.Length < 6 || tabDebut.Length > 3)
            {
                MsgBox.show("Date de début invalide.", "Erreur de date");
            }
            else if (!txtDateFin.Text.Contains('/') || txtDateFin.Text.Length < 6 || tabFin.Length > 3)
            {
                MsgBox.show("Date de fin invalide.", "Erreur de date");
            }
            else
            {
                if ((tabDebut[0].Length != 2 && tabDebut[0].Length != 1) //Vérifie le jour
                    || (tabDebut[1].Length != 2 && tabDebut[1].Length != 1) //Vérifie le mois
                    || (tabDebut[2].Length != 4 && tabDebut[2].Length != 2)) //Vérifie l'année
                {
                    MsgBox.show("Date de début invalide.", "Erreur de date");
                }
                else if ((tabFin[0].Length != 2 && tabFin[0].Length != 1) //Vérifie le jour
                    || (tabFin[1].Length != 2 && tabFin[1].Length != 1) //Vérifie le mois
                    || (tabFin[2].Length != 4 && tabFin[2].Length != 2)) //Vérifie l'année
                {
                    MsgBox.show("Date de fin invalide.", "Erreur de date");
                }
                else
                {
                    int yDebut, mDebut, dDebut, yFin, mFin, dFin;

                    if (tabDebut[2].Length == 2) //Si l'année du début ne vaut que deux chiffres
                    {
                        yDebut = int.Parse("20" + tabDebut[2]);
                    }
                    else
                    {
                        yDebut = int.Parse(tabDebut[2]);
                    }
                    mDebut = int.Parse(tabDebut[1]);
                    dDebut = int.Parse(tabDebut[0]);


                    if (tabFin[2].Length == 2) //Si l'année de fin ne vaut que deux chiffres
                    {
                        yFin = int.Parse("20" + tabFin[2]);
                    }
                    else
                    {
                        yFin = int.Parse(tabFin[2]);
                    }
                    mFin = int.Parse(tabFin[1]);
                    dFin = int.Parse(tabFin[0]);

                    dtDebut = new DateTime(yDebut, mDebut, dDebut);
                    dtFin = new DateTime(yFin, mFin, dFin);

                    if (DateTime.Compare(dtDebut, dtFin) > 0)
                    {
                        MsgBox.show("La date de fin doit être ultérieure à la date de début.",
                            "Date invalide");
                    }
                    else
                    {
                        if (DateTime.Compare(dtDebut, dtFin.AddDays(-1)) != 0)
                        {
                            MsgBox.show("Les dates ne sont pas valides.", "Dates invalides");
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        
    }
}
