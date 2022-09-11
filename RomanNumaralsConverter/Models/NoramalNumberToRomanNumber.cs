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
        

        public string ConverNumber(int inputNormalNumber) 
        {
            int NormalNumber = inputNormalNumber;
            if (NormalNumber == 1) 
            { 
                return "I"; 
            } 
            string thousandString = "";
            int thousands = NormalNumber / 1000;
            Console.WriteLine(thousands);

            if (thousands >= 1) 
            {
                string thousand = "M";
                
                
                for(int i = 0; i < thousands; i++) 
                {
                    Console.WriteLine("M");
                    thousandString += thousand;
                    Console.WriteLine(thousandString);
                }

                Console.WriteLine(thousandString);
                
            }

            return thousandString;




        }
    }
}
