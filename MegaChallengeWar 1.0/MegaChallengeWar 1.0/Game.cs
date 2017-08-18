using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaChallengeWar_1._0
{
    public class Game
    {
        private Player _player1;
        private Player _player2;
        

        public Game(string player1Name, string player2Name)
        {
            _player1 =new Player() { Name = player1Name };
            _player2 = new Player() { Name = player2Name };
        
        }

        public string Play()
        {
            Deck deck = new Deck();
            string result = "<h3>Dealing cards ...</h3>";

            result += deck.Deal(_player1, _player2);
            result += "<h3>Begin battle! ...</h3>";

            int round = 0;
            while (_player1.Cards.Count != 0 && _player2.Cards.Count != 0)
            {
                Battle battle = new Battle();
                result += battle.PerformBattle(_player1, _player2);

                round++;
                if (round > 20)
                    break;
            }
             result += determineWinner();
            return result;
        }

        private string determineWinner()
        {
            string result = " ";
            if (_player1.Cards.Count > _player2.Cards.Count) 
                result += "<br /><span style='color:red; font-weight:bolder;'>Dean wins</span>";
            else 
               result += "<br /><span style='color:purple; font-weight:bolder;'>Sam wins</span>";

            result += "<br /><span style='color:red; font-weight:bolder;'>Dean:</span>" + _player1.Cards.Count +
                      "<br /><span<style='color:purple; font-weight:bolder;'>Sam:</span>" + _player2.Cards.Count;
            return result;

        }

    }

}