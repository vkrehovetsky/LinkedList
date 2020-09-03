using System.Text;

namespace LinkedListApp
{
    public class DoublyLinkedList
    {
        private Link _first;
        private Link _last;

        public Link Add(string name)
        {
            Link link = new Link(name);

            if (_first == null)
            {
                _first = _last = link;
            }
            else
            {
                _last.Next = link;
                link.Previous = _last;
                link.Next = null;
                _last = link;
            }

            return link;
        }

        public Link Delete()
        {
            Link current = _first;

            if (_first == null)
                return null;
            if (_first.Next == null)
            {
                _first = null;
                return _last;
            }

            while (current.Next != null)
            {
                _last = current;
                current = current.Next;
            }
            _last.Next = null;
            return current;
        }

        public bool Contains(string val)
        {
            Link current = _first;
            while (current != null)
            {
                if (val.Equals(current.Name))
                    return true;

                current = current.Next;
            }
            return false;
        }

        public override string ToString()
        {
            Link current = _first;
            StringBuilder stringBuilder = new StringBuilder();
            while (current != null)
            {
                stringBuilder.Append(current);
                current = current.Next;
            }
            return stringBuilder.ToString();
        }

        public void AddAfter(Link link, string name)
        {
            if (link == null || string.IsNullOrEmpty(name))
                return;
            Link newLink = new Link(name);
            newLink.Previous = link;
            if (link.Next != null)
                link.Next.Previous = newLink;
            newLink.Next = link.Next;
            link.Next = newLink;
        }
    }
}
