using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proga1.MyQueque
{
    class LinkedQueque
    {
        private class Node
        {
            public int data;
            public Node next;
            public Node prev;

            public Node(int data, Node next, Node prev)
            {
                this.data = data;
                this.next = next;
                this.prev = prev;
            }

            public Node()
            {

            }
        }

        private Node head;
        private int count = 0;

        public LinkedQueque()
        {
            head = new Node();
        }

        public int Cout
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

        public void Enqueue(int NN)
        {
            if ((object)head.data == null)
            {
                head.data = NN;
                ++count;
            }
            else
            {
                Node p = new Node(NN, head, null);
                head.prev = p;
                head = p;
                ++count;
            }
        }
        void Clear()
        {
            count = 0;
        }
        int Dequeue()
        {
            if (head == null)
            {
                throw new StackNullPointerException();
            }
            else
            {
                Node p = head;
                head = head.prev;
                return p.data;
            }
        }
        int Peek()
        {
            if (count == 0)
            {
                Console.WriteLine("Queue probably is not exist");
                return 0;
            }
            else
            {
                return head.data;
            }
        }
    }
}
