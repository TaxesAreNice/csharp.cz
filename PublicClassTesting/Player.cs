
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace PublicClassTesting
{
    public class Player
    {
        public bool EnemyIsDead = false;
        //const = ze je hodnota iba jedna
        private const int maxHP = 100;
        private const int minHP = 0;

        public bool CheckinIfYouGotAnyPostions = false;

        public bool YOUGOTPOTIONSYOUSONOFA = false;

        public bool DamageBoostActive = false;
        public bool HealBoostActive = false;

        public decimal currentHP = maxHP;
        private string Acion;
        private string PostionAcion;

        public int PlayerDamage = 20;
        public List<string> inventory = new List<string>();
        public string[] OneTimeUseItems = { "Double damage potion", "HP potion" };


        internal void TakeDamage(decimal MonsterDamage)
        {
            currentHP -= MonsterDamage;
        }
        public bool DealDamage(Monster opponent)
        {
            opponent.TakeDamage(PlayerDamage);
            return true;

        }

        internal void ThePlayerAcionPart(string? playerAcion, Monster opponent)
        {
            Acion = playerAcion;
            if (playerAcion == "")
            {
                DealDamage(opponent);
                if (opponent.currentHP <= 0)
                {
                    Console.WriteLine("You've hit th enemy so hard, it disapired from this universe");
                    EnemyIsDead = true;
                }
                else
                {
                    Console.WriteLine($"You've hit the enemy\nEnemy HP: {opponent.currentHP}\n");
                }
            }
            else
            {
                Console.WriteLine("What ya doing, bro?");
            }
        }
        internal void GottaRepeat(Monster opponent)
        {
            opponent.currentHP = opponent.BackappHP;

            currentHP = currentHP * 2;
            Console.WriteLine($"You just got your HP doubled, HECK YEAH!");
            if (currentHP > maxHP)
            {
                currentHP = maxHP;

            }

        }
        internal void UseDaDrink(string? ItemChoser)
        {

            PostionAcion = ItemChoser;

           
                 
                switch (ItemChoser)
                {
                    case "heal":
                        {
                        if (inventory.Contains("HP potion"))
                        {
                            currentHP = currentHP * 2;
                            HealBoostActive = true;
                            if (currentHP > maxHP * 2)
                            {
                                currentHP = maxHP * 2;
                            }
                            Console.WriteLine($"You used a health potion, your HP is now {currentHP}");
                            inventory.Remove("HP potion");
                            break;
                           
                        }
                        else
                        {
                            Console.WriteLine("You don't have that potions bro");
                            break;
                        }
                        }
                    case "damage":
                    {
                        if (inventory.Contains("Double damage potion"))
                        {
                            PlayerDamage = PlayerDamage * 2;
                            DamageBoostActive = true;
                            Console.WriteLine($"You used a damage potion, your damage is now {PlayerDamage}");
                            inventory.Remove("Double damage potion");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You don't have that potions bro");
                            break;
                        }
                    }
                    case "":
                            {
                                Console.WriteLine("oh c'mon :(");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Nah, what bro?");
                                break;
                            }
                        }
                    }
        
       

        
        internal void BoostAdder(int WeAreCookingBro)
        {
            if (WeAreCookingBro % 2 == 1)
            {
                    // pick a random item from OneTimeUseItems
                    Random rand = new Random();
                    int randomIndex = rand.Next(OneTimeUseItems.Length);

                    inventory.Add(OneTimeUseItems[randomIndex]);
                    Console.WriteLine($"You've received a {OneTimeUseItems[randomIndex]}!");
                }
                else
                {

                }
            }

    }
}


