using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SDRSharp.GpredictConnector;
using System.Threading;

namespace UnitTestGpredictConnector
{
    /// <summary>
    /// Zusammenfassungsbeschreibung für Test_rigctrld
    /// </summary>
    [TestClass]
    public class Test_rigctrld_set_frequency
    {
         private TestContext testContextInstance;

        /// <summary>
        ///Ruft den Textkontext mit Informationen über
        ///den aktuellen Testlauf sowie Funktionalität für diesen auf oder legt diese fest.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Zusätzliche Testattribute
        //
        // Sie können beim Schreiben der Tests folgende zusätzliche Attribute verwenden:
        //
        // Verwenden Sie ClassInitialize, um vor Ausführung des ersten Tests in der Klasse Code auszuführen.
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Verwenden Sie ClassCleanup, um nach Ausführung aller Tests in einer Klasse Code auszuführen.
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Mit TestInitialize können Sie vor jedem einzelnen Test Code ausführen. 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Mit TestCleanup können Sie nach jedem Test Code ausführen.
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion
        [TestInitialize()]
        public void Initialize()
        {
            class_under_test_ = new Rigctrld();
        }


        [TestMethod]
        public void SetFrequency_F__144800123()
        {
            Rigctrld cut = new Rigctrld();
            TestHelper_SetFrequency(expected_freq: 144800123, command: "F  144800123");
        }

        private void TestHelper_SetFrequency(long expected_freq, string command)
        {
            long result_freq = 0;
            class_under_test_.FrequencyInHzChanged += x => result_freq = x;
            class_under_test_.ExecCommand(command);
            Assert.IsNotNull(class_under_test_.FrequencySetThread); // should be running
            class_under_test_.FrequencySetThread.Join(); // wait for the freqeuncy set thread to finish his work
            Assert.AreEqual(expected_freq, class_under_test_.FrequencyInHz);
            Assert.AreEqual(expected_freq, result_freq);
        }

        private Rigctrld class_under_test_ = null;
    }
}
