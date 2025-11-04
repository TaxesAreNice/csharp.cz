using System;
using System.Text;

namespace PublicClassTesting
{
    public class Monster
    {
        public bool PlayerIsDead = false;
        public int OriginalHP = 200;
        public int BackappHP = 200;
        private const int minHP = 0;

        public int currentHP = 200;


        public decimal MonsterDamage = 5;
        public decimal BackappDamage = 5;

        internal void TakeDamage(int damage)
        {
            currentHP -= damage;
        }
        public bool DealDamage(Player player)
        {
            player.TakeDamage(MonsterDamage);
            return true;

        }
        internal void TheMonsterAcionPart(Player player)
        { 
            DealDamage(player);
            if (player.currentHP <= 0)
            {
                Console.WriteLine("The enemy hit you so hard, that you just freaking died");
                PlayerIsDead = true;
            }
            else
            {
                Console.WriteLine($"The enemy hit you\nYour HP: {player.currentHP}");
            }
        }
        internal void StrongerMonster()
        {

            currentHP = (int)(currentHP * 1.05); // 5% more
            BackappHP = currentHP;

            MonsterDamage = (decimal)(MonsterDamage * 1.05m); // 5% more
            BackappDamage = (decimal)MonsterDamage;
        }
    }
}

