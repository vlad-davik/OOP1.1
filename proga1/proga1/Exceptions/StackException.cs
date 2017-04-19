using System;
using System.Diagnostics;
namespace proga1
{
	public class StackException : Exception
	{
		public StackException():base()
		{
		}
	}

	public class StackNullPointerException:StackException
	{
		public StackNullPointerException() : base()
		{
			Debug.WriteLine("Stack probably is not exist");
		}
	}
	/// <summary>
	/// Exception only for array-based implementation
	/// </summary>
	public class StackIsFullException : StackException
	{
		public StackIsFullException() : base()
		{
			Debug.WriteLine("Stack is full yet");
		}
	}

}
