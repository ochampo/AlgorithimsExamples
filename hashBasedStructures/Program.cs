// See https://aka.ms/new-console-template for more information
using hashBasedStructures;
using hashBasedStructures.Data;

Console.WriteLine("Hello, World!");

Employee employee = new Employee("dan", 1234, "test");
Employee employee1 = new Employee("dan2", 1235, "test");
Employee employee2 = new Employee("dan3", 1236, "test");
Employee employee3 = new Employee("dan4", 1237, "test");
Findemployee find = new Findemployee();

find.searchForemployee(employee);
find.searchForemployee(employee1);
find.searchForemployee(employee2);
find.searchForemployee(employee3);


