namespace programme_Vierge
{
    class cGit : cTemplateInfos
    {
        public string nameChild = "";
        public string contentChild = "";
        public int dateEntryChild = 0;

        public override string isAuthor()
        {
            nameChild = "Philippe et Émile";
            return nameChild;
        }

        public override string isContent()
        {
            contentChild = "gitgitgitgit";
            return contentChild;
        }

        public override int isDate()
        {
            dateEntryChild = 20190409;
            return dateEntryChild;
        }
    }
}
