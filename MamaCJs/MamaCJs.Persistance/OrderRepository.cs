using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MamaCJs.Persistance
{
    public class OrderRepository
    {
        public static void CreateOrder()
        {
            var db = new MamaCJsDbEntities();

            var order = new Order();
            order.OrderId = Guid.NewGuid();
            order.Size = DTO.Enums.SizeType.Large;
            order.Crust = DTO.Enums.CrustType.Thick;
            order.Pepperoni = true;
            order.Name = "Test";
            order.Address = "123 Elm";
            order.Zip = "12345";
            order.Phone = "555-5555";
            order.PaymentType = DTO.Enums.PaymentType.Credit;
            order.TotalCoast = 16.50M;

            db.Orders.Add(order);
            db.SaveChanges();

        }
    }
}
