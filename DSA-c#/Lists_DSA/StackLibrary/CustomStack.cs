using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackLibrary
{
    public class CustomStack<T>
    {
        public void Push(T item)
        {
            _customLinkedList2.AddFirst(item);
            Count++;
        }




        private CustomLinkedList2<int> _customLinkedList2 = new CustomLinkedList2<int>();
        public int Count = 0;
    }
}
