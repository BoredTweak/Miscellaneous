using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ExtensionLibrary.Core.Test
{
    [TestClass]
    public class IsInTests
    {
        [TestMethod]
        public void IsIn_Returns_True_For_ItemInList()
        {
            string input = "Example192";
            string[] list = new string[1000];
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = $"Example{i}";
            }

            bool result = input.IsIn(list);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsIn_Returns_False_For_ItemNotInList()
        {
            string input = "Example1200";
            string[] list = new string[1000];
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = $"Example{i}";
            }

            bool result = input.IsIn(list);

            Assert.IsFalse(result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsIn_Throws_ArgumentNullException_For_NullString()
        {
            string input = null;
            string[] list = new string[1000];
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = $"Example{i}";
            }

            bool result = input.IsIn(list);

            Assert.Fail("Expected an ArgumentNullException to have been thrown.");
        }
    }
}
