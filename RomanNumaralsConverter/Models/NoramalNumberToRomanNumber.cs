using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RomanNumaralsConverter.PredefinedValues;

namespace RomanNumaralsConverter.Models
{
    public class NoramalNumberToRomanNumber
    {
        public int NoramalNumber;
        string romanNumber = "";

        public Dictionary<string, int> RomanNumeralSymbols = new Dictionary<string, int>
        {
            {"M", 1000 },
            {"CM", 900 },
            {"D", 500 },
            {"CD", 400 },
            {"C", 100 },
            {"XC", 90 },
            {"L", 50 },
            {"XL", 40 },
            {"X", 10 },
            {"IX", 9 },
            {"V", 5 },
            {"IV", 4 },
            {"I", 1 },   
        };

        public Dictionary<string, int> OutputDictionary = new Dictionary<string, int>();

        public NoramalNumberToRomanNumber() 
        {
        }
        public string ConverNumber(int inputNormalNumber) 
        {
            if (inputNormalNumber > 0 && inputNormalNumber <= 3000)
            {
                NoramalNumber = inputNormalNumber;
                foreach (var (key, value) in RomanNumeralSymbols)
                {
                    string romanDigit = key;
                    int romanDigitValue = value;
                    int placeMultiplier = NoramalNumber / romanDigitValue;
                    if (placeMultiplier >= 1)
                    {
                        NoramalNumber = NoramalNumber % romanDigitValue;
                        OutputDictionary.Add(romanDigit, placeMultiplier);
                    }
                }
                foreach (var (key, value) in OutputDictionary)
                {
                    int placeMultiplier = value;
                    string romanDigit = key;
                    for (int i = 0; i < value; i++)
                    {
                        romanNumber += key;
                    }
                }
                return romanNumber;
            }
            throw new ArgumentException(message: "Please ente a number between 1 to 3000");
        }
    }
}
