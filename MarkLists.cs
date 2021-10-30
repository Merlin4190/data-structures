using System;

namespace LinkedList
{
    public class MarkLists
    {
        public MakeNode head;

        public MarkLists()
        {
            head = null;
        }

        public void InsertAtTheFront(int mark){
            if(head == null)
            {
                head = new MakeNode(mark);
            }
            else
            {
                MakeNode newNode = new MakeNode(mark);
                newNode.Next = head;
                head = newNode;
            }
        }

        public void InsertAtTheMiddle(MakeNode prevNode, int mark){
            if(prevNode != null)
            {
                MakeNode newNode = new MakeNode(mark);
                newNode.Next = prevNode.Next;
                prevNode.Next = newNode;
            }
        }

        public void InsertAtTheEnd(int mark)
        {
            if(head==null)
            {
                head = new MakeNode(mark);
            }
            else
            {
                head.Next = new MakeNode(mark);
            }
        }

        public void Display()
        {
            if(head != null)
            {
                head.Display();
            }
        }
    }
    
}