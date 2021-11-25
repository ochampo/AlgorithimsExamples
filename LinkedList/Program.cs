// See https://aka.ms/new-console-template for more information
using LinkedList;
using static LinkedList.CustomLinkedList;
Console.WriteLine("Hello, World!");

 
CustomLinkedList list = new CustomLinkedList();

Node firstnode = new Node(3);
Node secondnode = new Node(4);
Node thirdnode = new Node(5);
Node fourthnode = new Node(6);

list.head = firstnode;
firstnode.next = secondnode;
secondnode.next = thirdnode;
thirdnode.next = fourthnode;
list.displayContents();
list.deleteBackHalf();
Console.WriteLine();
list.displayContents();