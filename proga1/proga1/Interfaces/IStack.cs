using System;
using System.Collections.Generic;

namespace proga1
{
	public interface IStack<Integer>:IEnumerable<int>
	{
		int Count { get;}
		bool isEmpty { get; }

		void Push(int value);
		void Clear();
		int Pop();
		int Peek();
	}
}
