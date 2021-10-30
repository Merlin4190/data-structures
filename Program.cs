using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            MarkLists mark = new MarkLists();
            mark.InsertAtTheEnd(5);
            mark.InsertAtTheFront(10);
            mark.InsertAtTheMiddle(mark.head, 8);
            mark.Display();
            Console.ReadLine();
        }
    }
}
