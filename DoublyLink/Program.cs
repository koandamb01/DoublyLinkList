using System;

namespace DoublyLink
{
    class Program
    {
        static void Main(string[] args)
        {
            CircularDoublyLinkList Circular = new CircularDoublyLinkList();

            Circular.AddToTail(5);
            Circular.AddToTail(3);
            Circular.AddToTail(1);

            Console.WriteLine($"Prev {Circular.ControlNode.Prev.Value}");
            Console.WriteLine($"Next {Circular.ControlNode.Next.Value}");
        }
    }
}
