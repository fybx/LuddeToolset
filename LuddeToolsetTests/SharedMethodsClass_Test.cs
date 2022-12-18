using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LuddeToolset;
using System.Collections.Generic;

namespace LuddeToolsetTests
{
    [TestClass]
    public class SharedMethodsClass_Test
    {
        [TestMethod]
        public void Test_CollectionMethods()
        {
            List<string> listNames = new List<string>()
            {
                "John", "Alice", "Bob", "James", "Ashley", "Brian"
            };

            List<int> listNumbers = new List<int>()
            {
                123, 43, 54, 43546, 37842734, 987326428, int.MaxValue, 32334343
            };

            string[] arrayNames = new string[6]
            {
                "John", "Alice", "Bob", "James", "Ashley", "Brian"
            };

            int[] arrayNumbers = new int[8]
            {
                123, 43, 54, 43546, 37842734, 987326428, int.MaxValue, 32334343
            };

            double[] arrayNumbersDouble = new double[8]
            {
                0.123007654, 43, 54, 435.46, 37.842734, 9873264.28, int.MaxValue, 3234233.433456343
            };
        }
    }
}
