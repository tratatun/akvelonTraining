namespace LinkedListTools
{
    public class MyLinkedList
    {
        public int Data;
        public MyLinkedList Child;

        public MyLinkedList()
        {
        }

        public MyLinkedList(int data, MyLinkedList child = null)
        {
            Data = data;
            Child = child;
        }

        public void AddLast(MyLinkedList last)
        {
            if (Child != null)
            {
                Child.AddLast(last);
            }
            else
            {
                Child = last;
            }
        }

        public bool AddAtIndex(MyLinkedList node, int index)
        {
            if (index == 1)
            {
                node.Child = Child;
                Child = node;
                return true;
            }

            if(Child != null)
            {
                return Child.AddAtIndex(node, --index);
            }

            return false;
        }

        public MyLinkedList DeleteElement(int index)
        {
            if (Child != null)
            {
                if (index == 1)
                {
                    MyLinkedList deleted = Child;
                    Child = Child.Child;
                    deleted.Child = null;
                    return deleted;
                }
                else
                {
                    return Child.DeleteElement(--index);
                }
            }
            return null;
        }

        public override string ToString()
        {
            return Data + "->" + Child;
        }
    }
}