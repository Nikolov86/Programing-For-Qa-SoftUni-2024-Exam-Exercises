using System;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace TestApp.Tests;

public class DigitAndSymbolCounterTests
{

    [Test]
    public void Test_EmptyStringInput_ReturnsEmptyDictionary()
    {
        // Arrange
        string input = "";

        // Act
        var result = DigitAndSymbolCounter.CountDigitsAndSymbols(input);

        // Assert
        Assert.IsEmpty(result);

    }

    [Test]
    public void Test_NoDigitsStringInput_ReturnsOnlyNonDigitsCount()
    {
        // Arrange
        string input = "Hello World";

        // Act
        var result = DigitAndSymbolCounter.CountDigitsAndSymbols(input);

        // Assert
        Assert.IsFalse(result.ContainsKey("even digit"));
        Assert.IsFalse(result.ContainsKey("odd digit"));
        Assert.AreEqual(11, result["non-digit symbol"]);
    }

    [Test]
    public void Test_NoOddDigitsStringInput_ReturnsOnlyEvenDigitsAndNonDigitsCount()
    {
        // Arrange
        string input = "2468XYZ";

        // Act
        var result = DigitAndSymbolCounter.CountDigitsAndSymbols(input);

        // Assert
        Assert.AreEqual(4, result["even digit"]);
        Assert.IsFalse(result.ContainsKey("odd digit"));
        Assert.AreEqual(3, result["non-digit symbol"]);
    }

    [Test]
    public void Test_NoEvenDigitsStringInput_ReturnsOnlyOddDigitsAndNonDigitsCount()
    {
        // Arrange
        string input = "QA is cool 579?";

        // Act
        var result = DigitAndSymbolCounter.CountDigitsAndSymbols(input);

        // Assert
        Assert.IsFalse(result.ContainsKey("even digit"));
        Assert.AreEqual(3, result["odd digit"]);
        Assert.AreEqual(12, result["non-digit symbol"]);
    }

    [Test]
    public void Test_SymbolsEvenAndOddDigitsStringInput_ReturnsAllTypeOfCounts()
    {
        // Arrange
        string input = "123abc!";

        // Act
        var result = DigitAndSymbolCounter.CountDigitsAndSymbols(input);

        // Assert
        Assert.AreEqual(1, result["even digit"]);
        Assert.AreEqual(2, result["odd digit"]);
        Assert.AreEqual(4, result["non-digit symbol"]);
    }
}