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
    public partial class UCFicheSaisieEncart : UserControl
    {
        /* Constructeur du UserControl */
        public UCFicheSaisieEncart()
        {
            InitializeComponent();
        }

        /* Evénement load pour ce userControl */
        private void UCFicheSaisieEncart_Load(object sender, EventArgs e)
        {
            //Pas d'erreurs au début
            pcbAttDate.Visible = false;
            pcbAttInit.Visible = false;
            pcbAttPoids.Visible = false;
            pcbAttTitle.Visible = false;
            pcbAttTitre.Visible = false;
            pcbAttType.Visible = false;

            //Pré-rempli les dates d'encartages dans la nuit d'aujourd'hui à demain
            txtDateDebut.Text = DateTime.Now.ToShortDateString();
            txtDateFin.Text = DateTime.Now.AddDays(1).ToShortDateString();

            this.ActiveControl = txtTitreEncart;
        }



        /* Quand on tape au clavier dans la textBox des Initiales */
        private void txtInitiales_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(txtInitiales.Text.Length >= 5)
            {
                if((char)Keys.Delete == e.KeyChar || (char)Keys.Back == e.KeyChar)
                {
                    //On accepte de supprimer des caractères
                }
                else
                {
                    //Mais on ne peut plus écrire quoi que ce soit
                    e.Handled = true;
                }
            }
            else
            {
                if (char.IsLetter(e.KeyChar) || (char)Keys.Back == e.KeyChar
                || (char)Keys.Delete == e.KeyChar)
                {
                    /* On ne fait rien si les touches sont des lettres, la touche 
                      retour ou la touche suppr */
                }
                else
                {
                    //Sinon on bloque tous les autres caractères
                    e.Handled = true;
                }
            }
        }

        /* Quand on tape au clavier dans la textBox Date début de l'encart */
        private void txtDateDebut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(txtDateDebut.Text.Length >= 10)
            {
                if((char)Keys.Delete == e.KeyChar || (char)Keys.Back == e.KeyChar)
                {
                    //On accepte la suppression des caractères
                }
                else
                {
                    //On bloque tous les autres caractères
                    e.Handled = true;
                }
            }
            else
            {
                if (char.IsDigit(e.KeyChar) || e.KeyChar == '/'
                    || (char)Keys.Back == e.KeyChar || (char)Keys.Delete == e.KeyChar)
                {
                    /* On ne fait rien si les touches sont des chiffres, la touche 
                     slash, la touche retour ou la touche suppr */
                }
                else
                {
                    //Sinon on bloque tous les autres caractères
                    e.Handled = true;
                }
            }
        }

        /* Quand on tape au clavier dans la textBox Date fin de l'encart */
        private void txtDateFin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtDateFin.Text.Length >= 10)
            {
                if ((char)Keys.Delete == e.KeyChar || (char)Keys.Back == e.KeyChar)
                {
                    //On accepte la suppression des caractères
                }
                else
                {
                    //On bloque tous les autres caractères
                    e.Handled = true;
                }
            }
            else
            {
                if (char.IsDigit(e.KeyChar) || e.KeyChar == '/'
                    || (char)Keys.Back == e.KeyChar || (char)Keys.Delete == e.KeyChar)
                {
                    /* On ne fait rien si les touches sont des chiffres, la touche 
                     slash, la touche retour ou la touche suppr */
                }
                else
                {
                    //Sinon on bloque tous les autres caractères
                    e.Handled = true;
                }
            }
        }

        /* Quand on tape au clavier dans la textBox pour le poids de l'encart */
        private void txtPoids_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || (char)Keys.Back == e.KeyChar 
                || (char)Keys.Delete == e.KeyChar)
            {
                /* On ne fait rien si les touches sont des chiffres,
                  la touche retour ou la touche suppr */
            }
            else
            {
                //Sinon on bloque tous les autres caractères
                e.Handled = true;
            }
        }

    }
}
