
using System.ComponentModel;
using PublicClassTesting;




int WeAreCookingBro = 0;
int finallrounds = 0;


Player player = new Player();


Monster monster = new Monster();
Monster opponent = monster;



while (WeAreCookingBro < 1000000000)
{
    if (WeAreCookingBro > 0)
    {
        monster.StrongerMonster();
    }
    player.BoostAdder(WeAreCookingBro);
    Console.WriteLine(player.inventory.Count);

    



    Console.WriteLine("\n\nWhat postion do you wanna use? (heal) or (damage) or enter to skip");
    string? ItemChoser = Console.ReadLine();
    player.UseDaDrink(ItemChoser);
    Round();
    WeAreCookingBro++;
}


void Round()
{
    Console.WriteLine($"\n\nAn ememy has apired infront of you and it hit you, dealing {monster.MonsterDamage} damage  / your HP:{player.currentHP - monster.MonsterDamage}");
    monster.DealDamage(player);
    int roundLoop = 0;
    while (roundLoop < 10000000)
    {
        Console.WriteLine($"------------\nPress enter to deal {player.PlayerDamage}");

        string? playerAcion = Console.ReadLine();
        player.ThePlayerAcionPart(playerAcion, opponent);

        if (player.EnemyIsDead == true)
        {
            roundLoop = 10000000;
            player.GottaRepeat(opponent);
            player.EnemyIsDead = false;
        }

        if (roundLoop != 10000000)
        {
            monster.TheMonsterAcionPart(player);
        }
        else
        {
           continue;
        }
      
        if (monster.PlayerIsDead == true)
        {
            
            roundLoop = 10000000;
            finallrounds = WeAreCookingBro;
            WeAreCookingBro = 1000000000;
            break;
        }
      
        roundLoop++;
    }
   

}




Console.WriteLine($"-----------\nYou killed that freaky enemy about {finallrounds} times!");




