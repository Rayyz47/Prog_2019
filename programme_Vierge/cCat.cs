using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programme_Vierge
{
    class cCat : cAnimal
    {
        // recoir en parametre commbien de legs le chats a dans ce cas ci c est 4
        public cCat() : base(4)
        {

        }
        //Cette void override la void Talk pour donner une specificiter a comment un chat parle 
        public override void Talk()
        {
            frmPoly2.affichageTotal += ("Miow \r\n");
        }
        //Cette void override la void virtuel Eat pour donner une specificiter a comment un chat mange 
        public override void Eat()
        {
            frmPoly2.affichageTotal += ($"{Name} eats a fancy meal. \r\n");
        }


    }
}
