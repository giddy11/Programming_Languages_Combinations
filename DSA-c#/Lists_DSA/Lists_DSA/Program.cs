// See https://aka.ms/new-console-template for more information

/*  First example  */
/*var randList = new List<object>();
var one_to_ten = Enumerable.Range(1,10).ToList();

randList.Add("string");
randList.Add(1.234);
randList.Add(28);

randList.AddRange(one_to_ten.Cast<object>());

//Console.WriteLine("Random List:");
//foreach (var element in randList)
//{
//    Console.WriteLine(element);
//}

Console.WriteLine(randList[0]);
Console.WriteLine($"List Length: {randList.Count}");

//Console.WriteLine("First 3 Random List:");
//for(int i = 0; i < 3; i++)
//{
//    Console.WriteLine($"{i} : {randList[i]}");
//}

//Console.WriteLine("First 3 Random List:");
//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        Console.Write(randList[i]);
//    }
//    Console.WriteLine();
//}
var first3 = randList.Take(3).ToList();

Console.WriteLine($"Index of string: {first3.IndexOf("string")}");
Console.WriteLine($"How many strings: {first3.Count(item => item is string && (string)item == "string")}");

first3[0] = "New String";
foreach(var item in first3)
{
    Console.WriteLine(item);
}
Console.WriteLine("\n\n");

first3.Add("Another");
foreach (var item in first3)
{
    Console.WriteLine(item);
}
Console.WriteLine("\n\n");

Console.WriteLine();

*/

var myList = new CustomLinkedList<int>();
var val1 = new ListNode<int>(1);
var val2 = new ListNode<int>(2);
var val3 = new ListNode<int>(3);
var val4 = new ListNode<int>(30);
var val5 = new ListNode<int>(21);

myList.AddNode(val1);
myList.AddNode(val2);
myList.AddFirst(val4);

myList.AddNode(val3);
myList.AddFirst(val5);

Console.WriteLine(myList.ToString());


public class CustomLinkedList<T>
{
    //public T HeadValue => Head.Value;
    public ListNode<T> Head { get; set; }
    public ListNode<T> Tail { get; set; }

    public void AddNode(ListNode<T> node)
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

    public void AddFirst(ListNode<T> node)
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
            Head.PreviousNode = node;
            node.NextNode = Head;
            Head = temp;
        }
    }

    public override string ToString()
    {
        ListNode<T> current = Head;
        string result = "";

        while (current != null)
        {
            result += current.Value + " ";
            current = current.NextNode;
        }

        return result;
    }
    public void DeleteNode()
    {

    }
}

public class ListNode<T>
{
    //creating a node when you havent decided whether its at the head or tail
    public ListNode(T value)
    {
        Value = value;
    }

    //creating a node at the head or tail
    public ListNode(T value, ListNode<T> previousNode) : this(value)
    {
        PreviousNode = previousNode;
    }

    public T Value { get; set; }
    public ListNode<T> PreviousNode { get; set; }
    public ListNode<T> NextNode { get; set; }
}