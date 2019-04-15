using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programme_Vierge
{
    class cSnake : cAnimal
    {
        // recoit en parametre commbien de legs le serpant a dans ce cas ci c est 0
        public cSnake() : base(0)
        {

        }
        //Cette void override la void Talk pour donner une specificiter a comment un serpant parle 
        public override void Talk()
        {
            frmPoly2.affichageTotal += ("Hissssss \r\n");
        }

    }
}
