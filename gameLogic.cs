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