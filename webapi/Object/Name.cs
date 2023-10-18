namespace webapi.Object
{
    public class Name
    {
        public string First { get; set; }
        public string Last { get; set; }

        public Name(string first, string last)
        {
            First = first;
            Last = last;
        }
    }
}