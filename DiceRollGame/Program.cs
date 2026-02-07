using DiceRollGame.Game;
using DiceRollGame.UserCommunication;

namespace DiceRollGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var dice = new Dice(random);
            var guessingGame = new GuessingGame(dice);
          
            GameResult gameResult = guessingGame.Play();
            GuessingGame.PrintResult(gameResult);

            Console.ReadKey();
        }
    }
}
