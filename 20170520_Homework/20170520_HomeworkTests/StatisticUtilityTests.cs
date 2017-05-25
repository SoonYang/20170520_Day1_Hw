using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _20170520_Homework.Tests
{
    [TestClass()]
    public class StatisticUtilityTests
    {
        // source example
        List<Product> TestData = new List<Product>
        {
            new Product{ Id = 1, Cost = 1, Revenue = 11, SellPrice = 21 },
            new Product{ Id = 2, Cost = 2, Revenue = 12, SellPrice = 22 },
            new Product{ Id = 3, Cost = 3, Revenue = 13, SellPrice = 23 },
            new Product{ Id = 4, Cost = 4, Revenue = 14, SellPrice = 24 },
            new Product{ Id = 5, Cost = 5, Revenue = 15, SellPrice = 25 },
            new Product{ Id = 6, Cost = 6, Revenue = 16, SellPrice = 26 },
            new Product{ Id = 7, Cost = 7, Revenue = 17, SellPrice = 27 },
            new Product{ Id = 8, Cost = 8, Revenue = 18, SellPrice = 28 },
            new Product{ Id = 9, Cost = 9, Revenue = 19, SellPrice = 29 },
            new Product{ Id = 10, Cost = 10, Revenue = 20, SellPrice = 30 },
            new Product{ Id = 11, Cost = 11, Revenue = 21, SellPrice = 31 },
        };

        [TestMethod()]
        public void GetSum_For_Cost_GroupBy_3_Should_Get_6_15_24_21()
        {
            // Arrange
            var target = Substitute.For<IStatisticUtility<Product>>();
            target.SetSource(TestData);

            var colPredicate = new Func<Product, object>(r => r.Cost);
            var groupByNum = 3;

            // Stub
            target.GetSum(colPredicate, groupByNum)
                .Returns(new List<decimal> { 6, 15, 24, 21 });

            var expected = new List<decimal> { 6, 15, 24, 21 };

            // Act
            var actual = target
                .GetSum(colPredicate, groupByNum)
                .ToList();

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetSum_For_Revenue_GroupBy_4_Should_Get_50_66_60()
        {
            // Arrange
            var target = Substitute.For<IStatisticUtility<Product>>();
            target.SetSource(TestData);

            var colPredicate = new Func<Product, object>(r => r.Revenue);
            var groupByNum = 4;

            // Stub
            target.GetSum(colPredicate, groupByNum)
                .Returns(new List<decimal> { 50, 66, 60 });

            var expected = new List<decimal> { 50, 66, 60 };

            // Act
            var actual = target
                .GetSum(colPredicate, groupByNum)
                .ToList();

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}