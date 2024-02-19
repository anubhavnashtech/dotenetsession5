using System;

namespace interfacetestabilityDemo
{
    public class Shippment
    {
        public float Cost { get; set; }

        public DateTime ShippingDate { get; set; }
    }

    public class Order
    {
        public float TotalPrice { get; set; }

        public Shippment Shippment { get; set; }

        public bool IsShipped 
        {
            get {return Shippment != null;} 

        }

    }

    public interface IShippingCalculator
    {
        float CalculateShipping(Order order);
    }

    public class ShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            if(order.TotalPrice < 30f)
                return order.TotalPrice*0.1f;

            return 0;
        }
    }

    public class OrderProcessor
    {
        private readonly IShippingCalculator _shippingCalculator;

        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            _shippingCalculator = shippingCalculator;
        }

        public void Process(Order order)
        {
            if(order.IsShipped)
            throw new InvalidOperationException("This order is already processed");

            order.Shippment = new Shippment()
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        }
    }



    public class Program
    {
        static void Main(string[] args)
        {
            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            var order = new Order(){TotalPrice = 100f};

            orderProcessor.Process(order);
        }
    }
}
