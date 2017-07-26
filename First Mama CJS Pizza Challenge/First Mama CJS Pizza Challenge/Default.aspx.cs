using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace First_Mama_CJS_Pizza_Challenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            resultImage.ImageUrl = "MyPic.jpg";
        }

        protected void purchaseButton_Click(object sender, EventArgs e)
        {
            double total;
            if (babyRadioButton.Checked)
                total = 10.00;
            else if (mamaRadioButton.Checked)
                total = 13.00;
            else  
                total = 16.00;
            {
                if (dRadioButton.Checked)
                    total += 2.00;
            }

            total = (pepCheckBox.Checked) ? total + 1.5 : total;
            total = (oCheckBox.Checked) ? total + .75 : total;
            total = (gpCheckBox.Checked) ? total + .50 : total;
            total = (rpCheckBox.Checked) ? total + .50 : total;
            total = (aCheckBox.Checked) ? total + 2.00 : total;

            if ((pepCheckBox.Checked
                && gpCheckBox.Checked
                && aCheckBox.Checked)
                || (pepCheckBox.Checked
                && rpCheckBox.Checked
                && oCheckBox.Checked))
            {
                total -= 2.00;
            }
            resultLabel.Text = "$" + total.ToString();

        }

    }
}