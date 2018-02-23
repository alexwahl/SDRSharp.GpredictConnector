using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SDRSharp.GpredictConnector;

namespace UnitTestHamlibTCP
{
    [TestClass]
    public class Test_FrequencyManager
    {
        
        [TestMethod]
        public void SetFrequencyFromOutside_DefaultConfig()
        {
            long expectedFrequency = 438775000;
            long gatheredFrequency = 0;
            FrequencyManager cut = new FrequencyManager();
            cut.RxFreqChanged += x => gatheredFrequency = x;
            cut.SetFreqFromOutside(expectedFrequency);
            Assert.AreEqual(expectedFrequency, gatheredFrequency);
            
        }
    }
}
