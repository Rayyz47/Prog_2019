using System;
using System.Windows.Forms;

namespace programme_Vierge
{
    public partial class frmInterface : Form
    {
        public frmInterface()
        {
            InitializeComponent();
        }
        //Retourne au menu de choix
        private void button1_Click(object sender, EventArgs e)
        {
            frmAccueil frm = new frmAccueil();
            frm.Show();
            Close();
        }
        //bouton qui Instensie l'interface et affiche le resultat
        private void btnBTN_Click(object sender, EventArgs e)
        {
            //Instensiation de l'interface
            Mot inter = new Mot();
            //Affiche le retour de l'interface mot
            MessageBox.Show(inter.motInterface());
        }

        private void btnBTN3_Click(object sender, EventArgs e)
        {
            //Instensiation de l'interface
            interFinal inter = new interFinal();
            //Affiche le retour de l'interface mot
            MessageBox.Show(inter.motInterface());
            //Affiche le retour de l'interface int
            MessageBox.Show(inter.intInterface().ToString());
            //Affiche le retour de l'interface de validation
            MessageBox.Show(inter.valide().ToString());
        }

        private void btnBTN2_Click(object sender, EventArgs e)
        {
            //Instensiation de l'interface
            nombre inter = new nombre();
            //Affiche le retour de l'interface int
            MessageBox.Show(inter.intInterface().ToString());
        }
    }
}
