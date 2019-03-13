using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLink
{
    public class Node
    {
        
        public int Value { get; set; }
        public Node Next { get; set; }
        public Node Prev { get; set; }

        public Node(int val)
        {
            Value = val;
            Next = null;
            Prev = null;
        }
    }
}
