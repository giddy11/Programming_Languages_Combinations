// See https://aka.ms/new-console-template for more information

Console.WriteLine("hello");

var myList = new CustomLinkedList();
var node1 = new Node(1);
var node2 = new Node(2);
var node3 = new Node(3);

myList.AddNode(node1);
myList.AddNode(node2);
myList.AddNode(node3);

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

    public override string ToString()
    {
        Node current = Head;
        string result = "";

        while (current != null)
        {
            result += current.Value + " ";
            current = current.Next;
        }

        return result;
    }



    public Node Head { get; set; }
    public Node Tail { get; set; }
}