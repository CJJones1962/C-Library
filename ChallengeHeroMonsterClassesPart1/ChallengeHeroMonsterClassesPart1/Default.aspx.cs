using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeHeroMonsterClassesPart1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Character hero = new Character();
            hero.Name = "Batman";
            hero.Health = 100;
            hero.DamageMaximum = 30;
            hero.AttackBonus = false;

            Character monster = new Character();
            monster.Name = "Joker";
            monster.Health = 50;
            monster.DamageMaximum = 25;
            monster.AttackBonus = true;

            int damage = hero.Attack();
            monster.Defend(damage);

            damage = monster.Attack();
            hero.Defend(damage);

            printstats(hero);
            printstats(monster);

        }

        private void printstats(Character character)
        {
            resultLabel.Text += String.Format("<p>Name: {0} - Health: {1:N} - DamageMaximum,: {2:N} - AttackBonus {3:N}</p>",
                character.Name, 
                character.Health.ToString(),
                character.DamageMaximum.ToString(),
                character.AttackBonus.ToString());

        }
    }


    class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int DamageMaximum { get; set; }
        public bool AttackBonus { get; set; }


        public int Attack()
        {
            Random random = new Random();
            int damage = random.Next(this.DamageMaximum);
            return damage;

        }

        public void Defend(int damage)
        {
            this.Health -= damage;
        }

    }


}