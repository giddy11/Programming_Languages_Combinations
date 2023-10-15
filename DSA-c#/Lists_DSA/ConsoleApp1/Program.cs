// See https://aka.ms/new-console-template for more information

using StackLibrary;

var myList = new CustomLinkedList2<int>();
var myStack = new Stack<int>();
var myStack1 = new CustomStack<int>();


myStack1.Push(1);
myStack1.Push(2);
myStack1.Push(3);

//var node1 = new Node2<string>("Hello");
//var node2 = new Node2<string>("Please");
//var node3 = new Node2<string>("look");

//var node1 = new Node2<int>(1);
//var node2 = new Node2<int>(2);
//var node3 = new Node2<int>(3);

/*ADD FIRST*/
//myList.AddFirst(node1);
//myList.AddFirst(node2);
//myList.AddFirst(node3);

//myList.AddNode(node1);
//myList.AddNode(node2);
//myList.AddNode(node3);
//myList.DeleteNode(node2);

//Console.WriteLine(myList.ToString());
Console.WriteLine(myStack1.ToString());

