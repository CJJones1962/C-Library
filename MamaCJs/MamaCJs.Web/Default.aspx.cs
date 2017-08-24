using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MamaCJs.Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var order = new DTO.OrderDTO();
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


            Domain.OrderManager.CreateOrder(order);
        }
    }
}