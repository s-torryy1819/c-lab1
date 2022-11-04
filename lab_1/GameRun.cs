
namespace lab_1
{
    class GameRun
    {
        static void Main(string[] args)
        {
            GameAccount user1 = new GameAccount("Bob", 0, 0);
            GameAccount user2 = new GameAccount("Charlie", 0, 0);
            GameFunctionality gameFunctionality = new GameFunctionality();

            user1.startNewGame();
            user2.startNewGame();
            Console.WriteLine("\nGame started\n");
            user1.setGoal(3);
            user2.setGoal(5);
            user1.GetStats();
            user2.GetStats();
            user2.setGoal(10);
            user1.setGoal(20);
            user1.GetStats();
            user2.GetStats();
            gameFunctionality.findWinner(user1, user2, user1.CurrentRating, user2.CurrentRating);
            user1.endGame();
            user2.endGame();
            Console.WriteLine("\nGame ended\n");

            user1.startNewGame();
            user2.startNewGame();
            Console.WriteLine("\nGame started\n");
            user1.setGoal(2);
            user2.setGoal(17);
            user1.GetStats();
            user2.GetStats();

            gameFunctionality.findWinner(user1, user2, user1.CurrentRating, user2.CurrentRating);
            user1.endGame();
            user2.endGame();
            Console.WriteLine("Game ended\n\nStatistics for users :");
            Console.WriteLine("User     " + user1.getStatistics()[0].UserName + "    " + user2.getStatistics()[0].UserName + "    " + user1.getStatistics()[1].UserName + "    " + user2.getStatistics()[1].UserName);
            Console.WriteLine("Game     " + user1.getStatistics()[0].GamesCount + "         " + user2.getStatistics()[0].GamesCount + "         " + user1.getStatistics()[1].GamesCount + "         " + user2.getStatistics()[1].GamesCount);
            Console.WriteLine("Rating   " + user1.getStatistics()[0].CurrentRating + "        " + user2.getStatistics()[0].CurrentRating + "        " + user1.getStatistics()[1].CurrentRating + "        " + user2.getStatistics()[1].CurrentRating);

        }

    }
}