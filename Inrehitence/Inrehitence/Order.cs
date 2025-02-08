/*using System;

class Order
{
    public string orderId, orderDate;

    public Order(string orderId, string orderDate)
    {
        this.orderId = orderId;
        this.orderDate = orderDate;
    }

    public virtual void GetOrderStatus()
    {
        Console.WriteLine($"Order ID: {orderId} \nOrder Date: {orderDate}");
    }
}

class ShippedOrder : Order
{
    public string trackingNumber;

    public ShippedOrder(string orderId, string orderDate, string trackingNumber)
        : base(orderId, orderDate)
    {
        this.trackingNumber = trackingNumber;
    }

    public override void GetOrderStatus()
    {
        base.GetOrderStatus();
        Console.WriteLine($"Tracking Number: {trackingNumber}");
    }
}

class DeliveredOrder : ShippedOrder
{
    public string deliveryDate;

    public DeliveredOrder(string orderId, string orderDate, string trackingNumber, string deliveryDate)
        : base(orderId, orderDate, trackingNumber)
    {
        this.deliveryDate = deliveryDate;
    }

    public override void GetOrderStatus()
    {
        base.GetOrderStatus();
        Console.WriteLine($"Delivery Date: {deliveryDate}");
    }
}

class HelloWorld
{
    static void Main()
    {
        Order order = new Order("ORD123", "2025-02-08");
        order.GetOrderStatus();

        Console.WriteLine("\n---");

        ShippedOrder shippedOrder = new ShippedOrder("ORD124", "2025-02-07", "TRK987654");
        shippedOrder.GetOrderStatus();

        Console.WriteLine("\n---");

        DeliveredOrder deliveredOrder = new DeliveredOrder("ORD125", "2025-02-06", "TRK654321", "2025-02-08");
        deliveredOrder.GetOrderStatus();

        Console.ReadLine();
    }
}*/