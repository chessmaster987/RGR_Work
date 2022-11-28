using RGR_Project;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        /*
        [TestMethod]
        /\public void TestMethod1()//first, when was only a Truck.cs & interface Transport
        {
            Truck t = new Truck();
            t.deliver();
            Assert.AreEqual(t.GetType().Name, "Truck");
        }
        */

        [TestMethod]
        public void TestMethod2()//creating by Factory Method pattern 
        {
            Creator truckcreate = new TransportCreator();
            Creator planecreate = new TransportCreator();
            Creator shipcreate = new TransportCreator();
            Transport truck = truckcreate.CreateTransport("truck");
            Transport plane = planecreate.CreateTransport("plane");
            Transport ship = shipcreate.CreateTransport("ship");
            Assert.AreEqual(plane.GetType().Name, "Plane");
            Assert.AreEqual(truck.GetType().Name, "Truck");
            Assert.AreEqual(ship.GetType().Name, "Ship");
        }

        [TestMethod]
        public void TestMethod3() //creating by Decorator Method pattern
        {
            
        }
    }
}
    