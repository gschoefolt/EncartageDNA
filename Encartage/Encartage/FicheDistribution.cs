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
    public partial class FicheDistribution : UserControl
    {
        /* @Variables : Dictionnaire contenant les informations */
        private Dictionary<string, string> dictInfos;

        int editionPorteur = -1; 
        // -1 : édition complète ou partielle, 0 : édition partielle, 1 : édition porteur uniquement



        /* @Constructor : Constructeur de ce UserControl */
        public FicheDistribution(Dictionary<string, string> dico)
        {
            InitializeComponent();
            dictInfos = new Dictionary<string, string>(dico);
            if(dictInfos["type"] == "P")
            {
                this.lblEdition.Text = "Édition partielle";
            }
        }

        /* @Constructor : Constructeur pour la version FicheEditionPorteur */
        public FicheDistribution(Dictionary<string, string> dico, int editionPorteur)
        {
            InitializeComponent();
            dictInfos = new Dictionary<string, string>(dico);
            this.editionPorteur = editionPorteur;
            if (editionPorteur == 1)
            {
                buildEditions();
                buildEditionPorteur();
            }
            else if(editionPorteur == 0)
            {
                buildEditions();
                buildEditionPartielle();
            }
        }



        /* @Event (UserControl) : Load du UserControl */
        private void FicheDistribution_Load(object sender, EventArgs e)
        {
            pcbAttDistrib.Visible = false;
            pcbAttEditions.Visible = false;
            pcbAttNbExemp.Visible = false;

            buildEditions();
        }


        /* @Event (Bouton) : Click sur le bouton pour reset les distributions */
        private void btnResetDistrib_Click(object sender, EventArgs e)
        {
            cbxPorteur.Checked = false;
            cbxSB.Checked = false;
            cbxVno.Checked = false;
            txtNbExemp.Text = string.Empty;
        }

        /* @Event (Bouton) : Click sur le bouton pour reset les éditions */
        private void btnResetEdit_Click(object sender, EventArgs e)
        {
            foreach(CheckBox c in grpEditions.Controls)
            {
                c.Checked = false;
            }
        }


        /* @Event (CheckBox) : Click sur la checkBox 67 */
        private void cbx67_Click(object sender, EventArgs e)
        {
            if (cbx67.Checked)
            {
                foreach (CheckBox c in grpEditions.Controls)
                {
                    if (c.Name != "cbx67" && c.Name != "cbx68" && c.Text.Contains("67"))
                    {
                        c.Checked = true;
                    }
                }
            }
            else
            {
                foreach (CheckBox c in grpEditions.Controls)
                {
                    if (c.Name != "cbx67" && c.Name != "cbx68" && c.Text.Contains("67"))
                    {
                        c.Checked = false;
                    }
                }
            }
        }

        /* @Event (CheckBox) : Click sur la checkBox 68 */
        private void cbx68_Click(object sender, EventArgs e)
        {
            if (cbx68.Checked)
            {
                foreach (CheckBox c in grpEditions.Controls)
                {
                    if (c.Name != "cbx67" && c.Name != "cbx68" && c.Text.Contains("68"))
                    {
                        c.Checked = true;
                    }
                }
            }
            else
            {
                foreach (CheckBox c in grpEditions.Controls)
                {
                    if (c.Name != "cbx67" && c.Name != "cbx68" && c.Text.Contains("68"))
                    {
                        c.Checked = false;
                    }
                }
            }
        }

        /* @Event (CheckBox) : Click sur une checkBox autre que 67 ou 68 */
        private void cbx_Click(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;

            if (c.Checked) //Vérifie si cbx67 ou cbx68 soit coché ou non
            {
                if (c.Text.Contains("67"))
                {
                    int compteur = 0;
                    foreach (CheckBox cb in grpEditions.Controls)
                    {
                        if (cb.Name != "cbx67" && cb.Name != "cbx68" && cb.Text.Contains("67")
                            && cb.Checked)
                        {
                            compteur++;
                        }
                    }
                    if(dictInfos["titre"] == "DNA")
                    {
                        if(compteur == FrmHome.nbEdit67Dna)
                        {
                            cbx67.Checked = true;
                        }
                    }
                    else if(dictInfos["titre"] == "ALS")
                    {
                        if (compteur == FrmHome.nbEdit67Als)
                        {
                            cbx67.Checked = true;
                        }
                    }
                }
                else if (c.Text.Contains("68"))
                {
                    int compteur = 0;
                    foreach (CheckBox cb in grpEditions.Controls)
                    {
                        if (cb.Name != "cbx67" && cb.Name != "cbx68" && cb.Text.Contains("68")
                            && cb.Checked)
                        {
                            compteur++;
                        }
                    }
                    if (dictInfos["titre"] == "DNA")
                    {
                        if (compteur == FrmHome.nbEdit68Dna)
                        {
                            cbx68.Checked = true;
                        }
                    }
                    else if (dictInfos["titre"] == "ALS")
                    {
                        if (compteur == FrmHome.nbEdit68Als)
                        {
                            cbx68.Checked = true;
                        }
                    }
                }
            }
            else //Pour décocher cbx67 ou cbx68 si un checkbox est décoché
            {
                if(c.Text.Contains("67") && cbx67.Checked) //Si on décoche un "67"
                {
                    cbx67.Checked = false;
                }
                else if(c.Text.Contains("68") && cbx68.Checked) //Si on décoche un "68"
                {
                    cbx68.Checked = false;
                }
            }
        }



        /* @Method : Construit les checkbox des éditions */
        private void buildEditions()
        {
            int top = 30;
            int left = 10;

            if (dictInfos["titre"] == "DNA")
            {
                List<string> editsDna = FrmHome.listeEditionsDna;
                for(int i = 0; i < editsDna.Count; i++)
                {
                    if (i % 6 == 0 && i > 0)
                    {
                        top = 30;
                        left += 260;
                    }
                    CheckBox cbx = new CheckBox()
                    {
                        Text = editsDna[i],
                        AutoSize = true,
                        Cursor = Cursors.Hand,
                        Top = top,
                        Left = left,
                    };
                    cbx.Click += new EventHandler(cbx_Click);
                    grpEditions.Controls.Add(cbx);
                    top += 40;
                }
            }
            else if(dictInfos["titre"] == "ALS")
            {
                List<string> editsAls = FrmHome.listeEditionsAls;
                for (int i = 0; i < editsAls.Count; i++)
                {
                    if (i % 6 == 0 && i > 0)
                    {
                        top = 30;
                        left += 260;
                    }
                    CheckBox cbx = new CheckBox()
                    {
                        Text = editsAls[i],
                        AutoSize = true,
                        Cursor = Cursors.Hand,
                        Top = top,
                        Left = left,
                    };
                    cbx.Click += new EventHandler(cbx_Click);
                    grpEditions.Controls.Add(cbx);
                    top += 40;
                }
            }
        }

        /* @Method : Construit l'UserControl pour être la FicheEditionPorteur */
        private void buildEditionPorteur()
        {
            grpDistribution.Visible = false;
            btnResetDistrib.Visible = false;
            this.lblEdition.Text = "Et dans tous les districts porteurs des éditions :";
            this.lblTitre.Text = "Fiche édition Porteur";
            this.lblTitre.Location = new Point(356, 15);
        }

        /* @Method : Construit l'UserControl pour être la FicheEditionPartielle */
        private void buildEditionPartielle()
        {
            this.lblEdition.Text = "Édition partielle";
            this.lblTitre.Text = "Fiche édition partielle";
            this.lblTitre.Location = new Point(353, 15);
        }


        /* @Method : Vérifie la saisie de l'utilisateur */
        public DialogResult verifSaisie()
        {
            #region Vérifie les éditions choisies
            string editions = "";
            if(cbx67.Checked && cbx68.Checked)
            {
                editions = "67, 68";
            }
            else
            {
                if (cbx67.Checked)
                {
                    editions = "67,";
                    foreach (CheckBox c in grpEditions.Controls)
                    {
                        if (c.Name != "cbx67" && c.Name != "cbx68" && c.Checked && c.Text.Contains("68"))
                        {
                            editions += $"{c.Text.Substring(0, 3)},";
                        }
                    }
                }
                else if(cbx68.Checked)
                {
                    editions = "68,";
                    foreach (CheckBox c in grpEditions.Controls)
                    {
                        if (c.Name != "cbx67" && c.Name != "cbx68" && c.Checked && c.Text.Contains("67"))
                        {
                            editions += $"{c.Text.Substring(0, 3)},";
                        }
                    }
                }
                else
                {
                    foreach (CheckBox c in grpEditions.Controls)
                    {
                        if (c.Name != "cbx67" && c.Name != "cbx68" && c.Checked)
                        {
                            editions += $"{c.Text.Substring(0, 3)},";
                        }
                    }
                }
            }

            if (editions == string.Empty && editionPorteur != 1)
            {
                pcbAttEditions.Visible = true;
                MsgBox.show("Veuillez choisir au moins une édition.", "Erreur d'édition");
                return DialogResult.No;
            }
            else
            {
                pcbAttEditions.Visible = false;
                if(editionPorteur == 1)
                {
                    if(editions != "67, 68")
                    {
                        dictInfos["editionsPorteur"] = editions == string.Empty ? "" : editions.Remove(editions.Length - 1, 1);
                    }
                    else
                    {
                        dictInfos["editionsPorteur"] = editions;
                    }
                }
                else if(editionPorteur == 0)
                {
                    if(editions != "67, 68")
                    {
                        dictInfos["editionsPartielle"] = editions.Remove(editions.Length - 1, 1);
                    }
                    else
                    {
                        dictInfos["editionsPartielle"] = editions;
                    }
                }
                else
                {
                    if(editions != "67, 68")
                    {
                        dictInfos["editions"] = editions.Remove(editions.Length - 1, 1);
                    }
                    else
                    {
                        dictInfos["editions"] = editions;
                    }
                }
                
            }
            #endregion

            #region Vérifie la(les) distribution(s)
            if(editionPorteur != 1)
            {
                if (!cbxPorteur.Checked && !cbxVno.Checked && !cbxSB.Checked)
                {
                    pcbAttDistrib.Visible = true;
                    MsgBox.show("Veuillez sélectionner au moins une distribution.", "Erreur de distribution");
                    return DialogResult.No;
                }
                else
                {
                    pcbAttDistrib.Visible = false;
                    if(editionPorteur == 0)
                    {
                        string distrib = (cbxPorteur.Checked ? " P" : "") +
                                                (cbxSB.Checked ? " SB" : "") +
                                                (cbxVno.Checked ? " VNO" : "");
                        dictInfos["distribPartielle"] = distrib == "" ? "" : distrib.Remove(0, 1);
                    }
                    else
                    {
                        string distrib = (cbxPorteur.Checked ? " P" : "") +
                                                (cbxSB.Checked ? " SB" : "") +
                                                (cbxVno.Checked ? " VNO" : "");
                        dictInfos["distrib"] = distrib == "" ? "" : distrib.Remove(0, 1);
                    }
                }
            }
            #endregion

            #region Nombre d'exemplaire
            if(editionPorteur != 1)
            {
                if(editionPorteur == 0)
                {
                    dictInfos["nbExempPartielle"] = txtNbExemp.Text;
                }
                else
                {
                    dictInfos["nbExemp"] = txtNbExemp.Text;
                }
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
        }

        /* @Method : Rebuild la fiche Distribution */
        public Dictionary<string, string> changeDictio
        {
            set
            {
                if(value["titre"] != this.dictInfos["titre"])
                {
                    List<Control> liste = new List<Control>();
                    foreach (CheckBox c in this.grpEditions.Controls)
                    {
                        liste.Add(c);
                    }

                    foreach(CheckBox c in liste)
                    {
                        if(c.Name != "cbx67" && c.Name != "cbx68")
                        {
                            this.grpEditions.Controls.Remove(c);
                        }
                    }

                    this.dictInfos = new Dictionary<string, string>(value);
                    if (value["type"] == "P")
                    {
                        this.lblEdition.Text = "Édition partielle";
                    }
                    else
                    {
                        this.lblEdition.Text = "Édition complète";
                    }
                    buildEditions();
                }
                if(value["type"] != this.dictInfos["type"])
                {
                    if(value["type"] == "P")
                    {
                        this.lblEdition.Text = "Édition partielle";
                    }
                    else
                    {
                        this.lblEdition.Text = "Édition complète";
                    }
                    this.dictInfos = new Dictionary<string, string>(value);
                }
            }
        }

        /* @Method : Change le dictionnaire actuel */
        public Dictionary<string, string> changeDico
        {
            set
            {
                this.dictInfos = new Dictionary<string, string>(value);
            }
        }

    }
}
