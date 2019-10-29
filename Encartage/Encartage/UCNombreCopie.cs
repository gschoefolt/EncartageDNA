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
    public partial class UCNombreCopie : UserControl
    {
        /* @Variables : Nombre à garder en mémoire */
        private int nbActuel = 1;



        /* @Constructor : Constructeur du UserControl */
        public UCNombreCopie()
        {
            InitializeComponent();
        }



        /* @Event (Bouton) : Ajoute 1 au nombre dans la texteBox */
        private void btnPlus_Click(object sender, EventArgs e)
        {
            nbActuel = int.Parse(txtCompte.Text) + 1;
            txtCompte.Text = nbActuel.ToString();
        }

        /* @Event (Bouton) : Enlève 1 au nombre dans la texteBox */
        private void btnMoins_Click(object sender, EventArgs e)
        {
            nbActuel = Math.Max(int.Parse(txtCompte.Text) - 1, 0);
            txtCompte.Text = nbActuel.ToString();
        }



        /* @Method : Retourne le nombre actuel dans la texteBox */
        public int nbCopie
        {
            get
            {
                return this.nbActuel;
            }

            set
            {
                this.nbActuel = value;
            }
        }

    }
}
