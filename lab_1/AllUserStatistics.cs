using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab_1
{
    public class AllUserStatistics
    {
        List<UserStatisctics> statisticsList = new List<UserStatisctics>();
        public void addDataPoint(String userName, int currentRating, int gamesCount)
        {
            UserStatisctics userStatisctics = new UserStatisctics(userName, currentRating, gamesCount);
            statisticsList.Add(userStatisctics);
        }
        public List<UserStatisctics> getStatisticsList()
        {
            return statisticsList;
        }
    }
}