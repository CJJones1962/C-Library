using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePhunWithstrings
{
    public partial class Default : System.Web.UI.Page
    {
        private object myString;

        public object Luke { get; private set; }
        public object Skywalker { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            // 1. Reverse your name
            string name = "Cj Jones";
            // In my case, the result would be:
            //senoJ  jC
            /*
            for (int i = name.Length -1; i >= 0;  i --)
            {
                resultLabel.Text += name[i];
            }
            */
            
            // 2. Reverse this sequence;
            string names = "Luke, Leia,Han,Chewbacca";
            // Should look like this:
            // Chewbacca, Han, Leia, Luke:
            /*
            string[] Skywalker = names.Split(',');
            string result = "";
            for (int i = Skywalker.Length - 1; i >= 0; i--)
            {
                result += Skywalker[i] + ",";
            }
            result = result.Remove(result.Length - 1, 1);
            resultLabel.Text = result;
            */


            // 3. Padding so names look like with 14 characters long;
            // *****Luke*****
            // *****Leia*****
            // *****Han******
            // ***Chewbacca**

            /*
            string[] Skywalker = names.Split(',');
            string result = "";
            for (int i = 0; i < Skywalker.Length; i++)
            {
                int padLeft = (14 - Skywalker[i].Length) / 2;
                string temp = Skywalker[i].PadLeft(Skywalker[i].Length + padLeft, '*');
                result += temp.PadRight(14, '*');
                result += "<br />";
            }
            resultLabel.Text = result;
           */




            // 4. String Puzzle;

            string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY";

            //This is what it should show.
            //Now is the time for all good men to coe to the adi of their country.
            string removeMe = "remove-me";
            int index = puzzle.IndexOf(removeMe);
            puzzle = puzzle.Remove(index, removeMe.Length);
            puzzle = puzzle.ToLower();
            puzzle = puzzle.Replace('z', 't');
            puzzle - puzzle.Remove(0, 1);
            puzzle = puzzle.Insert(0, "N");

            resultLabel.Text = puzzle;


        }
    }
}