using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackLibrary
{
    public class CustomStack<T>
    {
        public Node2<T> Push(Node2<T> node)
        {
            _customLinkedList2.AddFirst(node);
            _customLinkedList2.Count++;
            return node;
        }

        public Node2<T>? Pop()
        {
            var rem = _customLinkedList2.DeleteFirstNode();
            _customLinkedList2.Count--;
            return rem;
        }

        public Node2<T>? Pop2()
        {
            var remHead = _customLinkedList2.Head;
            _customLinkedList2.DeleteNode(remHead);
            _customLinkedList2.Count--;
            return remHead;
        }

        public T Peek()
        {
            return _customLinkedList2.Head.Value;
        }




        private CustomLinkedList2<T> _customLinkedList2 = new CustomLinkedList2<T>();
    }
}
