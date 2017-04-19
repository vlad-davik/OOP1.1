using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proga1.Interfaces
{
    interface IQueue<Integer> : IEnumerable<int>
    {
        int Cout { get; }
        bool isEmpty { get; }

        void Enqueue(int NN);
        void Clear();
        int Dequeue();
        int Peek();
    }
}
