using System;

namespace HelloWorld
{
    class GameRun
    {
        static void Main(string[] args)
        {
            GameAccount user1 = new GameAccount("Bob", 0, 0);
            GameAccount user2 = new GameAccount("Charlie", 0, 0);
            GameRun gameRun = new GameRun();

            user1.startNewGame();
            user2.startNewGame();
            Console.WriteLine("Game started");
            user1.setGoal();
            user2.setGoal();
            user1.setGoal();
            user1.setGoal();
            user2.setGoal();
            user2.setGoal();
            user2.setGoal();
            user1.setGoal();
            user2.setGoal();
            user2.setGoal();
            user1.GetStats();
            user2.GetStats();
            user2.setGoal();
            user1.setGoal();
            user1.setGoal();
            user2.setGoal();
            user2.setGoal();
            user2.setGoal();
            user1.setGoal();
            user1.GetStats();
            user2.GetStats();
            gameRun.findWinner(user1, user2, user1.CurrentRating, user2.CurrentRating);
            user1.endGame();
            user2.endGame();
            Console.WriteLine("Game ended");

            user1.startNewGame();
            user2.startNewGame();
            Console.WriteLine("Game started");
            user1.setGoal();
            user1.setGoal();
            user2.setGoal();
            user2.setGoal();
            user2.setGoal();
            user1.setGoal();
            user1.setGoal();
            user2.setGoal();
            user1.setGoal();
            user1.setGoal();
            user1.GetStats();
            user2.GetStats();

            gameRun.findWinner(user1, user2, user1.CurrentRating, user2.CurrentRating);
            user1.endGame();
            user2.endGame();
            Console.WriteLine("Game ended");
        }
        public void findWinner(GameAccount user1, GameAccount user2, int ratingOfUser1, int ratingOfUser2)
        {
            if (ratingOfUser1 > ratingOfUser2)
            {
                user1.WinGame(user2.UserName, ratingOfUser1);
                user2.LoseGame(user1.UserName, ratingOfUser1);
            }
            else if (ratingOfUser2 > ratingOfUser1)
            {
                user2.WinGame(user1.UserName, ratingOfUser2);
                user1.LoseGame(user2.UserName, ratingOfUser1);
            }
            else
            {
                Console.WriteLine("Ratings are equal");
            }
        }
    }
}