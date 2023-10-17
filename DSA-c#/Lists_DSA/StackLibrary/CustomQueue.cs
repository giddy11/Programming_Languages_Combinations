using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackLibrary
{
    public class CustomQueue<T>
    {
        public Node2<T> Enqueue(Node2<T> node)
        {
            return _customLinkedList2.AddNode(node);
        }

        public Node2<T>? Dequeue()
        {
            var remHead = _customLinkedList2.Head;
            return _customLinkedList2.DeleteNode(remHead);
        }


        private CustomLinkedList2<T> _customLinkedList2 = new CustomLinkedList2<T>();
    }
}
