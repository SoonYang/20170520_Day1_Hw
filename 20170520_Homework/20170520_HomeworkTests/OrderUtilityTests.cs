using Microsoft.VisualStudio.TestTools.UnitTesting;
using _20170520_Homework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20170520_Homework.Tests
{
    [TestClass()]
    public class OrderUtilityTests
    {
        [TestMethod()]
        public void GetSum_For_Cost_GroupBy_3_Should_Get_6_15_24_21()
        {
            // Arrange
            var target = new OrderUtility();
            var colName = "Cost";
            var groupByNum = 3;
            var expected = new List<int> { 6, 15, 24, 21 };

            // Act
            var actual = target
                .GetSum(colName, groupByNum)
                .ToList();

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetSum_For_Revenue_GroupBy_4_Should_Get_50_66_60()
        {
            // Arrange
            var target = new OrderUtility();
            var colName = "Revenue";
            var groupByNum = 4;
            var expected = new List<int> { 50, 66, 60 };

            // Act
            var actual = target
                .GetSum(colName, groupByNum)
                .ToList();

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}