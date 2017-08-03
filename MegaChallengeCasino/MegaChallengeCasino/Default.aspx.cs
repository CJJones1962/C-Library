using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MegaChallengeCasino
{
    public partial class Default : System.Web.UI.Page
    {
        Random random = new Random();

        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void leverButton_Click(object sender, EventArgs e)


        {
            pulllever();

        }
        private void pulllever()
        {
            string[] reels = new string[] { spinReel(), spinReel(), spinReel() };
            displayImages(reels);
        }

        private void displayImages(string[] reels)
        {
            randomImage1.ImageUrl = "/Images/" + reels[0]+ ".png";
            randomImage2.ImageUrl = "/Images/" + reels[1] + ".png";
            randomImage3.ImageUrl = "/Images/" + reels[2] + ".png";

        }
        private string spinReel()
        {
            string[] images = new string[] {"Strawberry","Bar","Lemon","Bell","Clover","Cherry" +
                    "Diamond","Orange","Seven","HorseShoe","Plum","Watermelon"};
            return images[random.Next(11)];

        }
                

        
    }
}