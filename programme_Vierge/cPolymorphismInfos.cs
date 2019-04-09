namespace programme_Vierge
{
    class cPolymorphismInfos : cTemplateInfos
    {
        public string nameChild = "";
        public string contentChild = "";
        public int dateEntryChild = 0;

        public override string isAuthor()
        {
            nameChild = "Marie-Pier et Denis";
            return nameChild;
        }

        public override string isContent()
        {
            contentChild = "Polymorphisme";
            return contentChild;
        }

        public override int isDate()
        {
            dateEntryChild = 20190408;
            return dateEntryChild;
        }

        public override bool IsTitle(string titleEntry)
        {
            return base.IsTitle(titleEntry);
        }
    }
}