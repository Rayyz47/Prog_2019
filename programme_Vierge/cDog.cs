using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programme_Vierge
{
    class cDog: cAnimal
    {
        public cDog() : base(4)
        {

        }
        //Cette void override la void Talk pour donner une specificiter a comment un chat parle 
        public override void Talk()
        {
            frmPoly2.affichageTotal += ("Woof! \r\n");
        }

        public void Guard()
        {
            MessageBox.Show("The dog guards the house!");
        }

    }
}
