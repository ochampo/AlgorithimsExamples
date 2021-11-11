// See https://aka.ms/new-console-template for more information


using SringAlgorithms;

ValidateStrings validate = new ValidateStrings();
NormalizeStrings normalize = new NormalizeStrings();
ParseAndSearch parse = new ParseAndSearch();
//Console.WriteLine(validate.IsUppercase("hello"));
//Console.WriteLine(validate.IsUppercase("HELLO"));
//Console.WriteLine(validate.IsLowercase("hello"));
//Console.WriteLine(validate.IsLowercase("HELLO"));
//Console.WriteLine(validate.IsComplex("HELLO"));
//Console.WriteLine(validate.IsComplex("HELLO12"));
//Console.WriteLine(validate.IsComplex("hELL0sda"));

//Console.WriteLine( normalize.NormalizeStr("Hello there Buddy,     "));

parse.searchAlgorithm("Hello");
