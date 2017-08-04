using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mega_Casino_Challenge_2._0
{
    public partial class Default : System.Web.UI.Page
    {

        Random random = new Random();
        private int multiplier;

        public int CherryCount { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void leverButton_Click(object sender, EventArgs e)
        {
            int bet = 0;
            if (!int.TryParse(betTextBox.Text, out bet)) return;

            int winnings = pullLever(bet);

            displayResult(bet, winnings);
        }

        private void displayResult(int bet, int winnings)
        {
            if (winnings > 0)
                youbetLabel.Text = String.Format("You bet {0:C} and won {1:C} !", bet, winnings);
            else
                youbetLabel.Text = String.Format("Sorry, you lost your {0:C}. Better luck next time.", bet);
            
        }

        private int pullLever(int bet)
        {
            string[] reels = new string[] { spinReel(), spinReel(), spinReel() };
            displayImages(reels);

            int multipiler = EvalulateSpin(reels);
            return bet * multiplier;

        }

        private int EvalulateSpin(string[] reels)
        {
            if (isBar(reels)) return 0;
            if (isJackpot(reels)) return 100;
            int multiplier = 0;
            if (isWinner(reels, out  multiplier)) return multiplier;
            return 0;
        }

        private bool isWinner(string[] reels, out int multiplier)
        {
            multiplier = determineMultiplier(reels);
            if (multiplier > 0) return true;
            return false;
        }

        private int determineMultiplier(string[] reels)
        {
            int cherryCount = determineCherryCount(reels);
            if (cherryCount == 1) return 2;
            if (cherryCount == 2) return 3;
            if (cherryCount == 3) return 4;
            return 0;
        }
        
        private int determineCherryCount(string[] reels)
        {
            int cherryCount = 0;
            if (reels[0] == "Cherry") cherryCount++;
            if (reels[1] == "Cherry") cherryCount++;
            if (reels[2] == "Cherry") cherryCount++;
            return CherryCount;
        }

        private bool isJackpot(string[] reels)
        {
            if (reels[0] == "Seven" && reels[1] == "Seven" && reels[2] == "Seven")
                return true;
            else
                return false;
        }

        private bool isBar(string[] reels)
        {
            if (reels[0] == "Bar" || reels[1] == "Bar" || reels[2] == "Bar")
                return true;
            else
                return false;
        }
        
        private void displayImages(string[] reels)
        {
            randomImage1.ImageUrl = "/Images/" + reels[0] + ".png";
            randomImage2.ImageUrl = "/Images/" + reels[1] + ".png";
            randomImage3.ImageUrl = "/Images/" + reels[2] + ".png";
        }

        private string spinReel()
        {
            string[] images = new string[] { "Strawberry", "Bar", "Lemon", "Bell", "Clover", "Cherry", "Diamond", "Orange", "Seven", "HorseShoe", "Plum", "Watermelon" };
            return images[random.Next(11)];
        }

    }
}



  
