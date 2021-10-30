using System;

namespace LinkedList
{
    public class MakeNode
    {
        public int Mark { get; set; }

        public MakeNode Next { get; set; }

        public MakeNode(int mark, MakeNode next = null)
        {
            Mark = mark;
            Next = next;
        }

        public void InsertAtTheEnd(int mark)
        {
            if(Next == null){
                Next = new MakeNode(mark);
            }
            else
            {
                Next.InsertAtTheEnd(mark);
            }
        }

        public void Display()
        {
            Console.Write($"{Mark}->");

            if(Next != null)
            {
                Next.Display();
            }
        }
    }

}