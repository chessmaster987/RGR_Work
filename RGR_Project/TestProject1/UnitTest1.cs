using RGR_Project;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Truck t = new Truck();
            t.deliver();
            t.fillfuel();
            Assert.AreEqual(t.GetType().Name, "Truck");
        }

        [TestMethod]
        public void TestMethod2()
        { 
           Delivery truckcreate = new RoadDelivery();
           Delivery planecreate = new WindDelivery();
           Delivery shipcreate = new SeaDelivery();
           Transport truck = truckcreate.CreateTransport();
           Transport plane = planecreate.CreateTransport();
           Transport ship = shipcreate.CreateTransport();
           Assert.AreEqual(plane.GetType().Name, "Plane");
        }
    }
}
    