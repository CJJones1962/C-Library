using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CJ_CS_ASP_013
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //comparisonTypeLabel.Text = "equal to";
            //comparisonTypeLabel.Text = "not equal to";
            comparisonTypeLabel.Text = "greater than";
        }

        protected void okButton_Click(object sender, EventArgs e)
        {

           
            // resultLabel.Text = (isTextBox.Text == secondTextBox.Text) ? "Yes" : "No";

            //resultLabel.Text = (isTextBox.Text != secondTextBox.Text) ? "Yes" : "No";

            // resultLabel.Text = (isTextBox.Text > secondTextBox.Text) ? "Yes" : "No";

            // int first = int.Parse(isTextBox.Text);
            //int second = int.Parse(secondTextBox.Text);

            // resultLabel.Text = (!ICheckBox.Checked) ? "No" : "Yes"; 
            /*
            if (ICheckBox.Checked 
                && isTextBox.Text == "CJ" 
                && secondTextBox.Text=="Amazon")
            {
                resultLabel.Text = "Perfect trifecta!";
                
            }
            else
            {
                resultLabel.Text = "";
            }
            */
            /*
            if (ICheckBox.Checked 
                || isTextBox.Text == "CJ"
                || secondTextBox.Text == "Amazon")
            {
                resultLabel.Text = "One out of three ain't bad.";
            }
        */

            if ((ICheckBox.Checked 
                || isTextBox.Text == "CJ")
                && secondTextBox.Text == "Amazon")
            {
                resultLabel.Text = "Two out of three ain't bad.";
            }
    }

    }
}