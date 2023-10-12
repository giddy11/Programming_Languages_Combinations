using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList1
{
    public class ListNode<T>
    {
        //creating a node when you havent decided whether its at the head or tail
        public ListNode(T value)
        {
            Value = value;
        }

        //creating a node at the head or tail
        public ListNode(T value, ListNode<T> previousNode): this(value)
        {
            PreviousNode = previousNode;
        }

        public T Value { get; set; }
        public ListNode<T> PreviousNode { get; set; }
        public ListNode<T> NextNode { get; set; }
    }
}
