﻿// See https://aka.ms/new-console-template for more information
using hashBasedStructures;
using hashBasedStructures.Data;
using System;
using static hashBasedStructures.DetectACyclicLinkedList;

Console.WriteLine("Hello, World!");

Employee employee = new Employee("dan", 1234, "test1");
Employee employee1 = new Employee("dan2", 1235, "test2");
Employee employee2 = new Employee("dan3", 1236, "test3");
Employee employee3 = new Employee("dan4", 1237, "test4");
Findemployee find = new Findemployee();

//find.searchForemployee(employee);
//find.searchForemployee(employee1);
//find.searchForemployee(employee2);
// var test = find.searchForemployee(employee3);

//Employee e;

//if(test.TryGetValue(1234, out e))
//{
//    Console.WriteLine(e.name + " : " + e.department);
//}


//Findemployee.findMissingElements(new int[] { 1, 2,3,4,6,7,7,7,7 }, new int[] {1,2,3,4}).ForEach(Console.WriteLine);




//DisplayFrequency.frequency(new int[] { 1,1,2,3,3,4,7,7,7,7 });
// DisplayFrequency.testingDictionaries(new int[] { 1, 1, 2, 3, 3, 4, 7, 7, 7, 7 });







//NodeTest test = new NodeTest(0);


//test.AddToEnd(5);
//test.AddToEnd(4);
//test.AddToEnd(2);
//test.AddToEnd(51);
//test.print();



Node node = new Node(1);
Node node1 = new Node(1);
Node node2 = new Node(1);
Node node3 = new Node(1);

DetectACyclicLinkedList detect = new DetectACyclicLinkedList();

detect.head = node;
node.next = node1;
