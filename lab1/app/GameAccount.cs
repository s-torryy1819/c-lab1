using System;

namespace HelloWorld
{
    class GameAccount
    {
        private String userName;
        public int currentRating;
        private int gamesCount;
        public String UserName
        {
            get { return userName; }
            set
            {
                userName = value;
            }
        }
        public int CurrentRating
        {
            get { return currentRating; }
            set
            {
                currentRating = value;
            }
        }
        public int GamesCount
        {
            get { return gamesCount; }
            set
            {
                gamesCount = value;
            }
        }
        public GameAccount(String userName, int currentRating, int gamesCount)
        {
            UserName = userName;
            CurrentRating = currentRating;
            GamesCount = gamesCount;
        }
        public void startNewGame()
        {
            currentRating = 0;
            gamesCount++;
        }
        public void endGame()
        {
            currentRating = 0;
        }
        public void setGoal()
        {
            currentRating++;
        }
        public void WinGame(String opponentName, int rating)
        {
            Console.WriteLine(userName + " won!!!\nRating : " + currentRating + "\nThe opponent : " + opponentName + "\n........");
        }
        public void LoseGame(String opponentName, int rating)
        {
            Console.WriteLine(userName + " losed...\nRating : " + currentRating + "\nThe opponent : " + opponentName + "\n........");
        }
        public void GetStats()
        {
            Console.WriteLine("Game Statistics\nUserName : " + userName + "\nRating : " + currentRating + "\nCount : " + gamesCount + "\n........");
        }
        public static bool checkRating(int rating)
        {
            if (rating < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(rating), "Rating can not be less than 1\n");
            }
            return true;
        }
    }
}