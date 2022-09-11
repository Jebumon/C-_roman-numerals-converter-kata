namespace RomanNumaralsConverter.Tests;
using RomanNumaralsConverter.Models;
using FluentAssertions;

public class NoramalNumberToRomanNumberTests
{
    NoramalNumberToRomanNumber noramalNumberToRoman = new();

    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Convert_number_1_should_return_I()
    {
        noramalNumberToRoman.ConverNumber(1).Should().Be("I");
    }

    [Test]
    public void Convert_number_1000_should_return_M()
    {
        noramalNumberToRoman.ConverNumber(1000).Should().Be("M");
    }

    [Test]
    public void Convert_number_2000_should_return_MM()
    {
        noramalNumberToRoman.ConverNumber(2000).Should().Be("MM");
    }

    [Test]
    public void Convert_number_3000_should_return_MMM()
    {
        noramalNumberToRoman.ConverNumber(3000).Should().Be("MMM");
    }
}