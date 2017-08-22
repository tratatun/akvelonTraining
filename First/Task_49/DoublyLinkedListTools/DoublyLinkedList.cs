using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListTools
{
    public class DoublyLinkedList
    {
        public DoublyLinkedList Previous
        {
            get => _previous;
            set
            {
                _previous = value;
                if (_previous != null)
                {
                    _previous._next = this;
                }
            }
        }
        public DoublyLinkedList Next
        {
            get => _next;
            set
            {
                _next = value;
                if (_next != null)
                {
                    _next._previous = this;
                }
            }
        }

        private DoublyLinkedList _previous;
        private DoublyLinkedList _next;

        public int Data;

        public DoublyLinkedList(int data, DoublyLinkedList next = null, DoublyLinkedList prev = null)
        {
            Data = data;
            Next = next;
            Previous = prev;
        }


        public override string ToString()
        {
            return Previous?.ToString() ?? ToStringNext();
        }

        private string ToStringNext()
        {
            return Data + (Next != null ? "<->" + Next.ToStringNext() : "");
        }
    }
}
