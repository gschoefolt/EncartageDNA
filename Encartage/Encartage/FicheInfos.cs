using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encartage
{
    public partial class FicheInfos : UserControl
    {
        /* @Variables : Dictionnaire contenant les informations */
        Dictionary<string, string> dictInfos = new Dictionary<string, string>();

        DateTime dtFin;
        DateTime dtDebut;



        /* @Constructor : Constructeur de ce UserControl */
        public FicheInfos()
        {
            InitializeComponent();
        }



        /* @Event (UserControl) : Load pour ce UserControl */
        private void FicheInfos_Load(object sender, EventArgs e)
        {
            pcbAttDate.Visible = false;
            pcbAttInit.Visible = false;
            pcbAttPoids.Visible = false;
            pcbAttTitle.Visible = false;
            pcbAttTitre.Visible = false;
            pcbAttType.Visible = false;

            txtDateDebut.Text = DateTime.Now.ToShortDateString();
            txtDateFin.Text = DateTime.Now.AddDays(1).ToShortDateString();
            dtDebut = DateTime.Now;
            dtFin = DateTime.Now.AddDays(1);
        }


        /* @Event (Bouton) : Click sur le bouton pour reset les infos de l'encart */
        private void btnResetInfos_Click(object sender, EventArgs e)
        {
            txtInitiales.Text = string.Empty;
            txtDateDebut.Text = DateTime.Now.ToShortDateString();
            txtDateFin.Text = DateTime.Now.AddDays(1).ToShortDateString();
            txtNomEncart.Text = string.Empty;
            txtPoids.Text = string.Empty;
            rdbEditComplet.Checked = false;
            rdbEditPart.Checked = false;
        }

        /* @Event (Bouton) : Click sur le bouton pour reset le titre de l'encart */
        private void btnResetTitre_Click(object sender, EventArgs e)
        {
            rdbAls.Checked = false;
            rdbDna.Checked = false;
        }


        /* @Event (Bouton) : Click sur le bouton pour revenir en arrière d'un jour */
        private void btnMoins_Click(object sender, EventArgs e)
        {
            if (verifDates(true))
            {
                txtDateDebut.Text = dtDebut.AddDays(-1).ToShortDateString();
                txtDateFin.Text = dtFin.AddDays(-1).ToShortDateString();
            }
        }

        /* @Event (Bouton) : Click sur le bouton pour aller d'un jour en avant */
        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (verifDates())
            {
                txtDateDebut.Text = dtDebut.AddDays(1).ToShortDateString();
                txtDateFin.Text = dtFin.AddDays(1).ToShortDateString();
            }
        }



        /* @Method : Vérifie la saisie de l'utilisateur */
        public DialogResult verifSaisie()
        {
            #region Vérifie le titre sélectionné
            if(!rdbAls.Checked && !rdbDna.Checked)
            {
                pcbAttTitre.Visible = true;
                MsgBox.show("Veuillez sélectionner le titre ALS ou DNA pour l'encart.", "Erreur de titre");
                return DialogResult.No;
            }
            else
            {
                pcbAttTitre.Visible = false;
                dictInfos["titre"] = rdbAls.Checked ? "ALS" : "DNA";
            }
            #endregion

            #region Initiales utilisées
            dictInfos["initiales"] = txtInitiales.Text;
            #endregion

            #region Vérifie les dates sélectionnées
            if (verifDates())
            {
                dictInfos["dateDebut"] = dtDebut.ToShortDateString().Replace('/', '.');
                dictInfos["dateFin"] = dtFin.ToShortDateString().Replace('/', '.');
            }
            #endregion

            #region Vérifie le nom de l'encart
            if(txtNomEncart.Text == string.Empty)
            {
                pcbAttTitle.Visible = true;
                MsgBox.show("Le nom de l'encart ne peut pas être vide.", "Erreur de nom d'encart");
                return DialogResult.No;
            }
            else
            {
                pcbAttTitle.Visible = false;
                dictInfos["nom"] = txtNomEncart.Text;
            }
            #endregion

            #region Poids de l'encart
            dictInfos["poids"] = txtPoids.Text;
            #endregion

            #region Vérifie le type d'édition sélectionné
            if(!rdbEditComplet.Checked && !rdbEditPart.Checked)
            {
                pcbAttType.Visible = true;
                MsgBox.show("Veuillez choisir le type d'édition de l'encart.", "Erreur de type d'édition");
                return DialogResult.No;
            }
            else
            {
                pcbAttType.Visible = false;
                dictInfos["type"] = rdbEditComplet.Checked ? "C" : "P";
            }
            #endregion

            return DialogResult.OK;
        }


        /* @Method : Dictionnaire contenant toutes les informations */
        public Dictionary<string, string> dictioInfos
        {
            get
            {
                return this.dictInfos;
            }
            set
            {
                if(value["titre"] == "DNA")
                {
                    rdbDna.Checked = true;
                }
                else if(value["titre"] == "ALS")
                {
                    rdbAls.Checked = true;
                }
                txtInitiales.Text = value["initiales"];
                txtDateDebut.Text = value["dateDebut"].Replace('.', '/');
                txtDateFin.Text = value["dateFin"].Replace('.', '/');
            }
        }


        /* @Method : Vérifie les dates sélectionnés et renvoie un booleen */
        private bool verifDates(bool btnMoins = false)
        {
            string[] tabDebut = txtDateDebut.Text.Split('/');
            string[] tabFin = txtDateFin.Text.Split('/');
            if (!txtDateDebut.Text.Contains('/') || txtDateDebut.Text.Length < 6 || tabDebut.Length > 3)
            {
                pcbAttDate.Visible = true;
                MsgBox.show("Date de début invalide.", "Erreur de date");
                return false;
            }
            else if (!txtDateFin.Text.Contains('/') || txtDateFin.Text.Length < 6 || tabFin.Length > 3)
            {
                pcbAttDate.Visible = true;
                MsgBox.show("Date de fin invalide.", "Erreur de date");
                return false;
            }
            else
            {
                if ((tabDebut[0].Length != 2 && tabDebut[0].Length != 1)//Vérifie le jour
                    || (tabDebut[1].Length != 2 && tabDebut[1].Length != 1) //Vérifie le mois
                    || (tabDebut[2].Length != 4 && tabDebut[2].Length != 2)) //Vérifie l'année
                {
                    pcbAttDate.Visible = true;
                    MsgBox.show("Date de début invalide.", "Erreur de date");
                    return false;
                }
                else if ((tabFin[0].Length != 2 && tabFin[0].Length != 1) //Vérifie le jour
                    || (tabFin[1].Length != 2 && tabFin[1].Length != 1) //Vérifie le mois
                    || (tabFin[2].Length != 4 && tabFin[2].Length != 2)) //Vérifie l'année
                {
                    pcbAttDate.Visible = true;
                    MsgBox.show("Date de fin invalide.", "Erreur de date");
                    return false;
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

                    DateTime now = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                    if (btnMoins)
                    {
                        DateTime dtDebut2 = dtDebut.AddDays(-1);
                        if(DateTime.Compare(dtDebut2, now) < 0)
                        {
                            pcbAttDate.Visible = true;
                            MsgBox.show("La date de début doit être à partir d'aujourd'hui au minimum.",
                                "Date invalide");
                            return false;
                        }
                    }
                    else if (DateTime.Compare(dtDebut, now) < 0)
                    {
                        pcbAttDate.Visible = true;
                        MsgBox.show("La date de début doit être à partir d'aujourd'hui au minimum.",
                            "Date invalide");
                        return false;
                    }

                    if (DateTime.Compare(dtDebut, dtFin) > 0)
                    {
                        pcbAttDate.Visible = true;
                        MsgBox.show("La date de fin doit être ultérieure à la date de début.",
                            "Date invalide");
                        return false;
                    }
                    else
                    {
                        if (DateTime.Compare(dtDebut, dtFin.AddDays(-1)) != 0)
                        {
                            pcbAttDate.Visible = true;
                            MsgBox.show("Les dates ne sont pas valides.", "Dates invalides");
                            return false;
                        }
                        else
                        {
                            pcbAttDate.Visible = false;
                            return true;
                        }
                    }
                }
            }
        }

    }
}
