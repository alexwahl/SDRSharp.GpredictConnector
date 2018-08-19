using Microsoft.VisualStudio.TestTools.UnitTesting;
using SDRSharp.GpredictConnector;

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
            TestHelper_SetFrequency(expected_freq: 144800123, command: "F  144800123");
        }
        [TestMethod]
        public void SetFrequency_F__1GHZ()
        {
            TestHelper_SetFrequency(expected_freq: 1234567890, command: "F  1234567890");
        }
        [TestMethod]
        public void SetFrequency_F__10m()
        {
            TestHelper_SetFrequency(expected_freq: 29420877, command: "F  29420877");
        }

        [TestMethod]
        public void SetFrequency_F_144800123()
        {
            TestHelper_SetFrequency(expected_freq: 144800123, command: "F 144800123");
        }

        [TestMethod]
        public void SetFrequency_F_00144800123()
        {
            TestHelper_SetFrequency(expected_freq: 144800123, command: "F 00144800123");
        }

        [TestMethod]
        public void SetFrequency_F_1GHZ()
        {
            TestHelper_SetFrequency(expected_freq: 1234567890, command: "F 1234567890");
        }
        [TestMethod]
        public void SetFrequency_F_10m()
        {
            TestHelper_SetFrequency(expected_freq: 29420877, command: "F 29420877");
        }

        [TestMethod]
        public void SetFrequency_unparseableFreq()
        {
            Assert.AreEqual("RPRT -8\n", class_under_test_.ExecCommand("F 1234d567890"));
            Assert.IsNull(class_under_test_.FrequencySetThread);
            Assert.AreEqual(0, class_under_test_.FrequencyInHz);
        }

        private void TestHelper_SetFrequency(long expected_freq, string command)
        {
            long result_freq = 0;

            class_under_test_.FrequencyInHzChanged += x => result_freq = x;
            Assert.AreEqual("RPRT 0\n", class_under_test_.ExecCommand(command));
            Assert.IsNotNull(class_under_test_.FrequencySetThread); // should be running
            class_under_test_.FrequencySetThread.Join(); // wait for the freqeuncy set thread to finish his work
            Assert.AreEqual(expected_freq, class_under_test_.FrequencyInHz);
            Assert.AreEqual(expected_freq, result_freq);
        }

        private Rigctrld class_under_test_ = null;
    }
}
