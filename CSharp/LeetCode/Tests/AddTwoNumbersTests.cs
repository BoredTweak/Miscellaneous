using LeetCode;

using Projects.AddTwoNumbers;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests;

[TestClass]
public class AddTwoNumbersTests
{
    [TestMethod]
    public void Run_Returns_ExpectedResult()
    {
        // Arrange
        var l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
        var l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
        var expected = new ListNode(7, new ListNode(0, new ListNode(8)));
        
        // Act
        var actual = AddTwoNumbers.Run(l1, l2);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Run_Returns_ExpectedResult_UnevenLengths()
    {
        // Arrange
        var l1 = new ListNode(9, new ListNode(9, new ListNode(9)));
        var l2 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))))));
        var expected = new ListNode(8, new ListNode(9, new ListNode(9, new ListNode(0, new ListNode(0, new ListNode(0, new ListNode(1)))))));
        
        // Act
        var actual = AddTwoNumbers.Run(l1, l2);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}

