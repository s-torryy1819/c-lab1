

namespace lab_1
{
    public class GameAccount
    {
        private String userName = "Vicky";
        public int currentRating;
        private int gamesCount;
        AllUserStatistics allUserStatistics = new AllUserStatistics();
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
            allUserStatistics.addDataPoint(userName, currentRating, gamesCount);
            currentRating = 0;
        }
        public List<UserStatisctics> getStatistics()
        {
            return allUserStatistics.getStatisticsList();
        }
        public void setGoal(int goal)
        {
            currentRating += goal;
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
        public void GetStatsForAllGames()
        {
            Console.WriteLine("Game Statistics\nUserName : " + userName + "\nRating : " + currentRating + "\nCount : " + gamesCount + "\n........");
        }
    }
}