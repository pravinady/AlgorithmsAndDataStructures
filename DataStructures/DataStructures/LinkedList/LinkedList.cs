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
            list.AddNodeToEnd(1);
            list.AddNodeToEnd(2);
            list.AddNodeToEnd(3);

            return list;
        }

        public void AddNodeToFront(int data)
        {
            var newNode = CreateNode(data);
            newNode.Next = Head;
            Head = newNode;
            Console.WriteLine($"Inserted new node to the front whose value : {data}");
        }

        public void AddNodeToEnd(int data)
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
            Console.WriteLine($"Inserted new node to the end whose value : {data}");
        }

        public void AddNodeAfter(int nodeToLookFor, int data)
        {
            bool isNodeFound = false;
            var n = Head;
            var prevNode = new Node();
            var nextNode = new Node();
            var newNode = CreateNode(data);

            while (n != null)
            {
                if (n.Data == nodeToLookFor)
                {
                    prevNode = n;
                    nextNode = n.Next;
                    isNodeFound = true;
                    break;
                }
                n = n.Next;
            }
            if (!isNodeFound) throw new Exception("Node to look for is not found");

            newNode.Next = nextNode;
            prevNode.Next = newNode;

            Console.WriteLine($"Inserted new node with value: {data} after the node: {nodeToLookFor}");
        }

        public void DeleteNode(int data)
        {
            if (Head == null)
            {
                throw new Exception("Linked List is empty");
            }

            if (IsDeleteFirstNode(data))
            {
                DeleteFirstNode();
            }
            else
            {
                DeleteMiddleOrLastNode(data);
            }
			Console.WriteLine($"Deleted node with value: {data}");
		}

        private bool IsDeleteFirstNode(int data)
        {
            return Head.Data == data;
        }

        private void DeleteMiddleOrLastNode(int data)
        {
            var curNode = Head;
            Node prevNode = null;

            while (curNode != null && curNode.Data != data)
            {
                
                    prevNode = curNode;
                    curNode = curNode.Next;
            }

            if (prevNode == null)
            {
                throw new Exception("Node is not found when trying to delete it.");
            }
            else
            {
                prevNode.Next = curNode.Next;
            }
        }

        private void DeleteFirstNode()
        {
            Head = Head.Next;
        }

        public void PrintNodes()
        {
            Console.WriteLine("Elements in the linked list are:");
            var node = Head;
            while (node != null)
            {
                Console.WriteLine(node.Data);
                node = node.Next;
            }
        }

		#region Private Methods

		private static Node CreateNode(int data)
		{
			Node newNode = new Node();
			newNode.Data = data;

			return newNode;
		}

        #endregion
    }
}
