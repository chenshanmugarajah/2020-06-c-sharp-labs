using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace DeleteMe
{
    public class PlayerStats
    {
        public string name { get; set; }
        public int flagsCaptured { get; set; }
        public int kills { get; set; }
        public int deaths { get; set; }
        public PlayerStats(int flags, int kills, int deaths, string name)
        {
            this.kills = kills;
            this.flagsCaptured = flags;
            this.deaths = deaths;
            this.name = name;
        }

        public override string ToString()
        {
            return $"Player name: {name}, Player kills: {kills}, Player flags: {flagsCaptured}";
        }
    }
}
