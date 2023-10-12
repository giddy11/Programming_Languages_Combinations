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

using LinkedList1;

var myList = new CustomLinkedList<int>();
var val1 = new ListNode<int>(1);
var val2 = new ListNode<int>(2);
var val3 = new ListNode<int>(3);

myList.AddNode(val1);
myList.AddNode(val2);
myList.AddNode(val3);


Console.WriteLine(myList.ToString());