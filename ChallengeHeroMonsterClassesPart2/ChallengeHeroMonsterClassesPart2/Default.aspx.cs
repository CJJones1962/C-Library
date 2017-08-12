using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeHeroMonsterClassesPart2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Character hero = new Character();
            hero.Name = "Wonder Woman";
            hero.Health = 100;
            hero.DamageMaximum = 30;
            hero.AttackBonus = false;

            Character monster = new Character();
            monster.Name = "Cheetah";
            monster.Health = 75;
            monster.DamageMaximum = 25;
            monster.AttackBonus = true;

            Dice dice = new Dice();
            
            // Bonus
            if (hero.AttackBonus)
               monster.Defend(hero.Attack(dice));
            if (monster.AttackBonus)
                hero.Defend(monster.Attack(dice));
            
            while (hero.Health >0 && monster.Health > 0)
            {
                monster.Defend(hero.Attack(dice));
                hero.Defend(monster.Attack(dice));

                printstats(hero);
                printstats(monster);
            }     
                int damage = hero.Attack(dice);
                monster.Defend(damage);

                damage = monster.Attack(dice);
                hero.Defend(damage);

                displayResults(hero, monster);
        }
    
        private void displayResults(Character opponent1, Character opponent2)
        {
            if (opponent1.Health <= 0 && opponent2.Health <= 0)
                resultLabel.Text += String.Format("<p>Both {0} and {1} died.", opponent1.Name, opponent2.Name);
            else if (opponent1.Health <= 0)
                resultLabel.Text += String.Format("<p>{0}Defeats {1}</p>", opponent2.Name, opponent1.Name);
            else if (opponent2.Health <= 0)
                resultLabel.Text += String.Format("<p> {0}Defeats {1}</p>", opponent1.Name, opponent2.Name);
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

        public int Attack(Dice dice)
        {
             Random random = new Random();
            int damage = random.Next(this.DamageMaximum);
            //dice.Sides = this.DamageMaximum;
            return damage;
        }

        public void Defend(int damage)
        {
            this.Health -= damage;
        }

    }

    class Dice
    {
        public int Sides { get; set; }

        Random random = new Random();
        public int Roll()
        {
           return random.Next(this.Sides);
        }
    }
}