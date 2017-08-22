namespace DoublyLinkedListTools
{
    public static class DoublyLinkedListTools
    {
        private static DoublyLinkedList Delete(DoublyLinkedList list)
        {
            if (list.Previous != null)
            {
                list.Previous.Next = list.Next;
                return GetHead(list.Previous);
            }

            if (list.Next != null)
            {
                list.Next.Previous = list.Previous;
                return GetHead(list.Next);
            }
            return null;
        }

        private static DoublyLinkedList GetHead(DoublyLinkedList list)
        {
            return list.Previous != null ? GetHead(list.Previous) : list;
        }

        public static DoublyLinkedList DeleteElementWithData(DoublyLinkedList list, int data)
        {
            DoublyLinkedList pointer = list;
            while (pointer != null)
            {
                if (pointer.Data == data)
                {
                    return Delete(pointer);
                }
                pointer = pointer.Next;
            }

            // traversing list in both lift and right ways

            pointer = list;
            while (pointer != null)
            {
                if (pointer.Data == data)
                {
                    return Delete(pointer);
                }
                pointer = pointer.Previous;
            }

            return list;
        }
        public static DoublyLinkedList DeleteElementNextAt(DoublyLinkedList list, int index)
        {
            DoublyLinkedList pointer = list;
            int counter = 0;
            while (pointer != null)
            {
                if (counter == index)
                {
                    return Delete(pointer);
                }
                counter++;
                pointer = pointer.Next;
            }
            return list;
        }
    }
}