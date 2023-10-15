// See https://aka.ms/new-console-template for more information

var myList = new CustomLinkedList();
var node1 = new Node(1);
var node2 = new Node(2);
var node3 = new Node(3);
var node4 = new Node(4);


myList.AddNode(node1);
myList.AddNode(node2);
myList.AddNode(node3);
myList.DeleteNode1(node4);

//myList.Clear();

//myList.FindNode(node2);

Console.WriteLine(myList.ToString());


class Node
{
    public Node(int value)
    {
        Value = value;
    }

    public int Value { get; set; }
    public Node Prev { get; set; }
    public Node Next { get; set; }
}

class CustomLinkedList
{
    public void AddNode(Node node)
    {
        if (Head == null)
        {
            Head = Tail = node;
        }
        else
        {
            var temp = Tail;
            Tail.Next = node;
            Tail = node;
            Tail.Prev = temp;
        }
    }

    public void AddFirst(Node node)
    {
        if (Head == null)
        {
            Head = Tail = node;
        }
        else
        {
            //var temp = Head;
            //temp.PreviousNode = node; // Set the previous node of the current Head
            //node.NextNode = temp;     // Set the next node of the new node
            //Head = node;
            var temp = node;
            Head.Prev = node;
            node.Next = Head;
            Head = temp;
        }
    }

    public void AddLast(Node node)
    {
        AddNode(node);
    }

    public Node? FindNode(Node node)
    {
        if (Head != null)
        {
            for (var currentNode = Head; currentNode != null; currentNode = currentNode.Next)
            {
                if (currentNode.Value == node.Value)
                {
                    return currentNode;
                }
            }
        }
        return null;
    }

    public Node? DeleteNode(Node node)
    {
        if (Head != null)
        {
            for (var curr = Head; curr != null; curr = curr.Next)
            {
                if (Equals(curr.Value, node.Value))
                {
                    curr.Prev.Next = curr.Next;
                    curr.Next.Prev = curr.Prev;
                    return curr;
                }
            }
        }
        return null;   
    }

    public Node? DeleteNode1(Node node)
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

        for (var current = Head; current != null; current = current.Next)
        {
            result += current.Value + " ";
        }

        return result;
    }



    public Node Head { get; set; }
    public Node Tail { get; set; }
}