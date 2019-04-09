using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programme_Vierge
{
    class cInterface : cTemplateInfos
    {
        public string nameChild = "";
        public string contentChild = "";
        public int dateEntryChild = 0;

        public override string isAuthor()
        {
            nameChild = "Alexandre";
            return nameChild;
        }

        public override string isContent()
        {
            contentChild = "Interface";
            return contentChild;
        }

        public override int isDate()
        {
            dateEntryChild = 20190409;
            return dateEntryChild;
        }
    }
}
