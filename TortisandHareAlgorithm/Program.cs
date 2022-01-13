// See https://aka.ms/new-console-template for more information
using TortisandHareAlgorithm;
using static TortisandHareAlgorithm.LinkedList;

//Console.WriteLine("Hello, World!");
//Node head = null;

// GFC.push(20);
// GFC.push(4);
// GFC.push(15);
// GFC.push(10);

//// Create a loop for testing
//head.next.next.next.next = head;

LinkedList<int> myList = new LinkedList<int>();


myList.AddLast(1);
myList.AddLast(2);
myList.AddLast(3);
myList.AddLast(5);
myList.AddLast(5);
myList.AddLast(11);



Console.WriteLine(GFC.FloydCycleDetection(myList));
Console.WriteLine(GFC.HasCycle(myList));