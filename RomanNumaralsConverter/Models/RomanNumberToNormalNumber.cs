using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RomanNumaralsConverter.PredefinedValues;

namespace RomanNumaralsConverter.Models
{
    public class RomanNumberToNormalNumber
    {
        public string RomanNumber { get; set; }
        public int OutPutNumber;
        public int rightDigit;
        public RomanNumberToNormalNumber(string inputRomanNumber) 
        {
            RomanNumber = inputRomanNumber;
        }

        public int ConvertRomanNumber(string inputRomanNumber) 
        {
            if (inputRomanNumber == null || inputRomanNumber == "")
            {
                Console.WriteLine("Roman number can't be null");
                throw new ArgumentException(message: "Roman number can't be null");
            }
            else
            {
                char[] romanDigits = inputRomanNumber.ToCharArray();
                List<int> digitValues = new List<int>();
                digitValues.Add(0);

                foreach (char romanDigit in romanDigits)
                {
                    try
                    {
                        int decimalValue = (int)Enum.Parse(typeof(RomanNumeralSymbols), romanDigit.ToString());
                        digitValues.Add(decimalValue);
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a valid Roman number");
                        throw new ArgumentException(message: "Please enter a valid Roman number");
                        romanDigits = null;
                        digitValues.Clear();
                        break;
                    }
                }
                digitValues.Add(0);
                for (int i = 0; i < digitValues.Count - 1; i++)
                {
                    int leftDigit = digitValues[i];
                    rightDigit = digitValues[i + 1];
                    if (leftDigit == rightDigit || leftDigit > rightDigit)
                    {
                        OutPutNumber = OutPutNumber + leftDigit;
                    }
                    else
                    {
                        OutPutNumber = OutPutNumber - leftDigit;
                    }
                }
                OutPutNumber = OutPutNumber + rightDigit;
            }
            Console.WriteLine("You converted the Roman Numeral '" + inputRomanNumber + "' to the number '" + OutPutNumber + "'");
            return OutPutNumber;
        }

    }
}
