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

        public MyLinkedList Reverse(MyLinkedList parent = null)
        {
            MyLinkedList child = Child;
            Child = parent;

            if (child != null)
            {
                return child.Reverse(this);
            }
            return this;
        }

        public override string ToString()
        {
            return Data + "->" + Child;
        }
    }
}