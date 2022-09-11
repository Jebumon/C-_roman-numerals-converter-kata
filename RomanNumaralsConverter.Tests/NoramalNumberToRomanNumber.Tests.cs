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
    public void number_1_should_return_I()
    {
        noramalNumberToRoman.ConverNumber(1).Should().Be("I");
    }
}