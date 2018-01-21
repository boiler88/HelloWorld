using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HWUnitTest
{
    /// <summary>
    /// Unit Tests for Hello World API calls
    /// </summary>
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void HWTest1()
        {
            HWServiceReference.HWServiceClient hwServClient = new HWServiceReference.HWServiceClient();
            Assert.IsTrue(hwServClient.GetMessage() == "Hello World");
        }

        [TestMethod]
        public void HWTest2()
        {
            HWServiceReference.HWServiceClient hwServClient = new HWServiceReference.HWServiceClient();
            Assert.IsTrue(hwServClient.HWDBUpdate());
        }
    }
}
