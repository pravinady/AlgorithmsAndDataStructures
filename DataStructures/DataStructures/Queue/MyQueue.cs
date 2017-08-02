using System;

namespace Practice.DataStructures
{
    public class MyQueue<T>
    {
		public Node<T> Head;
		public MyQueue()
		{
			Head = null;
		}

        public Node<T> Push(T data)
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
			Console.WriteLine($"Pushed new node : {data}");

            return newNode;
		}

        public Node<T> Pop()
		{
			if (Head == null)
			{
				throw new Exception("Queue is empty");
			}

            var deletedNode = Head;
			Head = Head.Next;

            Console.WriteLine($"Deleted node with value: {deletedNode.Data}");
            return deletedNode;
		}

		public void PrintNodes()
		{
			Console.WriteLine("Elements in the queue are:");
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
