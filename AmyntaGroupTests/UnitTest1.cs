using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using AmyntaGroup;

namespace AmyntaGroupTests
{
    [TestClass]
    public class UnitTest1
    {
        AVCheck testCase = new AVCheck();

        [TestMethod]
        public void AVC_ValiueIsNotDivisible()
        {
            int value = 1;

            string result = testCase.AVC(value);

            

            Assert.AreEqual("1", result);
        }

        [TestMethod]
        public void AVC_ValueIsAmyntaGroup()
        {
            int value = 15;
            string result = testCase.AVC(value);

            

            Assert.AreEqual("Amynta Group" , result);
        }
    }
}
