using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programme_Vierge
{
    public abstract class cAnimal
    {
        //ici est envoiyer le nom qu on a mis dans le formulaire qui est lue
        public string Name;

        public int NumberOfLegs { get; }
        public cAnimal(int numberOfLegs)
        {
            NumberOfLegs = numberOfLegs;
        }

        //Void abstract pour dire que l animal parle 
        public abstract void Talk();
        //Une void virtuel pour dire que l animal mange donc le nom de l animal avec la caracterisque de manger 
        public virtual void Eat()
        {
            frmPoly2.affichageTotal+=($"{Name} eats! \r\n");
        }

    }

   
}

