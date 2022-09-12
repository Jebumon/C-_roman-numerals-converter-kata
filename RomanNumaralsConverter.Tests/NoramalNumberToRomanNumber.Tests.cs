namespace RomanNumaralsConverter.Tests;
using RomanNumaralsConverter.Models;
using FluentAssertions;

public class NoramalNumberToRomanNumberTests
{
    private NoramalNumberToRomanNumber NoramalNumberToRomanNumber;

    [SetUp]
    public void Setup()
    {
        NoramalNumberToRomanNumber = new NoramalNumberToRomanNumber();
    }

    [Test]
    public void Convert_number_1_should_return_I()
    {
        NoramalNumberToRomanNumber.ConverNumber(1).Should().Be("I");
    }

    [Test]
    public void Convert_number_1000_should_return_M()
    {
        NoramalNumberToRomanNumber.ConverNumber(1000).Should().Be("M");
    }

    [Test]
    public void Convert_number_2000_should_return_MM()
    {
        NoramalNumberToRomanNumber.ConverNumber(2000).Should().Be("MM");
    }

    [Test]
    public void Convert_number_3000_should_return_MMM()
    {
        NoramalNumberToRomanNumber.ConverNumber(3000).Should().Be("MMM");
    }
}