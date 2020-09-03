namespace LinkedListApp
{
    public class Link
    {
        public string Name { get; set; }
        public Link Previous { get; set; }
        public Link Next { get; set; }

        public Link(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
