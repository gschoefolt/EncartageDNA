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
    public partial class frmStart : Form
    {
        UCSaisieEncart ucSaisieEncart; //Qui gère la partie saisie encart

        /* Constructeur du formulaire */
        public frmStart()
        {
            InitializeComponent();
        }

        /* Evenement load pour ce formulaire */
        private void frmStart_Load(object sender, EventArgs e)
        {
            this.ActiveControl = lblTitre;
        }



        /* Si pression de la croix en haut a droite ou sur le bouton quitter */
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /* Clique pour minimiser la fenetre */
        private void btnMinim_Click(object sender, EventArgs e)
        { 
            this.WindowState = FormWindowState.Minimized;
            this.ActiveControl = lblTitre;
        }



        /* Animation pour l'entrer de la souris dans un des menu */
        private void lblSaisieEncart_MouseEnter(object sender, EventArgs e)
        {
            if(sender is Label)
            {
                Panel pnl = (Panel)((Label)sender).Parent;
                pnl.BackColor = Color.FromArgb(233, 233, 233);
            }
            else if(sender is Panel)
            {
                Panel pnl = (Panel)sender;
                pnl.BackColor = Color.FromArgb(233, 233, 233);
            }
        }

        /* Animation pour la sortie de la souris des menus */
        private void lblSaisieEncart_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Label)
            {
                Panel pnl = (Panel)((Label)sender).Parent;
                pnl.BackColor = Color.White;
            }
            else if (sender is Panel)
            {
                Panel pnl = (Panel)sender;
                pnl.BackColor = Color.White;
            }
        }



        /* L'utilisateur veut saisir un encart et clique sur le menu de saisie encart */
        private void lblSaisieEncart_Click(object sender, EventArgs e)
        {
            if(ucSaisieEncart == null) //Si on ne la jamais généré
            {
                ucSaisieEncart = new UCSaisieEncart();
                ucSaisieEncart.Left = 30;
                ucSaisieEncart.Top = 30;
                pnlContent.Controls.Add(ucSaisieEncart);
            }
            else //Sinon on le montre
            {
                ucSaisieEncart.Show();
            }
        }
    }
}
