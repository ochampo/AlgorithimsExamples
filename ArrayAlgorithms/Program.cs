// See https://aka.ms/new-console-template for more information
using ArrayAlgorithms;


int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
//LinerSearch linerSearch = new LinerSearch(ref arr, ref 4);
//LinerSearch linerSearch = new LinerSearch();

//int? x = linerSearch.LinerSearchFindingData(arr,5);
//Console.WriteLine(x);
//int Item = Array.Find(arr,element => element == 3);
//Console.WriteLine("Array Example"+ Item);
//int[] items2 =  Array.FindAll(arr, element => element >=5);
//Array.ForEach(items2,Console.WriteLine);

//BinerySearchExample binerySearch  = new BinerySearchExample();
//Console.WriteLine(binerySearch.BinarySearch(arr,25));
//Console.WriteLine(Array.BinarySearch(arr,25));
aggregatingArrays aggregatingArrays = new aggregatingArrays();


int[] arr1 = { 1, 2, 3, 4, 5, 6, };
int[] arr2 = { 11, 152, 453, 444, 455, 415, 8226, 744, 822, 9888, 1000 };


int[] evenArr = aggregatingArrays.FindEvenNumbers(arr1, arr2);


Array.ForEach(evenArr,Console.WriteLine);

