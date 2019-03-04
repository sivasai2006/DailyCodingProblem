using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp
{
	public class Solution
	{
		private const string EmptyMarker = "1";

		public static void Test()
		{
			var node = new Node<string>("root", new Node<string>("left", new Node<string>("left.left"), null), new Node<string>("right"));

			var serialized = Serialize(node);

			Console.WriteLine(serialized);
			node = Deserialize(serialized);

			Console.WriteLine(node.Left.Left.Value);
		}

		public static string Serialize(Node<string> node)
		{
			if (node == null)
			{
				return EmptyMarker + '-';
			}

			var builder = new StringBuilder();

			builder.Append(node.Value + "-");

			builder.Append(Serialize(node.Left));
			builder.Append(Serialize(node.Right));

			return builder.ToString();
		}

		public static Node<string> Deserialize(string serializedNode)
		{
			String[] nodes = serializedNode.Split('-');//.ToArray();

			var queue = new Queue<string>(nodes);

			var node = DeserializeNode(queue);

			return node;
		}

		private static Node<string> DeserializeNode(Queue<string> nodes)
		{
			if (nodes.Peek() != null)
			{
				var nextNode = nodes.Dequeue();

				if (nextNode == EmptyMarker)
				{
					return null;
				}

				var node = new Node<string>(nextNode) {
					Left = DeserializeNode(nodes),
					Right = DeserializeNode(nodes)
				};

				return node;
			}

			return null;
		}
	}

    class Node<T>
		{
			public Node(T value)
			{
				Value = value;
			}

			public Node(T value, Node<T> left, Node<T> right)
				: this(value)
			{
				this.Left = left;
				this.Right = right;
			}

			public Node<T> Right { get; set; }

			public Node<T> Left { get; set; }

			public T Value { get; set; }
}
}

