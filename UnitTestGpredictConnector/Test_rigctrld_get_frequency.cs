using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SDRSharp.GpredictConnector;

namespace UnitTestGpredictConnector
{
    [TestClass]
    public class Test_rigctrld_get_frequency
    {
        [TestInitialize()]
        public void Initialize()
        {
            class_under_test_ = new Rigctrld();
        }

        [TestMethod]
        public void GetFrequency_00144800123()
        {
            TestHelper_GetFrequency(given_freq: 144800123, command: "f");
        }
        [TestMethod]
        public void GetFrequency_00144800123_leading_space()
        {
            class_under_test_.FrequencyInHz = 144800123;
            string result = class_under_test_.ExecCommand(" f");
            Assert.AreEqual("RPRT -4\n", result);
        }
        [TestMethod]
        public void GetFrequency_00144800123_tailing_LF()
        {
            TestHelper_GetFrequency(given_freq: 144800123, command: "f\n");
        }
        [TestMethod]
        public void GetFrequency_00144800123_tailing_foo()
        {
            class_under_test_.FrequencyInHz = 144800123;
            string result = class_under_test_.ExecCommand("foooo");
            Assert.AreEqual("RPRT -4\n", result);
        }
        [TestMethod]
        public void GetFrequency_1GHZ()
        {
            TestHelper_GetFrequency(given_freq: 1234567890, command: "f");
        }
        [TestMethod]
        public void GetFrequency_10m()
        {
            TestHelper_GetFrequency(given_freq: 29420877, command: "f");
        }

        private void TestHelper_GetFrequency(long given_freq, string command)
        {
            class_under_test_.FrequencyInHz = given_freq;
            string result = class_under_test_.ExecCommand(command);
            Assert.AreEqual(given_freq.ToString()+"\n", result);
        }

        private Rigctrld class_under_test_ = null;
    }
}
