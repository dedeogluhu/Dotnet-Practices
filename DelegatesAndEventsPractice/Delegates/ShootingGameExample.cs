namespace DelegatesAndEventsPractice.Delegates
{
    class DisplayPlayerOfTheGame
    {
        delegate int ScoreDelegate(PlayerStats stats);

        public void OnGameOver(PlayerStats[] allPlayerStats)
        {
            ScoreDelegate scoreCalculator = stats => stats.Deaths;

            string playerNameMostKills = GetPlayerNameTopScore(allPlayerStats, stats => stats.Kills);
            string playerNameMostFlags = GetPlayerNameTopScore(allPlayerStats, ScoreByFlagCaptures);
            string playerNameMostDeaths = GetPlayerNameTopScore(allPlayerStats, scoreCalculator);

            System.Console.WriteLine("Most Deaths:" + playerNameMostDeaths);
            System.Console.WriteLine("Most Kills:" + playerNameMostKills);
            System.Console.WriteLine("Most Flags:" + playerNameMostFlags);

        }

        int ScoreByKillCount(PlayerStats stats)
        {
            return stats.Kills;
        }

        int ScoreByFlagCaptures(PlayerStats stats)
        {
            return stats.FlagsCaptured;
        }

        string GetPlayerNameTopScore(PlayerStats[] allPlayerStats, ScoreDelegate scoreCal)
        {
            string name = "";
            int bestScore = 0;

            foreach (PlayerStats stats in allPlayerStats)
            {
                int score = scoreCal(stats);
                if (score > bestScore)
                {
                    bestScore = score;
                    name = stats.Name;
                }
            }

            return name;

        }
    }

    class PlayerStats
    {
        public string Name { get; set; }
        public int Kills { get; set; }
        public int Deaths { get; set; }
        public int FlagsCaptured { get; set; }
    }
}
