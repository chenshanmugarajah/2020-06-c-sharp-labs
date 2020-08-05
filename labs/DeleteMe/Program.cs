using System;
using System.Collections.Generic;

namespace DeleteMe
{
    class Program
    {
        static int randomNumber()
        {
            Random r = new Random();
            return r.Next(0, 100); //for ints
        }

        static void Main(string[] args)
        {
            var allPlayersStats = new List<PlayerStats>();

            for (int i = 0; i < 8; i++)
            {
                allPlayersStats.Add(new PlayerStats(randomNumber(), randomNumber(), randomNumber(), "Player " + i));
            }

            var input = allPlayersStats.ToArray();
            DisplayPlayerNames dpn = new DisplayPlayerNames();
            dpn.OnGameOver(input);
        }
    }
}
