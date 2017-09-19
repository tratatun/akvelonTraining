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

        public static void DeleteElement(ref MyLinkedList head, int index)
        {
            if (head == null) return;

            if (index == 0)
            {
                head = head.Child;
            }
            else if (head.Child != null)
            {
                if (index == 1)
                {
                    MyLinkedList deleted = head.Child;
                    head.Child = head.Child.Child;
                    deleted.Child = null;
                }
                else
                {
                    DeleteElement(ref head.Child, --index);
                }
            }
        }
        public static void DeleteByValue(ref MyLinkedList head, int value)
        {
            if (head == null) return;

            if (head.Data == value)
            {
                head = head.Child;
            }
            else if (head.Child != null && head.Child.Data == value)
            {
                head.Child = head.Child.Child;
            }
            else
            {
                DeleteByValue(ref head.Child, value);
            }
        }
        public override string ToString()
        {
            return Data + "->" + Child;
        }
    }
}