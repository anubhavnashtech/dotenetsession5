using interfacetestabilityDemo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace interfacetestabilityDemoTest
{

    [TestClass]
    public class OrderProcessorTest
    {

        // MethodName_Condition_Expectation

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Process_OrderIsAlreadyShipped_ThrowAnException()
        {
           var orderProcessor = new OrderProcessor(new FakeShippingClaculator());

           var order = new Order
           {
             Shippment = new Shippment()

           };

           orderProcessor.Process(order);
        }

        [TestMethod]
        public void Process_OrderIsNotShipped_ShouldSetShippmentProperty()
        {
           var orderProcessor = new OrderProcessor(new FakeShippingClaculator());
           var order = new Order();

           orderProcessor.Process(order);

           Assert.IsTrue(order.IsShipped);
        }


        public class FakeShippingClaculator : IShippingCalculator
        {

            public float CalculateShipping(Order order)
            {
                return 1;
            }

        }
    }
}