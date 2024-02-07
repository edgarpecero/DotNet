// See https://aka.ms/new-console-template for more information
using Humanizer;

Console.WriteLine("Please enter a name");

var name = Console.ReadLine();

Console.WriteLine("Please enter a position");

var position = Console.ReadLine();

Console.WriteLine("Please enter your age");

var age = int.Parse(Console.ReadLine());

Console.WriteLine($"Hello, My name is {name}, my position is {position} and I am {age.ToWords(new System.Globalization.CultureInfo("en"))} years old");

