using System;
namespace DataStructures.LinkedList
{
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        public Node()
        {
            Data = 0;
            Next = null;
        }
    }
}