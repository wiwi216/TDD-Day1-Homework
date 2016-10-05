﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpectedObjects;

namespace ProductLibrary.Tests
{
    [TestClass()]
    public class ProductTests
    {
        [TestMethod()]
        public void GetResultSetTest_number_3_field_Cost()
        {
            //arange
            var target = new Product();
            var number = 3;
            var fieldName = "Cost";

            var expected = new int[] { 6, 15, 24, 21 };

            //act
            IEnumerable<int> actual = target.GetResultSet(number, fieldName);

            //assert
            expected.ToExpectedObject().ShouldEqual(actual);
        }

        [TestMethod()]
        public void GetResultSetTest_number_4_field_Revenue()
        {
            //arange
            var target = new Product();
            var number = 4;
            var fieldName = "Revenue";

            var expected = new int[] { 50, 66, 60 };

            //act
            IEnumerable<int> actual = target.GetResultSet(number, fieldName);

            //assert
            expected.ToExpectedObject().ShouldEqual(actual);
        }
    }
}