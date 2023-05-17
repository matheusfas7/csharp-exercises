using Enum.Entities;
using Enum.Entities.Enums;
Order order = new Order
{
    Id = 1080,
    Moment = DateTime.Now,
    Status = OrderStatus.PendingPayment

};
// ou -->  Order order = new Order(1080, DateTime.Now, OrderStatus.PendingPayment);

Console.WriteLine(order);

string txt = OrderStatus.PendingPayment.ToString();
Console.WriteLine(txt);
