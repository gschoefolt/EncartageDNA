using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Encartage
{
    public partial class ModificationEncart : UserControl
    {
        /* @Variables */
        private FrmModifEncart frmModifEncart;
        private FrmHome frmHome;
        private List<Dictionary<string, string>> listeDicoActuelle;
        private Dictionary<string, string> dicoActuel = null;
        private DateTime dtFin;
        private DateTime dtDebut;


        /* @Constructor : Constructeur de ce UserControl */
        public ModificationEncart()
        {
            InitializeComponent();
        }



        /* @Event (UserControl) : Load du UserControl */
        private void ModificationEncart_Load(object sender, EventArgs e)
        {
            rdbDna.Checked = true;
            pcbAttTitre.Visible = false;
            pcbAttDate.Visible = false;
            txtDateDebut.Text = DateTime.Now.ToShortDateString();
            txtDateFin.Text = DateTime.Now.AddDays(1).ToShortDateString();
            frmHome = (FrmHome)(((Panel)(this.Parent)).Parent);
        }


        /* @Event (Bouton) : Click sur le bouton pour recherche les encarts */
        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool hasTitre = false;
            bool hasDate = false;
            if (!rdbAls.Checked && !rdbDna.Checked)
            {
                pcbAttTitre.Visible = true;
                MsgBox.show("Veuillez choisir un titre.", "Erreur de titre");
            }
            else
            {
                hasTitre = true;
                pcbAttTitre.Visible = false;
                if (verifDates())
                {
                    hasDate = true;
                }
            }

            if(hasTitre && hasDate)
            {
                Cursor = Cursors.WaitCursor;
                buildListBox(frmHome.getAllEncart(dtFin.ToShortDateString().Replace('/', '.'), 
                    rdbAls.Checked ? "ALS" : "DNA"));
                Cursor = Cursors.Default;
            }
        }

        /* @Event (Bouton) : Click sur le bouton pour modifier l'encart sélectionné */
        private void btnModif_Click(object sender, EventArgs e)
        {
            if(lboEncarts.SelectedIndex != -1)
            {
                frmModifEncart = new FrmModifEncart(dicoActuel);
                if(frmModifEncart.ShowDialog() == DialogResult.OK)
                {
                    //Il y a eu une modification d'encart

                }
                else
                {
                    //Il n'y a pas eu de modification d'encart

                }
            }
            else
            {
                MsgBox.show("Veuillez sélectionner un encart à modifier.", "Selectionnez un encart");
            }
        }

        /* @Event (Bouton) : Click sur le bouton "Supprimer" */
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if(lboEncarts.SelectedIndex == -1)
            {
                MsgBox.show("Vous n'avez rien sélectionné à supprimer.", "Erreur de suppression");
            }
            else
            {
                DialogResult d = MsgBox.showYesNo(
                    $"Voulez-vous vraiment supprimer \"{dicoActuel["nom"]}\" ?", "Confirmer la suppression ?");
                if(d == DialogResult.Yes)
                {
                    string date = dtFin.ToShortDateString().Replace('/', '.');
                    string titre = rdbAls.Checked ? "ALS" : "DNA";

                    int index = -1;
                    for(int i = 0; i < listeDicoActuelle.Count; i++)
                    {
                        if(listeDicoActuelle[i]["numero"] == dicoActuel["numero"])
                        {
                            index = i;
                        }
                    }
                    if(index != -1)
                    {
                        listeDicoActuelle.RemoveAt(index);
                    }
                    
                    Thread tSuppEncart = new Thread(() => frmHome.supprimeEncart(listeDicoActuelle, dicoActuel));
                    tSuppEncart.Start();

                    buildListBox(listeDicoActuelle);
                }
            }
        }


        /* @Event (Bouton) : Click sur le bouton pour revenir en arrière d'un jour */
        private void btnMoins_Click(object sender, EventArgs e)
        {
            if (verifDates())
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


        /* @Event (Bouton) : Click sur le bouton pour ouvrir le répertoire des encarts */
        private void btnOpenDirectory_Click(object sender, EventArgs e)
        {
            bool hasTitre = rdbAls.Checked || rdbDna.Checked;

            if (verifDates())
            {
                if (hasTitre)
                {
                    string date = dtFin.ToShortDateString().Replace('/', '.');
                    string titre = rdbAls.Checked ? "ALS" : "DNA";

                    string path = frmHome.getBaseDirectory(date, titre);
                    if (Directory.Exists(path))
                    {
                        Process.Start("explorer.exe", path);
                    }
                    else
                    {
                        MsgBox.show("Le répertoire n'existe pas.", "Erreur de répertoire");
                    }
                }
                else
                {
                    MsgBox.show("Veuillez choisir un titre.", "Erreur de titre");
                }
            }
        }

        /* @Event (ListBox) : SelectedIndexChanged de la listbox */
        private void lboEncarts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dictionary<string, string> dico = null;
            for(int i = 0; i < listeDicoActuelle.Count; i++)
            {
                Dictionary<string,string> d = listeDicoActuelle[i];
                if(d["numero"] == lboEncarts.SelectedValue as string)
                {
                    dico = new Dictionary<string, string>(d);
                    break;
                }
            }
            if (dico != null)
            {
                dicoActuel = new Dictionary<string, string>(dico);
                txtNom.Text = dico["nom"];
                txtPoids.Text = dico["poids"];
                txtEditions.Text = dico["editions"];
                txtDistrib.Text = dico["distrib"];
                txtNbExemp.Text = dico["nbExemp"];
                txtTypeEdit.Text = dico["type"] == "C" ? "Complete" : "Partielle";
            }
        }



        /* @Method : Construit la listeBox pour tous les encarts avec le titre et la date */
        private void buildListBox(List<Dictionary<string,string>> listDico)
        {
            if(listDico != null)
            {
                if(listDico.Count == 0)
                {
                    lboEncarts.DataSource = null;
                }
                else
                {
                    lboEncarts.DataSource = null;
                    listeDicoActuelle = new List<Dictionary<string, string>>(listDico);

                    Dictionary<string, string> dicoSource = new Dictionary<string, string>();
                    for (int i = 0; i < listeDicoActuelle.Count; i++)
                    {
                        dicoSource[listeDicoActuelle[i]["numero"]] = listeDicoActuelle[i]["nom"];
                    }

                    lboEncarts.DataSource = new BindingSource(dicoSource, null);
                    lboEncarts.ValueMember = "Key";
                    lboEncarts.DisplayMember = "Value";
                }
            }
        }


        /* @Method : Renvoie true si les dates sont correctes, sinon false */
        private bool verifDates()
        {
            string[] tabDebut = txtDateDebut.Text.Split('/');
            string[] tabFin = txtDateFin.Text.Split('/');
            if (!txtDateDebut.Text.Contains('/') || txtDateDebut.Text.Length < 6 || tabDebut.Length > 3)
            {
                pcbAttDate.Visible = true;
                MsgBox.show("Date de début invalide.", "Erreur de date");
            }
            else if (!txtDateFin.Text.Contains('/') || txtDateFin.Text.Length < 6 || tabFin.Length > 3)
            {
                pcbAttDate.Visible = true;
                MsgBox.show("Date de fin invalide.", "Erreur de date");
            }
            else
            {
                if ((tabDebut[0].Length != 2 && tabDebut[0].Length != 1) //Vérifie le jour
                    || (tabDebut[1].Length != 2 && tabDebut[1].Length != 1) //Vérifie le mois
                    || (tabDebut[2].Length != 4 && tabDebut[2].Length != 2)) //Vérifie l'année
                {
                    pcbAttDate.Visible = true;
                    MsgBox.show("Date de début invalide.", "Erreur de date");
                }
                else if ((tabFin[0].Length != 2 && tabFin[0].Length != 1) //Vérifie le jour
                    || (tabFin[1].Length != 2 && tabFin[1].Length != 1) //Vérifie le mois
                    || (tabFin[2].Length != 4 && tabFin[2].Length != 2)) //Vérifie l'année
                {
                    pcbAttDate.Visible = true;
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
                        pcbAttDate.Visible = true;
                        MsgBox.show("La date de fin doit être ultérieure à la date de début.",
                            "Date invalide");
                    }
                    else
                    {
                        if (DateTime.Compare(dtDebut, dtFin.AddDays(-1)) != 0)
                        {
                            pcbAttDate.Visible = true;
                            MsgBox.show("Les dates ne sont pas valides.", "Dates invalides");
                        }
                        else
                        {
                            pcbAttDate.Visible = false;
                            return true;
                        }
                    }
                }
            }
            return false;
        }

    }
}
