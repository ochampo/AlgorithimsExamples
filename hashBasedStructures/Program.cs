// See https://aka.ms/new-console-template for more information
using hashBasedStructures;
using hashBasedStructures.Data;
using System;

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
 DisplayFrequency.testingDictionaries(new int[] { 1, 1, 2, 3, 3, 4, 7, 7, 7, 7 });

