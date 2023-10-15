using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StackLibrary
{
    public class CustomLinkedList2<T>
    {
        public Node2<T> AddFirst(Node2<T> node)
        {
            if (Head != null)
            {
                var temp = Head;
                node.Next = Head;
                Head = node;
                temp.Prev = Head;
            }
            else
                Head = Tail = node;

            return node;
        }

        public Node2<T> AddNode(Node2<T> node)
        {
            if (Head != null)
            {
                Tail.Next = node;
                node.Prev = Tail;
                Tail = node;
            }
            else
                Head = Tail = node;

            return node;
        }

        public Node2<T>? FindNode(Node2<T> node)
        {
            if (Head != null)
            {
                for (var currentNode = Head; currentNode != null; currentNode = currentNode.Next)
                {
                    if (Equals(currentNode.Value, node.Value))
                    {
                        return currentNode;
                    }
                }
            }
            return null;
        }

        public Node2<T>? DeleteNode(Node2<T> node)
        {
            var nodeToDelete = FindNode(node);
            if (nodeToDelete is null)
            {
                return null;
            }
            else
            {
                if (nodeToDelete.Prev != null)
                    nodeToDelete.Prev.Next = nodeToDelete.Next;
                if (nodeToDelete.Next != null)
                    nodeToDelete.Next.Prev = nodeToDelete.Prev;
                if (nodeToDelete == Head)
                    Head = nodeToDelete.Next;

                return nodeToDelete;
            }
        }

        public void Clear()
        {
            Head = Tail = null;
        }

        public override string ToString()
        {
            string result = "";

            for (var currentNode = Head; currentNode != null; currentNode = currentNode.Next)
            {
                result += currentNode.Value + " ";
            }
            return result;
        }


        public Node2<T> Head {  get; set; }
        public Node2<T> Tail { get; set; }
    }
}
