// See https://aka.ms/new-console-template for more information
using RomanNumaralsConverter.Models;
NoramalNumberToRomanNumber noramalNumberToRoman = new();
RomanNumberToNormalNumber romanNumberToNormalNumber = new(null);
Console.WriteLine("---------------------------------------------------------------------------");
Console.WriteLine("|                         Roman numeral converter                         |");
Console.WriteLine("---------------------------------------------------------------------------");
Console.WriteLine("|                                                                         |\n");
Console.WriteLine("|           Press '1' for Convert Normal number to Roman number           |");
Console.WriteLine("|                                                                         |\n");
Console.WriteLine("|           Press '2' for Convert Roman number to Normal number           |");
Console.WriteLine("|                                                                         |\n");
Console.WriteLine("|                      Please select an option :                          |");
var  a = Console.ReadLine();
int number = Convert.ToInt32(a);
if (number == 1) 
{
    Console.WriteLine("|                                                                        |\n");
    Console.WriteLine("|                   Please ente a Normal number                          |");
    Console.WriteLine("|                                                                        |\n");
    var userInputNumber = Console.ReadLine();
    int inputNumberInt = Convert.ToInt32(userInputNumber);
    string romanNumber = noramalNumberToRoman.ConverNumber(inputNumberInt);
    Console.WriteLine("|        You Converted " + "'" + inputNumberInt + "'" + " to Roman Number " + "'" + romanNumber + "'          |");
    Console.WriteLine("|                                                                         |\n");
    Console.WriteLine("---------------------------------------------------------------------------");
}
else if(number == 2) 
{
    Console.WriteLine("|                                                                        |\n");
    Console.WriteLine("|                   Please ente a roman number                           |");
    Console.WriteLine("|                                                                        |\n");
    var userInputNumber = Console.ReadLine();
    string inputNumberString = Convert.ToString(userInputNumber).ToUpper();
    int normalNumber = romanNumberToNormalNumber.ConvertRomanNumber(inputNumberString);
    //Console.WriteLine("                You Converted " + "'" + inputNumberString + "'" + " to normal Number " + "'" + normalNumber + "'");
    Console.WriteLine("|                                                                         |\n");
    Console.WriteLine("---------------------------------------------------------------------------");
}



