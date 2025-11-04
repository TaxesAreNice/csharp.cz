

namespace Fafafela
{
    internal class Round
    {


        private int MonsterDamage = 5;
        private int PlayerDamage = 20;

        public void StartRound()
        {
            Console.WriteLine($"A wild monster appears and attacks you, dealing {MonsterDamage}");
        }

        public bool AcualRound()
        {
            Console.WriteLine($"Press enter to deal {PlayerDamage} damage");
            string? input = Console.ReadLine();
            if (input == "")
            {
                Console.WriteLine($"You dealt {PlayerDamage} damage to the monster!");
                
            }
            return true;
        }
        //put this in the main program ig?

    }
}
