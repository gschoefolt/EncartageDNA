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
    public partial class MsgBox : Form
    {
        /* @Variables : Pour le mouvement du formulaire */
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);



        /* @Constructor : Constructeur de ce formulaire */
        public MsgBox()
        {
            InitializeComponent();
        }

        /* @Constructor : Autre constructeur de ce formulaire */
        public MsgBox(string message, string titre, bool YesNo)
        {
            InitializeComponent();
            this.lblMsg.Text = message;
            this.lblTitle.Text = titre;

            if (YesNo) { buildYesNo(); }
        }



        /* @Event (Bouton) : Click sur le bouton "Ok" pour fermer le form */
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /* @Event (Bouton) : Click sur le bouton "OUI" */
        private void btnYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        /* @Event (Bouton) : Click sur le bouton "NON" */
        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }


        /* @Event (Panel) : MouseDown de la barre du haut */
        private void lblTitre_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        /* @Event (Panel) : MouseMove de la barre du haut */
        private void lblTitre_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        /* @Event (Panel) : MouseUp de la barre du haut */
        private void lblTitre_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }




        /* @Method : Construit le formulaire pour le "Oui/Non" */
        private void buildYesNo()
        {
            btnOk.Visible = false;

            Button btnYes = new Button()
            {
                AutoSize = true,
                Text = "OUI",
                Cursor = Cursors.Hand,
                Left = 150,
                Top = 260,
            };
            btnYes.Click += new EventHandler(btnYes_Click);
            this.Controls.Add(btnYes);

            Button btnNo = new Button()
            {
                AutoSize = true,
                Text = "NON",
                Cursor = Cursors.Hand,
                Left = 280,
                Top = 260,
            };
            btnNo.Click += new EventHandler(btnNo_Click);
            this.Controls.Add(btnNo);
        }


        /* @Method : Génére un MsgBox avec un message et un titre */
        public static void show(string msg, string titre)
        {
            MsgBox m = new MsgBox(msg, titre, false);
            m.ShowDialog();
        }

        /* @Method : Génére un MsgBox avec un "Oui/Non" et renvoie le DialoResult */
        public static DialogResult showYesNo(string msg, string titre)
        {
            MsgBox m = new MsgBox(msg, titre, true);
            return m.ShowDialog();
        }

    }
}
