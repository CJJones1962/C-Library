using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MamaCJs.Web
{
    public partial class OrderManagement : System.Web.UI.Page
    {
        public object GrideView { get; private set; }
        public object GrideView1 { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            var orders = Domain.OrderManager.GetOrders();
            GridView1.DataSource = orders;
            GridView1.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = GridView1.Rows[index];
            var value = row.Cells[1].Text.ToString();
            var orderId = Guid.Parse(value);

            Domain.OrderManager.CompleteOrder(orderId);
        }

        
    }
}