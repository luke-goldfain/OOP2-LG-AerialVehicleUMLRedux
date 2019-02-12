using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LGSprint0UML;

namespace Sprint0UnitTest
{
    [TestClass]
    public class UnitTestAV
    {
        Airplane ap;

        public UnitTestAV()
        {
            ap = new Airplane();
        }

        [TestMethod]
        public void AirplaneTests()
        {
            // Arrange
            // Act
            Airplane apInitial = ap;
            ap.TakeOff();
            Airplane apFailedTO = ap;
            ap.StartEngine();
            Airplane apStartedEngine = ap;
            ap.TakeOff();
            Airplane apTakenOff = ap;
            ap.FlyUp();
            Airplane apUpOnce = ap;
            ap.FlyUp(100000);
            Airplane apUpMax = ap;
            ap.FlyDown(100000);
            Airplane apFailedFlyDown = ap;
            ap.FlyDown(ap.MaxAltitude);
            Airplane apFlownDown = ap;
            ap.StopEngine();
            Airplane apStoppedEngine = ap;
            // Assert
            Assert.AreEqual(0, apInitial.CurrentAltitude);
            Assert.AreEqual(false, apFailedTO.Engine.IsStarted);
            Assert.AreEqual(true, apStartedEngine.Engine.IsStarted);
            Assert.AreEqual(true, apTakenOff.IsFlying);
            Assert.AreEqual(1000, apTakenOff.CurrentAltitude);
            Assert.AreEqual(2000, apUpOnce.CurrentAltitude);
            Assert.AreEqual(41000, apUpMax.CurrentAltitude);
            Assert.AreEqual(41000, apFailedFlyDown.CurrentAltitude);
            Assert.AreEqual(0, apFlownDown.CurrentAltitude);
            Assert.AreEqual(false, apStoppedEngine.Engine.IsStarted);
        }
    }
}