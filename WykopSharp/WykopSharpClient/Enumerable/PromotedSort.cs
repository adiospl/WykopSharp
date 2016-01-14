namespace WykopSharpClient.Enumerable
{
    namespace Search
    {
        public enum What
        {
            All,
            Promoted,
            Archive,
            Duplicates
        }

        public enum Sort
        {
            Best,
            Diggs,
            Comments,
            New
        }

        public enum When
        {
            All,
            Today,
            Yesterday,
            Week,
            Month,
            Range
        }
    }

    namespace Links
    {
        public enum PromotedSort
        {
            Day,
            Week,
            Month
        }

        public enum UpcommingSort
        {
            Date,
            Votes,
            Comments
        }
    }
}