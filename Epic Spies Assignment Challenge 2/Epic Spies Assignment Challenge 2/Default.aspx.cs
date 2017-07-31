using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Epic_Spies_Assignment_Challenge_2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void assignButton_Click(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                logoImage.ImageUrl = "epic-spies-logo.jpg";
                Calendar1.SelectedDate = DateTime.Now.Date;
                Calendar2.SelectedDate = DateTime.Now.Date.AddDays(14);
                Calendar3.SelectedDate = DateTime.Now.Date.AddDays(21);
            }

        }

        protected void assignButton1_Click(object sender, EventArgs e)
        {
            //Spies cost $500 per day.
            TimeSpan totaldurationOfAssignment = Calendar3.SelectedDate.Subtract(Calendar2.SelectedDate);
            double totalCost = totaldurationOfAssignment.TotalDays * 500.0;

            TimeSpan totaldurationOfEndAssignment = Calendar3.SelectedDate.Subtract(Calendar1.SelectedDate);

            //If > 21 days then add $1000
            if (totaldurationOfAssignment.TotalDays > 21)
            {
                totalCost += 1000.0;
            }



            string result = String.Format("Assignment of: {0} to Assignment: {1} is Authorized. Budget total:{2:C}",
                nameTextBox.Text, assignTextBox.Text, totalCost);


            //if next assignment is < 14 days then 
            DateTime earliestNewAssighmentDate = Calendar2.SelectedDate.AddDays(14);

            Calendar2.SelectedDate = earliestNewAssighmentDate;
            Calendar2.VisibleDate = earliestNewAssighmentDate;

            TimeSpan timeBetweenAssignments = Calendar1.SelectedDate.Subtract(Calendar2.SelectedDate);
            if (timeBetweenAssignments.TotalDays < 14)
            {
                resultLabel.Text = "Error: Must allow at least two weeks between previous" +
                    "assignment and new assignment.";
            }


            

            resultLabel.Text = result;
        }
    }
}