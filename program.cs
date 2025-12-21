// UIHelper.cs
using System;

namespace NumberGuessingGame
{
    public class UIHelper
    {
        public void ShowWelcomeMessage()
        {
            Console.WriteLine("Добро пожаловать в игру 'Угадай Число'!");
            Console.WriteLine("========================================");
            Console.WriteLine("Я загадал число от 1 до 100.");
            Console.WriteLine("Попробуй угадать его за минимальное количество попыток!");
            Console.WriteLine();
        }

        public int GetUserGuess(int attempt, int maxAttempts)
        {
            Console.Write($"Попытка {attempt}/{maxAttempts}. Введите число: ");

            while (true)
            {
                string input = Console.ReadLine();

                if (int.TryParse(input, out int guess) && guess >= 1 && guess <= 100)
                {
                    return guess;
                }

                Console.Write("Ошибка! Введите число от 1 до 100: ");
            }
        }

        public void ShowGuessResult(GuessResult result)
        {
            Console.WriteLine();

            if (result.IsCorrect)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(result.Message);
            }
            else if (result.AttemptsLeft == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(result.Message);
                Console.WriteLine($"Осталось попыток: {result.AttemptsLeft}");
            }

            Console.ResetColor();
            Console.WriteLine();
        }

        public bool AskToPlayAgain()
        {
            Console.Write("Хотите сыграть еще раз? (да/нет): ");
            string answer = Console.ReadLine().ToLower();
            return answer == "да" || answer == "yes" || answer == "д";
        }

        public void ShowGoodbye()
        {
            Console.WriteLine();
            Console.WriteLine("Спасибо за игру! До встречи!");
        }
    }
}
