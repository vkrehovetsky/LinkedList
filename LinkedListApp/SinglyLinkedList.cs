using System.Text;

namespace LinkedListApp
{
    public class SinglyLinkedList
    {
        private Link _first;
        private Link _last;

        public Link Add(string name)
        {
            Link link = new Link(name);

            if (_first == null)
            {
                _first = link;
                _last = link;
            }
            else
            {
                _last.Next = link;
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
            Link currentNode = _first;
            while (currentNode != null)
            {
                if (val.Equals(currentNode.Name))
                    return true;

                currentNode = currentNode.Next;
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
    }
}
