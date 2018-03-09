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
    public class Test_rigctrld
    {
        public Test_rigctrld()
        {
            //
            // TODO: Konstruktorlogik hier hinzufügen
            //
        }

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

        [TestMethod]
        public void SetFrequency()
        {
            Rigctrld cut = new Rigctrld();
            long expect_freq = 144800123;
            string test_command = "F  144800123";
            cut.ExecCommand(test_command);
            int count = 0;
            while (cut.FrequencyInHz == 0)
            {
                Thread.Sleep(1);
                count++;
                Assert.AreNotEqual(1000, count,"timeout...");
            }
            Assert.AreEqual(expect_freq, cut.FrequencyInHz);
        }

        [TestMethod]
        public void SetFrequencyCallback()
        {
            Rigctrld cut = new Rigctrld();
            long expect_freq = 144800123;
            long result_freq = 0;
            string test_command = "F  144800123";
            cut.FrequencyInHzChanged += x => result_freq = x;
            cut.ExecCommand(test_command);
            int count = 0;
            while (result_freq == 0)
            {
                Thread.Sleep(1);
                count++;
                Assert.AreNotEqual(1000, count, "timeout...");
            }
            Assert.AreEqual(expect_freq, result_freq);
        }
    }
}
