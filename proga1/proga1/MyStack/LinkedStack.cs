using System;
using System.Collections.Generic;
namespace proga1
{
	public class LinkedStack
	{
		private class Node
		{
			public int data;
			public Node next;

			public Node(int data, Node next)
			{
				this.data = data;
				this.next = next;
			}

			public Node()
			{
				
			}
		}
		//Variables
		private Node head;
		private int count;

		//CONSTRUCTOR
		public LinkedStack()
		{
			head = new Node();
		}

		//PROPERTIES
		int Count
		{
			get
			{
				return count;
			}
		}

		bool isEmpty
		{
			get
			{
				if (count == 0)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
		}

		//METHODS
		public void Push(int value)
		{
			if ((object)head.data == null)
			{
				head.data = value;
			}
			else
			{
				Node p = new Node(value, head);
				head = p;
				count++;
			}
		}

		public int Pop()
		{
			if (head == null)
			{
				throw new StackNullPointerException();
			}
			else
			{
				int result = head.data;
                return result;
			}
		}
			

	}
}
