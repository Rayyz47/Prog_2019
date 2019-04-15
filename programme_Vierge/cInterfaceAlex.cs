using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programme_Vierge
{
    //L'interface StringRand contiens une string
    interface StringRand
    {
        string motInterface();
    }

    //L'interface IntRand contiens un int
    interface IntRand
    {
        int intInterface();
    }

    //L'interface contiens plusieurs Variable
    interface MultipleVariable
    {
        string motInterface();
        bool valide();
        int intInterface();
    }


    //La classe genere un string contenant les numeros 0 a 10 et les retourne dans la variable de l'interface
    class Mot : StringRand
    {
        public string motInterface()
        {
            string str = "";
            for (int i = 0; i < 11; i++)
            {
                str += i.ToString() + Environment.NewLine;
            }
            return str;
        }
    }

    //La classe genere un int de 100 a 7000000 et le retourne dans le int de l'interface
    class nombre : IntRand
    {
        public int intInterface()
        {
            Random rnd = new Random();
            int rtn = rnd.Next(100, 7000000);
            return rtn;
        }
    }


    //Une classe peux avoir plusieur interface tent que chaqu'une de variable se trouvant dans les interface recupère une valeur
    class interFinal : MultipleVariable, IntRand, StringRand
    {
        //cette string est dans l'interface MultipleVaraible et StringRand
        public string motInterface()
        {
            string str = "";
            for (int i = 0; i < 11; i++)
            {
                str += i.ToString() + Environment.NewLine;
            }
            return str;
        }
        //Ce int est dans l'interface MultipleVaraible et intInterface
        public int intInterface()
        {
            Random rnd = new Random();
            int rtn = rnd.Next(100, 7000000);
            return rtn;
        }
        //Ce bool est dans l'interface MultipleVaraible seulemeent
        public bool valide()
        {
            bool tst = true;
            tst = false;
            return tst;
        }
    }
}
