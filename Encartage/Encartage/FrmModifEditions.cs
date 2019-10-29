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
    public partial class FrmModifEditions : Form
    {
        /* @Variables */
        Dictionary<string, string> dicoAct;
        private int editionSpecial = -1; //-1 Normal, 0 = porteur, 1 = partielle


        /* @Constructor : Constructeur du formulaire */
        public FrmModifEditions(Dictionary<string, string> dico, int editionSpecial)
        {
            InitializeComponent();
            dicoAct = new Dictionary<string, string>(dico);
            this.editionSpecial = editionSpecial;
        }



        /* @Event (Form) : Load du formulaire */
        private void FrmModifEditions_Load(object sender, EventArgs e)
        {
            if (editionSpecial == -1)
            {
                buildEditions("editions");
                lblEdition.Text = dicoAct["type"] == "C" ? "Édition complète" : "Édition partielle";
            }
            else if (editionSpecial == 0)
            {
                buildEditions("editionsPorteur");
                lblEdition.Text = "Édition porteur uniquement";
            }
            else if (editionSpecial == 1)
            {
                buildEditions("editionsPartielle");
                lblEdition.Text = "Édition partielle";
            }

            lblEdition.Location = new Point((this.Width / 2) - (lblEdition.Width / 2), 10);
        }


        /* @Event (Bouton) : Click sur le bouton pour reset les éditions */
        private void btnResetEdit_Click(object sender, EventArgs e)
        {
            foreach (CheckBox c in grpEditions.Controls)
            {
                c.Checked = false;
            }
        }

        /* @Event (Bouton) : Click sur le bouton pour valider les changements */
        private void btnValider_Click(object sender, EventArgs e)
        {
            DialogResult d = MsgBox.showYesNo("Voulez-vous vraiment confirmer les changements ?", "Confirmer ?");
            if (d == DialogResult.Yes)
            {
                bool error = false;

                #region Vérifie les éditions choisies
                string editions = "";
                if (cbx67.Checked && cbx68.Checked)
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
                    else if (cbx68.Checked)
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
                if (editionSpecial == 0)
                {
                    if (editions != "67, 68")
                    {
                        dicoAct["editionsPorteur"] = editions == string.Empty ? "" : editions.Remove(editions.Length - 1, 1);
                    }
                    else
                    {
                        dicoAct["editionsPorteur"] = editions;
                    }
                }
                else if (editionSpecial == 1)
                {
                    if(editions == "")
                    {
                        MsgBox.show("Veuillez remplir au moins une édition", "Erreur d'édition");
                        error = true;
                    }
                    else
                    {
                        if (editions != "67, 68")
                        {
                            dicoAct["editionsPartielle"] = editions.Remove(editions.Length - 1, 1);
                        }
                        else
                        {
                            dicoAct["editionsPartielle"] = editions;
                        }
                    }
                }
                else
                {
                    if (editions != "67, 68")
                    {
                        dicoAct["editions"] = editions.Remove(editions.Length - 1, 1);
                    }
                    else
                    {
                        if(editions == "")
                        {
                            MsgBox.show("Veuillez remplir au moins une édition", "Erreur d'édition");
                            error = true;
                        }
                        else
                        {
                            dicoAct["editions"] = editions;
                        }
                    }
                }
                #endregion


                if (!error)
                {
                    this.DialogResult = DialogResult.Yes;
                    this.Close();
                }
            }
        }

        /* @Event (Bouton) : Click sur le bouton pour annuler les changements */
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
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
                    if (dictInfos["titre"] == "DNA")
                    {
                        if (compteur == FrmHome.nbEdit67Dna)
                        {
                            cbx67.Checked = true;
                        }
                    }
                    else if (dictInfos["titre"] == "ALS")
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
                if (c.Text.Contains("67") && cbx67.Checked) //Si on décoche un "67"
                {
                    cbx67.Checked = false;
                }
                else if (c.Text.Contains("68") && cbx68.Checked) //Si on décoche un "68"
                {
                    cbx68.Checked = false;
                }
            }
        }



        /* @Method : Créer les éditions à cocher */
        private void buildEditions(string edit)
        {
            int top = 30;
            int left = 10;

            if (dicoAct["titre"] == "DNA")
            {
                string allEdits = FrmHome.getAllEdit(dicoAct[edit], "DNA");
                List<string> editsDna = FrmHome.listeEditionsDna;
                for (int i = 0; i < editsDna.Count; i++)
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
                        Checked = allEdits.Contains(editsDna[i].Substring(0, 3)),
                    };
                    cbx.Click += new EventHandler(cbx_Click);
                    grpEditions.Controls.Add(cbx);
                    top += 40;
                }
            }
            else if (dicoAct["titre"] == "ALS")
            {
                string allEdits = FrmHome.getAllEdit(dicoAct[edit], "ALS");
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
                        Checked = allEdits.Contains(editsAls[i].Substring(0, 3)),
                    };
                    cbx.Click += new EventHandler(cbx_Click);
                    grpEditions.Controls.Add(cbx);
                    top += 40;
                }
            }
            if(dicoAct[edit] == "67")
            {
                cbx67.Checked = true;
            }
            else if(dicoAct[edit] == "68")
            {
                cbx68.Checked = true;
            }
            else if (dicoAct[edit] == "67, 68")
            {
                cbx67.Checked = true;
                cbx68.Checked = true;
            }
            else if (dicoAct[edit].StartsWith("67,"))
            {
                cbx67.Checked = true;
            }
            else if (dicoAct[edit].StartsWith("68,"))
            {
                cbx68.Checked = true;
            }
        }


        /* @Method : Avoir le dictionnaire */
        public Dictionary<string, string> dictInfos
        {
            get
            {
                return this.dicoAct;
            }
        }

        
    }
}
