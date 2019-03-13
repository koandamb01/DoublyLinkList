using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLink
{
    class CircularDoublyLinkList
    {
        public Node ControlNode {get; set;}

        public CircularDoublyLinkList()
        {
            ControlNode = new Node(0);
        }

        public void AddToTail(int val)
        {
            Node newNode = new Node(val);

            if (ControlNode.Prev == null && ControlNode.Next == null)
            {
                ControlNode.Next = newNode;
                ControlNode.Prev = newNode;

                newNode.Prev = ControlNode;
                newNode.Next = ControlNode;
            }
            else
            {
                Node runner = ControlNode.Prev;
                while (runner.Next != ControlNode)
                {
                    runner = runner.Next;
                }

                runner.Next = newNode;
                newNode.Prev = runner;
                newNode.Next = ControlNode;
                ControlNode.Next = newNode;
            }
        }
    }
}
