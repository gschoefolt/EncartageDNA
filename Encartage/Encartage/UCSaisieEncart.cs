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
    public partial class UCSaisieEncart : UserControl
    {
        UCFicheSaisieEncart ucFicheSaisieEncart;

        /* Constructeur du UserControl qui va gérer la partie saisie encart */
        public UCSaisieEncart()
        {
            InitializeComponent();
        }

        /* Événement load de ce UserControl */
        private void UCSaisieEncart_Load(object sender, EventArgs e)
        {
            //On commence la première étape de la saisie de l'encart
            ucFicheSaisieEncart = new UCFicheSaisieEncart();
            ucFicheSaisieEncart.Left = 0;
            ucFicheSaisieEncart.Top = 0;
            this.Controls.Add(ucFicheSaisieEncart);
        }
    }
}
