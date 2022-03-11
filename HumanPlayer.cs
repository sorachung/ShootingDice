using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override void Play(Player other)
        {
            // Call roll for "this" object and for the "other" object
            Console.Write($"Please roll the die (1-{DiceSize}): ");
            bool success = int.TryParse(Console.ReadLine(), out int myRoll);

            while (!success || myRoll > DiceSize || myRoll < 1)
            {
                Console.Write("Please roll the die (1-6): ");
                success = int.TryParse(Console.ReadLine(), out myRoll);
            }

            int otherRoll = other.Roll();

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (myRoll < otherRoll)
            {
                Console.WriteLine($"{other.Name} Wins!");
            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }
        }
    }
}