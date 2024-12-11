using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class DictionaryIntersectionTests
{
    [Test]
    public void Test_Intersect_TwoEmptyDictionaries_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int>();
        Dictionary<string, int> dict2 = new Dictionary<string, int>();
        Dictionary<string, int> expected = new Dictionary<string, int>();

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Intersect_OneEmptyDictionaryAndOneNonEmptyDictionary_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int>
        {
            {"key1", 1},
            {"key2", 2}
        };
        Dictionary<string, int> dict2 = new Dictionary<string, int>();
        Dictionary<string, int> expected = new Dictionary<string, int>();

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithNoCommonKeys_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int>
        {
            {"key1", 1},
            {"key2", 2}
        };
        Dictionary<string, int> dict2 = new Dictionary<string, int> 
        {
            { "key3", 3},
            {"key4", 4 }
        
        };
        Dictionary<string, int> expected = new Dictionary<string, int>();

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndValues_ReturnsIntersectionDictionary()
    {
        // Arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int>
        {
            {"test1", 1},
            {"test2", 2},
            { "test3",3}
        };
        Dictionary<string, int> dict2 = new Dictionary<string, int>
        {
            {"test2", 2},
            {"test3", 3},
            { "test4",4}

        };
        Dictionary<string, int> expected = new Dictionary<string, int> 
        {
            {"test2", 2},
            {"test3", 3}
        
        };

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndDifferentValues_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int>
        {
            {"key1", 1},
            {"test2", 2}
        };
        Dictionary<string, int> dict2 = new Dictionary<string, int>
        {
            { "abc3", 3},
            {"efds4", 4 }

        };
        Dictionary<string, int> expected = new Dictionary<string, int>();

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        Assert.That(result, Is.Empty);
    }
}
