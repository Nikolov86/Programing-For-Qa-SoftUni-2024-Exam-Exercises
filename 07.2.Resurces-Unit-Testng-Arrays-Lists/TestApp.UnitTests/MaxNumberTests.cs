using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MaxNumberTests
{

    [Test]
    public void Test_FindMax_InputHasOneElement_ShouldReturnTheElement()
    {
        // Arrange
        List<int> listNumber = new List<int> { 7 };
       

        // Act
        int result = MaxNumber.FindMax(listNumber);

        // Assert
        Assert.That(result, Is.EqualTo(7));
    }

    [Test]
    public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> listNumber = new List<int> { 7 ,14 , 32 };


        // Act
        int result = MaxNumber.FindMax(listNumber);

        // Assert
        Assert.That(result, Is.EqualTo(32));
    }

    [Test]
    public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> listNumber = new List<int> { -1 ,-7, -200, -32 };


        // Act
        int result = MaxNumber.FindMax(listNumber);

        // Assert
        Assert.That(result, Is.EqualTo(-1));
    }

    [Test]
    public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> listNumber = new List<int> { -1, 7, 200, -32 };


        // Act
        int result = MaxNumber.FindMax(listNumber);

        // Assert
        Assert.That(result, Is.EqualTo(200));
    }

    [Test]
    public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
    {
        // Arrange
        List<int> listNumber = new List<int> { -1, -7, -1, 200, -32 , 200};


        // Act
        int result = MaxNumber.FindMax(listNumber);

        // Assert
        Assert.That(result, Is.EqualTo(200));
    }
}
