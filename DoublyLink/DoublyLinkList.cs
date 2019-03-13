using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLink
{
    public class DoublyLinkList
    {
        public DoublyLinkList()
        {
            Head = null;
            Tail = null;
        }
        public Node Head { get; set; }
        public Node Tail { get; set; }

        public int GetTail()
        {
            if(Tail == null)
            {
                return -1;
            }

            return Tail.Value;
        }
        public void AddToTail(int val)
        {
            Node newNode = new Node(val);

            if(Head == null && Tail == null)
            {
                Head = newNode;
                Tail = newNode;
            } else
            {
                Node runner = Head; 
                while(runner.Next != null)
                {
                    runner = runner.Next;
                }

                runner.Next = newNode;
                Tail = runner.Next;
                Tail.Prev = runner;
            }
        }
    }
}
