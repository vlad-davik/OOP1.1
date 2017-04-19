using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proga1.MyQueque
{
    class ArrayQueue
    {
        private static int LENGTH = 10;

        private int[] queue;
        private int position;

        public ArrayQueue()
        {
            queue = new int[LENGTH];
            position = -1;
        }

        public ArrayQueue(int length)
        {
            queue = new int[length];
            position = -1;
        }

        int Cout
        {
            get
            {
                return position + 1;
            }
        }

        bool isEmpty
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

        void Enqueue(int NN)
        {
            if (position + 2 > queue.Length)
            {
                Console.WriteLine("Queue is full");
            }
            else
            {
                queue[++position] = NN;
            }
        }
        void Clear()
        {
            position = -1;
        }
        public int Dequeue()
        {
            if (position == -1)
            {
                Console.WriteLine("Queue probably is not exist");
                return -1;
            }
            else
            {
                return queue[position--];
            }
        }
        public int Peek()
        {
            if (position == -1)
            {
                Console.WriteLine("Queue probably is not exist");
                return -1;
            }
            else
            {
                return queue[position];
            }
        }
    }
}

