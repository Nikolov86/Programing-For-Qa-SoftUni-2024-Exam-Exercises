using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ReverseTests
{
    [Test]
    public void Test_ReverseArray_InputIsEmpty_ShouldReturnEmptyString()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        string result = Reverse.ReverseArray(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    // TODO: finish the test
    [Test]
    public void Test_ReverseArray_InputHasOneElement_ShouldReturnTheSameElement()
    {
        // Arrange
        int[] oneNumber = new int[1] { 7};

        // Act
        string result = Reverse.ReverseArray(oneNumber);

        // Assert
        Assert.That(result, Is.EqualTo("7"));
    }

    [Test]
    public void Test_ReverseArray_InputHasMultipleElements_ShouldReturnReversedString()
    {
        //Arrage
        int[] numberArray = new int[3] {2,4,6 };
        string expected = "6 4 2";

        //Act
        string result = Reverse.ReverseArray(numberArray);

        //Assert 
        Assert.That (result, Is.EqualTo(expected));
    }
}
