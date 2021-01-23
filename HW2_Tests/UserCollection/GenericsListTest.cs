using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using HW2.UserCollection;

namespace HW2_Tests.UserCollection
{
    [TestClass]
    public class GenericsListTests
    {
        [TestMethod]
        public void GenericsList_AddingElements()
        {
            GenericsList<int> gList = new GenericsList<int>();

            ArrayList arrayToFill = new ArrayList() { 1, 2, 3, 4, 5, 6, 7 };

            for (int i = 0; i < arrayToFill.Count; i++)
                gList.Add(arrayToFill[i]);

            Assert.AreEqual(arrayToFill.Count, gList.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GenericsList_AddingElementsError()
        {
            GenericsList<int> gList = new GenericsList<int>();

            ArrayList arrayToFill = new ArrayList() { 1, 2, 3, "str", 5, 6, 7 };

            for (int i = 0; i < arrayToFill.Count; i++)
                gList.Add(arrayToFill[i]);
        }
    }
}
