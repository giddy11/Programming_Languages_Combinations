// See https://aka.ms/new-console-template for more information

using ConsoleApp1;
using StackLibrary;
using System.Collections;

/*
var myList = new CustomLinkedList2<int>();
var myStack = new Stack<int>();
var myStack1 = new CustomStack<int>();
var myQueue = new Queue<int>();
var myQueue1 = new CustomQueue<int>();
*/

//var node1 = new Node2<int>(1);
//var node2 = new Node2<int>(2);
//var node3 = new Node2<int>(3);


//myStack1.Push(node1);
//myStack1.Push(node2);
//myStack1.Push(node3);
//myStack1.Pop();
//myStack1.Peek();

//myQueue1.Enqueue(node1);
//myQueue1.Enqueue(node2);
//myQueue1.Enqueue(node3);
//myQueue1.Dequeue();


//myStack.Push(1);
//myStack.Push(2);
//myStack.Push(3);
//myStack.Pop();
//myStack.Peek();

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
//Console.WriteLine(myStack.ToString());
//Console.WriteLine(myStack1.ToString());

var myDict = new Dictionary<int, Student>();
var myHash = new Hashtable();
var listOfStudents = new List<Student>()
{
    new Student("Gideon", "Bayelsa", 8),
    new Student("Timothy", "Rivers", 3)
};

foreach (var student in listOfStudents)
{
    myDict.Add(student.Level, student);
}

foreach (var kvp in myDict)
{
    Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
}


Console.WriteLine();




