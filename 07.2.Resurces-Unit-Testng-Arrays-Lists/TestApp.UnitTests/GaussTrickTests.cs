using NUnit.Framework;

using System.Collections.Generic;
using System.Linq;

namespace TestApp.UnitTests;

public class GaussTrickTests
{
    [Test]
    public void Test_SumPairs_InputIsEmptyList_ShouldReturnEmptyList()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        List<int> result = GaussTrick.SumPairs(emptyList);

        // Assert
        CollectionAssert.AreEqual(emptyList, result);
    }

    // TODO: finish the test
    [Test]
    public void Test_SumPairs_InputHasSingleElement_ShouldReturnSameElement()
    {
        // Arrange
        List<int> listNumber = new List<int>(42);
        int expexted = 42;
        // Act
        List<int> result = GaussTrick.SumPairs(listNumber);

        //Assert 
        CollectionAssert.AreEqual(result, listNumber);
    }
    [Test]
    public void Test_SumPairs_InputHasEvenCountElements_ShouldReturnSumPairs()
    {
       // Arrange
        List<int> listEvenCount = new List<int>() { 2, 4, 5, 1 };
        List<int> expectedEvenCount = new List<int>() { 3, 9 };

        // Act
        List<int> result = GaussTrick.SumPairs(listEvenCount);

        // Assert
        CollectionAssert.AreEqual(expectedEvenCount, result);
    }

    [Test]
    public void Test_SumPairs_InputHasOddCountElements_ShouldReturnWithMiddleElement()
    {
        //Arrange 
        List<int> listArr = new List<int>() { 2, 4, 5, 1, 3, 6 };
        List<int> expectedArr = new List<int>() { 8, 7, 6 };

        //Act 
        List<int> result = GaussTrick.SumPairs(listArr);

        //Assert
        CollectionAssert.AreEqual(expectedArr, result);
    }
    [Test]
    public void Test_SumPairs_InputHasLargeEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> inputList = Enumerable.Range(1, 2).ToList(); // List with 4 elements
        List<int> expectedResult = new List<int>();
        for (int i = 0; i < inputList.Count / 2; i++)
        {
            expectedResult.Add(inputList[i] + inputList[inputList.Count - 1 - i]);
        }
        // Act
        List<int> result = GaussTrick.SumPairs(inputList);

        // Assert
        CollectionAssert.AreEqual(expectedResult, result);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeOddCountElements_ShouldReturnWithMiddleElement()
    {
        // Arrange
        List<int> inputList = Enumerable.Range(1, 100).ToList(); // List with 100 elements
        List<int> expectedResult = new List<int>();
        for (int i = 0; i < inputList.Count / 2; i++)
        {
            expectedResult.Add(inputList[i] + inputList[inputList.Count - 1 - i]);
        }

        // Act
        List<int> result = GaussTrick.SumPairs(inputList);

        // Assert
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
