// See https://aka.ms/new-console-template for more information
using QueuesAndStacks;

Console.WriteLine("Hello, World!");

QueueTest queueTest = new QueueTest();
PrintBinary printBinary = new PrintBinary();
StackTest stackTest = new StackTest();
PrintNextGreaterElement PrintNextGreaterElement = new PrintNextGreaterElement();
//printBinary.printBinary(4);
//printBinary.printBinary(10);
//printBinary.printBinary(5);
//printBinary.printBinary(3);
int [] arr1 = new int[] { 15, 20, 25, 46, 64 };
int[] arr2 = new int[] { 15, 20,100, 46, 64 };
int[] arr3 = new int[] { 25, 46, 464 };
int[] arr4 = new int[] { };

//queueTest.QueueImplementation();

//stackTest.ExperimentalStack();


PrintNextGreaterElement.NumbersChecker(arr1);
PrintNextGreaterElement.NumbersChecker(arr2);
PrintNextGreaterElement.NumbersChecker(arr3);
PrintNextGreaterElement.NumbersChecker(arr4);
