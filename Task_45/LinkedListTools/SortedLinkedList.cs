namespace LinkedListTools
{
    public class SortedLinkedList
    {
        public Node Head;

        public SortedLinkedList()
        {
        }

        public SortedLinkedList(int data)
        {
            Head = new Node(data);
        }
        
        public void AddNode(int data)
        {
            Node node = new Node(data);
            Node cur = Head;

            if (cur == null)
            {
                Head = node;
                return;
            }

            if (node.Data <= Head.Data)
            {
                node.Child = Head;
                Head = node;
                return;
            }

            while (cur.Data <= node.Data)
            {
                if (cur.Child == null)
                {
                    cur.Child = node;
                    break;
                }

                if (cur.Child.Data > node.Data)
                {
                    node.Child = cur.Child;
                    cur.Child = node;
                    break;
                }
                cur = cur.Child;
            }

        }

        public override string ToString()
        {
            if (Head != null)
            {
                return Head.ToString();
            }
            return string.Empty;
        }
    }
}