using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CJCS_ASP_011
{
    public partial class CJDefault : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Click(object sender, EventArgs e)
        {
                ResultLabel.Text = "";

            /*
            if (IsTextBox.Text == EqualTextBox.Text)
            {
                ResultLabel.Text = "Yes!  They're equal";
            }
            else
            {
                ResultLabel.Text = "No! They're not equal";
            }
            */

            if (CoolCheckBox.Checked == true)
            {
                ResultLabel.Text = "Yes! You are definitly cool!";
            }
            else
            {
                ResultLabel.Text = "Don't be so hard on yourself.";
            }

        }
                
    }
}