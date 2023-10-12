using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList1
{
    public class CustomLinkedList<T>
    {
        //public T HeadValue => Head.Value;
        public ListNode<T> Head { get; set; }
        public ListNode<T> Tail { get; set; }

        public void AddNode (ListNode<T> node)
        {
            if (Head == null)
            {
                Head = Tail = node;
            }
            else
            {
                var temp = Tail;
                Tail.NextNode = node;
                Tail = node;
                Tail.PreviousNode = temp;
            }
        }

        public void DeleteNode()
        {

        }
    }
}
