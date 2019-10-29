using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Encartage
{
    public partial class SaisieEncart : UserControl
    {
        /* @Variables : Différentes parties de la saisie de l'encart */
        FicheInfos ficheInfos;
        FicheDistribution ficheDistribution;
        FicheDistribution ficheEditionPorteur;
        FicheDistribution ficheEditionPartielle;
        FicheTexteASaisir ficheTexteASaisir;

        /* @Variables : Booléens pour les différentes fiches */
        bool ficheInfosIsActual = false;
        bool ficheDistributionIsActual = false;
        bool ficheEditionPorteurIsActual = false;
        bool ficheEditionPartielleIsActual = false;
        bool ficheTexteASaisirIsActual = false;



        /* @Constructor : Constructeur de ce UserControl */
        public SaisieEncart()
        {
            InitializeComponent();
        }



        /* @Event (UserControl) : Load du UserControl */
        private void SaisieEncart_Load(object sender, EventArgs e)
        {
            buildFicheInfos();
            ficheInfosIsActual = true;
            btnBack.Visible = false;
        }


        /* @Event (Bouton) : Click sur le bouton "Suivant" */
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ficheInfosIsActual) 
            {
                DialogResult d = ficheInfos.verifSaisie();
                if(d == DialogResult.OK) 
                {
                    ficheInfos.Hide();
                    ficheInfosIsActual = false;

                    if(ficheDistribution == null)
                    {
                        buildFicheDistribution();
                    }
                    else
                    {
                        ficheDistribution.changeDictio = ficheInfos.dictioInfos;
                        ficheDistribution.Show();
                    }

                    ficheDistributionIsActual = true;
                    btnBack.Visible = true;
                }
            }
            else if (ficheDistributionIsActual)
            {
                DialogResult d = ficheDistribution.verifSaisie();
                if(d == DialogResult.OK)
                {
                    if(ficheDistribution.dictioInfos["type"] == "C")
                    {
                        if(ficheDistribution.dictioInfos["distrib"].Contains("P") &&
                            ficheDistribution.dictioInfos["distrib"].Contains("VNO"))
                        {
                            //Fiche édition porteur
                            ficheDistribution.Hide();
                            ficheDistributionIsActual = false;

                            if(ficheEditionPorteur == null) { buildFicheEditionPorteur(); }
                            else
                            {
                                ficheEditionPorteur.changeDico = ficheDistribution.dictioInfos;
                                ficheEditionPorteur.Show();
                            }
                            
                            ficheEditionPorteurIsActual = true;
                        }
                        else
                        {
                           
                            DialogResult d2 = MsgBox.showYesNo("Voulez-vous saisir des éditions partielles ?",
                                "Édition partielle ?");
                            if (d2 == DialogResult.Yes)
                            {
                                //Fiche édition partielle
                                ficheDistribution.Hide();
                                ficheDistributionIsActual = false;

                                if (ficheEditionPartielle == null)
                                {
                                    ficheDistribution.dictioInfos["editionsPorteur"] = "";
                                    buildFicheEditionPartielle(ficheDistribution.dictioInfos);
                                }
                                else
                                {
                                    ficheEditionPartielle.changeDico = ficheDistribution.dictioInfos;
                                    ficheEditionPartielle.Show();
                                }
                                ficheEditionPartielleIsActual = true;
                            }
                            else if(d2 == DialogResult.No)
                            {
                                //Fiche texte à saisir
                                ficheDistribution.Hide();
                                ficheDistributionIsActual = false;

                                if(ficheTexteASaisir == null)
                                {
                                    ficheDistribution.dictioInfos["editionsPorteur"] = "";
                                    ficheDistribution.dictioInfos["editionsPartielle"] = "";
                                    ficheDistribution.dictioInfos["distribPartielle"] = "";
                                    ficheDistribution.dictioInfos["nbExempPartielle"] = "";
                                    buildFicheTexteASaisir(ficheDistribution.dictioInfos);
                                }
                                else
                                {
                                    ficheTexteASaisir.changeDico = ficheDistribution.dictioInfos;
                                    ficheTexteASaisir.Show();
                                }
                                ficheTexteASaisirIsActual = true;
                            }
                        }
                    }
                    else
                    {
                        

                        //Fiche texte à saisir
                        ficheDistribution.Hide();
                        ficheDistributionIsActual = false;

                        if (ficheTexteASaisir == null)
                        {
                            ficheDistribution.dictioInfos["editionsPorteur"] = "";
                            ficheDistribution.dictioInfos["editionsPartielle"] = "";
                            ficheDistribution.dictioInfos["distribPartielle"] = "";
                            ficheDistribution.dictioInfos["nbExempPartielle"] = "";
                            buildFicheTexteASaisir(ficheDistribution.dictioInfos);
                        }
                        else
                        {
                            ficheTexteASaisir.changeDico = ficheDistribution.dictioInfos;
                            ficheTexteASaisir.Show();
                        }
                        ficheTexteASaisirIsActual = true;
                    }
                }
            }
            else if (ficheEditionPorteurIsActual)
            {
                DialogResult d = ficheEditionPorteur.verifSaisie();
                if(d == DialogResult.OK)
                {
                    if(ficheEditionPorteur.dictioInfos["type"] == "C")
                    {
                        DialogResult d2 = MsgBox.showYesNo("Voulez-vous saisir des éditions partielles ?",
                                "Édition partielle ?");
                        if (d2 == DialogResult.Yes)
                        {
                            //Fiche édition partielle
                            ficheEditionPorteur.Hide();
                            ficheEditionPorteurIsActual = false;

                            if (ficheEditionPartielle == null)
                            {
                                buildFicheEditionPartielle(ficheEditionPorteur.dictioInfos);
                            }
                            else
                            {
                                ficheEditionPartielle.changeDico = ficheEditionPorteur.dictioInfos;
                                ficheEditionPartielle.Show();
                            }
                            ficheEditionPartielleIsActual = true;
                        }
                        else if (d2 == DialogResult.No)
                        {
                            //Fiche texte à saisir
                            ficheEditionPorteur.Hide();
                            ficheEditionPorteurIsActual = false;

                            if (ficheTexteASaisir == null)
                            {
                                ficheEditionPorteur.dictioInfos["editionsPartielle"] = "";
                                ficheEditionPorteur.dictioInfos["distribPartielle"] = "";
                                ficheEditionPorteur.dictioInfos["nbExempPartielle"] = "";
                                buildFicheTexteASaisir(ficheEditionPorteur.dictioInfos);
                            }
                            else
                            {
                                ficheTexteASaisir.changeDico = ficheEditionPorteur.dictioInfos;
                                ficheTexteASaisir.Show();
                            }
                            ficheTexteASaisirIsActual = true;
                        }
                    }
                    else
                    {
                        //Fiche texte à saisir
                        ficheEditionPorteur.Hide();
                        ficheEditionPorteurIsActual = false;

                        if (ficheTexteASaisir == null)
                        {
                            buildFicheTexteASaisir(ficheEditionPorteur.dictioInfos);
                        }
                        else
                        {
                            ficheTexteASaisir.changeDico = ficheEditionPorteur.dictioInfos;
                            ficheTexteASaisir.Show();
                        }
                        ficheTexteASaisirIsActual = true;
                    }
                }
            }
            else if (ficheEditionPartielleIsActual)
            {
                DialogResult d = ficheEditionPartielle.verifSaisie();
                if(d == DialogResult.OK)
                {
                    //Fiche texte à saisir
                    ficheEditionPartielle.Hide();
                    ficheEditionPartielleIsActual = false;

                    if(ficheTexteASaisir == null)
                    {
                        buildFicheTexteASaisir(ficheEditionPartielle.dictioInfos);
                    }
                    else
                    {
                        ficheTexteASaisir.changeDico = ficheEditionPartielle.dictioInfos;
                        ficheTexteASaisir.Show();
                    }
                    ficheTexteASaisirIsActual = true;
                }
            }
            else if (ficheTexteASaisirIsActual)
            {
                DialogResult d = ficheTexteASaisir.verifSaisie();
                if(d == DialogResult.OK)
                {
                    DialogResult d2 = MsgBox.showYesNo("Confirmer l'encart ?", "Confirmer ?");
                    if(d2 == DialogResult.Yes)
                    {
                        //Sauvegarde l'encart
                        Panel p = ((Panel)this.Parent);
                        FrmHome frm = (FrmHome)(p.Parent);

                        Cursor = Cursors.WaitCursor;

                        Thread t = new Thread(() => frm.saveEncart(ficheTexteASaisir.dictioInfos));
                        t.Start();

                        Thread tNote = new Thread(() => frm.buildNote(ficheTexteASaisir.dictioInfos));
                        tNote.Start();

                        Cursor = Cursors.Default;

                        DialogResult d3 = MsgBox.showYesNo("Voulez-vous saisir un nouvel encart ?", "Nouvel encart ?");
                        if (d3 == DialogResult.Yes)
                        {
                            buildNewEncart(ficheTexteASaisir.dictioInfos);
                        }
                        else if (d3 == DialogResult.No)
                        {
                            p.Controls.Remove(this);
                            frm.saisieEncartIsAct = false;
                        }
                    }
                }
            }
        }

        /* @Event (Bouton) : Click sur le bouton "Retour" */
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (ficheDistributionIsActual)
            {
                ficheDistribution.Hide();
                ficheDistributionIsActual = false;

                ficheInfos.Show();
                ficheInfosIsActual = true;
                btnBack.Visible = false;
            }
            else if (ficheEditionPorteurIsActual)
            {
                ficheEditionPorteur.Hide();
                ficheEditionPorteurIsActual = false;

                ficheDistribution.Show();
                ficheDistributionIsActual = true;
            }
            else if (ficheEditionPartielleIsActual)
            {
                ficheEditionPartielle.Hide();
                ficheEditionPartielleIsActual = false;

                if(ficheEditionPorteur == null)
                {
                    ficheDistribution.Show();
                    ficheDistributionIsActual = true;
                }
                else
                {
                    ficheEditionPorteur.Show();
                    ficheEditionPorteurIsActual = true;
                }
            }
            else if (ficheTexteASaisirIsActual)
            {
                ficheTexteASaisir.Hide();
                ficheTexteASaisirIsActual = false;

                if(ficheEditionPartielle != null)
                {
                    ficheEditionPartielle.Show();
                    ficheEditionPartielleIsActual = true;
                }
                else if(ficheEditionPorteur != null)
                {
                    ficheEditionPorteur.Show();
                    ficheEditionPorteurIsActual = true;
                }
                else
                {
                    ficheDistribution.Show();
                    ficheDistributionIsActual = true;
                }
            }
        }

        /* @Event (Bouton) : Click sur le bouton pour annuler l'encart et revenir au début */
        private void btnCancel_Click(object sender, EventArgs e)
        {
            buildNewEncart();
        }


        /* @Method : Prépare un nouvel encart */
        private void buildNewEncart(Dictionary<string, string> ancienDico = null)
        {
            List<Control> listeControls = new List<Control>();
            for(int i = 0; i < this.Controls.Count; i++)
            {
                listeControls.Add(this.Controls[i]);
            }

            for(int i = 0; i < listeControls.Count; i++)
            {
                if(!(listeControls[i] is Button))
                {
                    this.Controls.Remove(listeControls[i]);
                }
            }

            btnBack.Visible = false;
            buildFicheInfos();
            if(ancienDico != null)
            {
                ficheInfos.dictioInfos = ancienDico;
            }
            ficheInfosIsActual = true;

            ficheDistribution = null;
            ficheEditionPartielle = null;
            ficheEditionPorteur = null;
            ficheTexteASaisir = null;
        }


        /* @Method : Génére la fiche infos */
        private void buildFicheInfos()
        {
            ficheInfos = new FicheInfos()
            {
                Left = 0,
                Top = 0,
            };
            this.Controls.Add(ficheInfos);
        }

        /* @Method : Génére la fiche distribution */
        private void buildFicheDistribution()
        {
            ficheDistribution = new FicheDistribution(ficheInfos.dictioInfos)
            {
                Left = 0,
                Top = 0,
            };
            this.Controls.Add(ficheDistribution);
        }

        /* @Method : Génére la fiche édition porteur */
        private void buildFicheEditionPorteur()
        {
            ficheEditionPorteur = new FicheDistribution(ficheDistribution.dictioInfos, 1)
            {
                Left = 0,
                Top = 0,
            };
            this.Controls.Add(ficheEditionPorteur);
        }

        /* @Method : Génére la fiche édition partielle */
        private void buildFicheEditionPartielle(Dictionary<string, string> dico)
        {
            ficheEditionPartielle = new FicheDistribution(dico, 0)
            {
                Left = 0,
                Top = 0,
            };
            this.Controls.Add(ficheEditionPartielle);
        }

        /* @Method : Génére la fiche texte à saisir */
        private void buildFicheTexteASaisir(Dictionary<string, string> dico)
        {
            ficheTexteASaisir = new FicheTexteASaisir(dico)
            {
                Left = 0,
                Top = 0,
            };
            this.Controls.Add(ficheTexteASaisir);
        }

    }
}
