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

        public void AddAtIndex(MyLinkedList node, int index)
        {
            if (index <= 0)
            {
                node.Child = Child;
                Child = node;
            }
            else
            {
                index--;
                Child.AddAtIndex(node, index);
            }
        }

        public void DeleteElements(int indexStart, int indexlast)
        {
            //if (index <= 0)
            //{
            //    node.Child = Child;
            //    Child = node;
            //}
            //else
            //{
            //    index--;
            //    Child.AddAtIndex(node, index);
            //}
        }



        public override string ToString()
        {
            return Data + "->" + Child;
        }
    }
}