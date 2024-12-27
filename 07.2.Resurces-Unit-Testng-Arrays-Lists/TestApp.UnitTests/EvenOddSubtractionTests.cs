using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class EvenOddSubtractionTests
{
    [Test]
    public void Test_FindDifference_InputIsEmpty_ShouldReturnZero()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();
        int expected = 0;

        // Act
        int result = EvenOddSubtraction.FindDifference(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    // TODO: finish the test
    [Test]
    public void Test_FindDifference_InputHasOnlyEvenNumbers_ShouldReturnEvenSum()
    {
        // Arrange
        int[] evenArr = new int[2] { 10, 10};
        int expected = 20;

        // Act
        int result = EvenOddSubtraction.FindDifference(evenArr);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindDifference_InputHasOnlyOddNumbers_ShouldReturnNegativeOddSum()
    {
        //Arrange 
        int[] oddArr = new int[3] { 7, 5, 3 };
        int expected = -15;

        //Act
        int result = EvenOddSubtraction.FindDifference(oddArr);

        //Assert
        Assert.That(result,Is.EqualTo(expected));

    }
    [Test]
    public void Test_FindDifference_InputHasMixedNumbers_ShouldReturnDifference()
    {
        // Arrenge
        int[] mixArr = new int[4] { 4, 6, -3, -5 };
        int expected = 18;

        //Act 
        int result = EvenOddSubtraction.FindDifference(mixArr);

        //Assert 
        Assert.That(result, Is.EqualTo(expected));
    }
}
