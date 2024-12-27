using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class AverageTests
{
    // TODO: finish the test
    [Test]
    public void Test_CalculateAverage_InputHasOneElement_ShouldReturnSameElement()
    {
        // Arrange
        int[] array = { 42 };
        int expected = 42;

        // Act
        double result = Average.CalculateAverage(array);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateAverage_InputHasPositiveIntegers_ShouldReturnCorrectAverage()
    {
        //Arrenge 
        int[] positiveArr = { 1, 2, 3 };
        double  expected = 2.0;

        // Act
        double result = Average.CalculateAverage(positiveArr);

        //Assert
        Assert.That(result,Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateAverage_InputHasNegativeIntegers_ShouldReturnCorrectAverage()
    {
        //Arrange
        int[] negativeArr = { -5, -6, - 4 };
        double expected = -5;

        //Act
        double result = Average.CalculateAverage(negativeArr);

        //Assert 
        Assert.That(result ,Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateAverage_InputHasMixedIntegers_ShouldReturnCorrectAverage()
    {
        //Arrange 
        int[] mixArr = {- 1, 2, -3, 4 };
        double expected = 0.5;

        // Act
        double result = Average.CalculateAverage(mixArr);

        //Assert .
        Assert.That(result, Is.EqualTo(expected));
    }
}
