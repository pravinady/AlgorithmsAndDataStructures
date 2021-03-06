﻿using System;
namespace Practice.DataStructures
{
    public class MyLinkedList<T>
    {
        public Node<T> Head;
        public MyLinkedList()
        {
            Head = null;
        }

        public void AddNodeToFront(T data)
        {
            var newNode = CreateNode(data);
            newNode.Next = Head;
            Head = newNode;
            Console.WriteLine($"Inserted new node to the front whose value : {data}");
        }

        public void AddNodeToEnd(T data)
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

        public void AddNodeAfter(T nodeToLookFor, T data)
        {
            bool isNodeFound = false;
            var n = Head;
            var prevNode = new Node<T>();
            var nextNode = new Node<T>();
            var newNode = CreateNode(data);

            while (n != null)
            {
                if (n.Data.Equals(nodeToLookFor))
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

        public void DeleteNode(T data)
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

        private bool IsDeleteFirstNode(T data)
        {
            return Head.Data.Equals(data);
        }

        private void DeleteMiddleOrLastNode(T data)
        {
            var curNode = Head;
            Node<T> prevNode = null;

            while (curNode != null && !curNode.Data.Equals(data))
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

        private static Node<T> CreateNode(T data)
		{
			Node<T> newNode = new Node<T>();
			newNode.Data = data;

			return newNode;
		}

        #endregion
    }
}
