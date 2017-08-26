using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MamaCJs.Domain
{
    public class OrderManager
    {
        public static void CreateOrder(DTO.OrderDTO orderDTO)
        {
            //Validation
            if (orderDTO.Name.Trim().Length == 0)
                throw new Exception("Name is requierd.");

            if (orderDTO.Address.Trim().Length == 0)
                throw new Exception("Address is requierd.");

            if (orderDTO.Zip.Trim().Length == 0)
                throw new Exception("Zip is requierd.");

            if (orderDTO.Phone.Trim().Length == 0)
                throw new Exception("Phone is requierd.");

            orderDTO.OrderId = Guid.NewGuid();
            orderDTO.TotalCost = PizzaPriceManager.CalculateCost(orderDTO);
            Persistance.OrderRepository.CreateOrder(orderDTO);
        }

        public static object GetOrders()
        {
            return Persistance.OrderRepository.GetOrders();

        }

        public static void CompleteOrder(Guid orderId)
        {
            Persistance.OrderRepository.CompleteOrder(orderId);
        }

    }
}
