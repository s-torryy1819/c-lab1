
namespace lab_1
{
    public class GameFunctionality
    {
        public static bool checkRating(int rating)
        {
            if (rating < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(rating), "Rating can not be less than 1\n");
            }
            return true;
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