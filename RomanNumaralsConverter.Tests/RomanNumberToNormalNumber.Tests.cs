using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using RomanNumaralsConverter.Models;

namespace RomanNumaralsConverter.Tests
{
    public class RomanNumberToNormalNumberTests
    {
        private RomanNumberToNormalNumber romanNumberToNormalNumber;
        private NoramalNumberToRomanNumber normalNumberToRomanNumber;
        //string romanNumber = "";
        //int testNumber;

        [SetUp]
        public void Setup()
        {
            romanNumberToNormalNumber = new RomanNumberToNormalNumber(null);
            normalNumberToRomanNumber = new NoramalNumberToRomanNumber();

        }

        
        [Test]
        
        public void Convert_Roman_number_I_should_return_1()
        {
           /* for (int i = 1; i <= 30; i++)
            {
                testNumber = i;
                romanNumber = normalNumberToRomanNumber.ConverNumber(i);
                Console.WriteLine(romanNumber);
            }*/

            romanNumberToNormalNumber.ConvertRomanNumber("I").Should().Be(1);
        }

        [Test]

        public void Convert_Roman_number_XIV_should_return_14()
        {
            romanNumberToNormalNumber.ConvertRomanNumber("XIV").Should().Be(14);
        }

        [Test]

        public void Convert_Roman_number_XCIV_should_return_14()
        {
            romanNumberToNormalNumber.ConvertRomanNumber("XCIV").Should().Be(94);
        }

        [Test]

        public void Convert_Roman_number_MCCXXXIV_should_return_1234()
        {
            romanNumberToNormalNumber.ConvertRomanNumber("MCCXXXIV").Should().Be(1234);
        }

        [Test]

        public void Convert_Roman_number_MMCCCXLV_should_return_2345()
        {
            romanNumberToNormalNumber.ConvertRomanNumber("MMCCCXLV").Should().Be(2345);
        }

        [Test]

        public void Convert_Roman_number_null_should_return_ArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(() => romanNumberToNormalNumber.ConvertRomanNumber(null));
            Assert.That(ex.Message, Is.EqualTo("Roman number can't be null"));

        }

        [Test]

        public void Convert_Roman_number_Empty_should_return_ArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(() => romanNumberToNormalNumber.ConvertRomanNumber(""));
            Assert.That(ex.Message, Is.EqualTo("Roman number can't be null"));

        }

        [Test]

        public void Convert_Roman_number_Invalid_should_return_ArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(() => romanNumberToNormalNumber.ConvertRomanNumber("aggj"));
            Assert.That(ex.Message, Is.EqualTo("Please enter a valid Roman number"));

        }
    }

}
