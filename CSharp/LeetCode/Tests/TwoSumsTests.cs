namespace Tests;
using LeetCode;

[TestClass]
public class TwoSumsTests
{

    [TestMethod]
    [DataRow(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
    [DataRow(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
    [DataRow(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
    [DataRow(new int[] { 3, 2, 3 }, 6, new int[] { 0, 2 })]
    public void Run_Returns_ExpectedResult(int[] nums, int target, int[] expected)
    {
        // Arrange
        // Data comes from DataRow attribute

        // Act
        int[] actual = TwoSums.Run(nums, target);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Run_With_Large_Nums_Array_Returns_ExpectedResult()
    {
        // Arrange
        // Generate array for 1 through 10000
        int[] nums = Enumerable.Range(1, 10000).ToArray();
        int target = 19999;
        int[] expected = new int[] { 9998, 9999 };

        // Act
        int[] actual = TwoSums.Run(nums, target);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    [DataRow(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
    [DataRow(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
    [DataRow(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
    [DataRow(new int[] { 3, 2, 3 }, 6, new int[] { 0, 2 })]
    public void RunWithHashMap_Returns_ExpectedResult(int[] nums, int target, int[] expected)
    {
        // Arrange
        // Data comes from DataRow attribute

        // Act
        int[] actual = TwoSums.RunWithHashMap(nums, target);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void RunWithHashMap_With_Large_Nums_Array_Returns_ExpectedResult()
    {
        // Arrange
        // Generate array for 1 through 10000
        int[] nums = Enumerable.Range(1, 10000).ToArray();
        int target = 19999;
        int[] expected = new int[] { 9998, 9999 };

        // Act
        int[] actual = TwoSums.RunWithHashMap(nums, target);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }
}