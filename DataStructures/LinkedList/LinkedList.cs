using System;
namespace DataStructures.LinkedList
{
    public class LinkedList
    {
        public Node Head;
        public LinkedList()
        {
            Head = null;
        }

        public static LinkedList GetInstance(int length = 3)
        {
            var list = new LinkedList();
            list.AddNode(1);
            list.AddNode(2);
            list.AddNode(3);

            return list;
        }

        private static Node CreateNode(int data)
        {
            Node newNode = new Node();
            newNode.Data = data;
            newNode.Next = null;

            return newNode;
        }

		public void AddNode(int data)
		{
            var newNode = CreateNode(data);
			if (Head == null)
			{
                Head = newNode;
			}
			else
			{
                var curNode = Head;
				while (curNode.Next != null)
                {
                    curNode = curNode.Next;
                }
                curNode.Next = newNode;
			}
            Console.WriteLine($"Inserted new node with value : {data}");
		}

        public void PrintNodes()
        {
            Console.WriteLine("Elements in the linked list are:");
            var node = Head;
            while(node != null)
            {
                Console.WriteLine(node.Data);
                node = node.Next;
            }
        }
    }
}
