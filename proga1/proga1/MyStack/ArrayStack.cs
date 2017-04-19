using System;
using System.Collections.Generic;
namespace proga1
{
	public class ArrayStack

	{
		//CONSTANTS
		private static int LENGTH = 10;

		//VARIABLES
		private int[] stack;
		private int position;


		//CONSTRUCTORS
		public ArrayStack()
		{
			stack = new int[LENGTH];
			position = -1;
		}

		public ArrayStack(int length)
		{
			stack = new int[length];
			position = -1;
		}

		//PROPERTIES
		public int Count { get { return position + 1; } }
		public bool isEmpty 
		{ 
			get 
			{
				if (position == -1)
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
			if (position + 2 > stack.Length)
			{
				throw new StackIsFullException();
			}
			else
			{
				stack[++position] = value;
			}
		}

		public int Pop()
		{
			if (position == -1)
			{
				throw new StackIsFullException();
			}
			else
			{
				return stack[position--];
			}
		}

		public int Peek()
		{
			if (position == -1)
			{
				throw new StackIsFullException();
			}
			else
			{
				return stack[position];
			}
		}

		public void Clear()
		{
			position = -1;
		}



	}
}
