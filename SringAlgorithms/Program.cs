// See https://aka.ms/new-console-template for more information


using SringAlgorithms;

ValidateStrings validate = new ValidateStrings();
NormalizeStrings normalize = new NormalizeStrings();
ParseAndSearch parse = new ParseAndSearch();
ReverseEachWordInASentence sentence = new ReverseEachWordInASentence();
//Console.WriteLine(validate.IsUppercase("hello"));
//Console.WriteLine(validate.IsUppercase("HELLO"));
//Console.WriteLine(validate.IsLowercase("hello"));
//Console.WriteLine(validate.IsLowercase("HELLO"));
//Console.WriteLine(validate.IsComplex("HELLO"));
//Console.WriteLine(validate.IsComplex("HELLO12"));
//Console.WriteLine(validate.IsComplex("hELL0sda"));

//Console.WriteLine( normalize.NormalizeStr("Hello there Buddy,     "));

//parse.searchAlgorithm("Hello");

//Console.WriteLine(parse.ReverseString("danTest"));

//Console.WriteLine(parse.ReverseStringWithArray("Howdy"));
sentence.ReversalSentence("The red fox jumped over the fence or something like that \n");
Console.WriteLine(sentence.ReverseEachWord("The red fox jumped over the fence or something like that"));
