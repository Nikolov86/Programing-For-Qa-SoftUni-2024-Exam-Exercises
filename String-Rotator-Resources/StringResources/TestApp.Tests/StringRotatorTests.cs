using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class StringRotatorTests
{
    [Test]
    public void Test_RotateRight_EmptyString_ReturnsEmptyString()
    {
        // Arrenge
        string input = string.Empty;
        int pos = 3;

        // Act 
        string result = StringRotator.RotateRight(input, pos);

        // Assert
        Assert.AreEqual(input, result);
    }

    [Test]
    public void Test_RotateRight_RotateByZeroPositions_ReturnsOriginalString()
    {
        // Arrenge
        string input = "hello";
        int pos = 0;

        // Act 
        string result = StringRotator.RotateRight(input, pos);

        // Assert
        Assert.AreEqual(input, result);
    }

    [Test]
    public void Test_RotateRight_RotateByPositivePositions_ReturnsRotatedString()
    {
        // Arrenge
        string input = "abcdef";
        int pos = 2;
        string expected = "efabcd";

        // Act 
        string result = StringRotator.RotateRight(input, pos);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_RotateRight_RotateByNegativePositions_ReturnsRotatedString()
    {
        // Arrenge
        string input = "abcdef";
        int pos = -2;
        string expected = "efabcd";

        // Act 
        string result = StringRotator.RotateRight(input, pos);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_RotateRight_RotateByMorePositionsThanStringLength_ReturnsRotatedString()
    {
        // Arrenge
        string input = "xyz";
        int pos = 5;
        string expected = "yzx";

        // Act 
        string result = StringRotator.RotateRight(input, pos);

        // Assert
        Assert.AreEqual(expected, result);
    }
}
