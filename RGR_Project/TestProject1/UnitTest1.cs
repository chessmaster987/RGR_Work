using RGR_Project;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod2()
        {
            Creator creator = new TransportCreator();
            Transport truck = creator.CreateTransport("truck");
            Transport plane = creator.CreateTransport("plane");
            Transport ship = creator.CreateTransport("ship");

            Assert.AreEqual("Plane", plane.GetType().Name);
            Assert.AreEqual("Truck", truck.GetType().Name);
            Assert.AreEqual("Ship", ship.GetType().Name);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Transport truck = new Truck(40, 20, 15);
            Transport decoratedTruck = new PremiumFuel(new PowerfulEngine(new GPS_navigator(truck)));

            StringAssert.Contains(decoratedTruck.display(), "Truck");
            StringAssert.Contains(decoratedTruck.display(), "GPS");
            StringAssert.Contains(decoratedTruck.TransportType(), "GPS navigator");
            StringAssert.Contains(decoratedTruck.TransportType(), "powerful engine");
            StringAssert.Contains(decoratedTruck.TransportType(), "premium fuel");
        }

        [TestMethod]
        public void TestMethod4()
        {
            Creator creator = new TransportCreator();

            Assert.ThrowsException<ArgumentException>(() => creator.CreateTransport("train"));
        }
    }
}
