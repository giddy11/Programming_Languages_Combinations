using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackLibrary
{
    public class Node2<T>
    {
        public Node2(T value)
        {
            Value = value;
        }

        public T Value { get; set; }
        public Node2<T> Prev { get; set; }
        public Node2<T> Next { get; set; }
    }
}
