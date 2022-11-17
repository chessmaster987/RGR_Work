using RGR_Project;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()//first, when was only a Truck.cs & interface Transport
        {
            Truck t = new Truck();
            t.deliver();
            t.fillfuel();
            Assert.AreEqual(t.GetType().Name, "Truck");
        }

        [TestMethod]
        public void TestMethod2()//creating by Factory Method pattern 
        { 
           Delivery truckcreate = new RoadDelivery();
           Delivery planecreate = new WindDelivery();
           Delivery shipcreate = new SeaDelivery();
           Transport truck = truckcreate.CreateTransport();
           Transport plane = planecreate.CreateTransport();
           Transport ship = shipcreate.CreateTransport();
           Assert.AreEqual(plane.GetType().Name, "Plane");
        }

        [TestMethod]
        public void TestMethod3() //creating by Decorator Method pattern
        {
            
        }
    }
}
    