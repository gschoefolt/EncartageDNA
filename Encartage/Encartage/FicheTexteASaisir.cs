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
    public partial class FicheTexteASaisir : UserControl
    {
        /* @Variables : Dictionnaire contenant les informations */
        private Dictionary<string, string> dictInfos;



        /* @Constructor : Constructeur de ce UserControl */
        public FicheTexteASaisir(Dictionary<string, string> dico)
        {
            InitializeComponent();
            dictInfos = new Dictionary<string, string>(dico);
        }



        /* @Event (UserControl) : Load du UserControl */
        private void FicheTexteASaisir_Load(object sender, EventArgs e)
        {
            pcbAttTexte.Visible = false;
            buildListeTextes();
        }


        /* @Event (Bouton) : Click sur le bouton pour ajouter le texte sélectionné au texte de l'encart */
        private void btnAddResume_Click(object sender, EventArgs e)
        {
            foreach(string s in lboTextes.SelectedItems)
            {
                lboResume.Items.Add(s);
            }
        }

        /* @Event (Bouton) : Click sur le bouton pour enlever le texte des textes de l'encart */
        private void btnSubResume_Click(object sender, EventArgs e)
        {
            List<string> listeSelection = new List<string>();
            foreach(string s in lboResume.SelectedItems)
            {
                listeSelection.Add(s);
            }

            foreach(string s in listeSelection)
            {
                lboResume.Items.Remove(s);
            }
        }

        /* @Event (Bouton) : Click sur le bouton pour ajouter le texte aux textes prédéfinis */
        private void btnAddPredef_Click(object sender, EventArgs e)
        {
            if(txtTexte.Text == string.Empty)
            {
                pcbAttTexte.Visible = true;
                MsgBox.show("Vous ne pouvez pas ajouter du texte vide.", "Erreur de texte");
            }
            else
            {
                pcbAttTexte.Visible = false;
                lboTextes.Items.Add(txtTexte.Text);
                lboResume.Items.Add(txtTexte.Text);

                SaisieEncart s = (SaisieEncart)this.Parent;
                Panel p = (Panel)s.Parent;
                FrmHome f = (FrmHome)p.Parent;
                f.addTexteXml(txtTexte.Text);
            }
        }

        /* @Event (Bouton) : Click sur le bouton pour ajouter le texte du txtbox au texte de l'encart */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTexte.Text == string.Empty)
            {
                pcbAttTexte.Visible = true;
                MsgBox.show("Vous ne pouvez pas ajouter du texte vide.", "Erreur de texte");
            }
            else
            {
                pcbAttTexte.Visible = false;
                lboResume.Items.Add(txtTexte.Text);
            }
        }



        /* @Method : Remplit la lboTextes avec les textes prédéfinis */
        private void buildListeTextes()
        {
            for(int i = 0; i < FrmHome.listeTextesASaisir.Count; i++)
            {
                lboTextes.Items.Add(FrmHome.listeTextesASaisir[i]);
            }
        }


        /* @Method : Vérifie la saisie de l'utilisateur */
        public DialogResult verifSaisie()
        {
            if(lboResume.Items.Count == 0)
            {
                dictInfos["textes"] = "";
            }
            else
            {
                string textes = "";
                foreach(string s in lboResume.Items)
                {
                    textes += $"{s} ;;; ";
                }

                dictInfos["textes"] = textes.Remove(textes.Length - 5, 4);
            }
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
