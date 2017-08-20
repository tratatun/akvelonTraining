namespace LinkedListTools
{
    public class Node
    {
        public int Data;
        public Node Child;

        public Node()
        {
        }

        public Node(int data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data + "->" + Child;
        }
    }
}