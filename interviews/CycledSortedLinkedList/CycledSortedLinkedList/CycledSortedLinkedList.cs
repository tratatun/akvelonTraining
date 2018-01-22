using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycledSortedLinkedList
{
    public class LinkedList
    {
        // There is a cycled sorted linked list. The smaller element refers to the biggest one. 
        // Implement the insert operation into the list. The insert operation must not brake the sort condition and the cycle condition.

        public LinkedList NextNode;
        public int Data;

        public LinkedList(int data)
        {
            Data = data;
        }

        public void Insert(int newData, LinkedList head = null)
        {
            if (head == null) // saving Head of list
            {
                head = this;
            }

            if (NextNode == this)
            {
                throw new Exception("Wrong Input");
            }

            if (NextNode == null)
            {
                LinkedList newNode = new LinkedList(newData);
                NextNode = newNode;
                newNode.NextNode = this;
                return;
            }

            if (NextNode.Data <= newData && newData < NextNode.NextNode.Data)
            {
                LinkedList newNode = new LinkedList(newData);
                newNode.NextNode = NextNode.NextNode;
                NextNode.NextNode = newNode;
            }
            else if(NextNode.Data >= NextNode.NextNode.Data)
            {
                LinkedList newNode = new LinkedList(newData);
                if (NextNode.Data <= newData)
                {
                    newNode.NextNode = NextNode;
                    NextNode = newNode;
                }

                if (NextNode.NextNode.Data >= newData)
                {
                    newNode.NextNode = NextNode.NextNode;
                    NextNode.NextNode = newNode;
                }
            }
            else
            {
                NextNode.Insert(newData, head);
            }
        }

        //public override string ToString()
        //{
        //    if (Data > NextNode.Data)
        //    {
        //        return Data + "->"+ NextNode;
        //    }
        //    else
        //    {
        //        return Data +"->[loop]";
        //    }
        //}
    }
}
