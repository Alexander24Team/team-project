using System;

namespace NumberGuessingGame
{
    public class GameLogic
    {
        private int secretNumber;
        private int attempts = 0;
        private const int maxAttempts = 10;
        
        public void StartNewGame()
        {
            Random rand = new Random();
            secretNumber = rand.Next(1, 101);
            attempts = 0;
        }
        public (bool isCorrect, string message) CheckGuess(int guess)
        {
            attempts++;
            
            if (guess == secretNumber)
            {
                return (true, $"🎉 Поздравляем! Вы угадали число {secretNumber} за {attempts} попыток!");
            }
            
            if (attempts >= maxAttempts)
            {
                return (false, $"💀 Игра окончена! Загаданное число было: {secretNumber}");
            }
            
            if (guess < secretNumber)
            {
                return (false, $"📈 Загаданное число БОЛЬШЕ. Осталось попыток: {maxAttempts - attempts}");
            }
            else
            {
                return (false, $"📉 Загаданное число МЕНЬШЕ. Осталось попыток: {maxAttempts - attempts}");
            }
        }
        
        public int GetAttempts()
        {
            return attempts;
        }
        
        public int GetMaxAttempts()
        {
            return maxAttempts;
        }
    }
}