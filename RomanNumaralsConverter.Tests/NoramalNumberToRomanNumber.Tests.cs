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

    [Test]
    public void Convert_number_2221_should_return_MMCCXXI()
    {
        NoramalNumberToRomanNumber.ConverNumber(2221).Should().Be("MMCCXXI");
    }

    [Test]
    public void Convert_number_1249_should_return_MCCXLIX()
    {
        NoramalNumberToRomanNumber.ConverNumber(1249).Should().Be("MCCXLIX");
    }

    [Test]
    public void Convert_number_2290_should_return_MMCCXC()
    {
        NoramalNumberToRomanNumber.ConverNumber(2290).Should().Be("MMCCXC");
    }

    [Test]
    public void Convert_number_1234_should_return_MCCXXXIV()
    {
        NoramalNumberToRomanNumber.ConverNumber(1234).Should().Be("MCCXXXIV");
    }

    [Test]
    public void Convert_number_2345_should_return_MMCCCXLV()
    {
        NoramalNumberToRomanNumber.ConverNumber(2345).Should().Be("MMCCCXLV");
    }

    [Test]
    public void Convert_number_94_should_return_XCIV()
    {
        NoramalNumberToRomanNumber.ConverNumber(94).Should().Be("XCIV");
    }

    [Test]
    public void Convert_number_0_should_return_ArgumentException()
    {
        var ex = Assert.Throws<ArgumentException>(() => NoramalNumberToRomanNumber.ConverNumber(0));
        Assert.That(ex.Message, Is.EqualTo("Please ente a number between 1 to 3000"));
    }

    [Test]
    public void Convert_number_3001_should_return_ArgumentException()
    {
        var ex = Assert.Throws<ArgumentException>(() => NoramalNumberToRomanNumber.ConverNumber(3001));
        Assert.That(ex.Message, Is.EqualTo("Please ente a number between 1 to 3000"));
    }
}