using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CJCS_ASP_12
{
    public partial class CJDefault : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // resultLabel.Text = (IsTextBox.Text == EqualTextBox.Text) ? "Yes " : "No";
            /* resultLabel.Text = (oldCheckBox.Checked)
                  ? "I'm teaching an old dog new tricks!"
                  : "Young whippersnapper! Get off my lawn!";
                  */

            int result = (IsTextBox.Text == EqualTextBox.Text) ? 100 : 50;

            resultLabel.Text = result.ToString();
        }
    }
}