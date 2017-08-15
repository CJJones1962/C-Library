using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeSimpleDarts_2._0
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        
        protected void okButton_Click1(object sender, EventArgs e)
        {
            Game game = new Game("Player1", "Player2");
            string result = game.PlayDarts();
            resultLabel.Text = result;
        }
    }
}