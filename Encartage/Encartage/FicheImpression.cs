using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace Encartage
{
    public partial class FicheImpression : UserControl
    {
        /* @Variables */
        FrmHome frmHome;
        DateTime dtFin;
        DateTime dtDebut;
        private char[] tabCharInterdits = new char[] { '/', '\\', ';', ':', '<', '>', '?', '*', '|', '"' };


        /* @Constructor : Constructeur du UserControl */
        public FicheImpression()
        {
            InitializeComponent();
        }



        /* @Event (UserControl) : Load du UserControl */
        private void ImpressionNotesPlans_Load(object sender, EventArgs e)
        {
            frmHome = (FrmHome)(((Panel)(this.Parent)).Parent);

            rdbDna.Checked = true;
            pcbAttTitre.Visible = false;
            pcbAttDate.Visible = false;
            txtDateDebut.Text = DateTime.Now.ToShortDateString();
            txtDateFin.Text = DateTime.Now.AddDays(1).ToShortDateString();
            dtDebut = DateTime.Now;
            dtFin = DateTime.Now.AddDays(1);

            prepareComboBox();
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


        /* @Event (Bouton) : Click sur le bouton imprimer */
        private void btnPrint_Click(object sender, EventArgs e)
        {
            bool hasTitre = rdbAls.Checked || rdbDna.Checked;
            if (verifDates())
            {
                if (hasTitre)
                {
                    string date = dtFin.ToShortDateString().Replace('/', '.');
                    string titre = rdbAls.Checked ? "ALS" : "DNA";
                    List<Dictionary<string, string>> listeDico = frmHome.getAllEncart(date, titre);

                    if (listeDico != null)
                    {
                        Thread tListeEncart = new Thread(() => frmHome.buildListeEncart(date, titre, listeDico));
                        tListeEncart.Start();

                        for (int i = 0; i < listeDico.Count; i++)
                        {
                            if (!frmHome.fileExistNote(date, titre, $"{listeDico[i]["nom"]}.xls"))
                            {
                                frmHome.buildNote(listeDico[i]);
                            }
                        }

                        Thread tPlanEncart = new Thread(() => frmHome.buildPlanEncart(date, titre, listeDico));
                        tPlanEncart.Start();
                        tPlanEncart.Join();

                        string directory = frmHome.getBaseDirectory(date.Replace('/', '_'), titre);
                        string plan = $@"{directory}\PLAN.xls";
                        string liste = $@"{directory}\LISTE_ENCARTS.xls";
                        string notes = $@"{directory}\NOTES\";
                        try
                        {
                            Cursor = Cursors.WaitCursor;

                            if (ucNombreCopiePlan.nbCopie != 0)
                            {
                                Excel exPlan = new Excel(plan, 1);
                                exPlan.print(ucNombreCopiePlan.nbCopie, cboPrinters.SelectedIndex);
                            }

                            if (ucNombreCopieListe.nbCopie != 0)
                            {
                                Excel exListe = new Excel(liste, 1);
                                exListe.print(ucNombreCopieListe.nbCopie, cboPrinters.SelectedIndex);
                            }

                            if (ucNombreCopieNotes.nbCopie != 0)
                            { 
                                for(int i = 0; i < listeDico.Count; i++)
                                {
                                    string nom = listeDico[i]["nom"];
                                    for(int j = 0; j < tabCharInterdits.Length; j++)
                                    {
                                        if (nom.Contains(tabCharInterdits[j]))
                                        {
                                            nom = nom.Replace(tabCharInterdits[j], '_');
                                        }
                                    }
                                    Excel exNote = new Excel(notes + nom + ".xls", 1);
                                    exNote.print(ucNombreCopieNotes.nbCopie, cboPrinters.SelectedIndex);
                                    MessageBox.Show(notes + nom + ".xls");
                                }                                
                            }
                            Cursor = Cursors.Default;
                        }
                        catch (Exception exc)
                        {
                            MsgBox.show(exc.Message, "Erreur lors de l'impression");
                        }
                    }
                }
                else
                {
                    MsgBox.show("Veuillez choisir un titre.", "Erreur de titre");
                }
            }
        }

        /* @Event (Bouton) : Click sur open directory */
        private void btnOpenDirectory_Click(object sender, EventArgs e)
        {
            bool hasTitre = rdbAls.Checked || rdbDna.Checked;
            if (verifDates())
            {
                if (hasTitre)
                {
                    string date = dtFin.ToShortDateString().Replace('/','.');
                    string titre = rdbAls.Checked ? "ALS" : "DNA";


                    string path = frmHome.getBaseDirectory(date.Replace('/', '_'), titre);
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


        /* @Method : Vérifie la saisie */
        private bool verifSaisie()
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

            if (hasDate && hasTitre)
            {
                return true;
            }
            else
            {
                return false;
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

        /* @Method : Prépare la comboBox pour accueillir toutes les imprimantes */
        private void prepareComboBox()
        {
            string pkInstalledPrinters;
            for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                pkInstalledPrinters = PrinterSettings.InstalledPrinters[i];
                cboPrinters.Items.Add(pkInstalledPrinters);
            }
            cboPrinters.SelectedIndex = 0; 
        }


    }
}
