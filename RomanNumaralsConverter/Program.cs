// See https://aka.ms/new-console-template for more information
using RomanNumaralsConverter.Models;
Console.WriteLine("Hello, World!");
NoramalNumberToRomanNumber noramalNumberToRoman = new();
Console.WriteLine("Please enter a number");
var  a = Console.ReadLine();
int number = Convert.ToInt32(a);
string romanNumber = noramalNumberToRoman.ConverNumber(number);

Console.WriteLine("You Converted " +"'"+number+"'" + " to Roman Number "+ "'"+ romanNumber+ "'");
