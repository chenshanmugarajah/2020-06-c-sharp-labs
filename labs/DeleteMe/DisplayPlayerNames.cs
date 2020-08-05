using System;
using System.Collections.Generic;
using System.Text;

namespace DeleteMe
{
    public class DisplayPlayerNames
    {
        delegate int ScoreDelegate(PlayerStats stats);
        public void OnGameOver(PlayerStats[] allPlayerStats)
        {
            var instance1 = new ScoreDelegate(ScoreByFlagsCapped);

            Console.WriteLine($"==== Top Players ====");
            string playNameMostKills = GetPlayerNameMost(allPlayerStats, stats => stats.kills);
            string playNameMostFlags = GetPlayerNameMost(allPlayerStats, stats => stats.flagsCaptured);
            string playNameMostFlagsV2 = GetPlayerNameMost(allPlayerStats, ScoreByFlagsCapped);
            string playNameMostFlagsV3 = GetPlayerNameMost(allPlayerStats, instance1);

            Console.WriteLine($"Most kills: {playNameMostKills}");
            Console.WriteLine($"Most flags: {playNameMostFlags}");
            Console.WriteLine($"Most flagsV2: {playNameMostFlagsV2}");
            Console.WriteLine($"Most flagsV3: {playNameMostFlagsV3}");

            Console.WriteLine($"\n==== Player Stats ====");
            foreach (var player in allPlayerStats)
            {
                Console.WriteLine(player.ToString());
            }
        }

        int ScoreByFlagsCapped(PlayerStats stats)
        {
            return stats.flagsCaptured;
        }

        string GetPlayerNameMost(PlayerStats[] allPlayerStats, ScoreDelegate scoreCalculator)
        {
            string name = "";
            int bestScore = 0;

            foreach (PlayerStats stats in allPlayerStats)
            {
                int score = scoreCalculator(stats);
                if (score > bestScore)
                {
                    bestScore = score;
                    name = stats.name;
                }
            }
            return name;
        }
    }
}
