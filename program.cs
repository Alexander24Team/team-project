using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ИГРА 'УГАДАЙ ЧИСЛО' ===");
            
            GameLogic game = new GameLogic();
            UIHelper ui = new UIHelper();
            
            bool playAgain = true;
            
            while (playAgain)
            {
                game.StartNewGame();
                ui.ShowWelcome();
                
                bool gameWon = false;
                
                while (!gameWon)
                {
                    int guess = ui.GetGuess();
                    var result = game.CheckGuess(guess);
                    
                    Console.WriteLine(result.message);
                    gameWon = result.isCorrect;
                    
                    if (result.message.Contains("Проигрыш"))
                        break;
                }
                
                Console.Write("Сыграем еще? (да/нет): ");
                playAgain = Console.ReadLine().ToLower() == "да";
            }
            
            Console.WriteLine("Спасибо за игру!");
        }
    }
}