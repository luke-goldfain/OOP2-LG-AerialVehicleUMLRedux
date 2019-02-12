using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LGSprint0UML;

namespace Sprint0UnitTest
{
    [TestClass]
    public class UnitTestAV
    {
        Airplane ap;
        ToyPlane tp;

        public UnitTestAV()
        {
            
        }

        [TestMethod]
        public void AirplaneTests() // Includes tests for the Airplane's Engine
        {
            // Arrange
            ap = new Airplane();
            // Act
            Airplane apInitial = ap;
            ap.TakeOff();
            bool apFailedTO = ap.IsFlying;
            ap.StartEngine();
            bool apStartedEngine = ap.Engine.IsStarted;
            ap.TakeOff();
            Airplane apTakenOff = ap;
            int apTakeOffAltitude = ap.CurrentAltitude;
            ap.FlyUp();
            int apUpOnceAltitude = ap.CurrentAltitude;
            ap.FlyUp(100000);
            int apMaxAltitude = ap.CurrentAltitude;
            ap.FlyDown(100000);
            int apFailedDownAltitude = ap.CurrentAltitude;
            ap.FlyDown(ap.MaxAltitude);
            int apFlownDownAltitude = ap.CurrentAltitude;
            ap.StopEngine();
            bool apStoppedEngine = ap.Engine.IsStarted;
            // Assert
            Assert.AreEqual(0, apInitial.CurrentAltitude);
            Assert.AreEqual(false, apFailedTO);
            Assert.AreEqual(true, apStartedEngine);
            Assert.AreEqual(true, apTakenOff.IsFlying);
            Assert.AreEqual(1000, apTakeOffAltitude);
            Assert.AreEqual(2000, apUpOnceAltitude);
            Assert.AreEqual(41000, apMaxAltitude);
            Assert.AreEqual(41000, apFailedDownAltitude);
            Assert.AreEqual(0, apFlownDownAltitude);
            Assert.AreEqual(false, apStoppedEngine);
        }

        [TestMethod]
        public void ToyPlaneTests()
        {
            // Arrange
            tp = new ToyPlane();
            // Act
            bool tpInitialWound = tp.IsWoundUp;
            tp.WindUp();
            bool tpWoundUp = tp.IsWoundUp;
            tp.Unwind();
            tp.StartEngine();
            bool tpUnwoundEngine = tp.Engine.IsStarted;
            tp.WindUp();
            tp.StartEngine();
            bool tpWoundEngine = tp.Engine.IsStarted;
            tp.TakeOff();
            int tpTakeOffAltitude = tp.CurrentAltitude;
            tp.FlyUp();
            int tpUpOnceAltitude = tp.CurrentAltitude;
            tp.FlyUp(1000);
            int tpMaxAltitude = tp.CurrentAltitude;
            tp.FlyDown(1000);
            int tpFailedDownAltitude = tp.CurrentAltitude;
            tp.FlyDown(tp.MaxAltitude);
            int tpFlownDownAltitude = tp.CurrentAltitude;
            tp.StopEngine();
            bool tpStoppedEngine = tp.Engine.IsStarted;
            // Assert
            Assert.AreEqual(false, tpInitialWound);
            Assert.AreEqual(true, tpWoundUp);
            Assert.AreEqual(false, tpUnwoundEngine);
            Assert.AreEqual(true, tpWoundEngine);
            Assert.AreEqual(10, tpTakeOffAltitude);
            Assert.AreEqual(20, tpUpOnceAltitude);
            Assert.AreEqual(50, tpMaxAltitude);
            Assert.AreEqual(50, tpFailedDownAltitude);
            Assert.AreEqual(0, tpFlownDownAltitude);
            Assert.AreEqual(false, tpStoppedEngine);
        }
    }
}