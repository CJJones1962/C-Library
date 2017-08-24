using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MamaCJs.Persistance
{
    public class OrderRepository
    {
        public static void CreateOrder(DTO.OrderDTO orderDTO)
        {
            var db = new MamaCJsDbEntities();

            var order = convertToEntity(orderDTO);
            db.Orders.Add(order);
            db.SaveChanges();

        }
        private static Order convertToEntity(DTO.OrderDTO orderDTO)
        {
            var order = new Order();

            order.OrderId = orderDTO.OrderId;
            order.Size = orderDTO.Size;
            order.Crust = orderDTO.Crust;
            order.Sausage = orderDTO.Sausage;
            order.Pepperoni = orderDTO.Pepperoni;
            order.Onions = orderDTO.Onions;
            order.GreenPeppers = orderDTO.Pepperoni;
            order.Name = orderDTO.Name;
            order.Address = orderDTO.Address;
            order.Phone = orderDTO.Phone;
            order.Zip = orderDTO.Zip;
            order.TotalCoast = orderDTO.TotalCoast;
            order.PaymentType = orderDTO.PaymentType;
            order.Completed = orderDTO.Completed;


            return order;
        }
    }
}
