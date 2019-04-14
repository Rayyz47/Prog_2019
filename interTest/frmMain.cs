using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interTest
{

    /// <summary>
    /// Une interface ne peut contenir de champs, elle ne peut que contenir des propriété, indexeurs, etc.
    /// Tout est implicitement public.
    /// Une interface peut elle meme hériter de une ou plusieurs interface.
    /// Une classe peut implémenter le nombre d'interface qu'elle le souhaite.
    /// </summary>

    public partial class frmFRM : Form
    {
        public frmFRM()
        {
            InitializeComponent();
        }

        //L'instanciation d'une classe interfacé de fait de la sorte:
        //  *interface_name* *name* = new *classe_interfacé".
        // Ceci donne accès au définition de la methode de l'interface selon la classe instancié.
        private void btnBTN_Click(object sender, EventArgs e)
        {
            interfas inter = new cInterface();
            MessageBox.Show(inter.inter1());
        }

        private void btnBTN2_Click(object sender, EventArgs e)
        {
            interfase inter = new cInterface2();
            MessageBox.Show(inter.inter2().ToString());
        }

        private void btnBTN3_Click(object sender, EventArgs e)
        {
            imterrfase inter = new cInterface3();
            MessageBox.Show(inter.inter1());
            MessageBox.Show(inter.inter2().ToString());
            MessageBox.Show(inter.inter3().ToString());
        }
    }
}
