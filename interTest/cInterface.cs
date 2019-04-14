using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interTest
{
    interface interfas
    {
        string inter1();
    }


    interface interfase
    {
        int inter2();
    }


    interface imterrfase
    {
        string inter1();
        bool inter3();
        int inter2();
    }





    class cInterface: interfas
    {
        public string inter1()
        {
            string str = "";
            for (int i = 0; i < 10; i++)
            {
                str += i.ToString() + Environment.NewLine;
            }
            return str;
        }
    }


    class cInterface2 : interfase
    {
        public int inter2()
        {
            int rtn = 18;
            return rtn;
        }
    }



    class cInterface3 : interfas,interfase,imterrfase
    {
        public string inter1()
        {
            string str = "";
            for (int i = 0; i < 10; i++)
            {
                str += i.ToString() + Environment.NewLine;
            }
            return str;
        }

        public int inter2()
        {
            int rtn = 18;
            return rtn;
        }

        public bool inter3()
        {
            bool tst = true;
            tst = false;
            return tst;
        }
    }
}
